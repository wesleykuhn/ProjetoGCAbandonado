using GC.Library.Errors;
using System.Drawing;
using System.Windows.Forms;

namespace GC.Components
{
    public partial class CMP_CtlLoadingCircle : UserControl
    {
        private readonly Image frontImage;
        private Image completedImage = null;
        private readonly Color loadingCircleColor;
        private bool locked = false;

        internal byte LoadedCounter = 0;

        public CMP_CtlLoadingCircle()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            if (!Care.AntiInvalidInstance) throw new System.Exception("Não deixa esse componente nesse contrutor! Mude para algum dos outros dois. Isso foi por causa da falta de suporte do designer forms.");
        }

        public CMP_CtlLoadingCircle(Image frontImage, Color loadingCircleColor)
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            this.frontImage = frontImage;
            this.loadingCircleColor = loadingCircleColor;
        }

        public CMP_CtlLoadingCircle(Image frontImage, Color loadingCircleColor, Image completedImage)
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            this.frontImage = frontImage;
            this.loadingCircleColor = loadingCircleColor;
            this.completedImage = completedImage;
        }

        /// <summary>
        /// Increments the loading circle. Limit of 100!
        /// </summary>
        /// <param name="amount">Amount to increment, the limit is 100.</param>
        internal void Increment(byte amount)
        {
            if (amount > 100 || this.LoadedCounter + amount > 100) return;

            this.LoadedCounter += amount;

            this.Refresh();
        }

        private void CMP_CtlLoadingCircle_Paint(object sender, PaintEventArgs e)
        {
            if (this.locked) return;

            Library.Style.Render.RenderPaintEventArgs(ref e);

            if (this.LoadedCounter == 0)
            {
                Rectangle insideRec = new Rectangle(10, 10, 128, 128);
                e.Graphics.DrawImage(this.frontImage, insideRec);

                return;
            }          

            if(this.completedImage != null && this.LoadedCounter >= 100)
            {
                this.locked = true;

                e.Graphics.Dispose();

                Rectangle insideRec = new Rectangle(10, 10, 128, 128);
                e.Graphics.DrawImage(this.completedImage, insideRec);
            }
            else
            {
                // [100% represents 360°]    100 - 360 / 10 - X
                int amount = 360 * this.LoadedCounter / 100;

                Rectangle outsideRec = new Rectangle(4, 4, 138, 138);
                e.Graphics.FillPie(new SolidBrush(this.loadingCircleColor), outsideRec, 270, amount);

                Rectangle insideRec = new Rectangle(10, 10, 128, 128);
                e.Graphics.DrawImage(this.frontImage, insideRec);
            }            
        }
    }
}
