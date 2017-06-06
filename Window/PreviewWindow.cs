using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeagleAPI.Window
{
    public partial class PreviewWindow : Form
    {
        Form wind_;

        public PreviewWindow(Form window)
        {
            InitializeComponent();
            wind_ = window;
        }

        private void PreviewWindow_Load(object sender, EventArgs e)
        {
            wind_.TopLevel = false;
            wind_.AutoScroll = true;
            panel1.Controls.Add(wind_);
            wind_.Show();
        }
    }
}
