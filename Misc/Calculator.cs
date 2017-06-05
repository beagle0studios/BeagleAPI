using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    public enum CalculatorType
    {
        Add,
        Substract,
        Multiply,
        Divide
    }

    public class Calculator<T>
    {
        public delegate T CalculateHandler(T val1);
        public delegate T CalculateHandler_2(T val1, T val2);

        public CalculateHandler calcHandler;
        public CalculateHandler_2 calcHandler_2;

        public Calculator()
        {

        }
        public Calculator(CalculateHandler method)
        {
            calcHandler = method;
        }

        public T Run(T val1)
        {
            return (T)Convert.ChangeType(calcHandler(val1), typeof(T));
        }

        public T Run(T val1, T val2)
        {
            return (T)Convert.ChangeType(calcHandler_2(val1, val2), typeof(T));
        }
    }
}
