using GC.Library;
using GC.Library.Entities;
using GC.Library.Errors;
using GC.Library.Objects;
using GC.Library.Objects.SubObjects.Product;
using GC.Library.Translators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using GC.Library.Database;
using System.Windows.Forms;

namespace GC.Forms.Main.Modals.Warranties
{
    public partial class FRM_AlterWarranty : Bases.FRM_Default
    {
        internal bool Changes = false;

        private Costumer costumer = null;
        private Warranty oldWarranty;
        private int costumerId = -1;
        private bool isWarrantyOld = true;
        private bool oldCostumerExists = false;

        private Products.FRM_SearchOptions productsSearch = new Products.FRM_SearchOptions();
        private Jobs.FRM_SearchOptionsJobs jobsSearch = new Jobs.FRM_SearchOptionsJobs();

        public FRM_AlterWarranty(Warranty warranty)
        {
            InitializeComponent();

            this.ReadyForm();

            if (!Care.AntiInvalidInstance)
            {
                //Adjust the searchOptions
                this.productsSearch.ckbPackQuant.Hide();
                this.productsSearch.ckbWeight.Top -= 17;                

                this.AllProductsToListView();
                this.AllJobsToListView();                
            }

            if (!GlobalVariables.Warranties.Exists(x => x.Id == warranty.Id)) this.isWarrantyOld = true;
            else this.isWarrantyOld = false;

            LBL_WarrantyNumber.Text += warranty.Number;

            rtbObservations.Text = warranty.Observations;

            if (!warranty.Type)
            {
                //PRODUCT ---------------------------------------------------------------->
                if(GlobalVariables.Products.Exists(x => x.Id == warranty.Id_Item))
                {
                    int index = GlobalVariables.Products.FindIndex(x => x.Id == warranty.Id_Item);

                    foreach (ListViewItem lvi in lvlProducts.Items)
                    {
                        if(lvi.Text == GlobalVariables.Products[index].Code && lvi.SubItems[1].Text == GlobalVariables.Products[index].Description)
                        {                            
                            lvi.Focused = true;
                            lvlProducts.Focus();
                            lvi.Selected = true;
                        }
                    }
                }
                else
                {
                    LBL_SelectedItem.ForeColor = Library.Style.ColorsPalette.GDE_Danger;
                }
                // <------------------------------------------------------------------
            }
            else
            {
                // JOB ---------------------------------------------------------------->
                if (GlobalVariables.Jobs.Exists(x => x.Id == warranty.Id_Item))
                {
                    int index = GlobalVariables.Jobs.FindIndex(x => x.Id == warranty.Id_Item);

                    foreach (ListViewItem lvi in lvlJobs.Items)
                    {
                        if (lvi.Text == GlobalVariables.Jobs[index].Name)
                        {
                            RBT_Job.Checked = true;

                            lvi.Focused = true;
                            lvlJobs.Focus();
                            lvi.Selected = true;
                        }
                    }
                }
                else
                {
                    LBL_SelectedItem.ForeColor = Library.Style.ColorsPalette.GDE_Danger;
                }
                // <-------------------------------------------------------------------
            }

            if(GlobalVariables.Costumers.Exists(x => x.Id == warranty.Id_Costumer))
            {
                this.oldCostumerExists = true;

                this.costumerId = warranty.Id_Costumer;

                this.costumer = Costumer.CloneCostumer(warranty.Id_Costumer);

                this.UpdateCostumerUI();
            }

            dtpExpiration.Value = warranty.ExpiresIn;

            this.oldWarranty = warranty;
        }

        private void AllProductsToListView()
        {
            foreach (Product product in GlobalVariables.Products)
            {
                this.ProductToListView(product);
            }
        }

        private void AllJobsToListView()
        {
            foreach (Job job in GlobalVariables.Jobs)
            {
                this.JobToListView(job);
            }
        }

