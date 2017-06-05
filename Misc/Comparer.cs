using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    public class Comparer : IBeagleCompare
    {
        private bool isEqual = false;

        public Comparer(bool state)
        {
            isEqual = state;
        }

        public static bool operator true(Comparer a)
        {
            return a.isEqual;
        }

        public static bool operator false(Comparer a)
        {
            return a.isEqual;
        }

        public static bool operator !(Comparer a)
        {
            return a.isEqual;
        }
        //public static R operator ==(Comparer<R, P> a, bool b)
        //{
        //    if (a == null)
        //        return a.FALSEWORD;

        //    return (R)Convert.ChangeType((a.isEqual == b).ToString(), typeof(R));
        //}

        //public static R operator !=(Comparer<R, P> a, bool b)
        //{
        //    return (R)Convert.ChangeType((!(a.isEqual == b).ToString(), typeof(R));
        //}

        public override string ToString()
        {
            string result = "tope";
            if (isEqual)
                result = "TRUE";
            else
                result = "FALSE";

            return result;
        }

        public int CompareTo(object obj)
        {
            return 1;
        }

        public bool CompareSelf<T>(T objectToCompare, IBeagleCompare objectSelf)
        {
            try
            {
                if (Convert.ChangeType(objectToCompare, typeof(T)) == objectSelf)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (InvalidCastException r)
            {

                BeagleAPI.Window.Message.Messages m = new Window.Message.Messages("ACHTUNG",
                    "Vergleich wurde wegen untypischen Vergleichs nicht ausgeführt." +
                    Environment.NewLine
                     + r.Message);
                m.ShowDialog();
                return false;
            }

        }

        public bool Compare<T>(T objectToCompare)
        {
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static bool CheckEqual<T>(T val1, T val2)
        {
            Predicate<T> predicate = Chk_Intern;
            T[] t = new T[2];
            t[0] = val1;
            t[1] = val2;
            Array.Find(t, Chk_Intern);
            return false;
        }

        private static bool Chk_Intern<T>(T with)
        {
            return false;
        }
    }
}