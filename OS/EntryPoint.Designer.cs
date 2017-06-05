namespace BeagleAPI.OS
{
    partial class EntryPoint
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).BeginInit();
            this.pnl_titlebar_exstdwin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titlebar_exstdwin
            // 
            this.pnl_titlebar_exstdwin.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_titlebar_exstdwin.Size = new System.Drawing.Size(414, 20);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.label1.Location = new System.Drawing.Point(465, 523);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ladevorgang...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EntryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(414, 269);
            this.Controls.Add(this.label1);
            this.CreationTime = new System.DateTime(2017, 6, 4, 17, 5, 20, 427);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryPoint";
            this.ShowCloseButton = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EntryPoint";
            this.Title = "SYSTEM (DO NOT CLOSE)";
            this.WINDOW_TITLE = "SYSTEM (DO NOT CLOSE)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.WindowTitleColor = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.EntryPoint_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pnl_titlebar_exstdwin, 0);
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).EndInit();
            this.pnl_titlebar_exstdwin.ResumeLayout(false);
            this.pnl_titlebar_exstdwin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}