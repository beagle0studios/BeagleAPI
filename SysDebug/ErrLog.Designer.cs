namespace BeagleAPI.SysDebug
{
    partial class ErrLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrLog));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonE1 = new BeagleAPI.Controls.ButtonE(this);
            this.buttonE2 = new BeagleAPI.Controls.ButtonE(this);
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BeagleAPI.Properties.Resources.red_circ;
            this.pictureBox1.Location = new System.Drawing.Point(13, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(70, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ein Fehler ist aufgetreten";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label2.Location = new System.Drawing.Point(74, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 81);
            this.label2.TabIndex = 3;
            this.label2.Text = "errmsg";
            // 
            // buttonE1
            // 
            this.buttonE1.FlatAppearance.BorderSize = 0;
            this.buttonE1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.buttonE1.Location = new System.Drawing.Point(348, 165);
            this.buttonE1.Name = "buttonE1";
            this.buttonE1.Size = new System.Drawing.Size(87, 33);
            this.buttonE1.TabIndex = 4;
            this.buttonE1.Text = "Fertig";
            this.buttonE1.UseVisualStyleBackColor = true;
            this.buttonE1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonE1.Click += new System.EventHandler(this.buttonE1_Click);
            // 
            // buttonE2
            // 
            this.buttonE2.FlatAppearance.BorderSize = 0;
            this.buttonE2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.buttonE2.Location = new System.Drawing.Point(3, 165);
            this.buttonE2.Name = "buttonE2";
            this.buttonE2.Size = new System.Drawing.Size(133, 33);
            this.buttonE2.TabIndex = 5;
            this.buttonE2.Text = "Fehler debuggen";
            this.buttonE2.UseVisualStyleBackColor = true;
            // 
            // ErrLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 202);
            this.Controls.Add(this.buttonE2);
            this.Controls.Add(this.buttonE1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ErrLog";
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.buttonE1, 0);
            this.Controls.SetChildIndex(this.buttonE2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Controls.ButtonE buttonE1;
        private Controls.ButtonE buttonE2;
    }
}