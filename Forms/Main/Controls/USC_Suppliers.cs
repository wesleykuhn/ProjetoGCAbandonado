using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GC.Library.Database;
using GC.Library.Objects;
using GC.Library.Translators;
using GC.Library;
using GC.Library.Objects.SubObjects.Product;

namespace GC.Forms.Main.Controls
{
    public partial class USC_Suppliers : UserControl
    {
        internal event EventHandler SupplierAlteredDeleted;

        private Modals.Suppliers.FRM_SearchOptionsSuppliers FrmSO = new Modals.Suppliers.FRM_SearchOptionsSuppliers();

        int ListViewIndex = -1;        

        public USC_Suppliers()
        {
            InitializeComponent();

            if (!Library.Errors.Care.AntiInvalidInstance)
            {
                UpdateStats();
            }
        }

        internal void UpdateStats()
        {
            lblSuppliersCount.Text = "Total de Fornecedores Cadastrados: " + GlobalVariables.FragileData.RegisteredSuppliers.ToString() + "/" + GlobalVariables.FragileData.MaxSuppliers.ToString();
            lvlSuppliers.Items.Clear();
            AddAllSuppliersToListView();
        }

        private void AddAllSuppliersToListView()
        {
            foreach (Supplier item in GlobalVariables.Suppliers)
            {
                SupplierToListView(item);
            }
        }

        private void SupplierToListView(Supplier supplier)
        {
            int suppliersProducts = 0;
            var filtered = GlobalVariables.Products.Where(x => x.Id_Supplier == supplier.Id).Select(x => x.Id);
            foreach(int item in filtered)
            {
                suppliersProducts++;
            }
            ListViewItem lvi = lvlSuppliers.Items.Add(supplier.Name);
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(supplier.Description)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(supplier.Email)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(supplier.PhoneNumber)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(supplier.CpfCnpj)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, suppliersProducts.ToString()));

            if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.FragileData.RegisteredSuppliers >= GlobalVariables.FragileData.MaxSuppliers)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Infelizmente você já atingiu o seu limite de " + GlobalVariables.FragileData.MaxSuppliers.ToString() + " fornecedores cadastrados. Você não poderá cadastrar mais fornecedores. Contate a administração e mude seu plano para continuar a cadastrar seus fornecedores.", 1);
                messOk.Show();

                return;
            }

            Forms.Main.Modals.Suppliers.FRM_NewSupplier newSupplier = new Forms.Main.Modals.Suppliers.FRM_NewSupplier();
            newSupplier.ShowDialog();

            UpdateStats();
        }

        private void btnSearchOptions_Click(object sender, EventArgs e)
        {
            this.FrmSO.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.ListViewIndex >= 0)
            {
                string name = lvlSuppliers.Items[this.ListViewIndex].Text;

                var filtered = GlobalVariables.Suppliers.Where(x => x.Name == name).Select(x => x);

                Supplier toBeUpdated = null;
                foreach (Supplier item in filtered)
                {
                    toBeUpdated = item;
                }

                Forms.Main.Modals.Suppliers.FRM_AlterSupplier alterSupplier = new Forms.Main.Modals.Suppliers.FRM_AlterSupplier(toBeUpdated);
                alterSupplier.ShowDialog();

                if(alterSupplier.Alterations) this.SupplierAlteredDeleted(this, new EventArgs());
            }

            this.ListViewIndex = -1;

            btnAlter.Enabled = false;
            btnDelete.Enabled = false;

            UpdateStats();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
            GC.GlobalModals.FRM_Confirmation confirmation = new GC.GlobalModals.FRM_Confirmation("Este fornecedor será excluído permanentemente e todos os produtos que usam este fornecedor ficarão sem fornecedor. Tem certeza que deseja continuar?", 1);

            confirmation.ShowDialog();
            if (confirmation.Result)
            {
                if (this.ListViewIndex >= 0)
                {
                    ml.Show();

                    string name = lvlSuppliers.Items[this.ListViewIndex].Text;
                    var filtered = GlobalVariables.Suppliers.Where(x => x.Name == name).Select(x => x);
                    Supplier toBeDeleted = null;

                    foreach (Supplier item in filtered)
                    {
                        toBeDeleted = item;
                    }

                    //Makes null all the id_suppliers that refers to this supplier in table products
                    
                    var productsOfThisSupplier = GlobalVariables.Products.Where(x => x.Id_Supplier == toBeDeleted.Id).Select(x => x);

                    foreach (Product item in productsOfThisSupplier)
                    {
                        item.Id_Supplier = -1;
                        MySqlNonQuery.UpdateProduct(item);
                    }

                    //Now yeah, makes the delete
                    MySqlNonQuery.DeleteSupplierById(toBeDeleted.Id);

                    MySqlNonQuery.IncrementUserRegisteredSuppliers(-1);

                    GlobalVariables.Suppliers.Remove(toBeDeleted);
                    lvlSuppliers.Items.RemoveAt(this.ListViewIndex);
                }
                UpdateStats();

                this.SupplierAlteredDeleted(this, new EventArgs());
            }

            this.ListViewIndex = -1;
            btnDelete.Enabled = false;
            btnAlter.Enabled = false;

            ml.CustomClose();
        }

        private void LvlSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvlSuppliers.SelectedItems.Count != 0)
            {
                this.ListViewIndex = lvlSuppliers.SelectedIndices[0];
                if (this.ListViewIndex >= 0)
                {
                    btnDelete.Enabled = true;
                    btnAlter.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                    btnAlter.Enabled = false;
                }
            }
        }

        private void lvlSuppliers_DoubleClick(object sender, EventArgs e)
        {
            if (this.ListViewIndex >= 0)
            {
                string name = lvlSuppliers.Items[this.ListViewIndex].Text;
                var filtered = GlobalVariables.Suppliers.Where(x => x.Name == name).Select(x => x);
                Supplier supplier = null;
                foreach (Supplier item in filtered)
                {
                    supplier = item;
                }
                Forms.Main.Modals.Suppliers.FRM_DetailsSupplier details = new Forms.Main.Modals.Suppliers.FRM_DetailsSupplier(supplier);
                details.ShowDialog();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lvlSuppliers.Items.Clear();
                List<Supplier> suppliersFound = new List<Supplier>();
                if (txtSearch.Text.Length <= 0)
                {
                    AddAllSuppliersToListView();
                }
                else
                {
                    if (this.FrmSO.ckbName.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Suppliers.Where(x => x.Name != null && x.Name.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Supplier item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Supplier subItem in suppliersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) suppliersFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbDesc.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Suppliers.Where(x => x.Description != null && x.Description.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Supplier item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Supplier subItem in suppliersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) suppliersFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbEmail.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Suppliers.Where(x => x.Email != null && x.Email.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Supplier item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Supplier subItem in suppliersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) suppliersFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbPhone_number.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Suppliers.Where(x => x.PhoneNumber != null && x.PhoneNumber.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Supplier item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Supplier subItem in suppliersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) suppliersFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbCpfCnpj.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Suppliers.Where(x => x.CpfCnpj != null && x.CpfCnpj.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Supplier item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Supplier subItem in suppliersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) suppliersFound.Add(item);
                        }
                    }
                    if (suppliersFound.Count() <= 0)
                    {
                        ListViewItem lvi = lvlSuppliers.Items.Add("Nenhum resultado...");
                    }
                    else
                    {
                        foreach (Supplier item in suppliersFound)
                        {
                            SupplierToListView(item);
                        }
                    }
                }
            }
        }
    }
}
