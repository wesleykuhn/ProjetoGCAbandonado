using System;
using System.Drawing;
using System.Windows.Forms;

namespace GC.Components
{
    public partial class CMP_BtnRegularWhite : Button
    {
        public CMP_BtnRegularWhite()
        {
            InitializeComponent();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.ForeColor = Color.Black;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {

            base.ForeColor = Color.FromArgb(217, 217, 217);
            base.OnMouseLeave(e);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            if (this.Enabled)
            {
                base.FlatAppearance.BorderColor = Color.FromArgb(217, 217, 217);
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
                base.FlatAppearance.BorderColor = Color.FromArgb(217, 217, 217);
            }
            else
            {
                base.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
            }
            base.InitLayout();
        }
    }
}
