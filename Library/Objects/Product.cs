using GC.Library.Translators;
using System.Collections.Generic;
using System.Linq;

namespace GC.Library.Objects
{
    internal class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public double IdealStock { get; set; }
        public double Price { get; set; }
        public string Position { get; set; }
        public int PackQuantity { get; set; }
        public double Weight { get; set; }
        public int Id_Supplier { get; set; }

        public Product(int id, string code, string description, double ideal_stock, double price, string position, int pack_quantity, double weight_kg, int id_supplier)
        {
            this.Id = id;
            this.Code = code;
            this.Description = description;
            this.IdealStock = ideal_stock;
            this.Price = price;
            this.Position = position;
            this.PackQuantity = pack_quantity;
            this.Weight = weight_kg;
            this.Id_Supplier = id_supplier;
        }

        internal bool IsEqualTo(Product product)
        {
            if (product.Code == this.Code && product.Description == this.Description) return true;
            else return false;
        }

        internal static int GetProductId(string code, string description)
        {
            List<int> filtered = GlobalVariables.Products.Where(x => x.Code == code && x.Description == description).Select(x => x.Id).ToList();
            return filtered[0];
        }

        internal static Product CloneProduct(string code, string description)
        {
            if ((code == null || code == "") && (description == null || description == "")) return null;

            int index = GlobalVariables.Products.FindIndex(x => x.Code == code && x.Description == description);

            if (index < 0) return null;
            else return GlobalVariables.Products[index];
        }

        internal static Product CloneProduct(int id)
        {
            if (id == -1) return null;

            int index = GlobalVariables.Products.FindIndex(x => x.Id == id);

            if (index < 0) return null;
            else return GlobalVariables.Products[index];
        }

        internal static double GetTotalStockQuantity(int productId)
        {
            double stock = 0;

            var filtered = GlobalVariables.Lots.Where(x => x.Id_Product == productId).Select(x => x.Quantity);
            foreach (double item in filtered)
            {
                stock += item;
            }

            return stock;
        }

        internal static string GetTotalStockQuantityToString(int productId)
        {
            double stock = 0;

            var filtered = GlobalVariables.Lots.Where(x => x.Id_Product == productId).Select(x => x.Quantity);
            foreach (double item in filtered)
            {
                stock += item;
            }

            return ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals(stock);
        }
    }
}
