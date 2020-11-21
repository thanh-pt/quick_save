namespace HiddenSearch
{
    partial class Configuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            this.txtDataFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackActiveOpacity = new System.Windows.Forms.TrackBar();
            this.trackDeactiveOpacity = new System.Windows.Forms.TrackBar();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackActiveOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDeactiveOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataFileName
            // 
            this.txtDataFileName.Location = new System.Drawing.Point(65, 6);
            this.txtDataFileName.Name = "txtDataFileName";
            this.txtDataFileName.Size = new System.Drawing.Size(147, 20);
            this.txtDataFileName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Active opacity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deactive opacity:";
            // 
            // trackActiveOpacity
            // 
            this.trackActiveOpacity.Location = new System.Drawing.Point(95, 43);
            this.trackActiveOpacity.Maximum = 20;
            this.trackActiveOpacity.Minimum = 1;
            this.trackActiveOpacity.Name = "trackActiveOpacity";
            this.trackActiveOpacity.Size = new System.Drawing.Size(177, 45);
            this.trackActiveOpacity.TabIndex = 3;
            this.trackActiveOpacity.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackActiveOpacity.Value = 1;
            // 
            // trackDeactiveOpacity
            // 
            this.trackDeactiveOpacity.Location = new System.Drawing.Point(95, 94);
            this.trackDeactiveOpacity.Maximum = 20;
            this.trackDeactiveOpacity.Minimum = 1;
            this.trackDeactiveOpacity.Name = "trackDeactiveOpacity";
            this.trackDeactiveOpacity.Size = new System.Drawing.Size(177, 45);
            this.trackDeactiveOpacity.TabIndex = 3;
            this.trackDeactiveOpacity.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackDeactiveOpacity.Value = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(218, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(54, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 187);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.trackDeactiveOpacity);
            this.Controls.Add(this.trackActiveOpacity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataFileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 225);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 225);
            this.Name = "Configuration";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Configuration_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.trackActiveOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDeactiveOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDataFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackActiveOpacity;
        private System.Windows.Forms.TrackBar trackDeactiveOpacity;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
    }
}