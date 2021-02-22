using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GC.Library.Database;
using GC.Library.Objects;
using GC.GlobalModals;
using GC.Library.Translators;
using GC.Library;
using GC.Library.Objects.SubObjects.Product;

namespace GC.Forms.Main.Controls
{
    public partial class USC_Products : UserControl
    {
        internal event EventHandler ProductAlteredDeleted;

        private Modals.Products.FRM_SearchOptions FrmSO = new Modals.Products.FRM_SearchOptions();

        int ListViewIndex = -1;

        public USC_Products()
        {
            InitializeComponent();

            if (!Library.Errors.Care.AntiInvalidInstance)
            {
                UpdateStats();
            }
        }

        internal void UpdateStats()
        {            
            lblProductsCount.Text = "Total de Produtos Cadastrados: " + GlobalVariables.FragileData.RegisteredProducts.ToString() + "/" + GlobalVariables.FragileData.MaxProducts.ToString();
            lvlProducts.Items.Clear();
            AddAllProductsToListView();
        }

        internal void AddAllProductsToListView()
        {
            foreach (Product item in GlobalVariables.Products)
            {
                ProductToListView(item);
            }
        }

        internal void ProductToListView(Product product)
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

            double aux = Product.GetTotalStockQuantity(product.Id);
            if ((aux < product.IdealStock && GlobalVariables.Configuration.Enable_critical_stock_system) || (aux == 0 && GlobalVariables.Configuration.Enable_critical_stock_system))
            {
                lvi.BackColor = Color.FromArgb(0, 250, 148, 134);
            }
            else
            {
                if (lvi.Index % 2 != 0)
                {
                    lvi.BackColor = Color.FromArgb(0, 200, 200, 200);
                }
            }             
        }

        private void btnSearchOptions_Click(object sender, EventArgs e)
        {
            this.FrmSO.ShowDialog();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            if(GlobalVariables.FragileData.RegisteredProducts >= GlobalVariables.FragileData.MaxProducts)
            {
                FRM_MessageAndOK messOk = new FRM_MessageAndOK("Infelizmente você já atingiu o seu limite de " + GlobalVariables.FragileData.MaxProducts.ToString() + " produtos cadastrados. Você não poderá cadastrar mais produtos. Contate a administração e mude seu plano para continuar a cadastrar seus produtos.", 1);
                messOk.Show();

                return;
            }

            Modals.Products.FRM_NewProduct frmM_NP = new Modals.Products.FRM_NewProduct();
            frmM_NP.ShowDialog();

            UpdateStats();
        }

        private void btnAddProductStock_Click(object sender, EventArgs e)
        {
            if (this.ListViewIndex >= 0)
            {
                string code = lvlProducts.Items[this.ListViewIndex].Text;
                string desc = lvlProducts.Items[this.ListViewIndex].SubItems[1].Text;

                var filtered = GlobalVariables.Products.Where(x => x.Code == code && x.Description == desc).Select(x => x);

                Product toBeEdited = null;
                foreach (Product item in filtered)
                {
                    toBeEdited = item;
                }

                Modals.Products.FRM_EditStock editStock = new Modals.Products.FRM_EditStock(toBeEdited);
                editStock.ShowDialog();
                if (GlobalVariables.Configuration.Enable_critical_stock_system)
                {
                    if ((Product.GetTotalStockQuantity(toBeEdited.Id) < toBeEdited.IdealStock && GlobalVariables.Configuration.Enable_critical_stock_system) || (Product.GetTotalStockQuantity(toBeEdited.Id) == 0 && GlobalVariables.Configuration.Enable_critical_stock_system))
                    {
                        FRM_MessageAndOK messOK = new FRM_MessageAndOK("O produto '" + toBeEdited.Code + " - " + toBeEdited.Description + "' cujo estoque você editou agora está com o estoque baixo!", 1);
                        messOK.Show();
                    }
                }                
            }

            this.ListViewIndex = -1;
            btnAlter.Enabled = false;
            btnDelete.Enabled = false;
            btnProductStock.Enabled = false;

            UpdateStats();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.ListViewIndex >= 0)
            {
                string code = lvlProducts.Items[this.ListViewIndex].Text;
                string desc = lvlProducts.Items[this.ListViewIndex].SubItems[1].Text;

                var filtered = GlobalVariables.Products.Where(x => x.Code == code && x.Description == desc).Select(x => x);

                Product toBeUpdated = null;
                foreach (Product item in filtered)
                {
                    toBeUpdated = item;
                }

                Modals.Products.FRM_AlterProduct alterProduct = new Modals.Products.FRM_AlterProduct(toBeUpdated);
                alterProduct.ShowDialog();

                if (alterProduct.Alterations) this.ProductAlteredDeleted(this, new EventArgs());
            }

