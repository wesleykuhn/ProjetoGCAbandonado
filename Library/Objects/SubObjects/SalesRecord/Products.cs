namespace GC.Library.Objects.SubObjects.SalesRecord
{
    internal class Products
    {
        internal int Id_Product { get; set; }
        internal int SalesCounter { get; set; }
        internal double SalesAmount { get; set; }

        public Products(int id_product)
        {
            this.Id_Product = id_product;
            this.SalesCounter = 0;
            this.SalesAmount = 0;
        }

        internal string GetProductCode()
        {
            if(this.Id_Product == -1)
            {
                return null;
            }
            Objects.Product product = Objects.Product.CloneProduct(this.Id_Product);
            return product.Code;
        }

        internal string GetProductDescription()
        {
            if (this.Id_Product == -1)
            {
                return null;
            }
            Objects.Product product = Objects.Product.CloneProduct(this.Id_Product);
            return product.Description;
        }
    }
}
