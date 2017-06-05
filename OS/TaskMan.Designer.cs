namespace BeagleAPI.OS
{
    partial class TaskMan
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonE1 = new BeagleAPI.Controls.ButtonE();
            this.buttonE2 = new BeagleAPI.Controls.ButtonE();
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).BeginInit();
            this.pnl_titlebar_exstdwin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titlebar_exstdwin
            // 
            this.pnl_titlebar_exstdwin.Size = new System.Drawing.Size(705, 51);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(21, 59);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(662, 438);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonE1
            // 
            this.buttonE1.GetParent = this;
            this.buttonE1.Enabled = false;
            this.buttonE1.FlatAppearance.BorderSize = 0;
            this.buttonE1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE1.Location = new System.Drawing.Point(536, 508);
            this.buttonE1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonE1.Name = "buttonE1";
            this.buttonE1.Size = new System.Drawing.Size(150, 45);
            this.buttonE1.TabIndex = 2;
            this.buttonE1.Text = "Stop Task";
            this.buttonE1.UseVisualStyleBackColor = true;
            this.buttonE1.Click += new System.EventHandler(this.buttonE1_Click);
            // 
            // buttonE2
            // 
            this.buttonE2.GetParent = this;
            this.buttonE2.Enabled = false;
            this.buttonE2.FlatAppearance.BorderSize = 0;
            this.buttonE2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE2.Location = new System.Drawing.Point(322, 508);
            this.buttonE2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonE2.Name = "buttonE2";
            this.buttonE2.Size = new System.Drawing.Size(205, 45);
            this.buttonE2.TabIndex = 3;
            this.buttonE2.Text = "Get Process Info";
            this.buttonE2.UseVisualStyleBackColor = true;
            this.buttonE2.Click += new System.EventHandler(this.buttonE2_Click);
            // 
            // TaskMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.ClientSize = new System.Drawing.Size(705, 560);
            this.Controls.Add(this.buttonE2);
            this.Controls.Add(this.buttonE1);
            this.Controls.Add(this.listBox1);
            this.CreationTime = new System.DateTime(2017, 5, 10, 12, 43, 50, 813);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "TaskMan";
            this.Title = "TASKMANAGER";
            this.WINDOW_TITLE = "TASKMANAGER";
            this.Load += new System.EventHandler(this.TaskMan_Load);
            this.Shown += new System.EventHandler(this.TaskMan_Shown);
            this.Controls.SetChildIndex(this.pnl_titlebar_exstdwin, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.buttonE1, 0);
            this.Controls.SetChildIndex(this.buttonE2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).EndInit();
            this.pnl_titlebar_exstdwin.ResumeLayout(false);
            this.pnl_titlebar_exstdwin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private Controls.ButtonE buttonE1;
        private Controls.ButtonE buttonE2;
    }
}
