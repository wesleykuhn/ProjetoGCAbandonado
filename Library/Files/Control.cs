using System.IO;

namespace GC.Library.Files
{
    internal static class Control
    {
        internal static void DeleteFile(string path)
        {
            File.Delete(path);
        }

        internal static void DeleteRequestFile(string requestNumber)
        {
            DeleteFile(Informations.Directories.Requests + requestNumber + "_" + GlobalVariables.User.Id.ToString() + ".txt");
        }

        internal static void DeleteWarrantyFile(string warrantyNumber)
        {
            DeleteFile(Informations.Directories.Warranties + warrantyNumber + "_" + GlobalVariables.User.Id.ToString() + ".txt");
        }

        internal static void DeleteReminderFile(int reminderId)
        {
            DeleteFile(Informations.Directories.Reminders + reminderId.ToString() + "_" + GlobalVariables.User.Id.ToString() + ".txt");
        }

        internal static void DeleteLotsConsumptionFile(string requestNumber)
        {
            DeleteFile(Informations.Directories.LotsConsumption + requestNumber + "_" + GlobalVariables.User.Id.ToString() + ".txt");
        }
    }
}
