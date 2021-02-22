using System;
using System.Drawing;
using System.Windows.Forms;

namespace GC.Components
{
    public partial class CMP_ColorBox : UserControl
    {
        internal Color Color;
        internal byte Red, Green, Blue;

        public CMP_ColorBox()
        {
            InitializeComponent();
        }

        public CMP_ColorBox(Color color)
        {
            InitializeComponent();

            this.BackColor = color;

            this.Color = color;

            this.Red = color.R;
            this.Green = color.G;
            this.Blue = color.B;
        }

        public CMP_ColorBox(byte red, byte green, byte blue)
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(red, green, blue);

            this.Color = Color.FromArgb(red, green, blue);

            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }

        internal void SetColorBox(Color color)
        {
            this.BackColor = color;

            this.Color = color;

            this.Red = color.R;
            this.Green = color.G;
            this.Blue = color.B;
        }

        internal void SetColorBox(byte red, byte green, byte blue)
        {
            this.BackColor = Color.FromArgb(red, green, blue);

            this.Color = Color.FromArgb(red, green, blue);

            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }

        private void pnlColor_Click(object sender, EventArgs e)
        {
            this.OnClick(new EventArgs());
        }
    }
}
