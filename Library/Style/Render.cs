using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace GC.Library.Style
{
    internal class Render
    {
        internal static void RenderPaintEventArgs(ref PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            e.Graphics.InterpolationMode = InterpolationMode.High;
        }

        internal static void RenderDrawListViewColumnHeaderEventArgs(ref DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            e.Graphics.InterpolationMode = InterpolationMode.High;
        }
    }
}
