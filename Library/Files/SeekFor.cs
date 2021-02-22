using GC.Library.Objects;
using GC.Library.Objects.SubObjects.Product;
using GC.Library.Translators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GC.Library.Files
{
    internal static class SeekFor
    {
        internal static void OldRequest()
        {
            List<Request> oldRequests = new List<Request>();
            List<string> filteredFiles = new List<string>();
            string[] requestsNumber = GlobalVariables.Requests.Select(x => x.Number).ToArray();

            string[] allFiles = Directory.GetFiles(Informations.Directories.Requests);
            foreach (string item in allFiles)
            {
                string fileName = Path.GetFileName(item);
                if (fileName.Length < 16) continue;
                if (fileName.Substring(fileName.Length - 4, 4) != ".txt") continue;
                if (fileName.Substring(11, fileName.Length - 15) != GlobalVariables.User.Id.ToString()) continue;

                string Number = fileName.Substring(0, 10);
                if (requestsNumber.Contains(Number)) continue;
                else filteredFiles.Add(fileName);
            }

            foreach (string item2 in filteredFiles)
            {
                Request request = null;
                try
                {
                    request = Serialization.TxtFileToObject<Request>(Informations.Directories.Requests + item2, true);

                    if(request == null) continue;
                    if (request.Status == 'C') continue;
                    else if (request.Id_User != GlobalVariables.User.Id) continue;
                }
                catch (Exception ex)
                {
                    Errors.Care.AppendOnErrorLogFile(ex.Message);
                    continue;
                }

                if (request.ExpiresIn.Day == 1 && request.ExpiresIn.Month == 1 && request.ExpiresIn.Year == 1)
                {
                    request.ExpiresIn = new DateTime(1, 1, 1, 0, 0, 0);
                }

                oldRequests.Add(request);
            }

            GlobalVariables.OldRequests = oldRequests;

            Request.SortGlobalOldRequests();
        }

        internal static void CancelledRequests()
        {
            List<Request> cancelled = new List<Request>();
            List<string> filteredFiles = new List<string>();
            string[] requestsNumber = GlobalVariables.CancelledRequests.Select(x => x.Number).ToArray();

            string[] allFiles = Directory.GetFiles(Informations.Directories.Requests);
            foreach (string item in allFiles)
            {
                string fileName = Path.GetFileName(item);
                if (fileName.Length < 16) continue;
                if (fileName.Substring(fileName.Length - 4, 4) != ".txt") continue;
                if (fileName.Substring(11, fileName.Length - 15) != GlobalVariables.User.Id.ToString()) continue;

                string Number = fileName.Substring(0, 10);
                if (requestsNumber.Contains(Number)) continue;
                else filteredFiles.Add(fileName);
            }

            foreach (string item2 in filteredFiles)
            {                
                Request request = null;
                try
                {
                    request = Serialization.TxtFileToObject<Request>(Informations.Directories.Requests + item2, true);
                    if (request == null)
                    {
                        continue;
                    }
                }
                catch (Exception ex)
                {
                    Errors.Care.AppendOnErrorLogFile(ex.Message);
                    continue;
                }

                if (request.Status != 'C') continue;
                else if (request.Id_User != GlobalVariables.User.Id) continue;
                else cancelled.Add(request);
            }

            foreach (Request item3 in cancelled)
            {
                if(item3.ExpiresIn.Day == 1 && item3.ExpiresIn.Month == 1 && item3.ExpiresIn.Year == 1)
                {
                    item3.ExpiresIn = new DateTime(1, 1, 1, 0, 0, 0);
                }

                GlobalVariables.CancelledRequests.Add(item3);
            }

            Request.SortGlobalCancelledRequests();
        }            

        internal static List<DayRecord> OldDaysRecords()
        {
            List<DayRecord> dailySales = new List<DayRecord>();
            List<string> filteredFiles = new List<string>();

            string[] allFiles = Directory.GetFiles(Informations.Directories.DaysRecords);
            foreach (string item in allFiles)
            {
                string fileName = Path.GetFileName(item);
                if (fileName.Length < 14) continue;
                if (fileName.Substring(fileName.Length - 4, 4) != ".txt") continue; //ddMMyyyy_1.txt
                if (fileName.Substring(9, fileName.Length - 13) != GlobalVariables.User.Id.ToString()) continue;

                string aux = fileName.Substring(0, 2);
                aux += "/" + fileName.Substring(2, 2);
                aux += "/" + fileName.Substring(4, 4);
                DateTime date = Convert.ToDateTime(aux);
                if (GlobalVariables.DaysRecords.Exists(x => Checkers.Structs.IsSingleDateEqualsToSingleDate(date, x.Date))) continue;

                filteredFiles.Add(fileName);
            }

            foreach (string item2 in filteredFiles)
            {
                try
                {
                    DayRecord dailySale = Serialization.TxtFileToObject<DayRecord>(Informations.Directories.DaysRecords + item2, true);
                    if (dailySale == null) continue;
                    else if (dailySale.Id_User != GlobalVariables.User.Id) continue;
                    else dailySales.Add(dailySale);
                }
                catch (Exception ex)
                {
                    Errors.Care.AppendOnErrorLogFile(ex.Message);
                    continue;
                }
            }

            return dailySales;
        }

        internal static List<Lot> InactiveUsedLots(string requestNumber)
        {
            string path = Informations.Directories.LotsConsumption + requestNumber + "_" + GlobalVariables.User.Id.ToString() + ".txt";

            if (File.Exists(path))
            {
                List<Lot> lots = Translators.Serialization.TxtFileToObjectsList<Lot>(path, true);

                foreach (Lot item in lots)
                {
                    if (item.ExpiresIn.Day == 1 && item.ExpiresIn.Month == 1 && item.ExpiresIn.Year == 1)
                    {
                        item.ExpiresIn = new DateTime(1, 1, 1, 0, 0, 0);
                    }
                }

                return lots;
            }
            else
            {
                List<Lot> lots = new List<Lot>();
                return lots;
            }
        }

        internal static void OldWarranties()
        {
            List<string> filteredFiles = new List<string>();
            
            string[] allFiles = Directory.GetFiles(Informations.Directories.Warranties);
            foreach (string item in allFiles)
            {
                string fileName = Path.GetFileName(item);
                if (fileName.Length < 16) continue;

                if (fileName.Substring(fileName.Length - 4, 4) != ".txt") continue; // 1234567890_1.json

                if (fileName.Substring(11, fileName.Length - 15) != GlobalVariables.User.Id.ToString()) continue;

                if (GlobalVariables.Warranties.Exists(x => x.Number == fileName.Substring(0, 10))) continue;               

                filteredFiles.Add(fileName);
            }

            foreach (string file in filteredFiles)
            {
                try
                {
                    Warranty warranty = Serialization.TxtFileToObject<Warranty>(Informations.Directories.Warranties + file, true);
                    if (warranty == null) continue;
                    else if (warranty.Id_User != GlobalVariables.User.Id) continue;
                    else GlobalVariables.OldWarranties.Add(warranty);
                }
                catch (Exception ex)
                {
                    Errors.Care.AppendOnErrorLogFile(ex.Message);
                    continue;
                }
            }
        }

        internal static void OldReminders()
        {
            List<string> filteredFiles = new List<string>();

            string[] allFiles = Directory.GetFiles(Informations.Directories.Reminders);
            foreach (string item in allFiles)
            {
                string fileName = Path.GetFileName(item);
                if (fileName.Length < 7) continue;

                if (fileName.Substring(fileName.Length - 4, 4) != ".txt") continue; // 10800_108.txt => 6 start - 9 dot

                int startIndex = fileName.IndexOf('_') + 1;
                int indexOfDot = fileName.IndexOf('.');

                if (fileName.Substring(startIndex, indexOfDot - startIndex) != GlobalVariables.User.Id.ToString()) continue;

                if (GlobalVariables.Reminders.Exists(x => x.Id.ToString() == fileName.Substring(0, startIndex - 1))) continue;

                filteredFiles.Add(fileName);
            }

            foreach (string file in filteredFiles)
            {
                try
                {
                    Reminder reminder = Serialization.TxtFileToObject<Reminder>(Informations.Directories.Reminders + file, true);
                    if (reminder == null || reminder == default(Reminder)) continue;
                    else GlobalVariables.OldReminders.Add(reminder);
                }
                catch (Exception ex)
                {
                    Errors.Care.AppendOnErrorLogFile(ex.Message);
                    continue;
                }
            }
        }
    }
}
