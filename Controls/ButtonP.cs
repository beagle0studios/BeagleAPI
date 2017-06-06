using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeagleAPI.Window;

namespace BeagleAPI.Controls
{
    /// <summary>
    /// Stellt einen Button bereit, der Vorschaufunktionen bietet.
    /// </summary>
    public partial class ButtonP : ButtonE
    {
        private Point _previewPosition;
        private PreviewWindow prev;
        private Form _previewWindow;

        public ButtonP()
        {
            MouseHover += ButtonP_MouseHover;
            MouseLeave += ButtonP_MouseLeave;
            _previewPosition = new Point(20, 20);
        }

        #region Properties

        public Point PreviewPosition
        {
            get { return _previewPosition; }
            set { _previewPosition = value; }
        }

        public Form PreviewWindow
        {
            get { return _previewWindow; }
            set { _previewWindow = value; }
        }

        #endregion

        #region Methods

        private void ButtonP_MouseHover(object sender, EventArgs e)
        {
            prev = new PreviewWindow(_previewWindow);
            prev.Show();
        }

        private void ButtonP_MouseLeave(object sender, EventArgs e)
        {
            prev.Hide();
        }

        #endregion
    }
}
