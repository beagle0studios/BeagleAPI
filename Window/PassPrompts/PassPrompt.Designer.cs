namespace BeagleAPI.Window.PassPrompts
{
    partial class PassPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassPrompt));
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonE1 = new BeagleAPI.Controls.ButtonE(this);
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).BeginInit();
            this.pnl_titlebar_exstdwin.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowLogoIcon
            // 
            this.windowLogoIcon.Location = new System.Drawing.Point(5, 3);
            this.windowLogoIcon.Margin = new System.Windows.Forms.Padding(5);
            this.windowLogoIcon.Size = new System.Drawing.Size(15, 20);
            // 
            // pnl_titlebar_exstdwin
            // 
            this.pnl_titlebar_exstdwin.Margin = new System.Windows.Forms.Padding(5);
            this.pnl_titlebar_exstdwin.Size = new System.Drawing.Size(411, 27);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Für die angeforderte Aktion ist die Eingabe \r\neines Passwortes erforderlich. Gebe" +
    "n Sie das \r\nPasswort ein und klicken Sie auf OK.";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(27, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '•';
            this.textBox1.Size = new System.Drawing.Size(251, 25);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonE1
            // 
            this.buttonE1.FlatAppearance.BorderSize = 0;
            this.buttonE1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE1.Location = new System.Drawing.Point(284, 129);
            this.buttonE1.Name = "buttonE1";
            this.buttonE1.Size = new System.Drawing.Size(68, 25);
            this.buttonE1.TabIndex = 6;
            this.buttonE1.Text = "OK";
            this.buttonE1.UseVisualStyleBackColor = true;
            this.buttonE1.Click += new System.EventHandler(this.buttonE1_Click);
            // 
            // PassPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 207);
            this.Controls.Add(this.buttonE1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.CreationTime = new System.DateTime(2017, 5, 9, 14, 43, 57, 431);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassPrompt";
            this.Title = "Passwort Angefordert";
            this.WINDOW_TITLE = "Passwort Angefordert";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.buttonE1, 0);
            this.Controls.SetChildIndex(this.pnl_titlebar_exstdwin, 0);
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).EndInit();
            this.pnl_titlebar_exstdwin.ResumeLayout(false);
            this.pnl_titlebar_exstdwin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private Controls.ButtonE buttonE1;
    }
}