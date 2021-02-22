using GC.Library;
using GC.Library.Checkers;
using GC.Library.Objects;
using GC.Library.Objects.SubObjects.Product;
using GC.Library.Translators;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GC.Forms.Main.Modals.Products
{
    public partial class FRM_CriticalExpiration : Bases.FRM_Default
    {
        internal bool CanOpen = true;

        internal FRM_CriticalExpiration()
        {
            InitializeComponent();

            this.ReadyForm();

            int counter = GlobalVariables.Lots.Count(x => !Structs.IsDateTimeNull(x.ExpiresIn) && DateTime.Compare(DateTime.Now.AddDays(GlobalVariables.Configuration.Days_before_expiration), x.ExpiresIn) == 0 || !Structs.IsDateTimeNull(x.ExpiresIn) && DateTime.Compare(DateTime.Now.AddDays(GlobalVariables.Configuration.Days_before_expiration), x.ExpiresIn) == 1);

            if(counter == 0)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Não existe nenhum produto que está para vencer daqui " + GlobalVariables.Configuration.Days_before_expiration.ToString() + "dia(s). Caso queira mudar a quantidade de dias vá em 'Opções'", 6);
                messOk.Show();
                this.CanOpen = false;
            }
            else
            {
                List<Lot> lots = GlobalVariables.Lots.Where(x => !Structs.IsDateTimeNull(x.ExpiresIn) && DateTime.Compare(DateTime.Now.AddDays(GlobalVariables.Configuration.Days_before_expiration), x.ExpiresIn) == 0 || !Structs.IsDateTimeNull(x.ExpiresIn) && DateTime.Compare(DateTime.Now.AddDays(GlobalVariables.Configuration.Days_before_expiration), x.ExpiresIn) == 1).Select(x => x).ToList();
                lots.Sort((x, y) => DateTime.Compare(x.ExpiresIn, y.ExpiresIn));

                foreach (Lot item in lots)
                {
                    Product product = Product.CloneProduct(item.Id_Product);

                    ListViewItem lvi = lvlProducts.Items.Add(product.Code);
                    lvi.SubItems.Add(product.Description);
                    lvi.SubItems.Add(ObjectToListView.ToStringListView(item.Number));
                    lvi.SubItems.Add(ObjectToListView.ToDateTimeListView(item.ExpiresIn));
                    lvi.SubItems.Add(ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals(item.Quantity));
                    lvi.SubItems.Add(ObjectToListView.ToStringListView(product.Position));
                    lvi.SubItems.Add(ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals(product.PackQuantity));
                    lvi.SubItems.Add(Supplier.GetSupplierName(product.Id_Supplier));

                    if (lvi.Index % 2 != 0)
                    {
                        lvi.BackColor = Color.FromArgb(0, 200, 200, 200);
                    }
                }
            }            
        }
    }
}
