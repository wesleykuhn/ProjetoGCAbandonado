using System;
using System.Drawing;
using System.Windows.Forms;

namespace GC.Components
{
    public partial class CMP_BtnTopResize : Panel
    {
        public CMP_BtnTopResize()
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

        internal void SwitchToResize()
        {
            this.BackgroundImage = global::GC.Properties.Resources.icon_redimensionar_18x18;
        }

        internal void SwitchToMaximize()
        {
            this.BackgroundImage = global::GC.Properties.Resources.icon_maximizar_18x18;
        }
    }
}
