namespace GC.Library.Objects
{
    internal class FragileData
    {
        internal int RegisteredCostumers;
        internal int RegisteredProducts;
        internal int RegisteredJobs;
        internal int RegisteredSuppliers;
        internal readonly int MaxCostumers;
        internal readonly int MaxProducts;
        internal readonly int MaxJobs;
        internal readonly int MaxSuppliers;
        internal readonly int DayRecordsDaysOnDb;
        internal readonly int WarrantiesDaysOnDb;
        internal readonly int RequestDaysOnDb;
        internal readonly int RemindersDaysOnDb;

        public FragileData(int registeredCostumers, int registeredProducts, int registeredJobs, int registeredSuppliers, int maxCostumers, int maxProducts, int maxJobs, int maxSuppliers, int daysRecordsDaysOnDb, int warrantiesDaysOnDb, int requestDaysOnDb, int remindersDaysOnDb)
        {
            RegisteredCostumers = registeredCostumers;
            RegisteredProducts = registeredProducts;
            RegisteredJobs = registeredJobs;
            RegisteredSuppliers = registeredSuppliers;
            MaxCostumers = maxCostumers;
            MaxProducts = maxProducts;
            MaxJobs = maxJobs;
            MaxSuppliers = maxSuppliers;
            DayRecordsDaysOnDb = daysRecordsDaysOnDb;
            WarrantiesDaysOnDb = warrantiesDaysOnDb;
            RequestDaysOnDb = requestDaysOnDb;
            RemindersDaysOnDb = remindersDaysOnDb;
        }
    }
}
