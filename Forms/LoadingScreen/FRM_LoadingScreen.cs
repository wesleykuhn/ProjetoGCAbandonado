using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GC.Forms.LoadingScreen
{
    public partial class FRM_LoadingScreen : Form
    {
        private Task task;

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public FRM_LoadingScreen(string initialStatusText)
        {
            InitializeComponent();

            lblStatus.Text = initialStatusText;
            lblStatus.Left = (this.Width - lblStatus.Width) / 2;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        internal new void Show()
        {
            this.task = new Task(() => ShowDialog());
            this.task.Start();
        }

        internal void CustomClose()
        {
            Library.Errors.Care.HandleInvokeMethod(this, new Action(() => Close()));
        }

        internal void ChangeStatusMessage(string text)
        {
            Library.Errors.Care.HandleInvokeMethod(this, new Action(() => {
                lblStatus.Text = text;
                lblStatus.Left = (this.Width - lblStatus.Width) / 2;
                }));
        }

        internal void IncrementStep(byte value)
        {            
            Library.Errors.Care.HandleInvokeMethod(this, new Action(() => CTL_LoadingCircle.Increment(value)));
        }

        private void FrmLoadingScreen_Shown(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
