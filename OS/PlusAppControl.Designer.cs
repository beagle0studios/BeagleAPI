namespace BeagleAPI.OS
{
    partial class PlusAppControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonE1 = new BeagleAPI.Controls.ButtonE();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6.75F);
            this.label1.Location = new System.Drawing.Point(-2, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonE1
            // 
            this.buttonE1.BackColor = System.Drawing.Color.White;
            this.buttonE1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonE1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE1.GetParent = null;
            this.buttonE1.Location = new System.Drawing.Point(4, 4);
            this.buttonE1.Name = "buttonE1";
            this.buttonE1.Size = new System.Drawing.Size(56, 41);
            this.buttonE1.TabIndex = 2;
            this.buttonE1.UseVisualStyleBackColor = false;
            // 
            // PlusAppControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonE1);
            this.Controls.Add(this.label1);
            this.Name = "PlusAppControl";
            this.Size = new System.Drawing.Size(63, 75);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private BeagleAPI.Controls.ButtonE buttonE1;

    }
}
