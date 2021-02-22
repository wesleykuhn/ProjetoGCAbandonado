using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GC.Library.Database;
using GC.Library.Translators;
using GC.Library;
using GC.Library.Entities;

namespace GC.Forms.Main.Controls
{
    public partial class USC_Costumers : UserControl
    {
        internal event EventHandler CostumerUpdatedDeleted;

        Modals.Costumers.FRM_SearchOptionsCostumers FrmSO = new Modals.Costumers.FRM_SearchOptionsCostumers();

        int ListViewIndex = -1;        

        public USC_Costumers()
        {
            InitializeComponent();

            if (!Library.Errors.Care.AntiInvalidInstance)
            {
                UpdateStats();
            }
        }

        internal void UpdateStats()
        {
            lblCostumersCount.Text = "Total de Clientes Cadastrados: " + GlobalVariables.FragileData.RegisteredCostumers.ToString() + "/" + GlobalVariables.FragileData.MaxCostumers.ToString();

            if (lvlCostumers != null && lvlCostumers.Created)
            {
                lvlCostumers.Items.Clear();
            }

            if (GlobalVariables.Costumers != null && GlobalVariables.Costumers.Count > 0)
            {
                AddAllCostumersToListView();
            }
        }

        private void AddAllCostumersToListView()
        {
            foreach (Costumer item in GlobalVariables.Costumers)
            {
                CostumerToListView(item);
            }
        }

        private void CostumerToListView(Costumer costumer)
        {
            ListViewItem lvi = lvlCostumers.Items.Add(costumer.Name);
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(costumer.Email)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(costumer.PhoneNumber)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, costumer.Sex.ToString()));

