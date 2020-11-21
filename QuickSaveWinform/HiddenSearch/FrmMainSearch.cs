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
    public partial class FrmMainSearch : Form
    {
        double FG_OPACITY = 0.3;
        double BG_OPACITY = 0.05;

        public FrmMainSearch()
        {
            InitializeComponent();
            this.Opacity = FG_OPACITY;
            updateData();
        }

        private void FrmMainSearch_Activated(object sender, EventArgs e)
        {
            this.Opacity = FG_OPACITY;
            mainPanel.Visible = true;
        }

        private void FrmMainSearch_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = BG_OPACITY;
            mainPanel.Visible = false;
        }

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // TODO: Coding here
            // Searching...
            updateData("xxxxxxxxxxx",
                "yyyyyyyyyyyyyy",
                "zzzzzzzzzzzzzzzz");
        }
    }
}
