using System;
using System.Drawing;
using System.Windows.Forms;

namespace GC.Components
{
    public partial class CMP_BtnAdd : Button
    {
        public CMP_BtnAdd()
        {
            InitializeComponent();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.ForeColor = Color.White;            
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {

            base.ForeColor = Library.Style.ColorsPalette.GDE_Green;
            base.OnMouseLeave(e);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            if (this.Enabled)
            {
                base.FlatAppearance.BorderColor = Library.Style.ColorsPalette.GDE_Green;
            }
            else
            {
                base.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
            }

            base.OnEnabledChanged(e);
        }

        protected override void InitLayout()
        {
            if (this.Enabled)
            {
                base.FlatAppearance.BorderColor = Library.Style.ColorsPalette.GDE_Green;
            }
            else
            {
                base.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
            }
            base.InitLayout();
        }
    }
}
