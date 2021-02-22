using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GC.Library;
using GC.Library.Style;
using GC.Library.Objects;
using GC.Library.Translators;
using GC.Library.Entities;
using GC.Library.Database;

namespace GC.Forms.Main.Controls
{
    public partial class USC_Warranties : UserControl
    {
        private Modals.Warranties.FRM_SearchOptionsWarranties FrmSO = new Modals.Warranties.FRM_SearchOptionsWarranties();

        public USC_Warranties()
        {
            InitializeComponent();

            if (!Library.Errors.Care.AntiInvalidInstance)
            {
                this.UpdateList();
            }
        }

        internal void UpdateList()
        {
            lvlWarranties.Items.Clear();

            if(GlobalVariables.OldWarranties.Count > 0) this.WarratiesToList(GlobalVariables.OldWarranties);
            this.WarratiesToList(GlobalVariables.Warranties);

            lblWarrantiesCount.Text = "Total de Garantias: " + lvlWarranties.Items.Count.ToString();         
        }

        private void WarratiesToList(List<Warranty> warranties)
        {
            foreach (Warranty warranty in warranties)
            {
                this.WarrantyToList(warranty);
            }
        }

        private void WarrantyToList(Warranty warranty)
        {
            ListViewItem lvi = lvlWarranties.Items.Add(warranty.Number);
            
            Costumer costumer = Costumer.CloneCostumer(warranty.Id_Costumer);

            if (costumer == null) lvi.SubItems.Add("Esse cliente foi excluído!");
            else lvi.SubItems.Add(costumer.Name + " - " + costumer.GetAddress());

            if (lvi.Index % 2 != 0)
            {
                lvi.BackColor = Color.FromArgb(210, 210, 210);
            }

            lvi.UseItemStyleForSubItems = false;

            if (!warranty.Type)
            {
                lvi.SubItems.Add("PRODUTO", Color.Black, Color.SkyBlue, this.Font);

                Product product = Product.CloneProduct(warranty.Id_Item);

                if (product == null) lvi.SubItems.Add("Esse produto foi excluído!", Color.Black, ListViews.ListViewItemTint(ref lvi), this.Font);
                else lvi.SubItems.Add(product.Description, Color.Black, ListViews.ListViewItemTint(ref lvi), this.Font);
            }
            else
            {
                lvi.SubItems.Add("SERVIÇO", Color.Black, Color.LawnGreen, this.Font);

                Job job = Job.CloneJob(warranty.Id_Item);

                if (job == null) lvi.SubItems.Add("Esse serviço foi excluído!", Color.Black, ListViews.ListViewItemTint(ref lvi), this.Font);
                else lvi.SubItems.Add(job.Name, Color.Black, ListViews.ListViewItemTint(ref lvi), this.Font);
            }

            lvi.SubItems.Add(ObjectToListView.ToDateTimeListView(warranty.StartedIn), Color.Black, ListViews.ListViewItemTint(ref lvi), this.Font);
            lvi.SubItems.Add(ObjectToListView.ToDateTimeListView(warranty.ExpiresIn), Color.Black, ListViews.ListViewItemTint(ref lvi), this.Font);
        }

        private void btnSearchOptions_Click(object sender, EventArgs e)
        {
            this.FrmSO.ShowDialog();
        }

