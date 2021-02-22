using System;

namespace GC.Library.Translators
{
    internal static class ObjectToListView
    {
        /// <summary>
        /// If the parameter equals to -1 this method will return a blank string, else it will return the number to string. Usefull in ListViews.
        /// </summary>
        /// <param name="i">The int value to be comparated.</param>
        /// <returns>A blank string or an int to string.</returns>
        static internal string ToIntListView(int i)
        {
            if (i == -1) return "";
            else return i.ToString();
        }
        /// <summary>
        /// If the parameter equals to -1 this method will return a blank string, else it will return the number to string. Usefull in ListViews.
        /// </summary>
        /// <param name="d">The double value to be comparated.</param>
        /// <returns>A blank string or a double to string.</returns>
        static internal string ToDoubleListView(double d)
        {
            if (d == -1 || d == 0) return "";
            else return d.ToString();
        }
        /// <summary>
        /// If the parameter equals to -1 this method will return a blank string, else it will return the number to string. Usefull in ListViews.
        /// </summary>
        /// <param name="d">The double value to be comparated.</param>
        /// <returns>A blank string or a double to string with two decimals places.</returns>
        static internal string ToDoubleListView_TwoDecimals(double d)
        {
            if (d == -1 || d == 0) return "";
            else return d.ToString("n2");
        }
        /// <summary>
        /// If the parameter equals to -1 this method will return a blank string, else it will return the number to string. Usefull in ListViews.
        /// </summary>
        /// <param name="d">The double value to be comparated.</param>
        /// <returns>A blank string or a double to string with three decimals places.</returns>
        static internal string ToDoubleListView_ThreeDecimals(double d)
        {
            if (d == -1) return "";
            else return d.ToString("n3");
        }
        /// <summary>
        /// If the parameter equals to -1 this method will return a blank string, else it will check if the number is a double it will return a number with decimals to string, if it isn't then return a number without decimals to string. Usefull in ListViews.
        /// </summary>
        /// <param name="d">The double value to be checked.</param>
        /// <returns>A blank string, a double to string with three decimals places or an interger without decimal places.</returns>
        static internal string ToDoubleListView_ThreeOrZeroDecimals(double d)
        {
            if (d == -1)
            {
                return "";
            }
            else if ((d % 1) == 0)
            {
                return Convert.ToInt32(d).ToString();
            }
            else return d.ToString("n3");        
        }
        /// <summary>
        /// If the parameter equals to null this method will return a blank string, else returns the string withoud changed. Usefull in ListViews.
        /// </summary>
        /// <param name="s">The string to be comparated.</param>
        /// <returns>A blank string or the original string.</returns>
        static internal string ToStringListView(string s)
        {
            if (s == null) return "";
            else return s;
        }
        /// <summary>
        /// If the parameter equals to 1-1-1 00:00:00 this method will return a blank string, else returns the a datetime to string. Usefull in ListViews.
        /// </summary>
        /// <param name="date">The DateTime to be compareted.</param>
        /// <returns>A blank string or a datetime to string.</returns>
        static internal string ToDateTimeListView(DateTime date)
        {
            DateTime nullDate = new DateTime(1, 1, 1, 0, 0, 0);
            if (DateTime.Compare(date, nullDate) == 0) return "";
            else return date.ToString("dd/MM/yyyy HH:mm:ss");
        }

        static internal string ToDateListView(DateTime date)
        {
            return date.ToString("dd/MM/yyy");
        }
    }
}
