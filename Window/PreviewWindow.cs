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
        private StdW.StdWin WIND;

        public PreviewWindow(IStdWin window)
        {
            StdW.StdWin frm = (StdW.StdWin)window;

            InitializeComponent();
            frm.TopLevel = false;
            frm.Parent = this;
            WIND = frm;
            Location = Cursor.Position;
            TopMost = true;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            WIND.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
