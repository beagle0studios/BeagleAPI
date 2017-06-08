using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BeagleAPI.Controls
{
    public class ButtonTB : ButtonE
    {
        public ButtonTB(BeagleAPI.Window.IStdWin parent, Icon icon, string windowID) : base(parent)
        {
            BackgroundImage = icon.ToBitmap();
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            INFORMATION = windowID;
            Size = new Size(30, 30);
        }
    }
}
