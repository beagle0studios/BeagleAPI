
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    public class Initialization<T>
    {
        private string KEY;
        private Comparer deny = new Comparer(true);
        private object SENDER;
        /// <summary>
        /// Init class with specified key.
        /// </summary>
        /// <param name="_Key"> Key to identify Initialization class.</param>
        public Initialization(string _Key, object _sender)
        {
            KEY = _Key;
            deny = new Comparer(true);
            SENDER = _sender;
        }

        public T ReleaseObject()
        {
            object value = typeof(T);
            return (T)Convert.ChangeType(value, typeof(T));
        }

        /// <summary>
        /// Gets current InitKey.
        /// </summary>
        /// <param name="_holder">Reference to string where key will be copied to</param>
        /// <returns>Returns true if access was allowed; otherwise it returns false.</returns>
        public Comparer GetKey(ref string _holder, object _sender)
        {
            if (_sender == SENDER)
                deny = new Comparer(false);

            if (!deny)
                _holder = KEY;
            else
                _holder = "access denied.";
            return deny;
        }
    }
}
