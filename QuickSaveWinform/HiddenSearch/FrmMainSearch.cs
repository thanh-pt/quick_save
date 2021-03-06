﻿using System;
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

        public ConfigInfo ConfigData = new ConfigInfo();

        int m_lastWidth = 300;
        int m_lastHeigh = 325;
        List<HandbookInfo> m_lstHandbookObj;
        Dictionary<string, HandbookInfo> m_dicSearching = new Dictionary<string, HandbookInfo>();

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
            foreach (HandbookInfo handbookObj in m_lstHandbookObj)
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

        private HandbookInfo searching(string keyword)
        {
            HandbookInfo result = null;
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

        private void adaptiveApplicationHeigh()
        {
            this.Height = 40 
                        + txtKeyword.Height
                        + (txtStandFor.Visible ? txtStandFor.Height : 0)
                        + (txtDefinition.Visible ? 175 : 0)
                        + (txtHowItWork.Visible ? txtHowItWork.Height : 0);
        }

        #endregion

        private void FrmMainSearch_Activated(object sender, EventArgs e)
        {
            this.Opacity = ConfigData.ActiveOpacity;
            mainPanel.Visible = true;
            txtKeyword.Focus();
            this.Width = m_lastWidth;
            this.Height = m_lastHeigh;
        }

        private void FrmMainSearch_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = ConfigData.DeactiveOpacity;
            mainPanel.Visible = false;
            m_lastWidth = this.Width;
            m_lastHeigh = this.Height;
            this.Width = 0;
            this.Height = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HandbookInfo searchResult = searching(txtKeyword.Text.ToLower());
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
            FrmConfiguration config = new FrmConfiguration(this);
            config.ShowDialog();
        }

        private void txtHowItWork_TextChanged(object sender, EventArgs e)
        {
            if (txtHowItWork.Text.Length == 0)
            {
                txtHowItWork.Visible = false;
            } else
            {
                txtHowItWork.Visible = true;
            }
            adaptiveApplicationHeigh();
        }

        private void txtDefinition_TextChanged(object sender, EventArgs e)
        {
            if(txtDefinition.Text.Length == 0)
            {
                txtDefinition.Visible = false;
            } else
            {
                txtDefinition.Visible = true;
                txtDefinition.BringToFront();
            }
            adaptiveApplicationHeigh();
        }
    }
}
