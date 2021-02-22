using GC.Library;
using GC.Library.Files;
using GC.Library.Objects;
using GC.Library.Objects.SubObjects.Product;
using GC.Library.Relations;
using GC.Library.Translators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GC.Forms.Main.Modals.Stats
{
    public partial class FRM_ProductsConsumption : Bases.FRM_Full
    {
        private List<Id_Double> idsQuantity = new List<Id_Double>();

        public FRM_ProductsConsumption()
        {
            InitializeComponent();

            this.ReadyForm();

            this.UpdateList(false);
        }

        private void UpdateList(bool onlyFinishedRequests)
        {
            LVL_Products.Items.Clear();
            this.idsQuantity.Clear();

            //TO prevent the division by 0 in the daily consumption
            bool antiZeroDiv = false;

            //To calculate the average daily consumption
            TimeSpan days;
            int daysExisting = 0;

            if (DateTime.Now.ToString("dd/MM/yyyy") == GlobalVariables.User.Joined.ToString("dd/MM/yyyy")) antiZeroDiv = true;
            else
            {
                days = DateTime.Now.Subtract(GlobalVariables.User.Joined);
                daysExisting = (int)days.TotalDays;
            }

            if (GlobalVariables.OldRequests.Count < 1)
            {
                SeekFor.OldRequest();
            }

            //First we assembly the list
            foreach (Product product in GlobalVariables.Products)
            {
                this.idsQuantity.Add(new Id_Double(product.Id));
            }

            //Let's populate the list's counter
            //Old requests products quantity counter
            foreach (Request request in GlobalVariables.OldRequests)
            {
                if (onlyFinishedRequests)
                {
                    if (request.Status != 'F') continue;
                }

                foreach (Library.Objects.SubObjects.Request.Request_Products req_product in request.Products)
                {                   
                    int index = this.idsQuantity.FindIndex(x => x.Id == req_product.Id_Product);

                    if (index < 0) continue;

                    this.idsQuantity[index].Double += req_product.Quantity;
                }
            }

            //Requests products quantity counter
            foreach (Request request in GlobalVariables.Requests)
            {
                if (onlyFinishedRequests)
                {
                    if (request.Status != 'F') continue;
                }

                foreach (Library.Objects.SubObjects.Request.Request_Products req_product in request.Products)
                {
                    int index = this.idsQuantity.FindIndex(x => x.Id == req_product.Id_Product);

                    if (index < 0) continue;

                    this.idsQuantity[index].Double += req_product.Quantity;
                }
            }

            IEnumerable<Id_Double> ordered = this.idsQuantity.OrderByDescending(x => x.Double);

            // List to ListViewItem
            foreach (Id_Double relation in ordered)
            {
                Product product = Product.CloneProduct(relation.Id);

                ListViewItem lvi = LVL_Products.Items.Add(product.Code);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, product.Description));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals(relation.Double)));

                if(antiZeroDiv) lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, "N/A"));
                else lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals((double)relation.Double / daysExisting)));

                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, Product.GetTotalStockQuantityToString(product.Id)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView(product.IdealStock)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(product.Price)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(product.Position)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToIntListView(product.PackQuantity)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_ThreeDecimals(product.Weight)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, Supplier.GetSupplierName(product.Id_Supplier)));

                if (lvi.Index % 2 != 0)
                {
                    lvi.BackColor = Color.FromArgb(0, 200, 200, 200);
                }
            }
        }

        private void CBX_OnlyFinished_CheckedChanged(object sender, System.EventArgs e)
        {
            if (CBX_OnlyFinished.Checked) this.UpdateList(true);
            else this.UpdateList(false);
        }
    }
}
