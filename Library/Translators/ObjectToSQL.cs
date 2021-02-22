using System;

namespace GC.Library.Translators
{
    internal static class ObjectToSQL
    {
        internal static string ToDecimalSql_TwoDecimals(double value)
        {
            if (value == -1) return null;
            else return value.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
        }

        internal static string ToDecimalSql_ThreeDecimals(double value)
        {
            if (value == -1) return null;
            else return value.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture);
        }

        internal static string ToIntSql(int value)
        {
            if (value == -1) return null;
            else return value.ToString();
        }

        internal static string ToTinyIntSql(int value)
        {
            if (value == -1) return null;
            else return value.ToString();
        }

        internal static string ToDateTimeSql(DateTime dateTime)
        {
            DateTime nullDateTime = new DateTime(1, 1, 1, 0, 0, 0);
            if(DateTime.Compare(dateTime, nullDateTime) == 0)
            {
                return null;
            }
            else
            {
                return dateTime.ToString("yyyy/MM/dd HH:mm:ss");
            }
        }

        internal static string ToDateSql(DateTime date)
        {
            return date.ToString("yyyy/MM/dd");
        }

        internal static string ToBoolSql(bool boolean)
        {
            return Convert.ToInt32(boolean).ToString();
        }
    }
}
