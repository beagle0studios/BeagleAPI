using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeagleAPI.Misc;
using BeagleAPI.SysDebug.DelegatesEvents;
using BeagleAPI.Window;

namespace BeagleAPI.Controls
{
    public partial class ControlB : UserControl, IControlB, IBeagleBase
    {
        public IStdWin GetParent
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Word Title
        {
            get
            {
                return Name;
            }
        }

        public event EventHandler<StdWinButtonClickedEventArgs> StdWinClicked;

        public void Destroy()
        {
            DisposeB();
        }

        public void DisposeB()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is IControlB)
                {
                    ((IControlB)ctrl).DisposeB();
                }
            }
            UnregisterBaseBase();
            Dispose();
        }

        public void Redraw()
        {
        }

        public void Redraw(IControlB parent)
        {

        }

        public void RegisterToBaseBase()
        {
            BeagleAPI.Misc.BeagleBaseBase.ALLBEAGLES.Add(Name, this);
        }

        public void UnregisterBaseBase()
        {
            BeagleBaseBase.ALLBEAGLES.Remove(Name);
        }
    }
}
