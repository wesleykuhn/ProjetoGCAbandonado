using GC.Library.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GC.Library.Translators;
using GC.Library.Objects.SubObjects.Product;
using GC.Library;

namespace GC.Forms.Main.Modals.Suppliers
{
    public partial class FRM_DetailsSupplier : Bases.FRM_Default
    {
        internal FRM_DetailsSupplier(Supplier supplier)
        {
            InitializeComponent();

            this.ReadyForm();

            lblName.Text = supplier.Name;

            string aux = ObjectToListView.ToStringListView(supplier.Description);
            if(aux == "")
            {
                lblDesc.Text += "Não informada";
            }
            else
            {
                lblDesc.Text += aux;
            }

            aux = ObjectToListView.ToStringListView(supplier.Email);
            if (aux == "")
            {
                lblEmail.Text += "Não informado";
            }
            else
            {
                lblEmail.Text += aux;
            }

            aux = ObjectToListView.ToStringListView(supplier.PhoneNumber);
            if (aux == "")
            {
                lblPhone_number.Text += "Não informado";
            }
            else
            {
                lblPhone_number.Text += aux;
            }

            aux = ObjectToListView.ToStringListView(supplier.CpfCnpj);
            if (aux == "")
            {
                lblCpfCnpj.Text += "Não informado";
            }
            else
            {
                lblCpfCnpj.Text += aux;
            }

            var filtered = GlobalVariables.Products.Where(x => x.Id_Supplier == supplier.Id).Select(x => x);
            lblTotalProducts.Text += filtered.Count() + " produto(s).";
            foreach (Product product in filtered)
            {
                ListViewItem lvi = lvlProducts.Items.Add(product.Code);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, product.Description));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, Product.GetTotalStockQuantityToString(product.Id)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView(product.IdealStock)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(product.Price)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(product.Position)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToIntListView(product.PackQuantity)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_ThreeDecimals(product.Weight)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, Supplier.GetSupplierName(product.Id_Supplier)));

                if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);
            }                  
        }
    }
}
