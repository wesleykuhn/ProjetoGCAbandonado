using System;

namespace GC.Library.Translators
{
    internal static class ObjectToDetailLabel
    {
        internal static string ToLabelMasculino(string str) //ToLabelMasculino
        {
            if (str == null || str == "") return "Não informado";
            else return str;
        }

        internal static string ToLabelFeminino(string str) //ToLabelFeminino
        {
            if (str == null || str == "") return "Não informada";
            else return str;
        }

        internal static string ToIntLabel(int integer)
        {
            if(integer == -1)
            {
                return "0";
            }
            else
            {
                return integer.ToString();
            }
        }

        internal static string ToMoneyLabel(double value)
        {
            if(value == -1)
            {
                return "R$ 0,00";
            }
            else
            {
                return "R$ " + value.ToString("n2");
            }
        }

        internal static string ToKilogramLabel(double weight)
        {
            if(weight == -1)
            {
                return "0.000 kg";
            }
            else
            {
                return weight.ToString("n3") + " kg";
            }
        }

        internal static string ToDateTimeLabel(DateTime dateTime)
        {
            DateTime nullDate = new DateTime(1, 1, 1, 0, 0, 0);

            if(dateTime.CompareTo(nullDate) == 0)
            {
                return "Não possui";
            }
            else
            {
                return dateTime.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }
    }
}
