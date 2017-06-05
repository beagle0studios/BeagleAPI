using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    public class SearchFor<TResult>
    {
        public static TResult Search<T, TSearch>(T atValue) where T : BeagleAPI.Window.StdW.StdWin
        {
            object parsedValue = default(T);
            try
            {
                parsedValue = Convert.ChangeType(atValue, typeof(TResult));
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
