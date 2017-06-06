using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeagleAPI.Window.Message
{
    public partial class Messages : StdW.StdWin
    {
        public Action OnExit;

        /// <summary>
        /// Create a new message window.
        /// </summary>
        /// <param name="title">Message title (will be shown in uppercase)</param>
        /// <param name="msg">Message itself</param>
        /// <param name="showDirectly">True, if calling ShowDialog() is not neccessary.</param>
        public Messages(string title, string msg, bool showDirectly = false)
        {
            InitializeComponent();
            Title = title.ToUpper();
            label2.Text = msg;

            if (showDirectly) Show();
        }

        private void buttonE1_Click(object sender, EventArgs e)
        {
            OnExit();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnExit();
            this.Close();
        }

        /// <summary>
        /// Give the window a specific method calling at closing the window
        /// </summary>
        /// <param name="method">Method that will get called.</param>
        public void DoOnExit(Action method)
        {
            OnExit = method;
        }
    }
}
