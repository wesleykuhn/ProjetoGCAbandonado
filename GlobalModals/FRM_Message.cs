using System;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using GC.Library.Style;

namespace GC.GlobalModals
{
    public partial class FRM_Message : Forms.Bases.FRM_Default
    {
        int AutoCloseTime;

        Task Task;
        /// <summary>
        /// A form to inform the user about something and wait the entered time in hardcode to auto-close.
        /// </summary>
        /// <param name="text">The text to be in the center of the form.</param>
        /// <param name="colorMode">The main color of the form. 1: Warning. 2: Danger. 3: Primary. 4: Green. 5: Success. 6: Info. The default is Dark.</param>
        /// <param name="autoCloseTime">The time, in miliseconds, to auto-close the form. Use 0 to never auto-close.</param>
        public FRM_Message(string text, byte colorMode, int autoCloseTime)
        {
            InitializeComponent();

            this.ReadyForm();

            this.UnableClose();
            this.UnableMinimize();

            lblText.Text = text;

            switch (colorMode)
            {
                case 1:
                    SystemSounds.Exclamation.Play();
                    BackColor = ColorsPalette.GDE_Warning;
                    break;
                case 2:
                    SystemSounds.Hand.Play();
                    BackColor = ColorsPalette.GDE_Danger;
                    break;
                case 3:
                    SystemSounds.Exclamation.Play();
                    BackColor = ColorsPalette.GDE_Primary;
                    break;
                case 4:
                    SystemSounds.Exclamation.Play();
                    BackColor = ColorsPalette.GDE_Green;
                    break;
                case 5:
                    SystemSounds.Exclamation.Play();
                    BackColor = ColorsPalette.GDE_Green;
                    break;
                case 6:
                    SystemSounds.Exclamation.Play();
                    BackColor = ColorsPalette.GDE_Info;
                    break;
            }

            this.AutoCloseTime = autoCloseTime;

            this.Task = new Task(() => AutoClose());
            this.Task.Start();
        }

        internal new void Show()
        {
            ShowDialog();
        }

        private void FrmModal_Message_Load(object sender, EventArgs e)
        {
            this.Activate();                        
        }

        private void AutoClose()
        {
            if (this.AutoCloseTime > 0)
            {
                System.Threading.Thread.Sleep(this.AutoCloseTime);
                Invoke(new Action(() => this.Close()));
            }
        }

        private void FrmModal_Message_Shown(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
