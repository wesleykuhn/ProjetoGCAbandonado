using System;

namespace GC.Library.Objects
{
    public class Warranty
    {
        public int Id { get; set; }
        public string Number { get; set; }
        //0-Product | 1-Job
        public bool Type { get; set; }
        public DateTime StartedIn { get; set; }
        public DateTime ExpiresIn { get; set; }
        public string Observations { get; set; }
        public int Id_Item { get; set; }
        public int Id_Costumer { get; set; }
        public int Id_User { get; set; }

        public Warranty(){}

        public Warranty(int id, string number, bool type, DateTime startedIn, DateTime expiresIn, string observations, int id_Item, int id_Costumer, int id_User)
        {
            Id = id;
            Number = number;
            Type = type;
            StartedIn = startedIn;
            ExpiresIn = expiresIn;
            Observations = observations;
            Id_Item = id_Item;
            Id_Costumer = id_Costumer;
            Id_User = id_User;
        }

        internal int FindId(string number)
        {
            int index = GlobalVariables.Warranties.FindIndex(x => x.Number == number);
            return GlobalVariables.Warranties[index].Id;
        }

        internal static Warranty CloneWarranty(int id)
        {
            int index = GlobalVariables.Warranties.FindIndex(x => x.Id == id);
            return GlobalVariables.Warranties[index];
        }

        internal static Warranty CloneWarranty(string number)
        {
            int index = GlobalVariables.Warranties.FindIndex(x => x.Number == number);
            return GlobalVariables.Warranties[index];
        }

        internal static bool WarrantyIsOld(DateTime started_in)
        {
            DateTime old = DateTime.Now.AddDays(GlobalVariables.FragileData.WarrantiesDaysOnDb * -1);
            if (started_in.CompareTo(old) <= 0) return true;
            else return false;
        }
    }
}
