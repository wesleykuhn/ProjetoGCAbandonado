using System;

namespace GC.Library.Translators
{
    internal static class SqlToObject
    {
        internal static string ToString(string reader)
        {
            if (reader == "" || reader == null) return null;
            else return reader;
        }

        internal static double ToDouble(string reader)
        {
            double aux_double;

            bool result = Double.TryParse(reader, out aux_double);
            if (!result)
            {
                return -1;
            }
            else
            {
                return aux_double;
            }
        }

        internal static int ToInt(string reader)
        {
            int aux_int;
            bool result = Int32.TryParse(reader, out aux_int);
            if (!result)
            {
                return -1;
            }
            else
            {
                return aux_int;
            }
        }

        internal static DateTime ToDateTime(string reader)
        {
            DateTime aux_dt;
            bool result = DateTime.TryParse(reader, out aux_dt);
            if (result)
            {
                return aux_dt;
            }
            else
            {
                return new DateTime(1, 1, 1, 0, 0, 0);
            }
        }

        internal static DateTime ToDate(string reader)
        {
            return Convert.ToDateTime(reader);
        }

        internal static bool ToBool(string reader)
        {
            bool aux_bool;
            bool result = Boolean.TryParse(reader, out aux_bool);
            if (!result)
            {
                return false;
            }
            else
            {
                return aux_bool;
            }
        }

        internal static char ToChar(string reader)
        {
            return Char.Parse(reader);
        }

        internal static byte ToByte(string reader)
        {
            return Byte.Parse(reader);
        }
    }
}