            if(ObjectToListView.ToStringListView(costumer.Street) == "")
            {
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ""));
            }
            else
            {
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(costumer.Street + ", " + costumer.Number)));
            }

            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(costumer.Complement)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(costumer.Cep)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(costumer.District)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(costumer.City)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(costumer.State)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(costumer.Country)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(costumer.Debt)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToIntListView(costumer.DiscountCounter)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(costumer.DiscountAccumulated)));            

            if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);
        }

        private void BtnUpdateDebt_Click(object sender, EventArgs e)
        {
            if (this.ListViewIndex >= 0)
            {
                string name = lvlCostumers.Items[this.ListViewIndex].Text;
                string phone_number = lvlCostumers.Items[this.ListViewIndex].SubItems[2].Text;
                string address = lvlCostumers.Items[this.ListViewIndex].SubItems[4].Text;

                var filtered = GlobalVariables.Costumers.Where(x => x.Name == name && x.PhoneNumber == phone_number && x.Street + ", " + x.Number == address).Select(x => x);

                Costumer toBeUpdated = null;
                foreach (Costumer item in filtered)
                {
                    toBeUpdated = item;
                }

                Modals.Costumers.FRM_EditDebt alterCostumer = new Modals.Costumers.FRM_EditDebt(toBeUpdated);
                alterCostumer.ShowDialog();
            }
            this.ListViewIndex = -1;

            btnUpdateDebt.Enabled = false;
            btnUpdateDiscount.Enabled = false;
            btnAlter.Enabled = false;            
            btnDelete.Enabled = false;

            UpdateStats();
        }

        private void BtnUpdateDiscount_Click(object sender, EventArgs e)
        {
            if (this.ListViewIndex >= 0)
            {
                string name = lvlCostumers.Items[this.ListViewIndex].Text;
                string phone_number = lvlCostumers.Items[this.ListViewIndex].SubItems[2].Text;
                string address = lvlCostumers.Items[this.ListViewIndex].SubItems[4].Text;

                var filtered = GlobalVariables.Costumers.Where(x => x.Name == name && x.PhoneNumber == phone_number && x.Street + ", " + x.Number == address).Select(x => x);

                Costumer toBeUpdated = null;
                foreach (Costumer item in filtered)
                {
                    toBeUpdated = item;
                }

                Modals.Costumers.FRM_EditDiscounts alterCostumer = new Modals.Costumers.FRM_EditDiscounts(toBeUpdated);
                alterCostumer.ShowDialog();
            }
            this.ListViewIndex = -1;

            btnUpdateDebt.Enabled = false;
            btnUpdateDiscount.Enabled = false;
            btnAlter.Enabled = false;
            btnDelete.Enabled = false;

            UpdateStats();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.ListViewIndex >= 0)
            {
                string name = lvlCostumers.Items[this.ListViewIndex].Text;
                string phone_number = lvlCostumers.Items[this.ListViewIndex].SubItems[2].Text;
                string address = lvlCostumers.Items[this.ListViewIndex].SubItems[4].Text;

                var filtered = GlobalVariables.Costumers.Where(x => x.Name == name && x.PhoneNumber == phone_number && x.Street + ", " + x.Number == address).Select(x => x);

                Costumer toBeUpdated = null;
                foreach (Costumer item in filtered)
                {
                    toBeUpdated = item;
                }

                Modals.Costumers.FRM_AlterCostumer alterCostumer = new Modals.Costumers.FRM_AlterCostumer(toBeUpdated);
                alterCostumer.ShowDialog();

                if(alterCostumer.Alterations) this.CostumerUpdatedDeleted(this, new EventArgs());
            }

            this.ListViewIndex = -1;

            btnUpdateDebt.Enabled = false;
            btnUpdateDiscount.Enabled = false;
            btnAlter.Enabled = false;
            btnDelete.Enabled = false;

            UpdateStats();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();

            GlobalModals.FRM_Confirmation frmConfirmantion = new GlobalModals.FRM_Confirmation("Este cliente será excluído permanentemente e todos os pedidos e garantias que estão usando ele terão seu campo cliente mudado para 'Excluído'. Deseja realmente continuar? Ele não poderá ser recuperado após a exclusão.", 1);
            frmConfirmantion.ShowDialog();
            if (frmConfirmantion.Result)
            {
                if (this.ListViewIndex >= 0)
                {
                    ml.Show();

                    string name = lvlCostumers.Items[this.ListViewIndex].Text;
                    string phone_number = lvlCostumers.Items[this.ListViewIndex].SubItems[2].Text;
                    string address = lvlCostumers.Items[this.ListViewIndex].SubItems[4].Text;

                    var filtered = GlobalVariables.Costumers.Where(x => x.Name == name && x.PhoneNumber == phone_number && x.Street + ", " + x.Number == address).Select(x => x);

                    Costumer toBeDeleted = null;
                    foreach (Costumer item in filtered)
                    {
                        toBeDeleted = item;
                    }

                    
                    MySqlNonQuery.DeleteCostumerById(toBeDeleted.Id);

                    MySqlNonQuery.IncrementUserRegisteredCostumers(-1);

                    GlobalVariables.Costumers.Remove(toBeDeleted);
                    lvlCostumers.Items.RemoveAt(this.ListViewIndex);
                }

                UpdateStats();

                this.CostumerUpdatedDeleted(this, new EventArgs());
            }

            this.ListViewIndex = -1;

            btnUpdateDebt.Enabled = false;
            btnUpdateDiscount.Enabled = false;
            btnAlter.Enabled = false;
            btnDelete.Enabled = false;

            ml.CustomClose();
        }

        private void lvlCostumers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvlCostumers.SelectedItems.Count != 0)
            {
                this.ListViewIndex = lvlCostumers.SelectedIndices[0];
                if (this.ListViewIndex >= 0)
                {
                    btnUpdateDebt.Enabled = true;
                    btnUpdateDiscount.Enabled = true;
                    btnAlter.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnUpdateDebt.Enabled = false;
                    btnUpdateDiscount.Enabled = false;
                    btnAlter.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
        }

        private void btnSearchOptions_Click(object sender, EventArgs e)
        {
            this.FrmSO.ShowDialog();
        }

        private void BtnNewCostumer_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.FragileData.RegisteredCostumers >= GlobalVariables.FragileData.MaxCostumers)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Infelizmente você já atingiu o seu limite de " + GlobalVariables.FragileData.MaxCostumers.ToString() + " clientes cadastrados. Você não poderá cadastrar mais clientes. Contate a administração e mude seu plano para continuar a cadastrar seus clientes.", 1);
                messOk.Show();

                return;
            }

            Modals.Costumers.FRM_NewCostumer newCostumer = new Modals.Costumers.FRM_NewCostumer();
            newCostumer.ShowDialog();

            UpdateStats();
        }

        private void lvlCostumers_DoubleClick(object sender, EventArgs e)
        {
            if (this.ListViewIndex >= 0)
            {
                string name = lvlCostumers.Items[this.ListViewIndex].Text;
                string phone_number = lvlCostumers.Items[this.ListViewIndex].SubItems[2].Text;
                string address = lvlCostumers.Items[this.ListViewIndex].SubItems[4].Text;

                var filtered = GlobalVariables.Costumers.Where(x => x.Name == name && x.PhoneNumber == phone_number && x.Street + ", " + x.Number == address).Select(x => x);

                Costumer costumer = null;
                foreach (Costumer item in filtered)
                {
                    costumer = item;
                }
                Modals.Costumers.FRM_DetailsCostumer details = new Forms.Main.Modals.Costumers.FRM_DetailsCostumer(costumer);
                details.ShowDialog();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lvlCostumers.Items.Clear();
                List<Costumer> costumersFound = new List<Costumer>();
                if (txtSearch.Text.Length <= 0)
                {
                    AddAllCostumersToListView();
                }
                else
                {
                    if (this.FrmSO.ckbName.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Costumers.Where(x => x.Name.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Costumer item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Costumer subItem in costumersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) costumersFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbEmail.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Costumers.Where(x => x.Email != null && x.Email.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Costumer item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Costumer subItem in costumersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) costumersFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbPhoneNumber.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Costumers.Where(x => x.PhoneNumber != null && x.PhoneNumber.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Costumer item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Costumer subItem in costumersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) costumersFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbAddress.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Costumers.Where(x => x.Street.ToLower().Contains(txtSearch.Text.ToLower()) || x.Number.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Costumer item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Costumer subItem in costumersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) costumersFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbSex.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Costumers.Where(x => x.Sex.ToString().ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Costumer item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Costumer subItem in costumersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) costumersFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbComplement.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Costumers.Where(x => x.Complement != null && x.Complement.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Costumer item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Costumer subItem in costumersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) costumersFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbReference.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Costumers.Where(x => x.Reference != null && x.Reference.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Costumer item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Costumer subItem in costumersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) costumersFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbDistrict.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Costumers.Where(x => x.District != null && x.District.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Costumer item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Costumer subItem in costumersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) costumersFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbCity.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Costumers.Where(x => x.City != null && x.City.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Costumer item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Costumer subItem in costumersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) costumersFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbState.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Costumers.Where(x => x.State != null && x.State.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Costumer item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Costumer subItem in costumersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) costumersFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbCountry.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Costumers.Where(x => x.Country != null && x.Country.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Costumer item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Costumer subItem in costumersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) costumersFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbCep.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Costumers.Where(x => x.Cep != null && x.Cep.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Costumer item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Costumer subItem in costumersFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) costumersFound.Add(item);
                        }
                    }
                    if (costumersFound.Count() <= 0)
                    {
                        ListViewItem lvi = lvlCostumers.Items.Add("Nenhum resultado...");
                    }
                    else
                    {
                        foreach (Costumer item in costumersFound)
                        {
                            CostumerToListView(item);
                        }
                    }
                }
            }
        }
    }
}
