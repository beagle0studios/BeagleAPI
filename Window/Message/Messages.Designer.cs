namespace BeagleAPI.Window.Message
{
    partial class Messages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messages));
            this.buttonE1 = new BeagleAPI.Controls.ButtonE();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).BeginInit();
            this.pnl_titlebar_exstdwin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titlebar_exstdwin
            // 
            this.pnl_titlebar_exstdwin.Size = new System.Drawing.Size(412, 35);
            // 
            // buttonE1
            // 
            this.buttonE1.GetParent = this;
            this.buttonE1.FlatAppearance.BorderSize = 0;
            this.buttonE1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE1.Location = new System.Drawing.Point(314, 154);
            this.buttonE1.Name = "buttonE1";
            this.buttonE1.Size = new System.Drawing.Size(96, 32);
            this.buttonE1.TabIndex = 5;
            this.buttonE1.Text = "OK";
            this.buttonE1.UseVisualStyleBackColor = true;
            this.buttonE1.Click += new System.EventHandler(this.buttonE1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 93);
            this.label2.TabIndex = 6;
            this.label2.Text = "__-";
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 189);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonE1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Messages";
            this.ShowInTaskbar = false;
            this.Title = "_";
            this.WINDOW_TITLE = "_";
            this.Controls.SetChildIndex(this.buttonE1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.pnl_titlebar_exstdwin, 0);
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).EndInit();
            this.pnl_titlebar_exstdwin.ResumeLayout(false);
            this.pnl_titlebar_exstdwin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.ButtonE buttonE1;
        private System.Windows.Forms.Label label2;
    }
}