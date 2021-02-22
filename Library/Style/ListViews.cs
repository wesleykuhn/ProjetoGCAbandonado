using System.Drawing;
using System.Windows.Forms;

namespace GC.Library.Style
{
    internal class ListViews
    {
        internal static Color ListViewItemTint(ref ListViewItem lvi)
        {
            if (lvi.Index % 2 == 0)
            {
                return SystemColors.Window;
            }
            else return Color.FromArgb(210, 210, 210);
        }
    }
}
