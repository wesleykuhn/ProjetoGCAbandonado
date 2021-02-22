using System;
using System.Drawing;
using System.Media;
using GC.Library.Style;

namespace GC.GlobalModals
{
    public partial class FRM_Confirmation : Forms.Bases.FRM_Default
    {
        internal bool Result;

        /// <summary>
        /// A form to get the confirmation of the user to do something.
        /// </summary>
        /// <param name="text">The text to be in the center of the form.</param>
        /// <param name="colorMode">The main color of the form. 1: Warning. 2: Danger. 3: Primary. 4: Green. 5: Success. 6: Info. The default is Dark.</param>
        public FRM_Confirmation(string text, byte colorMode)
        {            
            InitializeComponent();

            this.ReadyForm();

            this.UnableClose();
            this.UnableMinimize();

            lblText.Text = text;
            switch (colorMode)
            {
                case 1:
                    PlaySound();
                    BackColor = ColorsPalette.GDE_Warning;
                    break;
                case 2:
                    PlaySound();
                    BackColor = ColorsPalette.GDE_Danger;
                    break;
                case 3:
                    PlaySound();
                    SystemSounds.Exclamation.Play();
                    BackColor = ColorsPalette.GDE_Primary;
                    break;
                case 4:
                    PlaySound();
                    BackColor = ColorsPalette.GDE_Green;
                    break;
                case 5:
                    PlaySound();
                    BackColor = ColorsPalette.GDE_Green;
                    break;
                case 6:
                    PlaySound();
                    BackColor = ColorsPalette.GDE_Info;
                    break;
            }           
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Result = true;
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Result = false;
            Close();
        }

        private void PlaySound()
        {
            SystemSounds.Asterisk.Play();
        }

        internal new void Show()
        {
            ShowDialog();
        }

        private void FrmModal_Confirmation_Shown(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
