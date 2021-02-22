using System;
using System.Collections.Generic;
using System.Linq;

namespace GC.Library.Objects
{
    public class Reminder
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Title { get; set; }
        public string Observations { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public DateTime CreatedIn { get; }

        public Reminder(){}

        public Reminder(int id, DateTime start, DateTime end, string title, string observations, byte red, byte green, byte blue, DateTime createdIn)
        {
            Id = id;
            Start = start;
            End = end;
            Title = title;
            Observations = observations;
            Red = red;
            Green = green;
            Blue = blue;
            CreatedIn = createdIn;
        }

        internal bool IsEqual(string title, DateTime start)
        {
            if (this.Title == title &&
                this.Start.Year == start.Year && this.Start.Month == start.Month && this.Start.Day == start.Day &&
                this.Start.Hour == start.Hour && this.Start.Minute == start.Minute)
            {
                return true;
            }
            else return false;
        }

        // ------------------------------------------------------------------------
        // STATIC ZONE ------------------------------------------------------------
        // ------------------------------------------------------------------------
        internal static List<int> TodaysRemindersIndices = new List<int>();

        internal static void UpdateTodaysReminders()
        {
            TodaysRemindersIndices.Clear();

            if (Forms.Main.Controls.USC_Schedule.ShowingOldReminders && GlobalVariables.OldReminders.Count > 0)
            {
                int[] ids2 = GlobalVariables.OldReminders.Where(x => x.Start.Day == DateTime.Now.Day).Select(x => x.Id).ToArray();

                foreach (int id2 in ids2)
                {
                    TodaysRemindersIndices.Add(GlobalVariables.OldReminders.FindIndex(x => x.Id == id2));
                }
            }

            int[] ids = GlobalVariables.Reminders.Where(x => x.Start.Day == DateTime.Now.Day).Select(x => x.Id).ToArray();

            foreach (int id in ids)
            {
                TodaysRemindersIndices.Add(GlobalVariables.Reminders.FindIndex(x => x.Id == id));
            }
        }

        internal static int GetReminderIndex(string title, DateTime start)
        {
            return GlobalVariables.Reminders.FindIndex(x => x.Title == title && DateTime.Compare(x.Start, start) == 0);
        }

        internal static bool ReminderIsOld(DateTime created_in)
        {
            DateTime old = DateTime.Now.AddDays(GlobalVariables.FragileData.RemindersDaysOnDb * -1);
            if (created_in.CompareTo(old) <= 0) return true;
            else return false;
        }
    }
}
