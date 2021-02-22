using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Windows.Forms.Calendar;
using GC.Library.Objects;
using GC.Library;
using GC.Forms.Main.Modals.Reminders;

namespace GC.Forms.Main.Controls
{
    public partial class USC_Schedule : UserControl
    {
        internal static bool ShowingOldReminders = false;

        private DateTime startDateCalendarView, endDateCalendarView;
        private DateTime calendarSelectionStart, calendarSelectionEnd;

        private byte daysScheduleTimeScaleZoom = 2;

        public USC_Schedule()
        {
            InitializeComponent();

            btnCalendarMonthBack.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnCalendarMonthFoward.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            btnDaysScheduleZoomIn.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnDaysScheduleZoomOut.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            this.startDateCalendarView = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0);
            this.endDateCalendarView = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month), 23, 59, 59);

            this.calendarSelectionStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            this.calendarSelectionEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            
            this.UpdateCalendarView();
            this.UpdateDaysScheduleView();
        }

        //-------------------------------------------------------------
        // GENERICS CLASS' METHODS AND PROPS --------------------------
        //-------------------------------------------------------------
        private CalendarItem ReminderToCalendarItem(System.Windows.Forms.Calendar.Calendar calendarTarget, Reminder reminder)
        {
            CalendarItem calendarItem = new CalendarItem(calendarTarget, reminder.Start, reminder.End, reminder.Title);

            calendarItem.ApplyColor(Color.FromArgb(reminder.Red, reminder.Green, reminder.Blue));

            return calendarItem;
        }

        private List<CalendarItem> RemindersToCalendarItems(System.Windows.Forms.Calendar.Calendar calendarTarget, Reminder[] reminders)
        {
            List<CalendarItem> cItems = new List<CalendarItem>();

            foreach (Reminder reminder in reminders)
            {
                cItems.Add(this.ReminderToCalendarItem(calendarTarget, reminder));
            }           

            return cItems;
        }

        private void USC_Schedule_Resize(object sender, EventArgs e)
        {
            pnlMonthBack.Left = (pnlMonthBack.Parent.Width - pnlMonthBack.Width) / 2;

            btnCalendarMonthFoward.Left = pnlMonthBack.Width + pnlMonthBack.Left + 6;
            btnCalendarMonthBack.Left = pnlMonthBack.Left - 6 - btnCalendarMonthBack.Width;
        }

        private void chxShowOld_CheckedChanged(object sender, EventArgs e)
        {
            if (chxShowOld.Checked)
            {
                ShowingOldReminders = true;

                if (GlobalVariables.OldReminders.Count <= 0) Library.Files.SeekFor.OldReminders();

                if(GlobalVariables.OldReminders.Count > 0)
                {
                    this.UpdateCalendarView();
                    this.UpdateDaysScheduleView();

                    Reminder.UpdateTodaysReminders();
                }
            }
            else
            {
                ShowingOldReminders = false;

                this.UpdateCalendarView();
                this.UpdateDaysScheduleView();

                Reminder.UpdateTodaysReminders();
            }
        }
        //----------------------------------------------------------------

        //----------------------------------------------------------------
        // BIGGER CALENDAR'S METHODS AND PROPS --------------------------
        //----------------------------------------------------------------
        private void UpdateCalendarView()
        {
            string monthName = startDateCalendarView.ToString("MMMM", CultureInfo.CreateSpecificCulture("pt-BR"));

            lblCalendarSelectedMonth.Text = monthName.Substring(0, 1).ToUpper() + monthName.Substring(1, monthName.Length - 1);
            lblCalendarSelectedMonth.Left = (lblCalendarSelectedMonth.Parent.Width - lblCalendarSelectedMonth.Width) / 2;

            cldCalendar.SetViewRange(this.startDateCalendarView, this.endDateCalendarView);

            if (this.startDateCalendarView.Month == DateTime.Now.Month)
            {
                cldDaysSchedule.SetViewRange(DateTime.Now, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59));
            }
            else
            {
                cldDaysSchedule.SetViewRange(startDateCalendarView, new DateTime(startDateCalendarView.Year, startDateCalendarView.Month, startDateCalendarView.Day, 23, 59, 59));
            }

            //----------------------------------------------------------------
            //Populating the current month of the calendar with reminder
            //----------------------------------------------------------------
            cldCalendar.Items.Clear();

            if (ShowingOldReminders && GlobalVariables.OldReminders.Count > 0)
            {
                Reminder[] filter2 = GlobalVariables.OldReminders.Where(x =>
                (x.Start.Month == this.startDateCalendarView.Month && x.Start.Year == this.startDateCalendarView.Year) ||
                (x.End.Month == this.endDateCalendarView.Month && x.End.Year == this.endDateCalendarView.Year) ||
                ((x.Start.Month < this.startDateCalendarView.Month && x.Start.Year == this.startDateCalendarView.Year) && (x.End.Month > this.endDateCalendarView.Month && x.End.Year == this.endDateCalendarView.Year))).Select(x => x).ToArray();

                if (filter2.Length > 0) cldCalendar.Items.AddRange(this.RemindersToCalendarItems(cldCalendar, filter2));
            }

            Reminder[] filter = GlobalVariables.Reminders.Where(x =>
            (x.Start.Month == this.startDateCalendarView.Month && x.Start.Year == this.startDateCalendarView.Year) ||
            (x.End.Month == this.endDateCalendarView.Month && x.End.Year == this.endDateCalendarView.Year) ||
            ((x.Start.Month < this.startDateCalendarView.Month && x.Start.Year == this.startDateCalendarView.Year) && (x.End.Month > this.endDateCalendarView.Month && x.End.Year == this.endDateCalendarView.Year))).Select(x => x).ToArray();

            if (filter.Length > 0) cldCalendar.Items.AddRange(this.RemindersToCalendarItems(cldCalendar, filter));
        }

        private void btnCalendarMonthBack_Click(object sender, EventArgs e)
        {
            this.startDateCalendarView = this.startDateCalendarView.AddMonths(-1);
            this.endDateCalendarView = new DateTime(startDateCalendarView.Year, startDateCalendarView.Month, DateTime.DaysInMonth(startDateCalendarView.Year, startDateCalendarView.Month), 23, 59, 59);

            this.UpdateCalendarView();
        }

        private void btnCalendarMonthFoward_Click(object sender, EventArgs e)
        {
            this.startDateCalendarView = this.startDateCalendarView.AddMonths(1);
            this.endDateCalendarView = new DateTime(startDateCalendarView.Year, startDateCalendarView.Month, DateTime.DaysInMonth(startDateCalendarView.Year, startDateCalendarView.Month), 23, 59, 59);

            this.UpdateCalendarView();
        }

        //Can't toutch the calendar's itens
        private void cldCalendar_ItemCreating(object sender, CalendarItemCancelEventArgs e)
        {
            e.Cancel = true;
        }

        //Can't toutch the calendar's itens
        private void cldCalendar_ItemDeleting(object sender, CalendarItemCancelEventArgs e)
        {
            e.Cancel = true;
        }

        //If user select the item, we load that on day's schedule at day of the item
        private void cldCalendar_ItemSelected(object sender, CalendarItemEventArgs e)
        {
            this.calendarSelectionStart = new DateTime(e.Item.Date.Year, e.Item.Date.Month, e.Item.Date.Day, 0, 0, 0);
            this.calendarSelectionEnd = new DateTime(e.Item.Date.Year, e.Item.Date.Month, e.Item.Date.Day, 23, 59, 59);

            this.UpdateDaysScheduleView();
        }

        private void cldCalendar_MouseUp(object sender, MouseEventArgs e)
        {
            if (cldCalendar.SelectedElementStart == null) return;

            if (DateTime.Compare(cldCalendar.SelectedElementStart.Date, cldCalendar.SelectedElementEnd.Date.AddDays(-4)) == -1)
            {
                GlobalModals.FRM_MessageAndOK.BuildAndShow("Você não pode selecionar mais do que 5 dias!", 1);

                this.calendarSelectionStart = new DateTime();
                this.calendarSelectionEnd = new DateTime();

                cldCalendar.SelectedElementStart = null;
                cldCalendar.SelectedElementEnd = null;

                this.UpdateDaysScheduleView();

                return;
            }

            this.calendarSelectionStart = cldCalendar.SelectedElementStart.Date;
            this.calendarSelectionEnd = new DateTime(cldCalendar.SelectedElementEnd.Date.Year, cldCalendar.SelectedElementEnd.Date.Month, cldCalendar.SelectedElementEnd.Date.Day, 23, 59, 59);

            this.UpdateDaysScheduleView();
        }

        private void cldCalendar_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            if (e.Item.Text == null || e.Item.Text == "") return;

            frmModal_DetailsReminder details = new frmModal_DetailsReminder(GlobalVariables.Reminders[Reminder.GetReminderIndex(e.Item.Text, e.Item.StartDate)]);
            details.ShowDialog();

            if (details.Changes)
            {
                this.UpdateCalendarView();
                this.UpdateDaysScheduleView();

                Reminder.UpdateTodaysReminders();
            }
        }
        //-----------------------------------------------------------------------

        //-----------------------------------------------------------------------
        // SMALLER DAY SCHEDULE'S METHODS AND PROPS -----------------------------
        //-----------------------------------------------------------------------
        private void UpdateDaysScheduleZoom()
        {
            switch (this.daysScheduleTimeScaleZoom)
            {
                case 6:
                    cldDaysSchedule.TimeScale = CalendarTimeScale.FiveMinutes;
                    break;

                case 5:
                    cldDaysSchedule.TimeScale = CalendarTimeScale.SixMinutes;
                    break;

                case 4:
                    cldDaysSchedule.TimeScale = CalendarTimeScale.TenMinutes;
                    break;

                case 3:
                    cldDaysSchedule.TimeScale = CalendarTimeScale.FifteenMinutes;
                    break;

                case 2:
                    cldDaysSchedule.TimeScale = CalendarTimeScale.ThirtyMinutes;
                    break;

                case 1:
                    cldDaysSchedule.TimeScale = CalendarTimeScale.SixtyMinutes;
                    break;
            }
        }

        private void UpdateDaysScheduleView()
        {
            if(this.calendarSelectionStart == default(DateTime))
            {
                cldDaysSchedule.SetViewRange(DateTime.Now, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59));
            }
            else
            {
                cldDaysSchedule.SetViewRange(this.calendarSelectionStart, this.calendarSelectionEnd);
            }

            cldDaysSchedule.Items.Clear();

            //----------------------------------------------------------------
            //Populating the current view of the schedule with reminder (Old Reminders)
            //----------------------------------------------------------------
            if (ShowingOldReminders && GlobalVariables.OldReminders.Count > 0)
            {
                Reminder[] filter2 = GlobalVariables.OldReminders.Where(x =>
                // Case 1:
                // Started before the start of the view and ends after the start of the view
                (DateTime.Compare(cldDaysSchedule.ViewStart, x.Start) <= 0 &&
                DateTime.Compare(x.End, cldDaysSchedule.ViewStart) == 1) ||

                // Case 2:
                // Started before the end of the view and ends after the start of the view
                (DateTime.Compare(x.Start, cldDaysSchedule.ViewEnd) == -1 &&
                DateTime.Compare(x.End, cldDaysSchedule.ViewStart) == 1) ||

                // Case 3:
                // Started before the start of the view and ends after the end of the view
                (DateTime.Compare(x.Start, cldDaysSchedule.ViewStart) == -1 &&
                DateTime.Compare(x.End, cldDaysSchedule.ViewEnd) == 1)).ToArray();

                if (filter2.Length > 0) cldDaysSchedule.Items.AddRange(this.RemindersToCalendarItems(cldDaysSchedule, filter2));
            }            

            //----------------------------------------------------------------
            //Populating the current view of the schedule with reminder (Normal Reminders)
            //----------------------------------------------------------------
            Reminder[] filter = GlobalVariables.Reminders.Where(x => 
            // Case 1:
            // Started before the start of the view and ends after the start of the view
            (DateTime.Compare(cldDaysSchedule.ViewStart, x.Start) <= 0 && 
            DateTime.Compare(x.End, cldDaysSchedule.ViewStart) == 1) ||
            
            // Case 2:
            // Started before the end of the view and ends after the start of the view
            (DateTime.Compare(x.Start, cldDaysSchedule.ViewEnd) == -1 && 
            DateTime.Compare(x.End, cldDaysSchedule.ViewStart) == 1) || 
            
            // Case 3:
            // Started before the start of the view and ends after the end of the view
            (DateTime.Compare(x.Start, cldDaysSchedule.ViewStart) == -1 &&
            DateTime.Compare(x.End, cldDaysSchedule.ViewEnd) == 1)).ToArray();

            if (filter.Length > 0) cldDaysSchedule.Items.AddRange(this.RemindersToCalendarItems(cldDaysSchedule, filter));
        }        

        private void btnDaysScheduleZoomIn_Click(object sender, EventArgs e)
        {
            if (this.daysScheduleTimeScaleZoom == 6) return;
            else
            {
                this.daysScheduleTimeScaleZoom++;

                this.UpdateDaysScheduleZoom();
            }
        }

        private void btnDaysScheduleZoomOut_Click(object sender, EventArgs e)
        {
            if (this.daysScheduleTimeScaleZoom == 1) return;
            else
            {
                this.daysScheduleTimeScaleZoom--;

                this.UpdateDaysScheduleZoom();
            }
        }

        private void cldDaysSchedule_ItemDeleting(object sender, CalendarItemCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void cldDaysSchedule_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            if (e.Item.Text == null || e.Item.Text == "") return;

            frmModal_DetailsReminder details = new frmModal_DetailsReminder(GlobalVariables.Reminders[Reminder.GetReminderIndex(e.Item.Text, e.Item.StartDate)]);
            details.ShowDialog();

            if (details.Changes)
            {
                this.UpdateCalendarView();
                this.UpdateDaysScheduleView();

                Reminder.UpdateTodaysReminders();
            }
        }        

        private void cldDaysSchedule_ItemCreating(object sender, CalendarItemCancelEventArgs e)
        {
            Modals.Reminders.frmModal_NewOrAlterReminder addAlter = new Modals.Reminders.frmModal_NewOrAlterReminder(e.Item.StartDate, e.Item.EndDate);
            addAlter.ShowDialog();

            if (addAlter.alterations)
            {
                this.UpdateCalendarView();
                this.UpdateDaysScheduleView();

                Reminder.UpdateTodaysReminders();
            }

            e.Cancel = true;
        }        

        private void cldDaysSchedule_ItemDatesChanged(object sender, CalendarItemEventArgs e)
        {
            this.UpdateDaysScheduleView();
        }          
    }
}
