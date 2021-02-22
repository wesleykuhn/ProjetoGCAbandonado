using System.Collections.Generic;
using System.Linq;

namespace GC.Library.Objects.SubObjects.Request
{
    public class Request_Products
    {
        public int Id_Product { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }

        public Request_Products(){}

        public Request_Products(int id_product, double quantity, double price)
        {
            this.Id_Product = id_product;
            this.Quantity = quantity;
            this.Price = price;
        }

        public static bool AListContains(List<Request_Products> products, string code, string description)
        {
            List<int> filtered = GlobalVariables.Products.Where(x => x.Code == code && x.Description == description).Select(x => x.Id).ToList();

            foreach (Request_Products item in products)
            {
                if (item.Id_Product == filtered[0]) return true;
            }

            return false;
        }
    }
}
