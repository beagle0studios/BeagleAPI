using BeagleAPI.Misc;
using BeagleAPI.Window.StdW;
using System;
using System.Windows.Forms;

namespace BeagleAPI.OS
{
    public partial class BaseDesktop : StdWin
    {
        public BaseDesktop()
        {
            InitializeComponent();
        }

        private void BaseDesktop_Load(object sender, EventArgs e)
        {
            pnl_titlebar_exstdwin.Visible = false;
        }

        private void buttonE1_Click(object sender, EventArgs e)
        {
            //EntryPoint.Shutdown
            Application.Exit();
        }

        private void buttonE2_Click(object sender, EventArgs e)
        {
            TaskMan taskMan = new TaskMan(this);
            taskMan.Show();
        }
    }
}
