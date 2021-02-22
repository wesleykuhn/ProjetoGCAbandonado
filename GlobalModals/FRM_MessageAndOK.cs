using System;
using System.Drawing;
using System.Media;
using GC.Library.Style;

namespace GC.GlobalModals
{
    public partial class FRM_MessageAndOK : Forms.Bases.FRM_Default
    {
        /// <summary>
        /// A form to inform the user about something and wait the user click in OK.
        /// </summary>
        /// <param name="text">The text to be in the center of the form.</param>
        /// <param name="colorMode">The main color of the form. 1: Warning. 2: Danger. 3: Primary. 4: Green. 5: Success. 6: Info. The default is Dark.</param>
        public FRM_MessageAndOK(string text, byte colorMode)
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
        }

        /// <summary>
        /// Automatic creates an instance of the Modal and shows it.
        /// </summary>
        /// <param name="message">The message text on Modal.</param>
        /// <param name="colorMode">1: Warning. 2: Danger. 3: Primary. 4: Green. 5: Success. 6: Info. The default is Dark.</param>
        internal static void BuildAndShow(string message, byte colorMode)
        {
            FRM_MessageAndOK frm = new FRM_MessageAndOK(message, colorMode);

            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal new void Show()
        {
            ShowDialog();
        }

        private void FrmModal_MessageAndOK_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void FrmModal_MessageAndOK_Shown(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
