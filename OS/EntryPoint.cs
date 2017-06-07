using BeagleAPI.Window;
using BeagleAPI.Window.StdW;
using BeagleAPI.Misc;
using System;

namespace BeagleAPI.OS
{
    public partial class EntryPoint : StdWin
    {
        public int Remaining = 2;
        private int timer = 0;
        private IStdWin showAfter;
        private IStdWin[] loadObjs;

        public EntryPoint(IStdWin show, ref IStdWin[] loadObjects)
        {
            InitializeComponent();
            pnl_titlebar_exstdwin.Visible = false;

            showAfter = show;
            loadObjs = loadObjects;
            ShowInTaskman = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EntryPoint_Load(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = (this.ClientSize.Height - label1.Height) / 2;
            
            foreach (IStdWin comp in loadObjs)
            {
                LoadObjectsStatic.LOADEDCOMPS.Add(comp);
                comp.IsLoadedToBase = true;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            if(timer > Remaining)
            {
                showAfter.Show();
                timer1.Stop();
                timer1.Dispose();
                this.Hide();
            }
        }

        private void ExitSelf()
        {

        }
    }
}
