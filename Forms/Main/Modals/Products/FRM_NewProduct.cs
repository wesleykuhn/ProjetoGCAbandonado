using GC.Library.Objects;
using GC.Library.Translators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using GC.Library.Database;
using System.Windows.Forms;
using GC.Library.Objects.SubObjects.Product;
using GC.Library;

namespace GC.Forms.Main.Modals.Products
{
    public partial class FRM_NewProduct : Bases.FRM_Default
    {
        List<Product> AddedProducts = new List<Product>();
        int ListViewIndex = -1;

        public FRM_NewProduct()
        {
            InitializeComponent();

            this.ReadyForm();

            this.ReplaceCloseEvent(new EventHandler(CloseForm));

            cbxSupplier.Items.Add("Nenhum");
            foreach (Supplier item in GlobalVariables.Suppliers)
            {
                cbxSupplier.Items.Add(item.Name);
            }
            cbxSupplier.SelectedIndex = 0;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            GC.GlobalModals.FRM_Confirmation confirmation = null;
            if (this.AddedProducts.Count() == 0) confirmation = new GC.GlobalModals.FRM_Confirmation("Deseja realmente cancelar?", 1);
            else if (this.AddedProducts.Count() > 0) confirmation = new GC.GlobalModals.FRM_Confirmation("Você tem " + this.AddedProducts.Count() + " produtos não salvo(s)! Deseja realmente cancelar?", 1);
            confirmation.ShowDialog();
            if (confirmation.Result)
            {
                Close();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
            ml.Show();

            int addedCount = this.AddedProducts.Count();

            MySqlNonQuery.CreateProducts(this.AddedProducts);

            MySqlNonQuery.IncrementUserRegisteredProducts(this.AddedProducts.Count);

            foreach (Product item in this.AddedProducts)
            {
                int id = Convert.ToInt32(MySqlReader.ReadOnlyOneColumn("product", "idproduct", new string[] { "code", "description", "id_user" }, new string[] { item.Code, item.Description, GlobalVariables.User.Id.ToString() }, new string[] { "AND", "AND" }, new bool[] { false, false, false }));

                item.Id = id;
            }

            foreach (Product item in this.AddedProducts)
            {
                GlobalVariables.Products.Add(item);
            }

            ml.CustomClose();

            Close();
        }

        private void ckbAutoCode_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAutoCode.Checked)
            {
                txtCode.Enabled = false;
            }
            else
            {
                txtCode.Enabled = true;
            }
            txtCode_TextChanged(ckbAutoCode, new EventArgs());
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            string code = txtCode.Text.TrimStart(), desc = txtDesc.Text.TrimStart();
            code = code.TrimEnd();
            desc = desc.TrimEnd();
            if (code.Length > 0 && desc.Length > 0)
            {
                btnCreate.Enabled = true;
            }
            else if (ckbAutoCode.Checked && desc.Length > 0)
            {
                btnCreate.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = false;
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            txtCode_TextChanged(txtDesc, new EventArgs());
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (nudPrice.Value <= 0)
            {
                GC.GlobalModals.FRM_MessageAndOK messOk = new GC.GlobalModals.FRM_MessageAndOK("Você não pode deixar o produto sem preço!", 1);
                messOk.Show();
                return;
            }

            bool success = true;

            // Handling with the 0 and "". Wich are null values ---------------------------------------------
            string position = FieldsToObject.ToString(txtPos.Text), desc = FieldsToObject.ToString(txtDesc.Text);
            double ideal_stock = FieldsToObject.ToDouble(Convert.ToDouble(nudIdeal_stock.Value)), price = FieldsToObject.ToDouble(Convert.ToDouble(nudPrice.Value)), weight = FieldsToObject.ToDouble(Convert.ToDouble(nudWeight.Value));
            int pack_qtt = FieldsToObject.ToInt(Convert.ToInt32(nudPackQuant.Value));
            // -------------------------------------------------------------------------------

            Product newProduct = new Product(0, "NoCode", desc, ideal_stock, price, position, pack_qtt, weight, Supplier.GetSupplierId(cbxSupplier.SelectedItem.ToString()));
            if (ckbAutoCode.Checked)
            {
                int counter = 1;
                bool alreadyExists = false, breaker = false, ignore = false;
                while (!breaker)
                {
                    alreadyExists = false;
                    ignore = false;
                    foreach (Product item in GlobalVariables.Products)
                    {
                        if (item.Code == counter.ToString())
                        {
                            alreadyExists = true;
                            ignore = true;
                            break;
                        }
                    }
                    if (!ignore)
                    {
                        foreach (Product item in this.AddedProducts)
                        {
                            if (item.Code == counter.ToString())
                            {
                                alreadyExists = true;
                                break;
                            }
                        }
                    }
                    if (alreadyExists) counter++;
                    else breaker = true;
                }
                newProduct.Code = counter.ToString();
            }
            else
            {
                string aux = txtCode.Text.TrimStart();
                aux = aux.TrimEnd();
                newProduct.Code = aux;
            }
            foreach (Product item in GlobalVariables.Products)
            {
                if (newProduct.Code == item.Code && newProduct.Description == item.Description)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Já existe um produto salvo com o esse mesmo código e descrição! Por favor, verifique e insira outro(s).", 1);
                    messOk.Show();

                    success = false;
                    break;
                }
            }
            if (success)
            {
                foreach (Product item in this.AddedProducts)
                {
                    if (newProduct.Code == item.Code && newProduct.Description == item.Description)
                    {
                        GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Um dos produtos cadastrados agora pouco por você já possui esse mesmo código e descrição! Por favor, verifique e insira outro(s).", 1);
                        messOk.Show();

                        success = false;
                        break;
                    }
                }
            }
            if (success)
            {
                this.AddedProducts.Add(newProduct);
                ListViewItem lvi = lvlAddedProducts.Items.Add(newProduct.Code);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, newProduct.Description));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView(newProduct.IdealStock)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(newProduct.Price)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(newProduct.Position)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToIntListView(newProduct.PackQuantity)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_ThreeDecimals(newProduct.Weight)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, Supplier.GetSupplierName(newProduct.Id_Supplier)));

                if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);

                txtCode.Text = String.Empty;
                txtDesc.Text = String.Empty;
                txtPos.Text = String.Empty;
                nudIdeal_stock.Value = 0;
                nudPackQuant.Value = 0;
                nudPrice.Value = 0;
                nudWeight.Value = 0;
                cbxSupplier.SelectedIndex = 0;
            }
            EnableOrDisableFinishButton();
            if (ckbAutoCode.Checked)
            {
                txtDesc.Focus();
            }
            else
            {
                txtCode.Focus();
            }
        }

        private void EnableOrDisableFinishButton()
        {
            if (this.AddedProducts.Count() > 0) btnAdd.Enabled = true;
            else btnAdd.Enabled = false;
        }

        private void lvlAddedProducts_DoubleClick(object sender, EventArgs e)
        {
            this.ListViewIndex = lvlAddedProducts.SelectedIndices[0];
            if (this.ListViewIndex >= 0)
            {
                this.AddedProducts.RemoveAt(this.ListViewIndex);
                lvlAddedProducts.Items.RemoveAt(this.ListViewIndex);
            }
            this.ListViewIndex = -1;
            EnableOrDisableFinishButton();
        }
    }
}
