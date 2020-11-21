using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiddenSearch
{
    public partial class Configuration : Form
    {
        FrmMainSearch mainSearch;
        public Configuration(FrmMainSearch parent)
        {
            InitializeComponent();
            mainSearch = parent;
        }

        private void Configuration_Shown(object sender, EventArgs e)
        {
            txtDataFileName.Text = mainSearch.ConfigData.DataFileName;
            trackActiveOpacity.Value = (int)(mainSearch.ConfigData.ActiveOpacity * 100)/5;
            trackDeactiveOpacity.Value = (int)(mainSearch.ConfigData.DeactiveOpacity * 100)/5;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mainSearch.ConfigData.DataFileName != txtDataFileName.Text)
            {
                mainSearch.ConfigData.DataFileName = txtDataFileName.Text;
                mainSearch.reloadDataBase();
            }
            mainSearch.ConfigData.ActiveOpacity = (double)trackActiveOpacity.Value * 5 / 100;
            mainSearch.ConfigData.DeactiveOpacity = (double)trackDeactiveOpacity.Value * 5 / 100;
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Data File";
            theDialog.Filter = "xlsx files|*.xlsx";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                txtDataFileName.Text = theDialog.FileName;
            }
        }
    }
}
