using System;

namespace GC.Library.Generators
{
    internal static class Code
    {
        /// <summary>
        /// Function to generate codes, with numbers and words.
        /// </summary>
        /// <param name="lenght">The lenght of the code. Enter an absolute number.</param>
        /// <returns>Returns the code.</returns>
        internal static string NumbersAndWords(int lenght)
        {
            string code = "";
            int aux;
            Random random = new Random();
            for(int i = 1;i <= lenght; i++)
            {
                aux = random.Next(0, 36);
                if (aux == 0) code += "A";
                else if (aux == 1) code += "B";
                else if (aux == 2) code += "C";
                else if (aux == 3) code += "D";
                else if (aux == 4) code += "E";
                else if (aux == 5) code += "F";
                else if (aux == 6) code += "G";
                else if (aux == 7) code += "H";
                else if (aux == 8) code += "I";
                else if (aux == 9) code += "J";
                else if (aux == 10) code += "K";
                else if (aux == 11) code += "L";
                else if (aux == 12) code += "M";
                else if (aux == 13) code += "N";
                else if (aux == 14) code += "O";
                else if (aux == 15) code += "P";
                else if (aux == 16) code += "Q";
                else if (aux == 17) code += "R";
                else if (aux == 18) code += "S";
                else if (aux == 19) code += "T";
                else if (aux == 20) code += "U";
                else if (aux == 21) code += "V";
                else if (aux == 22) code += "W";
                else if (aux == 23) code += "X";
                else if (aux == 24) code += "Y";
                else if (aux == 25) code += "Z";
                else if (aux == 26) code += "0";
                else if (aux == 27) code += "1";
                else if (aux == 28) code += "2";
                else if (aux == 29) code += "3";
                else if (aux == 30) code += "4";
                else if (aux == 31) code += "5";
                else if (aux == 32) code += "6";
                else if (aux == 33) code += "7";
                else if (aux == 34) code += "8";
                else if (aux == 35) code += "9";                          
            }
            return code;
        }
        /// <summary>
        /// A functions that return a code only with numbers.
        /// </summary>
        /// <param name="lenght">The lenght of the code. Enter an absolute number.</param>
        /// <returns>Returns a string with the code.</returns>
        internal static string Numbers(int lenght)
        {
            string code = "";
            int aux;
            Random random = new Random();
            for (int i = 1; i <= lenght; i++)
            {
                aux = random.Next(0, 10);
                if (aux == 0) code += "0";
                else if (aux == 1) code += "1";
                else if (aux == 2) code += "2";
                else if (aux == 3) code += "3";
                else if (aux == 4) code += "4";
                else if (aux == 5) code += "5";
                else if (aux == 6) code += "6";
                else if (aux == 7) code += "7";
                else if (aux == 8) code += "8";
                else if (aux == 9) code += "9";
            }
            return code;
        }
    }
}
