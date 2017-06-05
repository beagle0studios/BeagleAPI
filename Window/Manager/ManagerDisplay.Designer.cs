namespace BeagleAPI.Window.Manager
{
    partial class ManagerDisplay
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).BeginInit();
            this.pnl_titlebar_exstdwin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titlebar_exstdwin
            // 
            this.pnl_titlebar_exstdwin.Size = new System.Drawing.Size(783, 31);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(3, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(768, 252);
            this.listBox1.TabIndex = 1;
            // 
            // ManagerDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 313);
            this.Controls.Add(this.listBox1);
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.Name = "ManagerDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Title = "Manager Display";
            this.WINDOW_TITLE = "Manager Display";
            this.Controls.SetChildIndex(this.pnl_titlebar_exstdwin, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).EndInit();
            this.pnl_titlebar_exstdwin.ResumeLayout(false);
            this.pnl_titlebar_exstdwin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}