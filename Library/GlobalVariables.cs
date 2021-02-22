using System.Collections.Generic;
using GC.Library.Entities;
using GC.Library.Objects;
using GC.Library.Objects.SubObjects.Product;

namespace GC.Library
{
    static internal class GlobalVariables
    {
        //Singles -------------------------------------------------------------------->
        //Primitive
        internal static bool IsWindows10;
        internal static bool UserChangedPasswordRecently = false;
        //Classes
        internal static User User;
        internal static FragileData FragileData;
        internal static SalesRecord SalesRecords = null;
        internal static CompanyInformation CompanyInformation = null;
        internal static Configuration Configuration = null;
        internal static Announce Announce = null;
        internal static MySql.Data.MySqlClient.MySqlConnection MySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(Informations.DataBase.ConnectionString);
        
        //Lists -------------------------------------------------------------------->
        internal static List<Product> Products = new List<Product>();
        internal static List<Lot> Lots = new List<Lot>();
        internal static List<Supplier> Suppliers = new List<Supplier>();
        internal static List<Job> Jobs = new List<Job>();
        internal static List<Costumer> Costumers = new List<Costumer>();
        internal static List<DayRecord> DaysRecords = new List<DayRecord>();
        internal static List<AdminMessage> AdminMessages = new List<AdminMessage>();

        internal static List<Request> Requests = new List<Request>();
        internal static List<Request> OldRequests = new List<Request>();
        internal static List<Request> CancelledRequests = new List<Request>();        

        internal static List<Warranty> Warranties = new List<Warranty>();
        internal static List<Warranty> OldWarranties = new List<Warranty>();

        internal static List<Reminder> Reminders = new List<Reminder>();
        internal static List<Reminder> OldReminders = new List<Reminder>();

        internal static void ClearAll()
        {
            User = null;
            SalesRecords = null;
            CompanyInformation = null;
            Configuration = null;
            Announce = null;

            Products.Clear();
            Lots.Clear();
            Suppliers.Clear();
            Jobs.Clear();
            Costumers.Clear();
            Requests.Clear();
            OldRequests.Clear();
            CancelledRequests.Clear();
            DaysRecords.Clear();
            AdminMessages.Clear();
            Warranties.Clear();
            OldWarranties.Clear();
            Reminders.Clear();
            OldReminders.Clear();
        }
    }
}
