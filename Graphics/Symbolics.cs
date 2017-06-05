using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Graphics
{
    public class Symbolics
    {
        public static string[] House(int distanceBegin, int maxLength)
        {
            string[] temp = new string[maxLength];

            for(int i = 0; i < maxLength; i++)
            {
                temp[i] = "/";
            }

            return temp;
        }
    }
}
