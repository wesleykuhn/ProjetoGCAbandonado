using System.IO;

namespace GC.Library.Folders
{
    internal static class StartupCheckIn
    {
        internal static void CheckFoldersBeforeLoad()
        {
            OrdersFolder();
            LotsConsumptionFolder();
            DailySalesFolder();
            WarrantiesFolder();
            DocumentsFolder();
            RemindersFolder();
        }

        internal static void CheckFoldersAfterLoad()
        {
            //After get the user data from db we can assembly the user documents directory
            Informations.Directories.GeneratePdfUserDocumentsDirectories();

            UserDocumentsFolder();
            PdfRequestsFolder();
            PdfWarrantiesFolder();
        }

        private static void RemindersFolder()
        {
            if (!Directory.Exists(Informations.Directories.Reminders))
            {
                Directory.CreateDirectory(Informations.Directories.Reminders);
            }
        }

        private static void OrdersFolder()
        {
            if (!Directory.Exists(Informations.Directories.Requests))
            {
                Directory.CreateDirectory(Informations.Directories.Requests);
            }
        }

        private static void LotsConsumptionFolder()
        {
            if (!Directory.Exists(Informations.Directories.LotsConsumption))
            {
                Directory.CreateDirectory(Informations.Directories.LotsConsumption);
            }
        }

        private static void DailySalesFolder()
        {
            if (!Directory.Exists(Informations.Directories.DaysRecords))
            {
                Directory.CreateDirectory(Informations.Directories.DaysRecords);
            }
        }

        private static void WarrantiesFolder()
        {
            if (!Directory.Exists(Informations.Directories.Warranties))
            {
                Directory.CreateDirectory(Informations.Directories.Warranties);
            }
        }

        private static void DocumentsFolder()
        {
            if(!Directory.Exists(Informations.Directories.Documents))
            {
                Directory.CreateDirectory(Informations.Directories.Documents);
            }  
        }

        private static void UserDocumentsFolder()
        {
            if (!Directory.Exists(Informations.Directories.UserDocuments))
            {
                Directory.CreateDirectory(Informations.Directories.UserDocuments);
            }
        }

        private static void PdfWarrantiesFolder()
        {
            if (!Directory.Exists(Informations.Directories.PdfRequests))
            {
                Directory.CreateDirectory(Informations.Directories.PdfRequests);
            }
        }

        private static void PdfRequestsFolder()
        {
            if (!Directory.Exists(Informations.Directories.PdfWarranties))
            {
                Directory.CreateDirectory(Informations.Directories.PdfWarranties);
            }
        }
    }
}
