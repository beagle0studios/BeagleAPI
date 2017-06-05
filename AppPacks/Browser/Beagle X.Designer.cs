namespace BeagleAPI.AppPacks.Browser
{
    partial class Beagle_X
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_WebBrowser = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowserContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.neuLadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Controls = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnl_WebBrowser.SuspendLayout();
            this.webBrowserContext.SuspendLayout();
            this.pnl_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnl_WebBrowser);
            this.panel2.Controls.Add(this.pnl_Controls);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 424);
            this.panel2.TabIndex = 1;
            // 
            // pnl_WebBrowser
            // 
            this.pnl_WebBrowser.Controls.Add(this.webBrowser1);
            this.pnl_WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_WebBrowser.Location = new System.Drawing.Point(0, 41);
            this.pnl_WebBrowser.Name = "pnl_WebBrowser";
            this.pnl_WebBrowser.Size = new System.Drawing.Size(625, 383);
            this.pnl_WebBrowser.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.ContextMenuStrip = this.webBrowserContext;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(625, 383);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://beaglestudios.lima-city.de/", System.UriKind.Absolute);
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser1_NewWindow);
            // 
            // webBrowserContext
            // 
            this.webBrowserContext.BackColor = System.Drawing.Color.White;
            this.webBrowserContext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webBrowserContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuLadenToolStripMenuItem});
            this.webBrowserContext.Name = "webBrowserContext";
            this.webBrowserContext.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.webBrowserContext.Size = new System.Drawing.Size(147, 28);
            // 
            // neuLadenToolStripMenuItem
            // 
            this.neuLadenToolStripMenuItem.Image = global::BeagleAPI.Properties.Resources.circled_left_21600;
            this.neuLadenToolStripMenuItem.Name = "neuLadenToolStripMenuItem";
            this.neuLadenToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.neuLadenToolStripMenuItem.Text = "Neu laden";
            this.neuLadenToolStripMenuItem.ToolTipText = "Lädt die angezeigte Webseite neu";
            this.neuLadenToolStripMenuItem.Click += new System.EventHandler(this.neuLadenToolStripMenuItem_Click);
            // 
            // pnl_Controls
            // 
            this.pnl_Controls.Controls.Add(this.button8);
            this.pnl_Controls.Controls.Add(this.button7);
            this.pnl_Controls.Controls.Add(this.button6);
            this.pnl_Controls.Controls.Add(this.textBox1);
            this.pnl_Controls.Controls.Add(this.button5);
            this.pnl_Controls.Controls.Add(this.button4);
            this.pnl_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Controls.Location = new System.Drawing.Point(0, 0);
            this.pnl_Controls.Name = "pnl_Controls";
            this.pnl_Controls.Size = new System.Drawing.Size(625, 41);
            this.pnl_Controls.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.Dock = System.Windows.Forms.DockStyle.Left;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(57, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(29, 41);
            this.button8.TabIndex = 5;
            this.button8.Text = "R";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackgroundImage = global::BeagleAPI.Properties.Resources.circled_right_21600;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(564, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(29, 41);
            this.button7.TabIndex = 4;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::BeagleAPI.Properties.Resources.menu_6rows_fade_120;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(596, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(29, 41);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(89, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::BeagleAPI.Properties.Resources.circled_right_21600;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(28, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 41);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::BeagleAPI.Properties.Resources.circled_left_21600;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 41);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Beagle_X
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 455);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "Beagle_X";
            this.Load += new System.EventHandler(this.Beagle_X_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.windowLogoIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnl_WebBrowser.ResumeLayout(false);
            this.webBrowserContext.ResumeLayout(false);
            this.pnl_Controls.ResumeLayout(false);
            this.pnl_Controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_Controls;
        private System.Windows.Forms.Panel pnl_WebBrowser;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ContextMenuStrip webBrowserContext;
        private System.Windows.Forms.ToolStripMenuItem neuLadenToolStripMenuItem;
        private System.Windows.Forms.Button button8;
    }
}