using GC.Library;
using GC.Library.Entities;
using GC.Library.Translators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GC.Forms.Main.Modals.Requests.SubModals.NewRequest
{
    public partial class FRM_CostumersList : Bases.FRM_Default
    {
        Costumers.FRM_SearchOptionsCostumers FrmSO = new Costumers.FRM_SearchOptionsCostumers();

        internal int SelectedCostumerId = -1;

        public FRM_CostumersList()
        {
            InitializeComponent();

            this.ReadyForm();

            this.ReplaceCloseEvent(new EventHandler(CloseForm));

            UpdateStats();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.SelectedCostumerId = -1;

            this.Close();
        }

        private void BtnSearchOptions_Click(object sender, EventArgs e)
        {
            FrmSO.ShowDialog();
        }

        private void UpdateStats()
        {
            lvlCostumers.Items.Clear();
            AddAllCostumersToListView();
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

            if (ObjectToListView.ToStringListView(costumer.Street) == "")
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

        private void LvlCostumers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvlCostumers.SelectedItems.Count != 0)
            {
                lblSelected.Text = lvlCostumers.Items[lvlCostumers.SelectedIndices[0]].Text;
            }
            else
            {
                lblSelected.Text = "Ninguém";
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if(lvlCostumers.SelectedItems.Count == 0)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Você precisa selecionar um cliente antes de clicar em 'Selecionar'!", 1);
                messOk.Show();
                return;
            }

            string name = lvlCostumers.Items[lvlCostumers.SelectedIndices[0]].Text;
            string phone_number = lvlCostumers.Items[lvlCostumers.SelectedIndices[0]].SubItems[2].Text;
            string address = lvlCostumers.Items[lvlCostumers.SelectedIndices[0]].SubItems[4].Text;

            var filtered = GlobalVariables.Costumers.Where(x => x.Name == name && x.PhoneNumber == phone_number && x.Street + ", " + x.Number == address).Select(x => x.Id);

            foreach (int item in filtered)
            {
                this.SelectedCostumerId = item;
            }

            this.Close();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            lvlCostumers.Items.Clear();
            List<Costumer> costumersFound = new List<Costumer>();
            if (txtSearch.Text.Length <= 0)
            {
                AddAllCostumersToListView();
            }
            else
            {
                if (FrmSO.ckbName.Checked)
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
                if (FrmSO.ckbEmail.Checked)
                {
                    bool itemAlreadyExists;
                    var filtered = GlobalVariables.Costumers.Where(x => x.Email.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
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
                if (FrmSO.ckbPhoneNumber.Checked)
                {
                    bool itemAlreadyExists;
                    var filtered = GlobalVariables.Costumers.Where(x => x.PhoneNumber.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
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
                if (FrmSO.ckbAddress.Checked)
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
                if (FrmSO.ckbName.Checked)
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
                if (FrmSO.ckbSex.Checked)
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
                if (FrmSO.ckbComplement.Checked)
                {
                    bool itemAlreadyExists;
                    var filtered = GlobalVariables.Costumers.Where(x => x.Complement.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
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
                if (FrmSO.ckbReference.Checked)
                {
                    bool itemAlreadyExists;
                    var filtered = GlobalVariables.Costumers.Where(x => x.Reference.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
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
                if (FrmSO.ckbDistrict.Checked)
                {
                    bool itemAlreadyExists;
                    var filtered = GlobalVariables.Costumers.Where(x => x.District.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
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
                if (FrmSO.ckbCity.Checked)
                {
                    bool itemAlreadyExists;
                    var filtered = GlobalVariables.Costumers.Where(x => x.City.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
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
                if (FrmSO.ckbState.Checked)
                {
                    bool itemAlreadyExists;
                    var filtered = GlobalVariables.Costumers.Where(x => x.State.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
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
                if (FrmSO.ckbCountry.Checked)
                {
                    bool itemAlreadyExists;
                    var filtered = GlobalVariables.Costumers.Where(x => x.Country.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
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
                if (FrmSO.ckbCep.Checked)
                {
                    bool itemAlreadyExists;
                    var filtered = GlobalVariables.Costumers.Where(x => x.Cep.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
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

        private void LvlCostumers_DoubleClick(object sender, EventArgs e)
        {
            BtnSelect_Click(this, new EventArgs());
        }
    }
}
