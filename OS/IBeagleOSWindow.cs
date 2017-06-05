using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.OS
{
    public interface IBeagleOSWindow
    {
        bool IsOpened { get; set; }

        void ShowInTaskpanel();
        PlusAppControl GetAppControl();
        void AddAppControl(System.Windows.Forms.TableLayoutPanel taskpanel, ref PlusAppControl control);
        void RemoveAppControl(System.Windows.Forms.TableLayoutPanel taskpanel, ref PlusAppControl control);
    }
}
