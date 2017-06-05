using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeagleAPI.Controls;

namespace BeagleAPI.OS
{
    public partial class PlusAppControl : UserControl
    {
        public ButtonE BUTTON;
        public Label LABEL;

        public PlusAppControl()
        {
            InitializeComponent();
            BUTTON = this.buttonE1;
            LABEL = this.label1;
        }
    }
}
