using GC.Library.Database;
using GC.Library;
using GC.Library.Objects;
using GC.Library.Style;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GC.Forms.Main.Modals.Reminders
{
    public partial class frmModal_NewOrAlterReminder : Bases.FRM_Default
    {
        internal bool alterations = false;

        internal Reminder Reminder;

        private DateTime startDateTime, endDateTime;

        private string startHourBackup, endHourBackup;

        public frmModal_NewOrAlterReminder(DateTime start, DateTime end)
        {
            InitializeComponent();

            this.ReadyForm();

            btnAlter.Hide();

            this.startDateTime = start;
            this.endDateTime = end;

            dtpStartDate.Value = start;
            dtpEndDate.Value = end;

            this.UpdateStartTimeTxt();
            this.UpdateEndTimeTxt();

            clxBlue.SetColorBox(ColorsPalette.GDE_Primary);
            clxDark.SetColorBox(ColorsPalette.GDE_Dark);
            clxGreen.SetColorBox(ColorsPalette.GDE_Green);
            clxRed.SetColorBox(ColorsPalette.GDE_Danger);
            clxYellow.SetColorBox(ColorsPalette.GDE_Warning);

            //The custom color buiding
            this.ResetCustomColor();

            lblEditCustomColor.Hide();

            this.clxDark_Click(this, new EventArgs());
        }

        public frmModal_NewOrAlterReminder(Reminder reminder)
        {
            InitializeComponent();

            this.ReadyForm();

            btnAdd.Hide();
            btnAlter.Left = btnAdd.Left;

            this.Reminder = reminder;

            txtTitle.Text = reminder.Title;

            this.startDateTime = reminder.Start;
            this.endDateTime = reminder.End;

            dtpStartDate.Value = reminder.Start;
            dtpEndDate.Value = reminder.End;

            this.UpdateStartTimeTxt();
            this.UpdateEndTimeTxt();

            //The custom color buiding
            this.ResetCustomColor();
            lblEditCustomColor.Hide();

            clxBlue.SetColorBox(ColorsPalette.GDE_Primary);
            clxDark.SetColorBox(ColorsPalette.GDE_Dark);
            clxGreen.SetColorBox(ColorsPalette.GDE_Green);
            clxRed.SetColorBox(ColorsPalette.GDE_Danger);
            clxYellow.SetColorBox(ColorsPalette.GDE_Warning);

            if(ColorsPalette.Compare(ColorsPalette.GDE_Primary, Color.FromArgb(reminder.Red, reminder.Green, reminder.Blue)))
            {
                rbtBlue.Checked = true;
            }
            else if (ColorsPalette.Compare(ColorsPalette.GDE_Dark, Color.FromArgb(reminder.Red, reminder.Green, reminder.Blue)))
            {
                rbtDark.Checked = true;
            }
            else if (ColorsPalette.Compare(ColorsPalette.GDE_Green, Color.FromArgb(reminder.Red, reminder.Green, reminder.Blue)))
            {
                rbtGreen.Checked = true;
            }
            else if (ColorsPalette.Compare(ColorsPalette.GDE_Danger, Color.FromArgb(reminder.Red, reminder.Green, reminder.Blue)))
            {
                rbtRed.Checked = true;
            }
            else if (ColorsPalette.Compare(ColorsPalette.GDE_Warning, Color.FromArgb(reminder.Red, reminder.Green, reminder.Blue)))
            {
                rbtYellow.Checked = true;
            }
            else
            {
                pnlAddCustomColor.Hide();

                clxCustom.SetColorBox(Color.FromArgb(reminder.Red, reminder.Green, reminder.Blue));

                rbtCustom.Checked = true;

                lblEditCustomColor.Show();
            }

            if (reminder.Observations != null) rtbObservations.Text = reminder.Observations;
        }

        // -----------------------------------------------------------
        // DATE AND TIME CONTROL -------------------------------------
        private void UpdateStartTimeTxt()
        {
            this.startHourBackup = this.startDateTime.ToString("HH:mm");

            txtStartHour.Text = this.startDateTime.ToString("HH:mm");
        }

        private void UpdateEndTimeTxt()
        {
            this.endHourBackup = this.endDateTime.ToString("HH:mm");

            txtEndHour.Text = this.endDateTime.ToString("HH:mm");
        }

        private void txtStartHour_TextChanged(object sender, EventArgs e)
        {
            txtStartHour.Text = this.startHourBackup;
        }

        private void txtEndHour_TextChanged(object sender, EventArgs e)
        {
            txtEndHour.Text = this.endHourBackup;
        }

        private void txtStartHour_Click(object sender, EventArgs e)
        {
            SubModals.frmModal_NewOrAlterReminder_HourAndMinutesSelector selector = new SubModals.frmModal_NewOrAlterReminder_HourAndMinutesSelector(this.startDateTime);
            selector.ShowDialog();

            this.startDateTime = new DateTime(this.startDateTime.Year, this.startDateTime.Month, this.startDateTime.Day, selector.SelectedHour, selector.SelectedMinute, 0);

            this.startHourBackup = this.startDateTime.ToString("HH:mm");

            txtStartHour.Text = this.startDateTime.ToString("HH:mm");
        }

        private void txtEndHour_Click(object sender, EventArgs e)
        {
            SubModals.frmModal_NewOrAlterReminder_HourAndMinutesSelector selector = new SubModals.frmModal_NewOrAlterReminder_HourAndMinutesSelector(this.endDateTime);
            selector.ShowDialog();

            if(DateTime.Compare(this.startDateTime, new DateTime(this.endDateTime.Year, this.endDateTime.Month, this.endDateTime.Day, selector.SelectedHour, selector.SelectedMinute, 0)) > -1)
            {
                GlobalModals.FRM_MessageAndOK.BuildAndShow("A data e hora de término não pode ser menor que a data e hora de início!", 1);

                return;
            }

            this.endDateTime = new DateTime(this.endDateTime.Year, this.endDateTime.Month, this.endDateTime.Day, selector.SelectedHour, selector.SelectedMinute, 0);

            this.endHourBackup = this.endDateTime.ToString("HH:mm");

            txtEndHour.Text = this.endDateTime.ToString("HH:mm");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtpStartDate.Value, dtpEndDate.Value) != -1)
            {
                GlobalModals.FRM_MessageAndOK.BuildAndShow("A data e hora de término não pode ser menor que a data e hora de início! Por favor, verifique e tente novamente.", 1);

                return;
            }

            if (DateTime.Compare(dtpStartDate.Value, dtpEndDate.Value) != -1)
            {
                GlobalModals.FRM_MessageAndOK.BuildAndShow("A data e hora de início não pode ser maior que a data e hora de término! Por favor, verifique e tente novamente.", 1);

                return;
            }

            string aux = txtTitle.Text.TrimStart();
            aux = aux.TrimEnd();

            if(aux.Length < 1)
            {
                GlobalModals.FRM_MessageAndOK.BuildAndShow("O lembrete precisa de um título! Por favor, preencha o campo do título e tente novamente.", 1);

                return;
            }

            string aux2 = rtbObservations.Text.TrimStart();
            aux2 = aux2.TrimEnd();

            if (GlobalVariables.Reminders.Exists(x => x.IsEqual(aux, this.startDateTime)))
            {
                GlobalModals.FRM_MessageAndOK.BuildAndShow("Já existe um lembrete com esse título e com essa data e hora de início! Por favor, verifique e tenta novamente.", 1);

                return;
            }

            Color color = ColorsPalette.GDE_Dark;

            if (rbtBlue.Checked)
            {
                color = clxBlue.BackColor;
            }
            else if (rbtCustom.Checked)
            {
                color = clxCustom.BackColor;
            }
            else if (rbtGreen.Checked)
            {
                color = clxGreen.BackColor;
            }
            else if (rbtRed.Checked)
            {
                color = clxRed.BackColor;
            }
            else if(rbtYellow.Checked)
            {
                color = clxYellow.BackColor;
            }

            this.startDateTime = new DateTime(this.startDateTime.Year, this.startDateTime.Month, this.startDateTime.Day, this.startDateTime.Hour, this.startDateTime.Minute, 0);

            this.endDateTime = new DateTime(this.endDateTime.Year, this.endDateTime.Month, this.endDateTime.Day, this.endDateTime.Hour, this.endDateTime.Minute, 0);

            Reminder reminder = new Reminder(-1, this.startDateTime, this.endDateTime, aux, aux2, color.R, color.G, color.B, DateTime.Now);

            reminder.Id = MySqlNonQuery.CreateReminder(reminder);

            GlobalVariables.Reminders.Add(reminder);

            Library.Translators.Serialization.SerializeReminder(reminder);

            this.alterations = true;

            this.Close();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtpStartDate.Value, dtpEndDate.Value) != -1)
            {
                GlobalModals.FRM_MessageAndOK.BuildAndShow("A data e hora de término não pode ser menor que a data e hora de início! Por favor, verifique e tente novamente.", 1);

                return;
            }

            if (DateTime.Compare(dtpStartDate.Value, dtpEndDate.Value) != -1)
            {
                GlobalModals.FRM_MessageAndOK.BuildAndShow("A data e hora de início não pode ser maior que a data e hora de término! Por favor, verifique e tente novamente.", 1);

                return;
            }

            string aux = txtTitle.Text.TrimStart();
            aux = aux.TrimEnd();

            if (aux.Length < 1)
            {
                GlobalModals.FRM_MessageAndOK.BuildAndShow("O lembrete precisa de um título! Por favor, preencha o campo do título e tente novamente.", 1);

                return;
            }

            string aux2 = rtbObservations.Text.TrimStart();
            aux2 = aux2.TrimEnd();

            if (GlobalVariables.Reminders.Exists(x => x.IsEqual(aux, this.startDateTime) && x.Id != this.Reminder.Id))
            {
                GlobalModals.FRM_MessageAndOK.BuildAndShow("Já existe um lembrete com esse título e com essa data e hora de início! Por favor, verifique e tenta novamente.", 1);

                return;
            }

            Color color = ColorsPalette.GDE_Dark;

            if (rbtBlue.Checked)
            {
                color = clxBlue.BackColor;
            }
            else if (rbtCustom.Checked)
            {
                color = clxCustom.BackColor;
            }
            else if (rbtGreen.Checked)
            {
                color = clxGreen.BackColor;
            }
            else if (rbtRed.Checked)
            {
                color = clxRed.BackColor;
            }
            else if (rbtYellow.Checked)
            {
                color = clxYellow.BackColor;
            }

            this.startDateTime = new DateTime(this.startDateTime.Year, this.startDateTime.Month, this.startDateTime.Day, this.startDateTime.Hour, this.startDateTime.Minute, 0);

            this.endDateTime = new DateTime(this.endDateTime.Year, this.endDateTime.Month, this.endDateTime.Day, this.endDateTime.Hour, this.endDateTime.Minute, 0);

            this.Reminder = new Reminder(this.Reminder.Id, this.startDateTime, this.endDateTime, aux, aux2, color.R, color.G, color.B, DateTime.Now);

            MySqlNonQuery.UpdateReminder(this.Reminder);

            int index = GlobalVariables.Reminders.FindIndex(x => x.Id == this.Reminder.Id);
            GlobalVariables.Reminders[index] = this.Reminder;

            Library.Translators.Serialization.SerializeReminder(this.Reminder);

            this.alterations = true;

            this.Close();
        }

        // ------------------------------------------------------------
        // COLORS CONTROL ---------------------------------------------
        private void ResetCustomColor()
        {
            pnlAddCustomColor.Show();

            clxCustom.SetColorBox(SystemColors.Control);
        }

        private void clxDark_Click(object sender, EventArgs e)
        {
            rbtDark.Checked = true;
        }

        private void clxBlue_Click(object sender, EventArgs e)
        {
            rbtBlue.Checked = true;
        }

        private void clxGreen_Click(object sender, EventArgs e)
        {
            rbtGreen.Checked = true;
        }

        private void clxYellow_Click(object sender, EventArgs e)
        {
            rbtYellow.Checked = true;
        }

        private void clxRed_Click(object sender, EventArgs e)
        {
            rbtRed.Checked = true;
        }

        private void lblEditCustomColor_Click(object sender, EventArgs e)
        {
            this.PnlAddCustomColor_Click(this, new EventArgs());
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            this.endDateTime = new DateTime(dtpEndDate.Value.Year, dtpEndDate.Value.Month, dtpEndDate.Value.Day, this.endDateTime.Hour, this.endDateTime.Minute, 0);
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {        
            this.startDateTime = new DateTime(dtpStartDate.Value.Year, dtpStartDate.Value.Month, dtpStartDate.Value.Day, this.startDateTime.Hour, this.startDateTime.Minute, 0);
        }

        private void PnlAddCustomColor_Click(object sender, EventArgs e)
        {
            DialogResult result = cldColorPicker.ShowDialog();
            
            if(result == DialogResult.OK)
            {
                pnlAddCustomColor.Hide();

                clxCustom.SetColorBox(cldColorPicker.Color);

                rbtCustom.Checked = true;

                lblEditCustomColor.Show();
            }            
        }

        private void rbtCustom_CheckedChanged_1(object sender, EventArgs e)
        {
            if (pnlAddCustomColor.Visible) this.clxDark_Click(this, new EventArgs());
        }
        // -------------------------------------------------------------------------------
    }
}
