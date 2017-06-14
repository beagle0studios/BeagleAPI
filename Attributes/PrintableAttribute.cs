using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeagleAPI.Misc;

namespace BeagleAPI.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class PrintableAttribute : Attribute
    {
        private bool _printTitlebar = true;
        private bool _printWatersign = true;
        private string _nameOfWatersign = "";
        private PointB _watersignPos = PointB.Empty;

        public bool PrintTitlebar
        { get { return _printTitlebar; } set { _printTitlebar = value; } }

        public bool Watersign
        { get { return _printWatersign; } set { _printWatersign = value; } }

        public string WatersignPath
        { get { return _nameOfWatersign; } set { if (Watersign) _nameOfWatersign = value; } }

        public PointB WatersignPosition
        { get { return _watersignPos; } set { if (Watersign) _watersignPos = value; } }
    }
}
