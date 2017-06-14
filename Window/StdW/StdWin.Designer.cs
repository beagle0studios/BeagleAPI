namespace BeagleAPI.Window.StdW
{
    public partial class StdWin
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
            this.pnl_titlebar_exstdwin = new System.Windows.Forms.Panel();
            this.buttonStdWin1 = new BeagleAPI.Controls.ButtonStdWin();
            this.windowLogoIcon = new System.Windows.Forms.PictureBox();
            this.lblWindowTitle = new System.Windows.Forms.Label();
            this.buttonStdWin2 = new BeagleAPI.Controls.ButtonStdWin();
            this.pnl_titlebar_exstdwin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titlebar_exstdwin
            // 
            this.pnl_titlebar_exstdwin.Controls.Add(this.buttonStdWin2);
            this.pnl_titlebar_exstdwin.Controls.Add(this.buttonStdWin1);
            this.pnl_titlebar_exstdwin.Controls.Add(this.windowLogoIcon);
            this.pnl_titlebar_exstdwin.Controls.Add(this.lblWindowTitle);
            this.pnl_titlebar_exstdwin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titlebar_exstdwin.Location = new System.Drawing.Point(0, 0);
            this.pnl_titlebar_exstdwin.Name = "pnl_titlebar_exstdwin";
            this.pnl_titlebar_exstdwin.Size = new System.Drawing.Size(434, 37);
            this.pnl_titlebar_exstdwin.TabIndex = 0;
            this.pnl_titlebar_exstdwin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // buttonStdWin1
            // 
            this.buttonStdWin1.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStdWin1.FlatAppearance.BorderSize = 0;
            this.buttonStdWin1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonStdWin1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonStdWin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStdWin1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonStdWin1.Location = new System.Drawing.Point(394, 0);
            this.buttonStdWin1.Name = "buttonStdWin1";
            this.buttonStdWin1.Size = new System.Drawing.Size(40, 37);
            this.buttonStdWin1.TabIndex = 1;
            this.buttonStdWin1.Text = "X";
            this.buttonStdWin1.UseVisualStyleBackColor = true;
            this.buttonStdWin1.Click += new System.EventHandler(this.buttonStdWin1_Click);
            // 
            // windowLogoIcon
            // 
            this.windowLogoIcon.Location = new System.Drawing.Point(3, 2);
            this.windowLogoIcon.Name = "windowLogoIcon";
            this.windowLogoIcon.Size = new System.Drawing.Size(24, 25);
            this.windowLogoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.windowLogoIcon.TabIndex = 4;
            this.windowLogoIcon.TabStop = false;
            // 
            // lblWindowTitle
            // 
            this.lblWindowTitle.AutoSize = true;
            this.lblWindowTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblWindowTitle.Location = new System.Drawing.Point(27, 5);
            this.lblWindowTitle.Name = "lblWindowTitle";
            this.lblWindowTitle.Size = new System.Drawing.Size(174, 20);
            this.lblWindowTitle.TabIndex = 1;
            this.lblWindowTitle.Text = "Application has no Title";
            // 
            // buttonStdWin2
            // 
            this.buttonStdWin2.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStdWin2.FlatAppearance.BorderSize = 0;
            this.buttonStdWin2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonStdWin2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonStdWin2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStdWin2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonStdWin2.Location = new System.Drawing.Point(354, 0);
            this.buttonStdWin2.Name = "buttonStdWin2";
            this.buttonStdWin2.Size = new System.Drawing.Size(40, 37);
            this.buttonStdWin2.TabIndex = 5;
            this.buttonStdWin2.Text = "_";
            this.buttonStdWin2.UseVisualStyleBackColor = true;
            this.buttonStdWin2.Click += new System.EventHandler(this.buttonStdWin2_Click);
            // 
            // StdWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_titlebar_exstdwin);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StdWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.pnl_titlebar_exstdwin.ResumeLayout(false);
            this.pnl_titlebar_exstdwin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblWindowTitle;
        protected System.Windows.Forms.PictureBox windowLogoIcon;
        public System.Windows.Forms.Panel pnl_titlebar_exstdwin;
        private Controls.ButtonStdWin buttonStdWin1;
        private Controls.ButtonStdWin buttonStdWin2;
    }
}