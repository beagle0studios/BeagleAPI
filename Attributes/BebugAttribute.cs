using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Attributes
{
    public enum BebugType
    {
        Hint,
        Warning,
        Error,
        Critical
    }

    [AttributeUsage(AttributeTargets.All)]
    public class BebugAttribute : Attribute
    {
        public string DebugText
        { get; set; }

        public BebugType DebugType
        { get; set; }

        public BebugAttribute(string textDebug, BebugType type)
        {
            DebugText = textDebug;
            DebugType = type;
        }
    }

    public sealed class BebugInfo
    {
        public BebugType debugType { get; set; }
        public string debugText { get; set; }
        public string debugMethod { get; set; }
        public ParameterInfo[] parameterInfo { get; set; }

        public BebugInfo(string dbgText, BebugType dbgType, string debugMethodName, ParameterInfo[] paramInfo)
        {
            debugText = dbgText;
            debugType = dbgType;
            debugMethod = debugMethodName;
            parameterInfo = paramInfo;
        }
    }
}
