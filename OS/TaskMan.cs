using BeagleAPI.Window;
using BeagleAPI.Window.Manager;
using BeagleAPI.Window.StdW;
using System;
using System.Collections.Generic;

namespace BeagleAPI.OS
{
    public partial class TaskMan : StdWin
    {
        private int currentSelection = -1;
        private Dictionary<int, IStdWin> windows;

        public TaskMan() : base()
        {
            InitializeComponent();
            //ExitOnClose = true;
            windows = new Dictionary<int, IStdWin>();
        }

        public TaskMan(StdWin parent) : base(true, parent)
        {
            InitializeComponent();
            //ExitOnClose = true;
            windows = new Dictionary<int, IStdWin>();
        }

        private void TaskMan_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (IStdWin str in ManageHelper.window_collection.Values)
            {
                if (str.ShowInTaskman)
                {
                    listBox1.Items.Add((string)str.WINDOW_TITLE);
                    windows.Add(i, str);
                    i++;
                }
            }
            i = 0;
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
            windows.TryGetValue(currentSelection, out win);

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

        private void TaskMan_Shown(object sender, EventArgs e)
        {

        }

        private void buttonE2_Click(object sender, EventArgs e)
        {
            IStdWin win;
            windows.TryGetValue(currentSelection, out win);

            Window.Message.Messages m = new Window.Message.Messages(
                "Process Info",
                "Window Title: " + win.WINDOW_TITLE + Environment.NewLine +
                "Registered Name: " + win.ToString() + Environment.NewLine +
                "Creation Time: " + win.CreationTime.ToString(), true);
        }
    }
}