        private void ProductToListView(Product product)
        {
            ListViewItem lvi = lvlProducts.Items.Add(product.Code);
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, product.Description));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(product.Price)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(product.Position)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_ThreeDecimals(product.Weight)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, Supplier.GetSupplierName(product.Id_Supplier)));

            if (lvi.Index % 2 != 0)
            {
                lvi.BackColor = Color.FromArgb(0, 200, 200, 200);
            }
        }

        private void JobToListView(Job job)
        {
            ListViewItem lvi = lvlJobs.Items.Add(job.Name);
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(job.Description)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(job.Price)));

            if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);
        }

        private void btnSearchOptions_Click(object sender, EventArgs e)
        {
            if (RBT_Product.Checked)
            {
                this.productsSearch.ShowDialog();
            }
            else
            {
                this.jobsSearch.ShowDialog();
            }
        }

        private void RBT_Product_CheckedChanged(object sender, EventArgs e)
        {
            if (RBT_Product.Checked)
            {
                lvlProducts.BringToFront();
            }
            else
            {
                lvlJobs.BringToFront();
            }
        }

        private void btnChangeCostumer_Click(object sender, EventArgs e)
        {
            Requests.SubModals.NewRequest.FRM_CostumersList costumersList = new Requests.SubModals.NewRequest.FRM_CostumersList();
            costumersList.ShowDialog();

            this.costumerId = costumersList.SelectedCostumerId;
            if (this.costumerId == -1) this.costumer = null;
            else
            {
                var filtered = GlobalVariables.Costumers.Where(x => x.Id == this.costumerId).Select(x => x);
                foreach (Costumer costumer in filtered)
                {
                    this.costumer = costumer;
                }
            }

            this.UpdateCostumerUI();
        }

        private void UpdateCostumerUI()
        {
            if (this.costumerId == -1)
            {
                lblCostumerName.Text = "Selecione um cliente...";
                lblCostumerAddress.Hide();

                pnlCostumerIcon.BackgroundImage = Properties.Resources.icon_mais_30x30;
                pnlCostumerIcon.BackgroundImageLayout = ImageLayout.Center;
            }
            else
            {
                var filtered = GlobalVariables.Costumers.Where(x => x.Id == this.costumerId).Select(x => x);
                foreach (Costumer item in filtered)
                {
                    this.costumer = item;
                }

                if (this.costumer.Sex == 'M')
                {
                    pnlCostumerIcon.BackgroundImage = Properties.Resources.icon_perfil_menpadrao_100x100;
                }
                else
                {
                    pnlCostumerIcon.BackgroundImage = Properties.Resources.icon_perfil_woman_100x100;
                }

                pnlCostumerIcon.BackgroundImageLayout = ImageLayout.Stretch;

                if (this.costumer.Name.Length > 28)
                {
                    string aux = this.costumer.Name.Substring(0, 28);
                    aux += "...";
                    lblCostumerName.Text = aux;
                }
                else
                {
                    lblCostumerName.Text = this.costumer.Name;
                }

                lblCostumerAddress.Text = this.costumer.Street + ", " + this.costumer.Number;

                lblCostumerAddress.Show();
            }
        }

        private void UpdateLblTotalDuration()
        {
            TimeSpan duration = dtpExpiration.Value.Subtract(DateTime.Now);

            LBL_TotalDuration.Text = "Duração Total: " + duration.Days + " dias.";
            LBL_TotalDuration.Left = (PNL_ExpirationBack.Width - LBL_TotalDuration.Width) / 2;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            PNL_Background2.BringToFront();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PNL_Background1.BringToFront();
        }

        private void BTN_P_Day_Click(object sender, EventArgs e)
        {
            dtpExpiration.Value = dtpExpiration.Value.AddDays(1);
        }

        private void BTN_P_Month_Click(object sender, EventArgs e)
        {
            dtpExpiration.Value = dtpExpiration.Value.AddMonths(1);
        }

        private void BTN_P_3Month_Click(object sender, EventArgs e)
        {
            dtpExpiration.Value = dtpExpiration.Value.AddMonths(3);
        }

        private void BTN_P_Year_Click(object sender, EventArgs e)
        {
            dtpExpiration.Value = dtpExpiration.Value.AddYears(1);
        }

        private void BTN_M_Day_Click(object sender, EventArgs e)
        {
            dtpExpiration.Value = dtpExpiration.Value.AddDays(-1);
        }

        private void BTN_M_Month_Click(object sender, EventArgs e)
        {
            dtpExpiration.Value = dtpExpiration.Value.AddMonths(-1);
        }

        private void BTN_M_3Month_Click(object sender, EventArgs e)
        {
            dtpExpiration.Value = dtpExpiration.Value.AddMonths(-3);
        }

        private void BTN_M_Year_Click(object sender, EventArgs e)
        {
            dtpExpiration.Value = dtpExpiration.Value.AddYears(-1);
        }

        private void dtpExpiration_ValueChanged(object sender, EventArgs e)
        {
            this.UpdateLblTotalDuration();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (this.costumerId == -1 && this.oldCostumerExists || this.costumer == null && this.oldCostumerExists)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Nenhum cliente foi selecionado! Por favor, selecione um cliente e tente novamente.", 1);
                messOk.Show();

                return;
            }

            if (DateTime.Compare(dtpExpiration.Value, DateTime.Now) < 1)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("A duração da garantia não pode ser igual ou menor que a data de hoje! Por favor, corriga e tente novamente.", 1);
                messOk.Show();

                return;
            }

            Warranty newWarranty = null;

            if (RBT_Product.Checked)
            {
                if (lvlProducts.SelectedItems.Count < 1)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Você precisa selecionar um item da lista de produtos para continuar!", 1);
                    messOk.Show();

                    return;
                }

                int index = GlobalVariables.Products.FindIndex(x => x.Code == lvlProducts.Items[lvlProducts.SelectedIndices[0]].Text && x.Description == lvlProducts.Items[lvlProducts.SelectedIndices[0]].SubItems[1].Text);

                newWarranty = new Warranty(this.oldWarranty.Id, this.oldWarranty.Number, false, this.oldWarranty.StartedIn, dtpExpiration.Value, rtbObservations.Text,  GlobalVariables.Products[index].Id, this.costumerId, GlobalVariables.User.Id);
            }
            else
            {
                if (lvlJobs.SelectedItems.Count < 1)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Você precisa selecionar um item da lista de serviços para continuar!", 1);
                    messOk.Show();

                    return;
                }

                int index = GlobalVariables.Jobs.FindIndex(x => x.Name == lvlJobs.Items[lvlJobs.SelectedIndices[0]].Text);

                newWarranty = new Warranty(this.oldWarranty.Id, this.oldWarranty.Number, true, this.oldWarranty.StartedIn, dtpExpiration.Value, rtbObservations.Text, GlobalVariables.Jobs[index].Id, this.costumerId, GlobalVariables.User.Id);
            }

            if (GlobalVariables.Warranties.Exists(x => x.Type == newWarranty.Type && x.Id_Costumer == newWarranty.Id_Costumer && x.Id_Item == newWarranty.Id_Item && x.ExpiresIn == newWarranty.ExpiresIn) || GlobalVariables.OldWarranties.Exists(x => x.Type == newWarranty.Type && x.Id_Costumer == newWarranty.Id_Costumer && x.Id_Item == newWarranty.Id_Item && x.ExpiresIn == newWarranty.ExpiresIn))
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Já existe uma garantia com esse produto/serviço, cliente e duração! Por favor, verifique e tente novamente.", 1);
                messOk.Show();

                return;
            }            

            if (this.isWarrantyOld)
            {
                // 1/2
                Serialization.SerializeWarranty(newWarranty);

                // 2/2
                int index = GlobalVariables.OldWarranties.FindIndex(x => x.Id == newWarranty.Id);
                GlobalVariables.OldWarranties[index] = newWarranty;
            }
            else
            {
                // 1/3
                MySqlNonQuery.UpdateWarranty(newWarranty);

                // 2/3
                Serialization.SerializeWarranty(newWarranty);

                // 3/3
                int index = GlobalVariables.Warranties.FindIndex(x => x.Id == newWarranty.Id);
                GlobalVariables.Warranties[index] = newWarranty;
            }          
            
            this.Changes = true;

            this.Close();
        }

        private void lvlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateSelectedItemLabel(false);
        }

        private void lvlJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateSelectedItemLabel(true);
        }

        private void UpdateSelectedItemLabel(bool type)
        {
            if (!type)
            {
                if (lvlProducts.SelectedItems.Count < 1)
                {
                    LBL_SelectedItem.Text = "Nenhum item selecionado!";
                    LBL_SelectedItem.ForeColor = Library.Style.ColorsPalette.GDE_Danger;

                    return;
                }

                LBL_SelectedItem.Text = "Produto selecionado: " + lvlProducts.Items[lvlProducts.SelectedIndices[0]].Text + " - " + lvlProducts.Items[lvlProducts.SelectedIndices[0]].SubItems[1].Text;
                LBL_SelectedItem.ForeColor = Color.FromArgb(6, 106, 102);
            }
            else
            {
                if (lvlJobs.SelectedItems.Count < 1)
                {
                    LBL_SelectedItem.Text = "Nenhum item selecionado!";
                    LBL_SelectedItem.ForeColor = Library.Style.ColorsPalette.GDE_Danger;

                    return;
                }

                LBL_SelectedItem.Text = "Serviço selecionado: " + lvlJobs.Items[lvlJobs.SelectedIndices[0]].Text + " - " + lvlJobs.Items[lvlJobs.SelectedIndices[0]].SubItems[1].Text;
                LBL_SelectedItem.ForeColor = Color.FromArgb(6, 106, 102);
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (RBT_Product.Checked)
                {
                    lvlProducts.Items.Clear();

                    List<Product> productsFound = new List<Product>();

                    if (txtSearch.Text.Length <= 0)
                    {
                        this.AllProductsToListView();
                    }
                    else
                    {
                        if (this.productsSearch.ckbCode.Checked)
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
                        if (this.productsSearch.ckbDesc.Checked)
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
                        if (this.productsSearch.ckbPrice.Checked)
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
                        if (this.productsSearch.ckbPos.Checked)
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
                        if (this.productsSearch.ckbWeight.Checked)
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
                                this.ProductToListView(item);
                            }
                        }
                    }
                }
                else
                {
                    lvlJobs.Items.Clear();

                    List<Job> JobsFound = new List<Job>();

                    if (txtSearch.Text.Length <= 0)
                    {
                        this.AllJobsToListView();
                    }
                    else
                    {
                        if (this.jobsSearch.ckbName.Checked)
                        {
                            bool itemAlreadyExists;
                            var filtered = GlobalVariables.Jobs.Where(x => x.Name.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                            foreach (Job item in filtered)
                            {
                                itemAlreadyExists = false;
                                foreach (Job subItem in JobsFound)
                                {
                                    if (item.IsEqualTo(subItem))
                                    {
                                        itemAlreadyExists = true;
                                        break;
                                    }
                                }
                                if (!itemAlreadyExists) JobsFound.Add(item);
                            }
                        }
                        if (this.jobsSearch.ckbDesc.Checked)
                        {
                            bool itemAlreadyExists;
                            var filtered = GlobalVariables.Jobs.Where(x => x.Description != null && x.Description.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                            foreach (Job item in filtered)
                            {
                                itemAlreadyExists = false;
                                foreach (Job subItem in JobsFound)
                                {
                                    if (item.IsEqualTo(subItem))
                                    {
                                        itemAlreadyExists = true;
                                        break;
                                    }
                                }
                                if (!itemAlreadyExists) JobsFound.Add(item);
                            }
                        }
                        if (this.jobsSearch.ckbPrice.Checked)
                        {
                            bool itemAlreadyExists;
                            var filtered = GlobalVariables.Jobs.Where(x => x.Price > 0 && x.Price.ToString("n2").Contains(txtSearch.Text)).Select(x => x);
                            foreach (Job item in filtered)
                            {
                                itemAlreadyExists = false;
                                foreach (Job subItem in JobsFound)
                                {
                                    if (item.IsEqualTo(subItem))
                                    {
                                        itemAlreadyExists = true;
                                        break;
                                    }
                                }
                                if (!itemAlreadyExists) JobsFound.Add(item);
                            }
                        }
                        if (JobsFound.Count() <= 0)
                        {
                            ListViewItem lvi = lvlJobs.Items.Add("Nenhum resultado...");
                        }
                        else
                        {
                            foreach (Job item in JobsFound)
                            {
                                this.JobToListView(item);
                            }
                        }
                    }
                }
            }
        }
    }
}
