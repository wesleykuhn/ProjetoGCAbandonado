using GC.Library;
using GC.Library.Objects;
using GC.Library.Objects.SubObjects.Product;
using GC.Library.Objects.SubObjects.Request;
using GC.Library.Translators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GC.Forms.Main.Modals.Requests.SubModals.NewRequest
{    
    public partial class FRM_ProductsList : Bases.FRM_Default
    {
        //Onwer drawn fix ---------------------------
        [DllImport("user32")]
        private static extern bool SendMessage(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam);
        //-------------------------------------------

        Products.FRM_SearchOptions FrmSO = new Products.FRM_SearchOptions();
        
        internal List<Request_Products> SelectedProducts = new List<Request_Products>();
        private bool IsAlterRequest = false;

        //Anti-useless event call
        bool EventJumper = false;

        internal FRM_ProductsList(List<Request_Products> alreadySelectedProducts, bool IsAlterRequest)
        {
            InitializeComponent();

            this.ReadyForm();

            this.ReplaceCloseEvent(new EventHandler(CloseForm));

            this.SelectedProducts = alreadySelectedProducts;

            if (IsAlterRequest)
            {
                this.Text = "GC - Pedidos > Alteração De Pedido > Selecionando Produtos";

                this.IsAlterRequest = IsAlterRequest;
            }

            

            UpdateStats();

            this.EventJumper = false;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.SelectedProducts.Clear();

            this.Close();
        }

        internal void UpdateStats()
        {
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
            bool jump = false;

            ListViewItem lvi = lvlProducts.Items.Add("");
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ""));

            foreach (Request_Products item in SelectedProducts)
            {
                if(item.Id_Product == product.Id)
                {                    
                    UpdateQuantityText(lvi.Index, item.Quantity, item.Id_Product);

                    lvi.BackColor = Color.FromArgb(0, 128, 212, 255);

                    this.EventJumper = true;
                    lvi.Checked = true;

                    jump = true;
                }
            }
            
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, product.Code));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, product.Description));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, Product.GetTotalStockQuantityToString(product.Id)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(product.Price)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(product.Position)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToIntListView(product.PackQuantity)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_ThreeDecimals(product.Weight)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, Supplier.GetSupplierName(product.Id_Supplier)));

            if (!jump)
            {
                if (lvi.Index % 2 != 0)
                {
                    lvi.BackColor = Color.FromArgb(0, 200, 200, 200);
                }

                if (Product.GetTotalStockQuantity(product.Id) == 0 && GlobalVariables.Configuration.Enable_critical_stock_system)
                {
                    lvi.UseItemStyleForSubItems = false;
                    lvi.SubItems[4].BackColor = Color.FromArgb(0, 250, 148, 134);
                }
            }            
        }

        private void UpdateQuantityText(int listViewItemIndex, double value, int id_product)
        {
            if (value == -1)
            {
                lvlProducts.Items[listViewItemIndex].Text = "";
                lvlProducts.Items[listViewItemIndex].SubItems[1].Text = "";
            }
            else if ((value % 1) == 0)
            {
                lvlProducts.Items[listViewItemIndex].Text = ObjectToListView.ToIntListView(Convert.ToInt32(value));
                Product product = Product.CloneProduct(id_product);
                double totalValue = value * product.Price;
                lvlProducts.Items[listViewItemIndex].SubItems[1].Text = ObjectToListView.ToDoubleListView_TwoDecimals(totalValue);
            }
            else
            {
                lvlProducts.Items[listViewItemIndex].Text = ObjectToListView.ToDoubleListView_ThreeDecimals(value);
                Product product = Product.CloneProduct(id_product);
                double totalValue = value * product.Price;
                lvlProducts.Items[listViewItemIndex].SubItems[1].Text = ObjectToListView.ToDoubleListView_TwoDecimals(totalValue);
            }            
        }

        private void LvlProducts_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int index = e.Index;

            if (!this.EventJumper)
            {
                string code = lvlProducts.Items[index].SubItems[2].Text;
                string description = lvlProducts.Items[index].SubItems[3].Text;

                Product product = Product.CloneProduct(code, description);
                
                if(Product.GetTotalStockQuantity(product.Id) == 0 && e.CurrentValue == CheckState.Unchecked && GlobalVariables.Configuration.Enable_critical_stock_system)
                {
                    GlobalModals.FRM_Confirmation conf = new GlobalModals.FRM_Confirmation("O produto que você selecionou está com o estoque zerado! Por favor, verifique o estoque físico ou atualize o estoque no sistema. Deseja continuar assim mesmo?", 1);
                    conf.Show();

                    if (!conf.Result)
                    {
                        e.NewValue = CheckState.Unchecked;
                        return;
                    }
                }

                if (e.CurrentValue == CheckState.Unchecked)
                {
                    FRM_ProductsListQuantitySelector qttSelector = new FRM_ProductsListQuantitySelector(product, this.IsAlterRequest);
                    qttSelector.ShowDialog();

                    if (!qttSelector.Success)
                    {
                        e.NewValue = CheckState.Unchecked;
                        return;
                    }

                    if (Product.GetTotalStockQuantity(product.Id) < qttSelector.Quantity && GlobalVariables.Configuration.Enable_critical_stock_system)
                    {
                        GlobalModals.FRM_Confirmation conf = new GlobalModals.FRM_Confirmation("Atenção! O produto do código '" + product.Code + "' e descrição '" + product.Description + "' não tem estoque suficiente no sistema para atender a quantidade selecionada. Por favor, verifique o estoque físico e clique em 'Sim' para continuar com a criação do pedido ou 'Não' para cancelar a criação do pedido.", 1);
                        conf.Show();

                        if (!conf.Result)
                        {
                            e.NewValue = CheckState.Unchecked;
                            return;
                        }
                    }

                    double quantity = qttSelector.Quantity;
                    
                    UpdateQuantityText(index, quantity, product.Id);

                    Request_Products por = new Request_Products(product.Id, quantity, product.Price);

                    SelectedProducts.Add(por);

                    lvlProducts.Items[index].UseItemStyleForSubItems = true;
                    lvlProducts.Items[index].BackColor = Color.FromArgb(0, 128, 212, 255);

                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    List<Request_Products> filtered = SelectedProducts.Where(x => x.Id_Product == product.Id).Select(x => x).ToList();
                    SelectedProducts.Remove(filtered[0]);

                    UpdateQuantityText(index, -1, filtered[0].Id_Product);

                    lvlProducts.Items[index].UseItemStyleForSubItems = true;
                    if (index % 2 != 0)
                    {
                        lvlProducts.Items[index].BackColor = Color.FromArgb(0, 200, 200, 200);
                    }
                    else
                    {
                        lvlProducts.Items[index].BackColor = Color.FromArgb(0, 255, 255, 255);
                    }

                    if (lvlProducts.Items[index].SubItems[4].Text == "0")
                    {
                        lvlProducts.Items[index].UseItemStyleForSubItems = false;
                        lvlProducts.Items[index].SubItems[4].BackColor = Color.FromArgb(0, 250, 148, 134);
                    }
                }

                lblSelectedCount.Text = SelectedProducts.Count.ToString();
            }
            else
            {
                this.EventJumper = false;
            }            
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if(this.SelectedProducts.Count == 0)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Você precisa adicionar pelo menos um produto antes de clicar em 'Selecionar'!", 1);
                messOk.Show();
                return;
            }

            this.Close();
        }

        private void FrmModal_NewRequestProductsList_Shown(object sender, EventArgs e)
        {
            lvlProducts.ItemCheck += LvlProducts_ItemCheck;
        }

        private void BtnSearchOptions_Click(object sender, EventArgs e)
        {
            FrmSO.ShowDialog();
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
                    if (FrmSO.ckbCode.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Products.Where(x => x.Code.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
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
                    if (FrmSO.ckbDesc.Checked)
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
                    if (FrmSO.ckbPrice.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Products.Where(x => x.Price > 0 && x.Price.ToString().Contains(txtSearch.Text)).Select(x => x);
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
                    if (FrmSO.ckbPos.Checked)
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
                    if (FrmSO.ckbPackQuant.Checked)
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
                    if (FrmSO.ckbWeight.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Products.Where(x => x.Weight > 0 && x.Weight.ToString().Contains(txtSearch.Text)).Select(x => x);
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
                        ListViewItem lvi = lvlProducts.Items.Add("");
                        lvi.SubItems.Add("Nenhum resultado...");
                    }
                    else
                    {
                        foreach (Product item in productsFound)
                        {
                            ProductToListView(item);
                        }
                    }
                }

                if (productsFound.Count != 0)
                {
                    for (int i = 0; i < lvlProducts.Items.Count; i++)
                    {
                        if (Request_Products.AListContains(SelectedProducts, lvlProducts.Items[i].SubItems[2].Text, lvlProducts.Items[i].SubItems[3].Text))
                        {
                            this.EventJumper = true;
                            lvlProducts.Items[i].Checked = true;

                            lvlProducts.Items[i].UseItemStyleForSubItems = true;
                            lvlProducts.Items[i].BackColor = Color.FromArgb(0, 128, 212, 255);
                        }
                    }
                }
            }
        }
    }
}
