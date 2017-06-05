namespace BeagleAPI.Controls
{
    partial class Grouper
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
            this.lblGrouperText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-51, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "____________________________________________________________________________";
            // 
            // lblGrouperText
            // 
            this.lblGrouperText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblGrouperText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrouperText.Location = new System.Drawing.Point(0, 6);
            this.lblGrouperText.Name = "lblGrouperText";
            this.lblGrouperText.Size = new System.Drawing.Size(231, 13);
            this.lblGrouperText.TabIndex = 1;
            this.lblGrouperText.Text = "TEXT";
            this.lblGrouperText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Grouper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblGrouperText);
            this.Controls.Add(this.label1);
            this.Name = "Grouper";
            this.Size = new System.Drawing.Size(231, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGrouperText;
    }
}
