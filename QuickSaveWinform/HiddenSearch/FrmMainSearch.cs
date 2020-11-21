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
        double FG_OPACITY = 0.3;
        double BG_OPACITY = 0.05;
        string DB_FILE_NAME = "quiz.xlsx";

        List<HandbookObject> lstHandbookObj;
        Dictionary<string, HandbookObject> dicSearching = new Dictionary<string, HandbookObject>();

        public FrmMainSearch()
        {
            InitializeComponent();
        }

        #region User define code

        private void updateData(string standFor="", string definiation="", string howItWork="")
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

        private void readingDb()
        {
            FileInfo quizInfo = new FileInfo(DB_FILE_NAME);
            if (!quizInfo.Exists)
            {
                MessageBox.Show("Cannot find 'quiz.xlsx'!");
                return;
            }
            lstHandbookObj = ExcelReading.getExcelFile(quizInfo.FullName);
            foreach (HandbookObject handbookObj in lstHandbookObj)
            {
                string lowerKeyword = handbookObj.Keyword.ToLower();
                if (lowerKeyword.Contains("/"))
                {
                    List<string> subKey = lowerKeyword.Split('/').ToList();
                    foreach (string key in subKey)
                    {
                        dicSearching.Add(key.Trim(), handbookObj);
                    }
                }
                if (dicSearching.ContainsKey(lowerKeyword))
                {
                    dicSearching[lowerKeyword] = handbookObj;
                } else
                {
                    dicSearching.Add(lowerKeyword, handbookObj);
                }
            }
        }

        private HandbookObject searching(string keyword)
        {
            HandbookObject result = null;
            try
            {
                result = dicSearching[keyword];
            } catch { }
            return result;
        }

        #endregion

        private void FrmMainSearch_Activated(object sender, EventArgs e)
        {
            this.Opacity = FG_OPACITY;
            mainPanel.Visible = true;
            txtKeyword.Focus();
        }

        private void FrmMainSearch_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = BG_OPACITY;
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
            } else if (dicSearching.Count == 0)
            {
                updateData("Loading dict...");
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
            this.Opacity = FG_OPACITY;
            updateData();
            Thread tReadingDb = new Thread(new ThreadStart(readingDb));
            tReadingDb.Start();
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
    }
}
