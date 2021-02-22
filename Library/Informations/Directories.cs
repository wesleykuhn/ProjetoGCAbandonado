using System;

namespace GC.Library.Informations
{
    internal static class Directories
    {
        // .txt Files Directory
        internal readonly static string LastLoginSettings = Environment.CurrentDirectory + @"\Complement.cfg";
        internal readonly static string UserToken = Environment.CurrentDirectory + @"\Token.cfg";
        internal readonly static string ErrorsLogs = Environment.CurrentDirectory + @"\Erros.txt";        
        internal readonly static string LotsConsumption = Environment.CurrentDirectory + @"\LotsConsumption\";
        internal readonly static string DaysRecords = Environment.CurrentDirectory + @"\DaysRecords\";
        internal readonly static string Requests = Environment.CurrentDirectory + @"\Orders\";
        internal readonly static string Warranties = Environment.CurrentDirectory + @"\Warranties\";
        internal readonly static string Reminders = Environment.CurrentDirectory + @"\Reminders\";

        // .pdf Files Directory
        internal readonly static string Documents = Environment.CurrentDirectory + @"\Documentos\";
        internal static string UserDocuments;
        internal static string PdfWarranties;
        internal static string PdfRequests;

        internal static void GeneratePdfUserDocumentsDirectories()
        {
            UserDocuments = Documents + GlobalVariables.User.GetFirstWordAndSurname() + @"\";
            PdfWarranties = Documents + GlobalVariables.User.GetFirstWordAndSurname() + @"\Garantias\";
            PdfRequests = Documents + GlobalVariables.User.GetFirstWordAndSurname() + @"\Pedidos\";
        }
    }
}
