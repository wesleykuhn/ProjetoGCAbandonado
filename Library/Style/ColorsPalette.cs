using System.Drawing;

namespace GC.Library.Style
{
    internal static class ColorsPalette
    {
        internal static readonly Color GDE_Warning = Color.FromArgb(255, 193, 7); //Error/Problem
        internal static readonly Color GDE_Danger = Color.FromArgb(220, 53, 69); //Warning
        internal static readonly Color GDE_Primary = Color.FromArgb(0, 123, 255); //Alteration
        internal static readonly Color GDE_Green = Color.FromArgb(65, 184, 131); //New  
        internal static readonly Color GDE_Info = Color.FromArgb(46, 142, 152); //Information
        internal static readonly Color GDE_Dark = Color.FromArgb(33, 33, 33); //Default
        internal static readonly Color GDE_PurpleBlue = Color.FromArgb(23, 70, 220);

        //Mouse hover colors
        internal static readonly Color GDE_Warning_Hover = Color.FromArgb(235, 173, 0); //Error/Problem
        internal static readonly Color GDE_Danger_Hover = Color.FromArgb(200, 33, 49); //Warning
        internal static readonly Color GDE_Info_Hover = Color.FromArgb(26, 122, 132); //Information
        internal static readonly Color GDE_Dark_Hover = Color.FromArgb(13, 13, 13); //Default

        //Methods
        internal static bool Compare(Color c1, Color c2)
        {
            if (c1.R == c2.R && c1.G == c2.G && c1.B == c2.B) return true;
            else return false;
        }
    }
}
