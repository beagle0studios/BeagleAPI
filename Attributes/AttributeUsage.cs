using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Attributes
{
    public class AttributeUsage
    {
        public void Initialize()
        {
            Type tDemo = typeof(DemoAttributing);
            Type tAttr = typeof(BeagleAttrAttribute);
            MethodInfo mInfo1 = tDemo.GetMethod("DoSomething");
            MethodInfo mInfo2 = tDemo.GetMethod("DoMore");
            // Prüfen, ob das Attribut bei der Klasse 'Demo' gesetzt ist
            BeagleAttrAttribute attr = (BeagleAttrAttribute)Attribute.GetCustomAttribute(tDemo, tAttr);

            if (attr != null)
            {
                Console.WriteLine("Name: {0}", attr.Name);
                Console.WriteLine("Identifier: {0}", attr.Identifier);
            }
            else
                Console.WriteLine("Attribut nicht gesetzt");

            // Prüfen, ob das Attribut bei der Methode 'DoSomething' gesetzt ist
            attr = (BeagleAttrAttribute)Attribute.GetCustomAttribute(mInfo1, tAttr);

            if (attr != null)
            {
                Console.WriteLine("Name: {0}", attr.Name);
                Console.WriteLine("Identifier: {0}", attr.Identifier);
            }

            // Prüfen, ob das Attribut bei der Methode 'DoMore' gesetzt ist
            bool isDefinied = Attribute.IsDefined(mInfo2, tAttr);

            if (isDefinied)
                Console.WriteLine("DoMore hat das Attribut.");
            else
                Console.WriteLine("DoMore hat das Attribut nicht.");
            Console.ReadLine();
        }

        //another method
        public static object[] TestForAttribute(Type typ, bool inherit)
        {
            object[] temp;
            MemberInfo info = typ;
            object[] attributes = info.GetCustomAttributes(inherit);

            temp = new object[attributes.Length];

            for (int i = 0; i < attributes.Length; i++)
            {
                temp[i] = attributes[i];
            }
            return temp;
        }
    }

    [BeagleAttr("Klasse")]
    sealed class DemoAttributing
    {
        [BeagleAttr("Methode DoSomething", Identifier = 0x4FA)]
        public void DoSomething() { }
        public void DoMore() { }
    }
}
