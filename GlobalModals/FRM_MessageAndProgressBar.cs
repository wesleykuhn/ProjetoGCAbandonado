using System;
using System.Drawing;
using System.Threading.Tasks;
using GC.Library.Style;

namespace GC.GlobalModals
{
    public partial class FRM_MessageAndProgressBar : Forms.Bases.FRM_Default
    {
        Task Task;

        /// <summary>
        /// A form in loading modal style.
        /// </summary>
        /// <param name="text">The text to be in the center of the form.</param>
        /// <param name="colorMode">The main color of the form. 1: Warning. 2: Danger. 3: Primary. 4: Green. 5: Success. 6: Info. The default is Dark.</param>
        public FRM_MessageAndProgressBar(string text, byte colorMode)
        {
            InitializeComponent();

            this.ReadyForm();

            this.UnableClose();
            this.UnableMinimize();

            lblText.Text = text;

            switch (colorMode)
            {
                case 1:
                    BackColor = ColorsPalette.GDE_Warning;
                    break;
                case 2:
                    BackColor = ColorsPalette.GDE_Danger;
                    break;
                case 3:
                    BackColor = ColorsPalette.GDE_Primary;
                    break;
                case 4:
                    BackColor = ColorsPalette.GDE_Green;
                    break;
                case 5:
                    BackColor = ColorsPalette.GDE_Green;
                    break;
                case 6:
                    BackColor = ColorsPalette.GDE_Info;
                    break;
            }           
        }

        internal new void Show()
        {
            this.Task = new Task(() => ShowDialog());
            this.Task.Start();
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

        private void FrmModal_MessageAndProgressBar_Shown(object sender, EventArgs e)
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
        }
    }
}
