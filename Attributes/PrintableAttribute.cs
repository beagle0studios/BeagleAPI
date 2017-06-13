using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class PrintableAttribute : Attribute
    {
        private bool _printTitlebar = true;

        public bool PrintTitlebar
        { get { return _printTitlebar; } set { _printTitlebar = value; } }
    }
}
