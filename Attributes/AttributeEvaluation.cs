using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BeagleAPI.Window.Message;
using System.Windows.Forms;

namespace BeagleAPI.Attributes
{
    public sealed class AttributeEvaluation
    {
        public static void Initialize<TAttr>(Type UClass, params string[] methodNames) where TAttr : Attribute
        {
            Type tDemo = UClass;
            Type tAttr = typeof(TAttr);
            List<MethodInfo> mInfos = new List<MethodInfo>();

            foreach (string mName in methodNames)
            {
                MethodInfo mInfo = tDemo.GetMethod(mName);
                mInfos.Add(mInfo);
            }
            // Prüfen, ob das Attribut bei der Klasse 'UClass' gesetzt ist
            TAttr attr = (TAttr)Attribute.GetCustomAttribute(tDemo, tAttr);
            if (attr != null)
            {
                //Attribut gesetzt.
            }
            else
            {
                Messages m = new Messages("Achtung!", 
                    "Die Klasse '" + tDemo.ToString() + " hat das angegebene Attribut nicht gesetzt.", true);
            }

            //// Prüfen, ob das Attribut bei der Methode 'DoSomething' gesetzt ist
            //attr = (BeagleAttrAttribute)Attribute.GetCustomAttribute(mInfo1, tAttr);

            //if (attr != null)
            //{
            //    Console.WriteLine("Name: {0}", attr.Name);
            //    Console.WriteLine("Identifier: {0}", attr.Identifier);
            //}

            //// Prüfen, ob das Attribut bei der Methode 'DoMore' gesetzt ist
            //bool isDefinied = Attribute.IsDefined(mInfo2, tAttr);

            //if (isDefinied)
            //    Console.WriteLine("DoMore hat das Attribut.");
            //else
            //    Console.WriteLine("DoMore hat das Attribut nicht.");
            //Console.ReadLine();
        }
    }
}
