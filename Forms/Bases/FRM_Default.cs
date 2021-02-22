using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GC.Forms.Bases
{
    public partial class FRM_Default : Form
    {
        //Form Movement
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public FRM_Default()
        {
            InitializeComponent();
        }

        internal void ReadyForm()
        {
            this.lblFormTitle.Text = this.Text;

            //Adjust the top buttons
            pnl_btnClose.Left = this.Width - 50;
            pnl_btnMinimize.Left = this.Width - 100;

            //Adjust the color of top buttons
            pnl_btnClose.BackColor = this.BackColor;
            pnl_btnMinimize.BackColor = this.BackColor;
        }

        internal void HideTitle()
        {
            this.lblFormTitle.Hide();
        }

        internal void UnableClose()
        {
            pnl_btnClose.Click -= Pnl_btnClose_Click;
            pnl_btnClose.Enabled = false;
            pnl_btnClose.Hide();

            pnl_btnMinimize.Left += 50;
        }

        internal void UnableMinimize()
        {
            pnl_btnMinimize.Click -= Pnl_btnMinimize_Click;
            pnl_btnMinimize.Enabled = false;
            pnl_btnMinimize.Hide();
        }

        internal void ReplaceCloseByHide()
        {
            pnl_btnClose.Click -= Pnl_btnClose_Click;

            pnl_btnClose.Click += HideForm;
        }

        internal void ReplaceCloseEvent(EventHandler e)
        {
            pnl_btnClose.Click -= Pnl_btnClose_Click;

            pnl_btnClose.Click += e;
        }

        //Form Movement
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        //Form Movement
        private void LblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }        

        private void Pnl_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HideForm(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Pnl_btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        internal void EnableLabelTrainAnimation()
        {
            this.lblFormTitle.Hide();

            Task task = new Task(new Action(() =>
            {
                //Back panel
                Panel titlePanel = new Panel();
                titlePanel.Name = "titlePanel";
                titlePanel.Height = 16;
                titlePanel.Width = this.Width - 74;
                titlePanel.Left = 12;
                titlePanel.Top = 9;
                titlePanel.AutoScroll = false;

                //Title label
                Label title = new Label();
                title.Name = "lblTitle";
                title.AutoSize = true;
                title.Text = this.Text;
                title.Font = Library.Style.Labels.FormTitle;
                title.ForeColor = SystemColors.Control;
                title.Left = 0;
                title.Top = 0;

                //Combination
                titlePanel.Controls.Add(title);
                int titleIndex = titlePanel.Controls.GetChildIndex(title);
                int panelIndex;

                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => {
                        this.Controls.Add(titlePanel);
                    }));
                }
                else
                {
                    try
                    {
                        this.Controls.Add(titlePanel);
                    }
                    catch (InvalidOperationException)
                    {
                        this.Invoke(new Action(() => {
                            this.Controls.Add(titlePanel);
                        }));
                    }
                }

                panelIndex = this.Controls.GetChildIndex(titlePanel);

                int length = title.Width - titlePanel.Width;
                int initialLeft = title.Left;
                int newLeft;

                System.Threading.Tasks.Task task2;

                //The animation
                while (true)
                {
                    for (int i = 0; i < length; i++)
                    {
                        task2 = Task.Delay(75);
                        task2.Wait();

                        if (this.Controls[panelIndex].Controls[titleIndex].InvokeRequired)
                        {
                            newLeft = this.Controls[panelIndex].Controls[titleIndex].Left - 1;
                            this.Controls[panelIndex].Controls[titleIndex].Invoke(new Action(() => this.Controls[panelIndex].Controls[titleIndex].Left = newLeft));
                        }
                        else
                        {
                            newLeft = this.Controls[panelIndex].Controls[titleIndex].Left - 1;
                            this.Controls[panelIndex].Controls[titleIndex].Left = newLeft;
                        }
                    }

                    //The reset
                    task2 = Task.Delay(2000);
                    task2.Wait();

                    if (this.Controls[panelIndex].Controls[titleIndex].InvokeRequired)
                    {
                        this.Controls[panelIndex].Controls[titleIndex].Invoke(new Action(() => this.Controls[panelIndex].Controls[titleIndex].Left = initialLeft));
                    }
                    else
                    {
                        try
                        {
                            this.Controls[panelIndex].Controls[titleIndex].Left = initialLeft;
                        }
                        catch (InvalidOperationException)
                        {
                            this.Controls[panelIndex].Controls[titleIndex].Invoke(new Action(() => this.Controls[panelIndex].Controls[titleIndex].Left = initialLeft));
                        }
                    }
                }
            }));

            task.Start();
        }
    }
}
