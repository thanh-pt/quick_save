namespace HiddenSearch
{
    partial class FrmMainSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainSearch));
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.txtStandFor = new System.Windows.Forms.TextBox();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.txtHowItWork = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKeyword.Location = new System.Drawing.Point(0, 0);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(232, 20);
            this.txtKeyword.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(232, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.txtDefinition);
            this.mainPanel.Controls.Add(this.txtStandFor);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.txtHowItWork);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(284, 262);
            this.mainPanel.TabIndex = 2;
            // 
            // txtStandFor
            // 
            this.txtStandFor.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtStandFor.Location = new System.Drawing.Point(0, 20);
            this.txtStandFor.Name = "txtStandFor";
            this.txtStandFor.Size = new System.Drawing.Size(284, 20);
            this.txtStandFor.TabIndex = 2;
            this.txtStandFor.Text = "Car Configuration File";
            // 
            // txtDefinition
            // 
            this.txtDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDefinition.Location = new System.Drawing.Point(0, 40);
            this.txtDefinition.Multiline = true;
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDefinition.Size = new System.Drawing.Size(284, 142);
            this.txtDefinition.TabIndex = 3;
            this.txtDefinition.Text = resources.GetString("txtDefinition.Text");
            // 
            // txtHowItWork
            // 
            this.txtHowItWork.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtHowItWork.Location = new System.Drawing.Point(0, 182);
            this.txtHowItWork.Multiline = true;
            this.txtHowItWork.Name = "txtHowItWork";
            this.txtHowItWork.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHowItWork.Size = new System.Drawing.Size(284, 80);
            this.txtHowItWork.TabIndex = 4;
            this.txtHowItWork.Text = resources.GetString("txtHowItWork.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtKeyword);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 20);
            this.panel1.TabIndex = 5;
            // 
            // FrmMainSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMainSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " ";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FrmMainSearch_Activated);
            this.Deactivate += new System.EventHandler(this.FrmMainSearch_Deactivate);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox txtHowItWork;
        private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.TextBox txtStandFor;
        private System.Windows.Forms.Panel panel1;
    }
}