            this.ListViewIndex = -1;
            btnAlter.Enabled = false;
            btnDelete.Enabled = false;
            btnProductStock.Enabled = false;

            UpdateStats();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();

            FRM_Confirmation frmExitConfirmantion = new FRM_Confirmation("Atenção! Este produto será excluído permanentemente assim como todos os lotes do mesmo. Além disso, todos os pedidos e garantias que contém este produto ficarão com o preço/validade original, mas este produto não aparecerá mais naquele pedido/garantia. Deseja realmente continuar?", 1);
            frmExitConfirmantion.ShowDialog();
            if (frmExitConfirmantion.Result)
            {
                if (this.ListViewIndex >= 0)
                {
                    ml.Show();

                    string code = lvlProducts.Items[this.ListViewIndex].Text;
                    string desc = lvlProducts.Items[this.ListViewIndex].SubItems[1].Text;
                    var filtered = GlobalVariables.Products.Where(x => x.Code == code && x.Description == desc).Select(x => x);
                    Product toBeDeleted = null;
                    foreach (Product item in filtered)
                    {
                        toBeDeleted = item;
                    }

                    
                    MySqlNonQuery.DeleteProductById(toBeDeleted.Id);

                    MySqlNonQuery.IncrementUserRegisteredProducts(-1);

                    GlobalVariables.Products.Remove(toBeDeleted);
                    lvlProducts.Items.RemoveAt(this.ListViewIndex);
                }

                UpdateStats();
            }

            this.ListViewIndex = -1;

            btnDelete.Enabled = false;
            btnAlter.Enabled = false;
            btnProductStock.Enabled = false;

            ml.CustomClose();
        }

        private void LvlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if(lvlProducts.SelectedItems.Count != 0)
            {
                this.ListViewIndex = lvlProducts.SelectedIndices[0];
                if (this.ListViewIndex >= 0)
                {
                    btnDelete.Enabled = true;
                    btnAlter.Enabled = true;
                    btnProductStock.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                    btnAlter.Enabled = false;
                    btnProductStock.Enabled = false;
                }
            }            
        }

        private void BtnCriticalStock_Click(object sender, EventArgs e)
        {
            Modals.Products.FRM_CriticalStock criticalStock = new Modals.Products.FRM_CriticalStock();
            criticalStock.ShowDialog();
        }

        private void btnExpiration_Click(object sender, EventArgs e)
        {
            Modals.Products.FRM_CriticalExpiration expiration = new Modals.Products.FRM_CriticalExpiration();            
            if (expiration.CanOpen)
            {
                expiration.ShowDialog();
            }
        }

        private void lvlProducts_DoubleClick(object sender, EventArgs e)
        {
            if (this.ListViewIndex >= 0)
            {
                string code = lvlProducts.Items[this.ListViewIndex].Text;
                string desc = lvlProducts.Items[this.ListViewIndex].SubItems[1].Text;
                var filtered = GlobalVariables.Products.Where(x => x.Code == code && x.Description == desc).Select(x => x);
                Product product = null;
                foreach (Product item in filtered)
                {
                    product = item;
                }
                Modals.Products.frmModal_Details details = new Modals.Products.frmModal_Details(product);
                details.ShowDialog();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lvlProducts.Items.Clear();

                List<Product> productsFound = new List<Product>();

                if (txtSearch.Text.Length <= 0)
                {
                    AddAllProductsToListView();
                }
                else
                {
                    if (this.FrmSO.ckbCode.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Products.Where(x => x.Code != null && x.Code.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Product item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Product subItem in productsFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) productsFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbDesc.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Products.Where(x => x.Description != null && x.Description.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Product item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Product subItem in productsFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) productsFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbPrice.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Products.Where(x => x.Price > 0 && x.Price.ToString("n2").Contains(txtSearch.Text)).Select(x => x);
                        foreach (Product item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Product subItem in productsFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) productsFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbPos.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Products.Where(x => x.Position != null && x.Position.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Product item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Product subItem in productsFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) productsFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbPackQuant.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Products.Where(x => x.PackQuantity > 0 && x.PackQuantity.ToString().Contains(txtSearch.Text)).Select(x => x);
                        foreach (Product item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Product subItem in productsFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) productsFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbWeight.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Products.Where(x => x.Weight > 0 && x.Weight.ToString("n3").Contains(txtSearch.Text)).Select(x => x);
                        foreach (Product item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Product subItem in productsFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) productsFound.Add(item);
                        }
                    }
                    if (productsFound.Count() <= 0)
                    {
                        ListViewItem lvi = lvlProducts.Items.Add("Nenhum resultado...");
                    }
                    else
                    {
                        foreach (Product item in productsFound)
                        {
                            ProductToListView(item);
                        }
                    }
                }
            }
        }
    }
}
