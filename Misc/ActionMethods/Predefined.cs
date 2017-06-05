using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc.ActionMethods
{
    public sealed class Predefined
    {
        public void CreateFormWithinPanel(Window.StdW.StdWin form, System.Windows.Forms.Panel panel)
        {
            form.TopLevel = false;
            form.AutoScroll = true;
            panel.Controls.Add(form);
            form.Show();
        }
    }
}
