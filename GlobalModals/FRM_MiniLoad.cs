using System;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using GC.Library.Errors;
using System.Windows.Forms;

namespace GC.GlobalModals
{
    public partial class FRM_MiniLoad : Forms.Bases.FRM_Default
    {
        private Task Task;

        // 270 here means 0 on clock, and 360 means 3 on clock, this var will control that
        private short pointer = 270;
        // <------------------------------------------------------------

        public FRM_MiniLoad()
        {
            InitializeComponent();

            this.ReadyForm();

            this.UnableClose();
            this.UnableMinimize();
            this.HideTitle();
        }

        internal new void Show()
        {
            this.Task = new Task(() => ShowDialog());
            this.Task.Start();
        }

        internal new void Hide()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    this.Hide();
                }));
            }
            else
            {
                try
                {
                    this.Hide();
                }
                catch (InvalidOperationException)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Hide();
                    }));
                }
            }
        }

        internal void CustomClose()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    this.Close();
                }));
            }
            else
            {
                try
                {
                    this.Close();
                }
                catch (InvalidOperationException)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Close();
                    }));
                }
            }
        }

        private void FrmModal_MiniLoad_Shown(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    this.Activate();
                }));
            }
            else
            {
                try
                {
                    this.Activate();
                }
                catch (InvalidOperationException)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Activate();
                    }));
                }
            }

            System.Threading.Tasks.Task task;

            Task animTask = new Task(new Action(() =>
            {
                while (true)
                {
                    task = System.Threading.Tasks.Task.Delay(50);
                    task.Wait();

                    this.pointer += 30;

                    if (this.pointer == 360) this.pointer = 0;

                    Care.HandleInvokeMethod(ref PNL_LoadingCircle, new Action(() => {
                        PNL_LoadingCircle.Refresh();
                    }));                    
                }
            }));
            animTask.Start();
        }

        private void PNL_LoadingCircle_Paint(object sender, PaintEventArgs e)
        {
            Library.Style.Render.RenderPaintEventArgs(ref e);

            Rectangle outsideRec = new Rectangle(4, 4, 138, 138);
            e.Graphics.FillPie(new SolidBrush(Color.White), outsideRec, this.pointer, 70);

            Rectangle insideRec = new Rectangle(10, 10, 128, 128);
            e.Graphics.DrawImage(Properties.Resources.icon_gc_logo_128x128, insideRec);
        }
    }
}