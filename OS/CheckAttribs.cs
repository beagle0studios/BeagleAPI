using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeagleAPI.Attributes;
using System.Reflection;
using System.Windows.Forms;

namespace BeagleAPI.OS
{
    public sealed class CheckAttribs
    {
        public static List<BebugInfo> DebugApplication<TClass>()
        {
            List<BebugInfo> tmp = new List<BebugInfo>();

            Type f2 = typeof(TClass);
            foreach (MethodInfo mInf in f2.GetMethods())
            {
                foreach (Attribute a in mInf.GetCustomAttributes(false))
                {
                    BebugAttribute debugAtt = a as BebugAttribute;

                    if (debugAtt != null)
                    {
                        //MessageBox.Show(debugAtt.DebugText, debugAtt.DebugType.ToString());
                        tmp.Add(new BebugInfo(debugAtt.DebugText, debugAtt.DebugType, mInf.Name, mInf.GetParameters()));
                    }
                }
            }
            return tmp;
        }

        public static void TestAttributes<TClass>()
        {
            //first, get all attributes
            object[] allAttributes = AttributeUsage.TestForAttribute(typeof(TClass), false);

            //detecting if Form2 is printable by checking for PrintableAttribute
            foreach (object item in allAttributes)
            {
                PrintableAttribute bba = item as PrintableAttribute;
                if (bba != null)
                {
                    MessageBox.Show("Window is printable. Print Titlebar? " + bba.PrintTitlebar.ToString());
                    MessageBox.Show("Print only these values: W: " + bba.PrintRectangle.ToString());
                }

                StdWinComposerAttribute composer = item as StdWinComposerAttribute;
                if (composer != null)
                {
                    MessageBox.Show("Window title: " + composer.Name);
                }
            }

            //now, detect if constructor should be run before printing.
            Type f2 = typeof(TClass);
            foreach (ConstructorInfo cInf in f2.GetConstructors())
            {
                foreach (Attribute a in cInf.GetCustomAttributes(false))
                {
                    PrintableRestrictionAttribute printRes = (PrintableRestrictionAttribute)a;

                    if (printRes != null)
                    {
                        MessageBox.Show("Run constructor" + (printRes.RunConstructor ? "!" : " NOT!"));
                    }
                }
            }

            //now check for PrintAdditions method if something is to be printed additionally
            MethodInfo printAddInf;
            foreach (MethodInfo mInf in f2.GetMethods())
            {
                if (mInf.Name == "PrintAdditions")
                {
                    printAddInf = mInf;
                    MessageBox.Show("Method found, running method...");
                    mInf.Invoke(null, null);

                    foreach (Attribute a in printAddInf.GetCustomAttributes(false))
                    {
                        PrintableAdditionAttribute printAdd = (PrintableAdditionAttribute)a;

                        if (printAdd != null)
                        {
                            MessageBox.Show("Print additions on top: " + printAdd.AddOnTop.ToString());
                        }
                    }
                }
            }

            //now, check for the debug information
            foreach (MethodInfo mInf in f2.GetMethods())
            {
                foreach (Attribute a in mInf.GetCustomAttributes(false))
                {
                    BebugAttribute debugAtt = a as BebugAttribute;

                    if (debugAtt != null)
                    {
                        MessageBox.Show(debugAtt.DebugText, debugAtt.DebugType.ToString());
                    }
                }
            }
        }
    }
}
