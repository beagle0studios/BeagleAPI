namespace BeagleAPI.OS
{
    partial class BaseDesktop
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
            this.buttonE1 = new BeagleAPI.Controls.ButtonE(this);
            this.buttonE2 = new BeagleAPI.Controls.ButtonE(this);
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).BeginInit();
            this.pnl_titlebar_exstdwin.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonE1
            // 
            this.buttonE1.FlatAppearance.BorderSize = 0;
            this.buttonE1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE1.Location = new System.Drawing.Point(12, 37);
            this.buttonE1.Name = "buttonE1";
            this.buttonE1.Size = new System.Drawing.Size(104, 37);
            this.buttonE1.TabIndex = 2;
            this.buttonE1.Text = "Exit";
            this.buttonE1.UseVisualStyleBackColor = true;
            this.buttonE1.Click += new System.EventHandler(this.buttonE1_Click);
            // 
            // buttonE2
            // 
            this.buttonE2.FlatAppearance.BorderSize = 0;
            this.buttonE2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE2.Location = new System.Drawing.Point(122, 37);
            this.buttonE2.Name = "buttonE2";
            this.buttonE2.Size = new System.Drawing.Size(104, 37);
            this.buttonE2.TabIndex = 3;
            this.buttonE2.Text = "Taskmanager";
            this.buttonE2.UseVisualStyleBackColor = true;
            this.buttonE2.Click += new System.EventHandler(this.buttonE2_Click);
            // 
            // BaseDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.buttonE2);
            this.Controls.Add(this.buttonE1);
            this.Name = "BaseDesktop";
            this.Title = "DESKTOP";
            this.WINDOW_TITLE = "DESKTOP";
            this.Load += new System.EventHandler(this.BaseDesktop_Load);
            this.Controls.SetChildIndex(this.pnl_titlebar_exstdwin, 0);
            this.Controls.SetChildIndex(this.buttonE1, 0);
            this.Controls.SetChildIndex(this.buttonE2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).EndInit();
            this.pnl_titlebar_exstdwin.ResumeLayout(false);
            this.pnl_titlebar_exstdwin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ButtonE buttonE1;
        private Controls.ButtonE buttonE2;
    }
}
