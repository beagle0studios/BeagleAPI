using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeagleAPI.Window.StdW;
using System.Reflection;
using BeagleAPI.Window.Message;
using BeagleAPI.Attributes;

namespace BeagleAPI.Misc
{
    public class WindowToScreen<TWindow> where TWindow : StdWin
    {
        private TWindow screenWindow;

        public WindowToScreen(TWindow window) 
        {
            screenWindow = window;
        }

        public void CopyToScreen()
        {
            Type tWindow = typeof(TWindow);
            Type tAttr = typeof(PrintableAttribute);

            // Prüfen, ob das Attribut bei der Klasse 'tWindow' gesetzt ist
            PrintableAttribute attr = 
                (PrintableAttribute)Attribute.GetCustomAttribute(tWindow, tAttr);
            if (attr != null)
            {
                //Attribut gesetzt.
                Messages m = new Messages("Copy to screen!",
                    tWindow.ToString() + " wird in ein Bild verwandelt."
                    + Environment.NewLine
                    + "Titlebar mitprinten: " + attr.PrintTitlebar.ToString(), true);
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
