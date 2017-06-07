using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BeagleAPI.Window.StdW
{
    public partial class StdWinBlack : StdWin
    {
        public StdWinBlack()
        {
            InitializeComponent();
            BlackOut = true;
        }
    }
}
