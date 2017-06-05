using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    public class Dixonary<TResult, TParam>
    {
        public Dixonary()
        {

        }

        /// <summary>
        /// Tries to convert a value of Type TParam to TResult.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Returns converted value of type TResult.</returns>
        public TResult ToType(TParam value)
        {
            object parsedValue = default(TParam);
            try
            {
                parsedValue = Convert.ChangeType(value, typeof(TResult));
            }
            catch (InvalidCastException)
            {
                parsedValue = null;
            }
            catch (ArgumentException)
            {
                parsedValue = null;
            }

            return (TResult)parsedValue;
        }
    }
}