        private void btnShowOld_Click(object sender, EventArgs e)
        {
            Library.Files.SeekFor.OldWarranties();

            if (GlobalVariables.OldWarranties.Count > 0) this.UpdateList();

            btnShowOld.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Modals.Warranties.FRM_NewWarranty newWarranty = new Modals.Warranties.FRM_NewWarranty();
            newWarranty.ShowDialog();

            if (newWarranty.Changes)
            {
                this.UpdateList();
            }            
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (lvlWarranties.SelectedItems.Count > 0)
            {
                Modals.Warranties.FRM_AlterWarranty alterWarranty = null;

                if (GlobalVariables.OldWarranties.Count > 0)
                {
                    int index = GlobalVariables.OldWarranties.FindIndex(x => x.Number == lvlWarranties.Items[lvlWarranties.SelectedIndices[0]].Text);

                    if(index >= 0)
                    {
                        alterWarranty = new Modals.Warranties.FRM_AlterWarranty(GlobalVariables.OldWarranties[index]);
                        alterWarranty.ShowDialog();
                    }
                }
                else
                {
                    int index = GlobalVariables.Warranties.FindIndex(x => x.Number == lvlWarranties.Items[lvlWarranties.SelectedIndices[0]].Text);

                    if (index >= 0)
                    {
                        alterWarranty = new Modals.Warranties.FRM_AlterWarranty(GlobalVariables.Warranties[index]);
                        alterWarranty.ShowDialog();
                    }
                }

                if (alterWarranty.Changes)
                {
                    btnAlter.Enabled = false;
                    btnDelete.Enabled = false;

                    this.UpdateList();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvlWarranties.SelectedItems.Count > 0)
            {
                GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();

                GlobalModals.FRM_Confirmation confirmation = new GlobalModals.FRM_Confirmation("Deseja realmente excluir esta garantia?", 1);
                confirmation.Show();

                if (!confirmation.Result) return;

                ml.Show();

                Warranty warranty = Warranty.CloneWarranty(lvlWarranties.Items[lvlWarranties.SelectedIndices[0]].Text);
                
                if(GlobalVariables.Warranties.Exists(x => x.Number == warranty.Number))
                {
                    MySqlNonQuery.DeleteWarranty(warranty.Id);

                    GlobalVariables.Warranties.RemoveAll(x => x.Number == warranty.Number);
                }
                else
                {
                    GlobalVariables.OldWarranties.RemoveAll(x => x.Number == warranty.Number);
                }

                Library.Files.Control.DeleteWarrantyFile(warranty.Number);

                lvlWarranties.Items.RemoveAt(lvlWarranties.SelectedIndices[0]);

                this.UpdateList();
               
                btnDelete.Enabled = false;
                btnAlter.Enabled = false;

                ml.CustomClose();
            }
        }

        private void lvlWarranties_DoubleClick(object sender, EventArgs e)
        {
            if (lvlWarranties.SelectedItems.Count > 0)
            {
                Warranty warranty = null;

                if(GlobalVariables.Warranties.Exists(x => x.Number == lvlWarranties.Items[lvlWarranties.SelectedIndices[0]].Text))
                {
                    warranty = Warranty.CloneWarranty(lvlWarranties.Items[lvlWarranties.SelectedIndices[0]].Text);
                }
                else
                {
                    int index = GlobalVariables.OldWarranties.FindIndex(x => x.Number == lvlWarranties.Items[lvlWarranties.SelectedIndices[0]].Text);
                    warranty = GlobalVariables.OldWarranties[index];
                }

                Modals.Warranties.FRM_DetailsWarranty details = new Modals.Warranties.FRM_DetailsWarranty(warranty);
                details.ShowDialog();
            }
        }

        private void lvlWarranties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvlWarranties.SelectedItems.Count > 0)
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

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lvlWarranties.Items.Clear();

                List<Warranty> warrantiesFound = new List<Warranty>();

