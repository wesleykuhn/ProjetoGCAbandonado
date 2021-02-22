using System.Reflection;
using System.Runtime.InteropServices;

namespace GC.Library.Collectors
{
    internal static class AppGuid
    {
        internal static string Get()
        {
            Assembly assembly = typeof(Program).Assembly;
            GuidAttribute attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
            string id = attribute.Value;

            return id;
        }
    }
}
