using System;
using System.Drawing;
using System.Windows.Forms;

namespace GC.Components
{
    public partial class CMP_BtnTopClose : Panel
    {
        public CMP_BtnTopClose()
        {
            InitializeComponent();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            this.BackColor = Color.FromArgb(55, 33, 33);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackColor = Library.Style.ColorsPalette.GDE_Dark;
        }

        internal void SwitchToTurnoffIcon()
        {
            this.BackgroundImage = global::GC.Properties.Resources.icon_desligar_20x20;
        }
    }
}
