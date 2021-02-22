using GC.Library.Translators;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GC.Library.Sync
{
    internal class DatabaseToLocalFile
    {
        internal static void Requests()
        {
            List<string> inFolderRequestsNumber = new List<string>();
            string[] systemRequestsNumber = GlobalVariables.Requests.Select(x => x.Number).ToArray();
            string[] allFiles = Directory.GetFiles(Informations.Directories.Requests);
            foreach (string item in allFiles)
            {
                string fileName = Path.GetFileName(item);
                if (fileName.Length < 16) continue;
                if (fileName.Substring(fileName.Length - 4, 4) != ".txt") continue;
                if (fileName.Substring(11, fileName.Length - 15) != GlobalVariables.User.Id.ToString()) continue;

                string Number = fileName.Substring(0, 10);
                inFolderRequestsNumber.Add(Path.GetFileName(Number));
            }

            foreach (string item2 in systemRequestsNumber)
            {
                if (!inFolderRequestsNumber.Contains(item2))
                {
                    int index = GlobalVariables.Requests.FindIndex(x => x.Number == item2);
                    Serialization.SerializeRequest(GlobalVariables.Requests[index]);
                }
            }
        }

        internal static void Warranties()
        {
            List<string> inFolderWarrantiesNumber = new List<string>();
            string[] systemWarrantiesNumber = GlobalVariables.Warranties.Select(x => x.Number).ToArray();
            string[] allFiles = Directory.GetFiles(Informations.Directories.Warranties);
            foreach (string item in allFiles)
            {
                string fileName = Path.GetFileName(item);
                if (fileName.Length < 16) continue; // 1234567890_5.txt
                if (fileName.Substring(fileName.Length - 4, 4) != ".txt") continue;
                if (fileName.Substring(11, fileName.Length - 15) != GlobalVariables.User.Id.ToString()) continue;

                string Number = fileName.Substring(0, 10);
                inFolderWarrantiesNumber.Add(Path.GetFileName(Number));
            }

            foreach (string item2 in systemWarrantiesNumber)
            {
                if (!inFolderWarrantiesNumber.Contains(item2))
                {
                    int index = GlobalVariables.Warranties.FindIndex(x => x.Number == item2);
                    Serialization.SerializeWarranty(GlobalVariables.Warranties[index]);
                }
            }
        }
        
        internal static void Reminders()
        {
            List<int> inFolderRemindersId = new List<int>();
            int[] systemRemindersId = GlobalVariables.Reminders.Select(x => x.Id).ToArray();
            string[] allFiles = Directory.GetFiles(Informations.Directories.Reminders);
            foreach (string item in allFiles)
            {
                string fileName = Path.GetFileName(item);
                if (fileName.Length < 7) continue; // 812_62217.txt idreminder_iduser
                if (fileName.Substring(fileName.Length - 4, 4) != ".txt") continue;

                int indexOfUserId = fileName.IndexOf('_');
                int endIndexOfUserId = fileName.IndexOf('.');

                if (fileName.Substring(indexOfUserId + 1, endIndexOfUserId - indexOfUserId + 1) != GlobalVariables.User.Id.ToString()) continue;

                int id;
                bool result = int.TryParse(fileName.Substring(0, indexOfUserId), out id);
                if (!result) continue;

                inFolderRemindersId.Add(id);
            }

            foreach (int id in systemRemindersId)
            {
                if (!inFolderRemindersId.Contains(id))
                {
                    int index = GlobalVariables.Reminders.FindIndex(x => x.Id == id);
                    Serialization.SerializeReminder(GlobalVariables.Reminders[index]);
                }
            }
        }
    }
}
