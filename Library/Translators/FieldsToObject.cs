namespace GC.Library.Translators
{
    internal static class FieldsToObject
    {
        /// <summary>
        /// If the parameter equals to 0 absolute (Because of the insertered value in the NumericUpDown) then this method will return a -1 value, else it will return the parameter.
        /// </summary>
        /// <param name="i">The int value to be comparated.</param>
        /// <returns>A -1 value or the original value entered.</returns>
        static internal int ToInt(int i)
        {
            if (i == 0) return -1;
            else return i;
        }
        /// <summary>
        /// If the parameter equals to 0 absolute (Because of the insertered value in the NumericUpDown) then this method will return a -1 value, else it will return the parameter.
        /// </summary>
        /// <param name="d">The double value to be comparated.</param>
        /// <returns>A -1 value or the original value entered.</returns>
        static internal double ToDouble(double d)
        {
            if (d == 0) return -1;
            else return d;
        }
        /// <summary>
        /// If the parameter is a blank string (Because of the insertered value in the TextBox) then this method will return null, else it will return the parameter.
        /// </summary>
        /// <param name="s">The string to be comparated.</param>
        /// <returns>A blank string or the original value entered.</returns>
        static internal string ToString(string s)
        {
            string aux = s.TrimStart();
            aux = aux.TrimEnd();
            if (aux == "") return null;
            else return s;
        }
    }
}
