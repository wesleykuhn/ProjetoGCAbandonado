using System;
using System.Drawing;
using System.Windows.Forms;

namespace GC.Components
{
    public partial class CMP_BtnTopMinimize : Panel
    {
        public CMP_BtnTopMinimize()
        {
            InitializeComponent();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            this.BackColor = Color.FromArgb(55, 55, 55);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackColor = Library.Style.ColorsPalette.GDE_Dark;
        }        
    }
}
