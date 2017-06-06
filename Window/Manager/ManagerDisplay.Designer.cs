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
            this.buttonE2 = new BeagleAPI.Controls.ButtonE();
            this.buttonE1 = new BeagleAPI.Controls.ButtonE();
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).BeginInit();
            this.pnl_titlebar_exstdwin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titlebar_exstdwin
            // 
            this.pnl_titlebar_exstdwin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_titlebar_exstdwin.Size = new System.Drawing.Size(482, 20);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(2, 32);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(474, 164);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonE2
            // 
            this.buttonE2.Enabled = false;
            this.buttonE2.FlatAppearance.BorderSize = 0;
            this.buttonE2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE2.GetParent = null;
            this.buttonE2.Location = new System.Drawing.Point(252, 201);
            this.buttonE2.Name = "buttonE2";
            this.buttonE2.Size = new System.Drawing.Size(126, 29);
            this.buttonE2.TabIndex = 5;
            this.buttonE2.Text = "Get Process Info";
            this.buttonE2.UseVisualStyleBackColor = true;
            this.buttonE2.Click += new System.EventHandler(this.buttonE2_Click);
            // 
            // buttonE1
            // 
            this.buttonE1.Enabled = false;
            this.buttonE1.FlatAppearance.BorderSize = 0;
            this.buttonE1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE1.GetParent = null;
            this.buttonE1.Location = new System.Drawing.Point(384, 201);
            this.buttonE1.Name = "buttonE1";
            this.buttonE1.Size = new System.Drawing.Size(92, 29);
            this.buttonE1.TabIndex = 4;
            this.buttonE1.Text = "Stop Task";
            this.buttonE1.UseVisualStyleBackColor = true;
            this.buttonE1.Click += new System.EventHandler(this.buttonE1_Click);
            // 
            // ManagerDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 241);
            this.Controls.Add(this.buttonE2);
            this.Controls.Add(this.buttonE1);
            this.Controls.Add(this.listBox1);
            this.CreationTime = new System.DateTime(2017, 6, 6, 9, 46, 16, 67);
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "ManagerDisplay";
            this.ShowCloseButton = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Title = "Manager Display";
            this.WINDOW_TITLE = "Manager Display";
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
        private Controls.ButtonE buttonE2;
        private Controls.ButtonE buttonE1;
    }
}