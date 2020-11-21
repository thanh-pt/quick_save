using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace HiddenSearch
{
    public partial class FrmMainSearch : Form
    {
        private delegate void updateDataDelegate(string standFor = "", string definiation = "", string howItWork = "");

        public ConfigurationData ConfigData = new ConfigurationData();

        List<HandbookObject> m_lstHandbookObj;
        Dictionary<string, HandbookObject> m_dicSearching = new Dictionary<string, HandbookObject>();

        public FrmMainSearch()
        {
            InitializeComponent();
        }

        #region User define code

        private void updateData(string standFor="", string definiation="", string howItWork="")
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new updateDataDelegate
                (updateData),
                new object[] { standFor, definiation, howItWork});
            }
            else
            {
                if (howItWork == "")
                {
                    txtHowItWork.Height = 0;
                } else
                {
                    txtHowItWork.Height = 80;
                }

                txtStandFor.Text = standFor;
                txtDefinition.Text = definiation;
                txtHowItWork.Text = howItWork;
            }
        }

        private void readingDb()
        {
            updateData("Reading DB...");
            FileInfo quizInfo = new FileInfo(ConfigData.DataFileName);
            if (!quizInfo.Exists)
            {
                updateData("Cannot find DB!");
                return;
            }
            m_dicSearching.Clear();
            m_lstHandbookObj = ExcelReading.getExcelFile(quizInfo.FullName);
            foreach (HandbookObject handbookObj in m_lstHandbookObj)
            {
                string lowerKeyword = handbookObj.Keyword.ToLower();
                if (lowerKeyword.Contains("/"))
                {
                    List<string> subKey = lowerKeyword.Split('/').ToList();
                    foreach (string key in subKey)
                    {
                        m_dicSearching.Add(key.Trim(), handbookObj);
                    }
                }
                if (m_dicSearching.ContainsKey(lowerKeyword))
                {
                    m_dicSearching[lowerKeyword] = handbookObj;
                } else
                {
                    m_dicSearching.Add(lowerKeyword, handbookObj);
                }
            }
            updateData("Ready to use!");
        }

        private HandbookObject searching(string keyword)
        {
            HandbookObject result = null;
            try
            {
                result = m_dicSearching[keyword];
            } catch { }
            return result;
        }

        public void reloadDataBase()
        {
            Thread tReadingDb = new Thread(new ThreadStart(readingDb));
            tReadingDb.Start();
        }

        #endregion

        private void FrmMainSearch_Activated(object sender, EventArgs e)
        {
            this.Opacity = ConfigData.ActiveOpacity;
            mainPanel.Visible = true;
            txtKeyword.Focus();
        }

        private void FrmMainSearch_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = ConfigData.DeactiveOpacity;
            mainPanel.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HandbookObject searchResult = searching(txtKeyword.Text.ToLower());
            if (searchResult != null)
            {
                if (txtKeyword.Text.ToLower() != searchResult.Keyword.ToLower())
                {
                    txtKeyword.Text = searchResult.Keyword;
                }
                updateData(searchResult.StandFor,
                    searchResult.Definition,
                    searchResult.HowToUse);
            } else if (m_dicSearching.Count == 0)
            {
                updateData("Dict empty!!!");
            } else
            {
                updateData("Cannot found!!!");
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "" & (txtStandFor.Text != "" | txtDefinition.Text != ""))
            {
                updateData();
            }
        }

        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMainSearch_Shown(object sender, EventArgs e)
        {
            updateData();
            reloadDataBase();
        }

        private void btnShowMore_Click(object sender, EventArgs e)
        {
            if (btnShowMore.Text == "←")
            {
                btnConfig.Visible = true;
                btnClose.Visible = true;
                btnShowMore.Text = "→";
            } else
            {
                btnShowMore.Text = "←";
                btnConfig.Visible = false;
                btnClose.Visible = false;
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Configuration config = new Configuration(this);
            config.ShowDialog();
        }
    }
}
