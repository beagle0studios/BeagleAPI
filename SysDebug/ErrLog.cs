using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeagleAPI.SysDebug
{
    public partial class ErrLog : Window.StdW.StdWin
    {
        public ErrLog(string e)
        {
            InitializeComponent();
            WINDOW_TITLE = " ";
            label2.Text = e;
        }

        private void buttonE1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
