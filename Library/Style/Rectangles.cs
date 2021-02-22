using System.Drawing.Drawing2D;
using System.Drawing;

namespace GC.Library.Style
{
    internal class Rectangles
    {
        private static GraphicsPath CreateRoundedRetangle(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            path.AddArc(arc, 180, 90);   

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            return path;
        }

        internal static void CreateHollowRoundedRectangle(Graphics graphics, Pen pen, Rectangle bounds, int cornerRadius)
        {
            bounds.Width -= 1;
            bounds.Height -= 1;
            bounds.X += 1;
            bounds.Y += 1;
            using (GraphicsPath path = CreateRoundedRetangle(bounds, cornerRadius))
            {
                graphics.DrawPath(pen, path);
            }
        }

        internal static void CreateSolidRoundedRectangle(Graphics graphics, Brush brush, Rectangle bounds, int cornerRadius)
        {
            using (GraphicsPath path = CreateRoundedRetangle(bounds, cornerRadius))
            {
                graphics.FillPath(brush, path);
            }
        }

        internal static void CreateNormalSolidRectangle(Graphics graphics, Brush brush, Rectangle bounds)
        {
            graphics.FillRectangle(brush, bounds);
        }
    }
}
