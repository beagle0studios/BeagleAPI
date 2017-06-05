using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class BeagleAttrAttribute : Attribute
    {
        public string Name { get; set; }
        public int Identifier { get; set; }
        public BeagleAttrAttribute(string name)
        {
            Name = name;
        }
    }
}