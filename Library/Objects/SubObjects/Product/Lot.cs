using GC.Library.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GC.Library.Objects.SubObjects.Product
{
    public class Lot
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public double Quantity { get; set; }
        public DateTime Entry { get; set; }
        public DateTime ExpiresIn { get; set; }
        public int Id_Product { get; set; }

        public Lot(){}

        public Lot(int id, string number, double quantity, DateTime entry, DateTime expires_in, int id_product)
        {
            this.Id = id;
            this.Number = number;
            this.Quantity = quantity;
            this.Entry = entry;

            if(expires_in.Day == 1 && expires_in.Month == 1 && expires_in.Year == 1)
            {
                this.ExpiresIn = new DateTime(1, 1, 1, 0, 0, 0);
            }
            else
            {
                this.ExpiresIn = expires_in;
            }
            
            this.Id_Product = id_product;
        }

        internal bool IsEqual(Lot lot)
        {
            if (this.Number == lot.Number && this.Quantity == lot.Quantity && DateTime.Compare(this.Entry, lot.Entry) == 0 && DateTime.Compare(this.ExpiresIn, lot.ExpiresIn) == 0) return true;
            else return false;
        }

        internal static int GetLotId(string number, double quantity, DateTime entry)
        {
            int id = -1;

            var filtered = GlobalVariables.Lots.Where(x => x.Number == number && x.Quantity == quantity && DateTime.Compare(x.Entry, entry) == 0).Select(x => x.Id);
            foreach (var item in filtered)
            {
                id = item;
            }

            return id;
        }    
        
        internal static Lot CloneLotById(int id)
        {
            var filtered = GlobalVariables.Lots.Where(x => x.Id == id).Select(x => x);
            foreach (var item in filtered)
            {
                return item;
            }

            return null;
        }

        internal static void JoinSameLots()
        {
            List<int> removeIds = new List<int>();
            List<Lot> addLots = new List<Lot>();

            foreach (Objects.Product item in GlobalVariables.Products)
            {
                List<Lot> filtered = GlobalVariables.Lots.Where(x => x.Id_Product == item.Id).Select(x => x).ToList();
                foreach (var item2 in filtered)
                {
                    if (removeIds.Contains(item2.Id))
                    {
                        continue;
                    }

                    var filtered2 = filtered.Where(x => x.Number == item2.Number && x.Entry == item2.Entry && x.ExpiresIn == item2.ExpiresIn).Select(x => x);
                    if(filtered2.Count() > 1)
                    {                      
                        double newQuantity = 0;
                        foreach (var item3 in filtered2)
                        {
                            newQuantity += item3.Quantity;
                            
                            removeIds.Add(item3.Id);                           
                        }

                        Lot lot = new Lot(-1, item2.Number, newQuantity, item2.Entry, item2.ExpiresIn, item2.Id_Product);                       
                        lot.Id = MySqlNonQuery.CreateLot(lot);
                        addLots.Add(lot);
                    }                    
                }           
            }

            foreach (int id in removeIds)
            {
                GlobalVariables.Lots.RemoveAll(x => x.Id == id);

                MySqlNonQuery.DeleteLotById(id);
            }

            GlobalVariables.Lots.AddRange(addLots);
        }
    }
}
