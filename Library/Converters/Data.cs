using System;

namespace GC.Library.Converters
{
    internal static class Data
    {
        internal static int BytesToMegabytes(ulong bits)
        {
            decimal result = bits / 1024;

            result = result / 1024;

            return Convert.ToInt32(result);
        }
    }
}
