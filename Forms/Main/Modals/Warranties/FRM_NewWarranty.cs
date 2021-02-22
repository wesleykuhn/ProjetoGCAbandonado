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
    public partial class FRM_NewWarranty : Bases.FRM_Default
    {
        internal bool Changes = false;

        private int costumerId = -1;
        private Costumer costumer = null;

        private Products.FRM_SearchOptions productsSearch = new Products.FRM_SearchOptions();
        private Jobs.FRM_SearchOptionsJobs jobsSearch = new Jobs.FRM_SearchOptionsJobs();

        public FRM_NewWarranty()
        {
            InitializeComponent();

            this.ReadyForm();

            if (!Care.AntiInvalidInstance)
            {
                //Adjust the searchOptions
                this.productsSearch.ckbPackQuant.Hide();
                this.productsSearch.ckbWeight.Top -= 17;

                string number = (GlobalVariables.User.WarrantyCounter + 1).ToString();
                for (int i = 0; i < 10 - number.Length; i++)
                {
                    LBL_WarrantyNumber.Text += "0";
                }
                LBL_WarrantyNumber.Text += number;

                this.AllProductsToListView();
                this.AllJobsToListView();

                this.UpdateLblTotalDuration();

                LBL_SelectedItem.ForeColor = Library.Style.ColorsPalette.GDE_Danger;
            }
        }

        internal FRM_NewWarranty(List<Product> products, List<Job> jobs)
        {
            InitializeComponent();

            this.ReadyForm();

            if (!Care.AntiInvalidInstance)
            {
                //Adjust the searchOptions
                this.productsSearch.ckbPackQuant.Hide();
                this.productsSearch.ckbWeight.Top -= 17;

                string number = (GlobalVariables.User.WarrantyCounter + 1).ToString();
                for (int i = 0; i < 10 - number.Length; i++)
                {
                    LBL_WarrantyNumber.Text += "0";
                }
                LBL_WarrantyNumber.Text += number;

                this.ProductsToListView(products);
                this.JobsToListView(jobs);

                this.UpdateLblTotalDuration();

                LBL_SelectedItem.ForeColor = Library.Style.ColorsPalette.GDE_Danger;
            }
        }

        private void ProductsToListView(List<Product> products)
        {
            foreach (Product product in products)
            {
                this.ProductToListView(product);
            }
        }

        private void AllProductsToListView()
        {
            foreach (Product product in GlobalVariables.Products)
            {
                this.ProductToListView(product);
            }
        }

        private void JobsToListView(List<Job> jobs)
        {
            foreach (Job job in jobs)
            {
                this.JobToListView(job);
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
            if(this.costumerId == -1 || this.costumer == null)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Nenhum cliente foi selecionado! Por favor, selecione um cliente e tente novamente.", 1);
                messOk.Show();

                return;
            }

            if(DateTime.Compare(dtpExpiration.Value, DateTime.Now) < 1)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("A duração da garantia não pode ser igual ou menor que a data de hoje! Por favor, corriga e tente novamente.", 1);
                messOk.Show();

                return;
            }

            Warranty warranty = null;

            if (RBT_Product.Checked)
            {
                if(lvlProducts.SelectedItems.Count < 1)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Você precisa selecionar um item da lista de produtos para continuar!", 1);
                    messOk.Show();

                    return;
                }

                int index = GlobalVariables.Products.FindIndex(x => x.Code == lvlProducts.Items[lvlProducts.SelectedIndices[0]].Text && x.Description == lvlProducts.Items[lvlProducts.SelectedIndices[0]].SubItems[1].Text);

                warranty = new Warranty(-1, LBL_WarrantyNumber.Text.Substring(LBL_WarrantyNumber.Text.Length - 10, 10), false, DateTime.Now, dtpExpiration.Value, rtbObservations.Text, GlobalVariables.Products[index].Id, this.costumerId, GlobalVariables.User.Id);
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

                warranty = new Warranty(-1, LBL_WarrantyNumber.Text.Substring(LBL_WarrantyNumber.Text.Length - 10, 10), true, DateTime.Now, dtpExpiration.Value, rtbObservations.Text, GlobalVariables.Jobs[index].Id, this.costumerId, GlobalVariables.User.Id);
            }

            if(GlobalVariables.Warranties.Exists(x => x.Type == warranty.Type && x.Id_Costumer == warranty.Id_Costumer && x.Id_Item == warranty.Id_Item && x.ExpiresIn == warranty.ExpiresIn) || GlobalVariables.OldWarranties.Exists(x => x.Type == warranty.Type && x.Id_Costumer == warranty.Id_Costumer && x.Id_Item == warranty.Id_Item && x.ExpiresIn == warranty.ExpiresIn))
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Já existe uma garantia com esse produto/serviço, cliente e duração! Por favor, verifique e tente novamente.", 1);
                messOk.Show();

                return;
            }

            MySqlNonQuery.UpdateUser("warranty_counter", (GlobalVariables.User.WarrantyCounter + 1).ToString());
            GlobalVariables.User.WarrantyCounter++;

            // 1/3
            warranty.Id = MySqlNonQuery.CreateWarranty(warranty);

            // 2/3
            Serialization.SerializeWarranty(warranty);

            // 3/3
            GlobalVariables.Warranties.Add(warranty);

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
                            var filtered = GlobalVariables.Jobs.Where(x => x.Name != null && x.Name.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
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
