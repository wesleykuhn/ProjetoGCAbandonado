using System;
using System.Drawing;
using System.Windows.Forms;

namespace GC.Components
{
    public partial class CMP_BtnAlter : Button
    {
        public CMP_BtnAlter()
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

            base.ForeColor = Library.Style.ColorsPalette.GDE_Primary;
            base.OnMouseLeave(e);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            if (this.Enabled)
            {
                base.FlatAppearance.BorderColor = Library.Style.ColorsPalette.GDE_Primary; 
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
                base.FlatAppearance.BorderColor = Library.Style.ColorsPalette.GDE_Primary;
            }
            else
            {
                base.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
            }
            base.InitLayout();
        }
    }
}
