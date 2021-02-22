using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GC.Forms.Bases
{
    public partial class FRM_Full : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private const int cGrip = 16;
        private const int cCaption = 32;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //Resize var
        private bool Maximized = false;

        public FRM_Full()
        {
            InitializeComponent();

            //Form resize
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        //Resize
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(0, 22, 22, 22));

            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(brush, rc);
        }

        //Move
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void LblFormTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FRM_Full_Load(object sender, EventArgs e)
        {
            //Don't maximize and get the taskbar also!
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void FRM_Full_Resize(object sender, EventArgs e)
        {
            if (this.Bounds.Width < Screen.FromHandle(this.Handle).WorkingArea.Width || this.Bounds.Height < Screen.FromHandle(this.Handle).WorkingArea.Height)
            {
                this.pnl_btnResize.SwitchToMaximize();
                this.Maximized = false;
            }
            else
            {
                this.pnl_btnResize.SwitchToResize();
                this.Maximized = true;
            }
        }

        public void ReadyForm()
        {
            this.lblFormTitle.Text = this.Text;

            this.pnl_btnClose.Left = this.Width - 50;
            this.pnl_btnMinimize.Left = this.Width - 150;
            this.pnl_btnResize.Left = this.Width - 100;

            //Adjust the color of top buttons
            pnl_btnClose.BackColor = this.BackColor;
            pnl_btnMinimize.BackColor = this.BackColor;
            pnl_btnResize.BackColor = this.BackColor;
        }

        internal void ReplaceCloseEvent(EventHandler e)
        {
            pnl_btnClose.Click -= Pnl_btnClose_Click;

            pnl_btnClose.Click += e;
        }

        public void SwitchCloseToTurnoffIcon()
        {
            pnl_btnClose.SwitchToTurnoffIcon();
        }

        /// <summary>
        /// Desabilita o botão de fechar do formulário.
        /// </summary>
        public void UnableClose()
        {
            this.pnl_btnClose.Click -= Pnl_btnClose_Click;
            this.pnl_btnClose.Enabled = false;
            this.pnl_btnClose.Hide();

            if (this.pnl_btnResize.Enabled)
            {
                this.pnl_btnResize.Left += 50;
            }

            if (this.pnl_btnMinimize.Enabled)
            {
                this.pnl_btnMinimize.Left += 50;
            }
        }

        /// <summary>
        /// Desabilita o botão de Redimencionamento do formulário.
        /// </summary>
        public void UnableResize()
        {
            this.pnl_btnResize.Click -= Pnl_btnResize_Click;
            this.pnl_btnResize.Enabled = false;
            this.pnl_btnResize.Hide();

            if (this.pnl_btnMinimize.Enabled)
            {
                this.pnl_btnMinimize.Left += 50;
            }
        }

        /// <summary>
        /// Desabilita o botão de minimizar do formulário.
        /// </summary>
        public void UnableMinimize()
        {
            this.pnl_btnMinimize.Click -= Pnl_btnMinimize_Click;
            this.pnl_btnMinimize.Enabled = false;
            this.pnl_btnMinimize.Hide();
        }

        private void Pnl_btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Pnl_btnResize_Click(object sender, EventArgs e)
        {
            this.Maximized = !this.Maximized;

            if (!this.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Pnl_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
