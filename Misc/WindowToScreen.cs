using BeagleAPI.Attributes;
using BeagleAPI.Window.Message;
using BeagleAPI.Window.StdW;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeagleAPI.Misc
{
    /// <summary>
    /// Bietet die Möglichkeit, ein angegebenes Fenser in einem Bild zu speichern.
    /// </summary>
    public class WindowToScreen
    {
        private Type _windowType;
        private StdWin screenWindow;

        /// <summary>
        /// Constructor für die Klasse. Erstellt ein neues Objekt.
        /// </summary>
        /// <param name="windowType">Der Typ der Klasse, von der ein Bild erstellt werden soll. "typeof()"</param>
        /// <param name="window">Die Instanz der Klasse, von der ein Bild erstellt werden soll.</param>
        public WindowToScreen(Type windowType, StdWin window) 
        {
            screenWindow = window;
            _windowType = windowType;
        }

        /// <summary>
        /// Erstellt ein Bild des Fensters.
        /// </summary>
        /// <param name="path">Der absolute Speicherort des Bildes.</param>
        public void CopyToScreen(string path)
        {
            Type tWindow = _windowType;
            Type tAttr = typeof(PrintableAttribute);

            // Prüfen, ob das Attribut bei der Klasse 'tWindow' gesetzt ist
            PrintableAttribute attr = 
                (PrintableAttribute)Attribute.GetCustomAttribute(tWindow, tAttr);
            if (attr != null)
            {
                if (!attr.PrintTitlebar)
                    screenWindow.pnl_titlebar_exstdwin.Visible = false;

                var frm = screenWindow;

                Cursor.Current = Cursors.WaitCursor;
                frm.Enabled = false;
                var bmp = new Bitmap(frm.Width, frm.Height);

                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(path);

                frm.Enabled = true;
                Cursor.Current = Cursors.Default;
                
                if (!attr.PrintTitlebar)
                    screenWindow.pnl_titlebar_exstdwin.Visible = true;

                Messages m = new Messages("Bild wurde gespeichert!",
                    tWindow.ToString() + " wurde in einem Bild gespeichert."
                    + Environment.NewLine
                    + "Speicherort: " + path, true);

            }
            else
            {
                Messages m = new Messages("Achtung!",
                    "Die Klasse '" + tWindow.ToString() +
                    " muss das Attribut \"Printable\" gesetzt haben.", true);
            }
        }
    }
}
