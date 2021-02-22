using System;
using GC.Library.Checkers;
using GC.Library.Translators;
using GC.Library.Database;

namespace GC.Library.Objects
{
    public class DayRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Profit { get; set; }
        public int Id_User { get; set; }

        public DayRecord(int id, DateTime date, double profit, int id_user)
        {
            this.Id = id;
            this.Date = date;
            this.Profit = profit;
            this.Id_User = id_user;
        }

        /// <summary>
        /// You just need to put the value, positive or negative according to the situation, and the Method will automatic create or update the value on DB and on the folder.
        /// </summary>
        /// <param name="value">The value to be added or subtracted on the daily sale.</param>
        internal static void DaysRecordsUpdater(double value)
        {
            if(GlobalVariables.DaysRecords.Exists(x => Structs.IsDateSameThanToday(x.Date)))
            {
                int index = GlobalVariables.DaysRecords.FindIndex(x => Structs.IsDateSameThanToday(x.Date));
                GlobalVariables.DaysRecords[index].Profit += value;

                MySqlNonQuery.UpdateDaysRecordProfit(GlobalVariables.DaysRecords[index]);
            }
            else
            {
                //In the case of the user is cancelling a request of yesterday we drop down the profit from the yesterday's daily_sale.
                if (value <= 0)
                {
                    //Anti-bug protector 'if'
                    if (GlobalVariables.DaysRecords.Count <= 0) return;

                    GlobalVariables.DaysRecords[GlobalVariables.DaysRecords.Count - 1].Profit += value;

                    Serialization.SerializeDailySale(GlobalVariables.DaysRecords[GlobalVariables.DaysRecords.Count - 1]);

                    MySqlNonQuery.UpdateDaysRecordProfit(GlobalVariables.DaysRecords[GlobalVariables.DaysRecords.Count - 1]);
                }
                else
                {
                    DayRecord daysRecord = new DayRecord(-1, DateTime.Now, value, GlobalVariables.User.Id);
                    daysRecord.Id = MySqlNonQuery.CreateDaysRecord(daysRecord);

                    Serialization.SerializeDailySale(daysRecord);

                    GlobalVariables.DaysRecords.Add(daysRecord);
                }                
            }
        }

        internal static void DaysRecordsUpdater(double value, DateTime requestWasDoneIn)
        {
            if (GlobalVariables.DaysRecords.Exists(x => Structs.IsDateSameThanToday(x.Date)))
            {
                int index = GlobalVariables.DaysRecords.FindIndex(x => Structs.IsDateSameThanToday(x.Date));
                GlobalVariables.DaysRecords[index].Profit += value;

                MySqlNonQuery.UpdateDaysRecordProfit(GlobalVariables.DaysRecords[index]);
            }
            else
            {
                //In the case of the user is cancelling a request of yesterday we drop down the profit from the yesterday's daily_sale.
                if (value <= 0)
                {
                    //Anti-bug protector 'if'
                    if (GlobalVariables.DaysRecords.Count <= 0) return;

                    if (GlobalVariables.DaysRecords.Exists(x => Structs.IsSingleDateEqualsToSingleDate(x.Date, requestWasDoneIn)))
                    {
                        int index = GlobalVariables.DaysRecords.FindIndex(x => Structs.IsSingleDateEqualsToSingleDate(x.Date, requestWasDoneIn));
                        GlobalVariables.DaysRecords[index].Profit += value;

                        Serialization.SerializeDailySale(GlobalVariables.DaysRecords[index]);

                        MySqlNonQuery.UpdateDaysRecordProfit(GlobalVariables.DaysRecords[index]);
                    }
                    else
                    {
                        GlobalVariables.DaysRecords[GlobalVariables.DaysRecords.Count - 1].Profit += value;

                        Serialization.SerializeDailySale(GlobalVariables.DaysRecords[GlobalVariables.DaysRecords.Count - 1]);

                        MySqlNonQuery.UpdateDaysRecordProfit(GlobalVariables.DaysRecords[GlobalVariables.DaysRecords.Count - 1]);
                    }                    
                }
                else
                {
                    DayRecord daysRecord = new DayRecord(-1, DateTime.Now, value, GlobalVariables.User.Id);
                    daysRecord.Id = MySqlNonQuery.CreateDaysRecord(daysRecord);

                    Serialization.SerializeDailySale(daysRecord);

                    GlobalVariables.DaysRecords.Add(daysRecord);
                }
            }
        }

        internal static bool DayRecordIsOld(DateTime date)
        {
            DateTime old = DateTime.Now.AddDays(GlobalVariables.FragileData.DayRecordsDaysOnDb * -1);
            if (date.CompareTo(old) <= 0) return true;
            else return false;
        }
    }
}
