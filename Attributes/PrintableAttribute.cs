using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeagleAPI.Misc;
using System.Drawing;

namespace BeagleAPI.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class PrintableAttribute : Attribute
    {
        private bool _printTitlebar = true;
        private bool _printWatersign = true;
        private string _nameOfWatersign = "";
        private PointB _watersignPos = PointB.Empty;
        private Point _printRectangle = new PointB(15, 15);

        public bool PrintTitlebar
        { get { return _printTitlebar; } set { _printTitlebar = value; } }

        public bool Watersign
        { get { return _printWatersign; } set { _printWatersign = value; } }

        public string WatersignPath
        { get { return _nameOfWatersign; } set { if (Watersign) _nameOfWatersign = value; } }

        public PointB WatersignPosition
        { get { return _watersignPos; } set { if (Watersign) _watersignPos = value; } }

        public Point PrintRectangle
        { get { return _printRectangle; } set { _printRectangle = value; } }

        public PrintableAttribute(bool printTitlebar, int width, int height)
        {
            _printTitlebar = printTitlebar;
            _printRectangle = new Point(width, height);
        }
    }

    [AttributeUsage(AttributeTargets.Constructor)]
    public class PrintableRestrictionAttribute : Attribute
    {
        private bool _runConstructor = false;

        public bool RunConstructor
        { get { return _runConstructor; } set { _runConstructor = value; } }

        public PrintableRestrictionAttribute(bool runConstructor)
        {

        }
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class PrintableAdditionAttribute : Attribute
    {
        public bool AddOnTop = false;

        public PrintableAdditionAttribute(bool addOnTop)
        {
            this.AddOnTop = addOnTop;
        }
    }
}
