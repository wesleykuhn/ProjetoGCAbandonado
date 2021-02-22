using System.Windows.Forms;

namespace GC.Components
{
    public partial class CMP_CtlPanel : Control
    {
        public CMP_CtlPanel()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
        }
        /*
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020;
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Leave blank
        }
        */
    }
}
