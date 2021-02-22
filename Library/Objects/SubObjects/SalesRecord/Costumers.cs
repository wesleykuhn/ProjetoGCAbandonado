using GC.Library.Entities;

namespace GC.Library.Objects.SubObjects.SalesRecord
{
    internal class Costumers
    { 
        internal int Id_Costumer { get; set; }
        internal int ShoppingCounter { get; set; }
        internal double ShoppingAmount { get; set; }  
        
        internal Costumers(int id_costumer)
        {
            this.Id_Costumer = id_costumer;
            this.ShoppingCounter = 0;
            this.ShoppingAmount = 0;
        }

        internal string GetCostumerName()
        {
            return Costumer.GetCostumerName(this.Id_Costumer);
        }

        internal string GetCostumerPhoneNumber()
        {
            Costumer costumer = Costumer.CloneCostumer(this.Id_Costumer);
            return costumer.PhoneNumber;
        }

        internal string GetCostumerAddress()
        {
            Costumer costumer = Costumer.CloneCostumer(this.Id_Costumer);
            return costumer.Street + ", " + costumer.Number;
        }

        internal string GetCostumerEmail()
        {
            Costumer costumer = Costumer.CloneCostumer(this.Id_Costumer);
            return costumer.Email;
        }
    }
}
