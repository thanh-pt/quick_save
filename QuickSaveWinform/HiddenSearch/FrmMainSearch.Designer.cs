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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnShowMore = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKeyword.Location = new System.Drawing.Point(52, 0);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(232, 20);
            this.txtKeyword.TabIndex = 0;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            this.txtKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyword_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
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
            this.mainPanel.TabIndex = 0;
            // 
            // txtStandFor
            // 
            this.txtStandFor.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtStandFor.Location = new System.Drawing.Point(0, 20);
            this.txtStandFor.Name = "txtStandFor";
            this.txtStandFor.Size = new System.Drawing.Size(284, 20);
            this.txtStandFor.TabIndex = 1;
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
            this.txtDefinition.TabIndex = 2;
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
            this.txtHowItWork.TabIndex = 3;
            this.txtHowItWork.Text = resources.GetString("txtHowItWork.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowMore);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.txtKeyword);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 20);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(264, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✖";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfig.Location = new System.Drawing.Point(244, 0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(20, 20);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "❖";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Visible = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnShowMore
            // 
            this.btnShowMore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowMore.Location = new System.Drawing.Point(224, 0);
            this.btnShowMore.Name = "btnShowMore";
            this.btnShowMore.Size = new System.Drawing.Size(20, 20);
            this.btnShowMore.TabIndex = 4;
            this.btnShowMore.Text = "←";
            this.btnShowMore.UseVisualStyleBackColor = true;
            this.btnShowMore.Click += new System.EventHandler(this.btnShowMore_Click);
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
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FrmMainSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FrmMainSearch_Activated);
            this.Deactivate += new System.EventHandler(this.FrmMainSearch_Deactivate);
            this.Shown += new System.EventHandler(this.FrmMainSearch_Shown);
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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnShowMore;
    }
}