                if (txtSearch.Text.Length <= 0)
                {
                    this.UpdateList();
                }
                else
                {
                    //OLD LIST
                    if (GlobalVariables.OldWarranties.Count > 0)
                    {
                        if (this.FrmSO.ckbNumber.Checked)
                        {
                            var filtered = GlobalVariables.OldWarranties.Where(x => x.Number.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                            foreach (Warranty warranty in filtered)
                            {
                                if (!warrantiesFound.Exists(x => x.Id == warranty.Id)) warrantiesFound.Add(warranty);
                            }
                        }
                        if (this.FrmSO.ckbCostumer.Checked)
                        {
                            List<Warranty> filtered = new List<Warranty>();

                            var costumersIds = GlobalVariables.Costumers.Where(x => x.Name.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x.Id);

                            foreach (int id in costumersIds)
                            {
                                filtered.AddRange(GlobalVariables.OldWarranties.Where(x => x.Id_Costumer == id).ToList());
                            }

                            foreach (Warranty warranty in filtered)
                            {
                                if (!warrantiesFound.Exists(x => x.Id == warranty.Id)) warrantiesFound.Add(warranty);
                            }
                        }
                        if (this.FrmSO.ckbStartedIn.Checked)
                        {
                            var filtered = GlobalVariables.OldWarranties.Where(x => x.StartedIn.ToString("dd/MM/yyyy HH:mm:ss").Contains(txtSearch.Text)).Select(x => x);

                            foreach (Warranty warranty in filtered)
                            {
                                if (!warrantiesFound.Exists(x => x.Id == warranty.Id)) warrantiesFound.Add(warranty);
                            }
                        }
                        if (this.FrmSO.ckbExpiresIn.Checked)
                        {
                            var filtered = GlobalVariables.OldWarranties.Where(x => x.ExpiresIn.ToString("dd/MM/yyyy HH:mm:ss").Contains(txtSearch.Text)).Select(x => x);

                            foreach (Warranty warranty in filtered)
                            {
                                if (!warrantiesFound.Exists(x => x.Id == warranty.Id)) warrantiesFound.Add(warranty);
                            }
                        }
                    }

                    //NORMAL LIST
                    if (this.FrmSO.ckbNumber.Checked)
                    {
                        var filtered = GlobalVariables.Warranties.Where(x => x.Number.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Warranty warranty in filtered)
                        {
                            if (!warrantiesFound.Exists(x => x.Id == warranty.Id)) warrantiesFound.Add(warranty);
                        }
                    }
                    if (this.FrmSO.ckbCostumer.Checked)
                    {
                        List<Warranty> filtered = new List<Warranty>();

                        var costumersIds = GlobalVariables.Costumers.Where(x => x.Name.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x.Id);

                        foreach (int id in costumersIds)
                        {
                            filtered.AddRange(GlobalVariables.Warranties.Where(x => x.Id_Costumer == id).ToList());
                        }

                        foreach (Warranty warranty in filtered)
                        {
                            if (!warrantiesFound.Exists(x => x.Id == warranty.Id)) warrantiesFound.Add(warranty);
                        }
                    }
                    if (this.FrmSO.ckbStartedIn.Checked)
                    {
                        var filtered = GlobalVariables.Warranties.Where(x => x.StartedIn.ToString("dd/MM/yyyy HH:mm:ss").Contains(txtSearch.Text)).Select(x => x);

                        foreach (Warranty warranty in filtered)
                        {
                            if (!warrantiesFound.Exists(x => x.Id == warranty.Id)) warrantiesFound.Add(warranty);
                        }
                    }
                    if (this.FrmSO.ckbExpiresIn.Checked)
                    {
                        var filtered = GlobalVariables.Warranties.Where(x => x.ExpiresIn.ToString("dd/MM/yyyy HH:mm:ss").Contains(txtSearch.Text)).Select(x => x);

                        foreach (Warranty warranty in filtered)
                        {
                            if (!warrantiesFound.Exists(x => x.Id == warranty.Id)) warrantiesFound.Add(warranty);
                        }
                    }
                    if (this.FrmSO.rbtTypeProducts.Checked)
                    {
                        warrantiesFound.RemoveAll(x => x.Type == true);
                    }
                    if (this.FrmSO.rbtTypeJobs.Checked)
                    {
                        warrantiesFound.RemoveAll(x => x.Type == false);
                    }

                    if (warrantiesFound.Count() <= 0)
                    {
                        ListViewItem lvi = lvlWarranties.Items.Add("Nenhum resultado...");
                    }
                    else
                    {
                        foreach (Warranty warranty in warrantiesFound)
                        {
                            this.WarrantyToList(warranty);
                        }
                    }
                }
            }
        }
    }
}
