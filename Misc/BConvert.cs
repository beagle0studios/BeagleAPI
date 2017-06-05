using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    /// <summary>
    /// Class for converting types.
    /// </summary>
    /// <typeparam name="TResult">Return type of all methods that are called.</typeparam>
    public class BConvert<TResult>
    {
        /// <summary>
        /// Converts type T to a type of TResult.
        /// </summary>
        /// <typeparam name="T">Type that is to be converted to TResult.</typeparam>
        /// <param name="arg">Parameter to convert.</param>
        /// <returns>Returns converted T of type TResult.</returns>
        public static TResult ToType<T>(T arg)
        {
            object parsedValue = default(T);
            try
            {
                parsedValue = Convert.ChangeType(arg, typeof(TResult));
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
