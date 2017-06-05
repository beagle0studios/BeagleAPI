using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeagleAPI.Window.Manager
{
    public partial class ManagerDisplay : StdW.StdWin
    {
        public ManagerDisplay()
        {
            InitializeComponent();
            WindowManager.WhenRegisterWindow += WindowManager_WhenRegisterWindow;
            WindowManager.WhenUnregisterWindow += WindowManager_WhenUnregisterWindow;
        }

        private void WindowManager_WhenUnregisterWindow(object sender, SysDebug.DelegatesEvents.StdWinUnregisterEventArgs e)
        {
            listBox1.Items.Remove(e.Name + " | " + e.window.WINDOW_TITLE);
        }

        private void WindowManager_WhenRegisterWindow(object sender, SysDebug.DelegatesEvents.StdWinRegisterEventArgs e)
        {
            listBox1.Items.Add(e.Name + " | " + e.window.WINDOW_TITLE);
        }
    }
}
