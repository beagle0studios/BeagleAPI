using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeagleAPI.AppPacks.Browser
{
    internal partial class Beagle_X : Window.StdW.StdWin
    {
        private List<string> AboutStrings = new List<string>();
        private bool shouldMarkAll = true;
        private string CurrentURL = "";

        public Beagle_X()
            :base()
        {
            this.WINDOW_TITLE = "BEAGLE X";
            InitializeComponent();
            AboutStrings.Add("about:addons");
            AboutStrings.Add("about:blank");
            AboutStrings.Add("about:beagle");
            AboutStrings.Add("about:white");
        }

        private void Beagle_X_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                OpenWebsite(textBox1.Text);
            }
        }

        private void OpenWebsite(string url)
        {
            string finalURL = "";
            
            if (!url.Contains("http://") && !url.Contains("https://") && !url.Contains("://") && !url.Contains("about:"))
            {
                finalURL = "http://" + url;
            }
            else
            {
                finalURL = url;
            }

            if(CheckForAbout(url) != "")
            {
                DoAboutHandling(finalURL);
            }
            else {

                webBrowser1.Navigate(finalURL);
            }
        }

        private string CheckForAbout(string url)
        {
            string result = "";
            foreach (string v in AboutStrings)
            {
                if (url == v)
                {
                    result = v;
                    break;
                }
            }
            return result;
        }

        private void DoAboutHandling(string url)
        {
            if (url == "about:blank")
            {
                webBrowser1.Navigate("about:blank");
                return;
            }

            if (url == "about:white")
            {
                string curDir = Directory.GetCurrentDirectory() + @"\AppPacks\Browser\HTML\About";
                this.webBrowser1.Navigate("file:///" + curDir + @"\about_white.html");
                return;
            }
        }

        private void RefreshPage()
        {
            webBrowser1.Refresh(WebBrowserRefreshOption.Completely);
        }

        private void RefreshURL()
        {
            if (!webBrowser1.Url.AbsoluteUri.Contains("AppPacks/Browser/HTML/"))
                textBox1.Text = webBrowser1.Url.AbsoluteUri;
            else
                textBox1.Text = "Über!";

            this.WINDOW_TITLE = webBrowser1.DocumentTitle;
            windowLogoIcon.Image = Properties.Resources.green_circ;
        }

        private void GoBack()
        {
            webBrowser1.GoBack();
        }

        private void GoForward()
        {
            webBrowser1.GoForward();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenWebsite(textBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void neuLadenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            RefreshURL();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (shouldMarkAll)
            {
                textBox1.SelectionStart = 0;
                textBox1.SelectionLength = textBox1.Text.Length;
                shouldMarkAll = false;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            shouldMarkAll = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GoForward();
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            //opens in current tab instead of new window
            webBrowser1.Navigate(CurrentURL);
            e.Cancel = true;
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            CurrentURL = e.Url.AbsoluteUri;
            windowLogoIcon.Image = Properties.Resources.red_circ;
        }
    }
}
