using GC.Library.Objects;
using System;
using System.Drawing;
using System.Windows.Forms;
using GC.Library.Database;
using GC.Library;

namespace GC.Forms.Main.Modals.Reminders
{
    public partial class frmModal_DetailsReminder : Bases.FRM_Full
    {
        private Reminder reminder;

        internal bool Changes = false;

        public frmModal_DetailsReminder(Reminder reminder)
        {
            InitializeComponent();

            this.ReadyForm();

            this.reminder = reminder;

            btnAlter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            // COLOR AND TITLE
            pnlColor.BackColor = Color.FromArgb(reminder.Red, reminder.Green, reminder.Blue);
            if ((pnlColor.BackColor.R * 0.299 + pnlColor.BackColor.G * 0.587 + pnlColor.BackColor.B * 0.114) < 186)
            {
                lblTitle.ForeColor = Color.FromArgb(255, 255, 255);
            }
            lblTitle.Text = reminder.Title;

            // START 
            string aux = reminder.Start.ToString("D");

            lblStart.Text += aux.Substring(0, 1).ToUpper() + aux.Substring(1, aux.Length - 1) + " às";
            lblStartTime.Text = reminder.Start.ToString("HH:mm");
            lblStartTime.Left = lblStart.Left + lblStart.Width;

            // END
            aux = reminder.End.ToString("D");
            lblEnd.Text += aux.Substring(0, 1).ToUpper() + aux.Substring(1, aux.Length - 1) + " às " + reminder.End.ToString("HH:mm");

            // OBSERVATIONS
            if(reminder.Observations != null) rtbObservations.Text = reminder.Observations;
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            frmModal_NewOrAlterReminder alter = new frmModal_NewOrAlterReminder(this.reminder);
            alter.ShowDialog();

            if (alter.alterations)
            {
                this.Changes = true;

                this.Close();
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_Confirmation conf = new GlobalModals.FRM_Confirmation("Tem certeza que deseja excluir este lembrete? Uma vez excluído não será possível recuperá-lo.", 1);
            conf.Show();

            if (conf.Result)
            {
                MySqlNonQuery.DeleteReminderById(this.reminder.Id);                

                Library.Files.Control.DeleteReminderFile(this.reminder.Id);

                int index = GlobalVariables.Reminders.FindIndex(x => x.Id == this.reminder.Id);

                GlobalVariables.Reminders.RemoveAt(index);

                this.Changes = true;

                GlobalModals.FRM_MessageAndOK.BuildAndShow("Lembrete excluído com sucesso!", 4);

                this.Close();
            }
        }
    }
}
