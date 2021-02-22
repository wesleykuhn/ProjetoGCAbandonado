namespace GC.Library.Checkers
{
    internal static class Variables
    {
        internal static bool StringHasNumbersOnly(string txt)
        {
            foreach (char word in txt)
            {
                if (word != '0' && word != '1' && word != '2' && word != '3' && word != '4' && word != '5' && word != '6' && word != '7' && word != '8' && word != '9')
                {
                    return false;
                }
            }

            return true;
        }

        internal static bool IsValueDouble(double value)
        {
            if ((value % 1) == 0)
            {
                return false;
            }

            else return true;
        }
    }
}
