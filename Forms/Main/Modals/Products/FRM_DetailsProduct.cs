using GC.Library.Objects;
using GC.Library.Translators;
using GC.Library.Objects.SubObjects.Product;
using GC.Library.Checkers;

namespace GC.Forms.Main.Modals.Products
{
    public partial class frmModal_Details : Bases.FRM_Default
    {
        internal frmModal_Details(Product product)
        {
            InitializeComponent();

            this.ReadyForm();

            lblCode.Text += product.Code;
            lblDesc.Text += product.Description;

            string aux = ObjectToListView.ToDoubleListView_TwoDecimals(product.Price);
            if (aux == "") lblPrice.Text = "Preço: Não informado";
            else lblPrice.Text += aux;

            if (product.Position == "") lblPosition.Text += "Não informada";
            else lblPosition.Text += product.Position;

            aux = ObjectToListView.ToDoubleListView_ThreeDecimals(product.Weight);
            if (aux == "") lblWeight.Text = "Peso: Não informado";
            else lblWeight.Text += aux + " kg";

            lblSupplier.Text += Supplier.GetSupplierName(product.Id_Supplier);

            aux = ObjectToListView.ToIntListView(product.PackQuantity);
            if (aux == "") lblPackQtt.Text += "Não informada";
            else lblPackQtt.Text += aux;

            double stock = Product.GetTotalStockQuantity(product.Id);            
            if (Variables.IsValueDouble(stock))
            {
                lblStock.Text += stock.ToString("n3") + " kg";
            }
            else
            {
                lblStock.Text += stock.ToString() + " Unidades";
            }

            aux = ObjectToListView.ToDoubleListView(product.IdealStock);
            if (aux == "") lblIdeal_stock.Text += "Não informado";
            else lblIdeal_stock.Text += aux;
        }
    }
}
