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
        private int currentSelection = -1;
        private Dictionary<string, IStdWin> windows;

        public ManagerDisplay()
        {
            InitializeComponent();
            WindowManager.WhenRegisterWindow += WindowManager_WhenRegisterWindow;
            WindowManager.WhenUnregisterWindow += WindowManager_WhenUnregisterWindow;
            windows = new Dictionary<string, IStdWin>();
        }

        private void WindowManager_WhenUnregisterWindow(object sender, SysDebug.DelegatesEvents.StdWinUnregisterEventArgs e)
        {
            listBox1.Items.Remove(e.Name + " | " + e.window.WINDOW_TITLE);
        }

        private void WindowManager_WhenRegisterWindow(object sender, SysDebug.DelegatesEvents.StdWinRegisterEventArgs e)
        {
            listBox1.Items.Add(e.Name + " | " + e.window.WINDOW_TITLE);
            windows.Add(e.Name, e.window);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            currentSelection = listBox1.SelectedIndex;

            //if nothing was selected
            if (currentSelection < 0)
            {
                buttonE1.Enabled = false;
                buttonE2.Enabled = false;
            }
            else
            {
                buttonE1.Enabled = true;
                buttonE2.Enabled = true;
            }
        }

        private void buttonE1_Click(object sender, EventArgs e)
        {
            IStdWin win;
            windows.TryGetValue("", out win); //TODO: insert a valid string to detect window

            //if win is taskman, abort operation. dont close taskman via taskman
            if (win == this)
                return;

            foreach (var item in ManageHelper.window_collection)
            {
                if (item.Value.WINDOW_TITLE == win.WINDOW_TITLE)
                {
                    item.Value.Close();
                    //listBox1.Items[currentSelection] += " (Closed At: " + DateTime.Now.ToString() + ")";
                    listBox1.Items.RemoveAt(currentSelection);
                    break;
                }
            }
        }

        private void buttonE2_Click(object sender, EventArgs e)
        {
            IStdWin win;
            windows.TryGetValue("", out win); //TODO: insert a valid string to detect window

            Window.Message.Messages m = new Window.Message.Messages(
                "Process Info",
                "Window Title: " + win.WINDOW_TITLE + Environment.NewLine +
                "Registered Name: " + win.ToString() + Environment.NewLine +
                "Creation Time: " + win.CreationTime.ToString(), true);
        }
    }
}
