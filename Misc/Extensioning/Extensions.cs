using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc.Extensioning
{
    public static class Extensions
    {
        public static string ParseToString(this int child)
        {
            return Convert.ToString(child);
        }

        public static bool IsInRange(this int number, int min, int max)
        {
            if (number > min && number < max)
                return true;
            else
                return false;
        }

        public static Word ConvertToWord(string v)
        {
            return v;
        }
    }
}
