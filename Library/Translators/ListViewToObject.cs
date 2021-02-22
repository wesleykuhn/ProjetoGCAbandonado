using System;

namespace GC.Library.Translators
{
    internal static class ListViewToObject
    {
        /// <summary>
        /// Converts a list view's string to double, if the string is empty, then it will return -1, refering to a null value.
        /// </summary>
        /// <param name="value">The string to be converted.</param>
        /// <returns>-1 if is a empty string or the normal value in double type.</returns>
        internal static double ToDouble(string value)
        {
            if (value == "") return -1;
            else return Double.Parse(value);
        }

        /// <summary>
        /// Converts a list view's string to int, if the string is empty, then it will return -1, refering to a null value.
        /// </summary>
        /// <param name="value">The string to be converted.</param>
        /// <returns>-1 if is a empty string or the normal value in int type.</returns>
        internal static int ToInt(string value)
        {
            if (value == "") return -1;
            else return Int32.Parse(value);
        }

        /// <summary>
        /// Converts a list view's string to variable string, if the string is empty, then it will return null.
        /// </summary>
        /// <param name="str">The string to be converted.</param>
        /// <returns>null if is a empty string or the normal string.</returns>
        internal static string ToString(string str)
        {
            if (str == "") return null;
            else return str;
        }
    }
}
