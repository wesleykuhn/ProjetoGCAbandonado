using System.Drawing;
using System.Windows.Forms;
using GC.Library.Objects;
using GC.Library.Translators;
using System.Linq;
using GC.GlobalModals;
using System.Collections.Generic;
using System;
using GC.Library.Database;
using GC.Forms.Main.Modals.Requests.SubModals.NewRequest;
using GC.Library.Entities;
using GC.Library.Objects.SubObjects.Request;
using GC.Library.Objects.SubObjects.Product;
using GC.Library;
using GC.Library.Checkers;

namespace GC.Forms.Main.Modals.Requests
{
    public partial class FRM_AlterRequest : Bases.FRM_Full
    {
        private Request oldRequest;        

        internal bool Canceled = false;

        private double oldFinalValue = 0;
        private double FinalValue = 0, JobsValue = 0, ProductsValue = 0;
        private int CostumerId = -1;
        private Costumer Costumer = null;

        private List<Request_Jobs> Jobs = new List<Request_Jobs>();
        private List<Request_Products> Products = new List<Request_Products>();
        private List<Lot> UsedLots = new List<Lot>();

        private List<Request_Jobs> OriginalJobs = new List<Request_Jobs>();
        private List<Request_Products> OriginalProducts = new List<Request_Products>();
        private List<Request_Jobs> ModifiedJobs = new List<Request_Jobs>();
        private List<Request_Products> ModifiedProducts = new List<Request_Products>();

        private List<double> AdditionsValues = new List<double>();
        private List<double> AdditionsPercents = new List<double>();
        private double Additions = 0;
        private double OriginalAdditions = 0;

        private List<double> DiscountsValues = new List<double>();
        private List<double> DiscountsPercents = new List<double>();
        private double Discounts = 0;
        private double OriginalDiscounts = 0;

        private bool HasInDb = false;
        private bool IsOld = false;

        internal FRM_AlterRequest(Request request)
        {
            InitializeComponent();

            this.ReadyForm();

            this.Resize += new EventHandler(CenterLabels);            

            this.Jobs = request.Jobs.ToList();
            this.OriginalJobs = request.Jobs.ToList();
            this.Products = request.Products.ToList();
            this.OriginalProducts = request.Products.ToList();

            lblRequestNumber.Text += request.Number;

            if(request.Discount == -1)
            {
                this.Discounts = 0;
                this.OriginalDiscounts = 0;
            }
            else
            {
                this.Discounts = request.Discount;
                this.OriginalDiscounts = request.Discount;
            }

            if(request.Addition == -1)
            {
                this.Additions = 0;
                this.OriginalAdditions = 0;
            }
            else
            {
                this.Additions = request.Addition;
                this.OriginalAdditions = request.Addition;
            }

            this.oldFinalValue = request.Value;

            this.FinalValue = request.Value;            

            this.CostumerId = request.Id_Costumer;  
            if(this.CostumerId == -1 || !GlobalVariables.Costumers.Exists(x => x.Id == request.Id_Costumer))
            {
                this.Costumer = null;
                lblCostumerName.Text = "Este cliente foi excluído!";
                lblCostumerAddress.Hide();
                lblCostumerDiscountAccumulated.Hide();
                lblCostumerDiscountCounter.Hide();
                chxAddCostumerDiscount.Hide();

                pnlCostumerIcon.BackgroundImage = Properties.Resources.icon_lixeira_30x30;
                pnlCostumerIcon.BackgroundImageLayout = ImageLayout.Center;
            }
            else
            {
                this.Costumer = Costumer.CloneCostumer(this.CostumerId);
                UpdateCostumerUI();
            }

            if (!Structs.IsDateTimeNull(request.ExpiresIn))
            {
                cbxExpires.Checked = true;
                dtpExpiration.Value = request.ExpiresIn;
            }

            cbxPaymentMethod.SelectedIndex = request.PaymentType;

            if (request.IsDelivery)
            {
                cbxIsDelivery.Checked = true;
            }          
            
            rtbObservations.Text = request.Observations;

            foreach (Request_Products reqProd in this.Products)
            {
                Product product = Product.CloneProduct(reqProd.Id_Product);
                if (product == null) continue;

                ListViewItem lvi = null;
                if ((reqProd.Quantity % 1) == 0)
                {
                    lvi = lvlProducts.Items.Add(ObjectToListView.ToIntListView(Convert.ToInt32(reqProd.Quantity)));
                }
                else
                {
                    lvi = lvlProducts.Items.Add(ObjectToListView.ToDoubleListView_ThreeDecimals(reqProd.Quantity));
                }

                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(reqProd.Price * reqProd.Quantity)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, product.Code));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, product.Description));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(reqProd.Price)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(product.Position)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToIntListView(product.PackQuantity)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_ThreeDecimals(product.Weight)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, Supplier.GetSupplierName(product.Id_Supplier)));

                if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);

                this.ProductsValue += (reqProd.Price * reqProd.Quantity);                
            }

            foreach (Request_Jobs reqJob in this.Jobs)
            {
                Job job = Job.CloneJob(reqJob.Id_Job);
                if (job == null) continue;

                ListViewItem lvi = lvlJobs.Items.Add(job.Name);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(job.Description)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(reqJob.Price)));

                if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);

                this.JobsValue += reqJob.Price;
            }

            foreach (Request_Products item4 in this.Products)
            {
                int index = GlobalVariables.Products.FindIndex(x => x.Id == item4.Id_Product);

                if(item4.Price != GlobalVariables.Products[index].Price)
                {
                    this.ModifiedProducts.Add(item4);
                }
            }
            foreach (Request_Jobs item5 in this.Jobs)
            {
                int index = GlobalVariables.Jobs.FindIndex(x => x.Id == item5.Id_Job);

                if (item5.Price != GlobalVariables.Jobs[index].Price)
                {
                    this.ModifiedJobs.Add(item5);
                }
            }

            this.UsedLots = Library.Files.SeekFor.InactiveUsedLots(request.Number);

            this.HasInDb = MySqlReader.ObjectExistsInDB("request", "idrequest", request.Id.ToString());

            UpdateValuesText();
            CenterLabels(this, new EventArgs());

            if (!GlobalVariables.Requests.Exists(x => x.Id == request.Id))
            {
                this.IsOld = true;
            }

            this.oldRequest = request;
        }

        private void frmModal_AlterRequest_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void CenterLabels(object sender, EventArgs e)
        {
            lblConstCost.Left = (panel5.Width - lblConstCost.Width) / 2;
            lblConstJobs.Left = (panel7.Width - lblConstJobs.Width) / 2;
            lblConstProd.Left = (panel6.Width - lblConstProd.Width) / 2;
        }
        // <------------------------------------------------------------------------------------

        private void UpdateValuesText()
        {
            if (this.FinalValue > 9999999)
            {
                FRM_MessageAndOK messOk = new FRM_MessageAndOK("Erro fatal! O valor total do pedido não pode ultrapassar R$ 9999999,99!", 2);
                messOk.Show();

                this.Close();
            }

            lblValue.Text = ObjectToDetailLabel.ToMoneyLabel(this.FinalValue);
            lblValue.Left = pnlBackground1.Width - (lblValue.Width + 10);
            lblValueText.Left = lblValue.Left - 97;

            if (this.Additions == 0)
            {
                lblAdditions.Hide();
                lblAdditionsText.Hide();
            }
            else
            {
                lblAdditions.Show();
                lblAdditionsText.Show();

                lblAdditions.Text = ObjectToDetailLabel.ToMoneyLabel(this.Additions);
                lblAdditions.Left = lblValueText.Left - (20 + lblAdditions.Width);
                lblAdditionsText.Left = lblAdditions.Left - 100;
            }

            if (this.Discounts == 0)
            {
                lblDiscounts.Hide();
                lblDiscountsText.Hide();
            }
            else
            {
                if (lblAdditions.Visible)
                {
                    lblDiscounts.Show();
                    lblDiscountsText.Show();

                    lblDiscounts.Text = ObjectToDetailLabel.ToMoneyLabel(this.Discounts);
                    lblDiscounts.Left = lblAdditionsText.Left - (20 + lblDiscounts.Width);
                    lblDiscountsText.Left = lblDiscounts.Left - 95;
                }
                else
                {
                    lblDiscounts.Show();
                    lblDiscountsText.Show();

                    lblDiscounts.Text = ObjectToDetailLabel.ToMoneyLabel(this.Discounts);
                    lblDiscounts.Left = lblValueText.Left - (20 + lblDiscounts.Width);
                    lblDiscountsText.Left = lblDiscounts.Left - 95;
                }
            }
        }

        private void UpdateAdditions()
        {
            this.FinalValue -= this.Additions;

            this.Additions = 0;

            if (this.AdditionsValues.Count > 0)
            {
                foreach (double item in this.AdditionsValues)
                {
                    this.Additions += item;
                    this.FinalValue += item;
                }
            }
            if (this.AdditionsPercents.Count > 0)
            {
                foreach (double item in this.AdditionsPercents)
                {
                    this.Additions += (item * this.FinalValue) / 100;
                    this.FinalValue += (item * this.FinalValue) / 100;
                }
            }
        }

        private void UpdateDiscounts()
        {
            this.FinalValue += this.Discounts;

            this.Discounts = 0;

            if (this.DiscountsValues.Count > 0)
            {
                foreach (double item in this.DiscountsValues)
                {
                    this.Discounts += item;
                    this.FinalValue -= item;
                }
            }
            if (this.DiscountsPercents.Count > 0)
            {
                foreach (double item in this.DiscountsPercents)
                {
                    this.Discounts += (item * this.FinalValue) / 100;
                    this.FinalValue -= (item * this.FinalValue) / 100;
                }
            }
        }

        private void UpdateCostumerUI()
        {
            var filtered = GlobalVariables.Costumers.Where(x => x.Id == this.CostumerId).Select(x => x);
            foreach (Costumer item in filtered)
            {
                this.Costumer = item;
            }

            if(this.Costumer.Sex == 'M')
            {
                pnlCostumerIcon.BackgroundImage = Properties.Resources.icon_perfil_menpadrao_100x100;
            }
            else
            {
                pnlCostumerIcon.BackgroundImage = Properties.Resources.icon_perfil_woman_100x100;
            }

            if (this.Costumer.Name.Length > 28)
            {
                string aux = this.Costumer.Name.Substring(0, 28);
                aux += "...";
                lblCostumerName.Text = aux;
            }
            else
            {
                lblCostumerName.Text = this.Costumer.Name;
            }

            lblCostumerAddress.Text = this.Costumer.Street + ", " + this.Costumer.Number;
            lblCostumerDiscountAccumulated.Text = "Desconto acumulado: " + ObjectToDetailLabel.ToMoneyLabel(this.Costumer.DiscountAccumulated);
            lblCostumerDiscountCounter.Text = "Compras/Pedidos anotados: " + ObjectToDetailLabel.ToIntLabel(this.Costumer.DiscountCounter);

            lblCostumerAddress.Show();
            lblCostumerDiscountAccumulated.Show();
            lblCostumerDiscountCounter.Show();
            chxAddCostumerDiscount.Show();
        }

        private void CbxAddCostumerDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chxAddCostumerDiscount.Checked)
            {
                if (this.Costumer.DiscountAccumulated == -1)
                {
                    FRM_MessageAndOK messOk = new FRM_MessageAndOK("O cliente selecionado não possuí nenhum desconto acumulado!", 6);
                    messOk.Show();
                    chxAddCostumerDiscount.Checked = false;
                    return;
                }

                if (this.Costumer.DiscountAccumulated > 0)
                {
                    this.FinalValue -= this.Costumer.DiscountAccumulated;
                }

                UpdateAdditions();
                UpdateDiscounts();
                UpdateValuesText();
            }
            else
            {
                if (this.Costumer.DiscountAccumulated > 0)
                {
                    this.FinalValue += this.Costumer.DiscountAccumulated;
                }

                UpdateAdditions();
                UpdateDiscounts();
                UpdateValuesText();
            }
        }

        private void btnAddJobs_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Jobs.Count == 0)
            {
                FRM_MessageAndOK messOk = new FRM_MessageAndOK("Você não tem nenhum serviço adicionado no sistema!", 6);
                messOk.Show();
                return;
            }

            lvlJobs.Items.Clear();

            List<Request_Jobs> toBeIgnored = new List<Request_Jobs>();
            List<Job> newList = new List<Job>();
            foreach (Request_Jobs item in this.Jobs)
            {
                if(this.ModifiedJobs.Exists(x => x.Id_Job == item.Id_Job && x.Price == item.Price))
                {
                    toBeIgnored.Add(item);
                }
                else
                {
                    newList.Add(Job.CloneJob(item.Id_Job));
                }
            }

            this.FinalValue -= JobsValue;
            JobsValue = 0;

            FRM_JobsList jobsList = new FRM_JobsList(newList);
            jobsList.ShowDialog();

            this.Jobs = toBeIgnored;
            foreach (Job item2 in jobsList.SelectedJobs)
            {
                this.Jobs.Add(new Request_Jobs(item2.Id, item2.Price));
            }

            lvlJobs.Items.Clear();
            foreach (Request_Jobs item3 in this.Jobs)
            {
                Job job = Job.CloneJob(item3.Id_Job);
                if (job == null) continue;

                ListViewItem lvi = lvlJobs.Items.Add(job.Name);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(job.Description)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(item3.Price)));

                if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);

                JobsValue += item3.Price;
            }

            this.FinalValue += JobsValue;

            UpdateAdditions();
            UpdateDiscounts();
            UpdateValuesText();
        }

        private void btnRemoveJobs_Click(object sender, EventArgs e)
        {
            if (lvlJobs.SelectedItems.Count == 0)
            {
                GlobalModals.FRM_MessageAndOK messOk = new FRM_MessageAndOK("Você precisa selecionar pelo menos um serviço antes de clicar em remover!", 6);
                messOk.Show();
                return;
            }
            else
            {
                FRM_Confirmation confirmation = new FRM_Confirmation("Este(s) serviço(s) será(ão) removido(s) do pedido. Tem certeza que deseja continuar?", 1);
                confirmation.Show();

                if (confirmation.Result)
                {
                    List<string> names = new List<string>();
                    for (int i = 0; i < lvlJobs.SelectedItems.Count; i++)
                    {
                        names.Add(lvlJobs.Items[lvlJobs.SelectedIndices[i]].Text);
                    }

                    foreach (string item in names)
                    {
                        Job job = Job.CloneJob(item);
                        if (job == null) continue;

                        int index = this.Jobs.FindIndex(x => x.Id_Job == job.Id);
                        this.Jobs.RemoveAt(index);
                    }
                }
                else return;

                lvlJobs.Items.Clear();

                this.FinalValue -= JobsValue;
                JobsValue = 0;

                foreach (Request_Jobs item2 in this.Jobs)
                {
                    Job job = Job.CloneJob(item2.Id_Job);
                    if (job == null) continue;

                    ListViewItem lvi = lvlJobs.Items.Add(job.Name);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(job.Description)));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(item2.Price)));

                    if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);

                    JobsValue += item2.Price;
                }

                this.FinalValue += JobsValue;

                UpdateAdditions();
                UpdateDiscounts();
                UpdateValuesText();
            }
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Products.Count == 0)
            {
                GlobalModals.FRM_MessageAndOK messOk = new FRM_MessageAndOK("Você não tem nenhum produto adicionado no sistema!", 1);
                messOk.Show();
                return;
            }            

            //This will select what products and jobs are modified and don't need to be on the global product's list
            List<Request_Products> toBeIgnored = new List<Request_Products>();
            List<Request_Products> newList = new List<Request_Products>();
            foreach (Request_Products item in this.Products)
            {
                if (this.ModifiedProducts.Exists(x => x.Id_Product == item.Id_Product && x.Price == item.Price))
                {
                    toBeIgnored.Add(item);
                }
                else
                {
                    newList.Add(item);
                }
            }

            lvlProducts.Items.Clear();
            this.FinalValue -= this.ProductsValue;
            this.ProductsValue = 0;

            FRM_ProductsList productsList = new FRM_ProductsList(this.Products, true);
            productsList.ShowDialog();

            //System to avoid the duplication of products
            bool message = false;
            List<int> idsToRemove = new List<int>();
            foreach (Request_Products item3 in productsList.SelectedProducts)
            {
                if (toBeIgnored.Exists(x => x.Id_Product == item3.Id_Product))
                {
                    message = true;
                    idsToRemove.Add(item3.Id_Product);                    
                }
            }
            foreach (int item4 in idsToRemove)
            {
                productsList.SelectedProducts.RemoveAll(x => x.Id_Product == item4);
            }
            if (message)
            {
                GlobalModals.FRM_MessageAndOK messOk = new FRM_MessageAndOK("Atenção! Um ou mais produtos selecionados " +
                        "já estavam inclusos no pedido, porém com preço diferente. Por isso, esses produtos não foram adiconados. " +
                        "Você só poderá adicionar um produto com o preço novo depois que remover o produto com o preço antigo.", 6);
                messOk.Show();
            }

            this.Products = toBeIgnored;
            foreach (Request_Products item2 in productsList.SelectedProducts)
            {               
                this.Products.Add(item2);
            }

            lvlProducts.Items.Clear();
            foreach (Request_Products item in this.Products)
            {
                Product product = Product.CloneProduct(item.Id_Product);
                if (product == null) continue;

                ListViewItem lvi = null;
                if ((item.Quantity % 1) == 0)
                {
                    lvi = lvlProducts.Items.Add(ObjectToListView.ToIntListView(Convert.ToInt32(item.Quantity)));
                }
                else
                {
                    lvi = lvlProducts.Items.Add(ObjectToListView.ToDoubleListView_ThreeDecimals(item.Quantity));
                }

                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(item.Price * item.Quantity)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, product.Code));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, product.Description));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(item.Price)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(product.Position)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToIntListView(product.PackQuantity)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_ThreeDecimals(product.Weight)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, Supplier.GetSupplierName(product.Id_Supplier)));

                if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);

                ProductsValue += (item.Price * item.Quantity);
            }

            this.FinalValue += ProductsValue;

            UpdateAdditions();
            UpdateDiscounts();
            UpdateValuesText();
        }

        private void btnRemoveProducts_Click(object sender, EventArgs e)
        {
            if (lvlProducts.SelectedItems.Count == 0)
            {
                FRM_MessageAndOK messOk = new FRM_MessageAndOK("Você precisa selecionar pelo menos um produto antes de clicar em remover!", 6);
                messOk.Show();
                return;
            }
            else
            {
                FRM_Confirmation confirmation = new FRM_Confirmation("Este(s) produto(s) será(ão) removido(s) do pedido. Tem certeza que deseja continuar?", 1);
                confirmation.Show();

                if (confirmation.Result)
                {
                    List<string> codes = new List<string>();
                    List<string> descriptions = new List<string>();

                    for (int i = 0; i < lvlProducts.SelectedItems.Count; i++)
                    {
                        codes.Add(lvlProducts.Items[lvlProducts.SelectedIndices[i]].SubItems[2].Text);
                        descriptions.Add(lvlProducts.Items[lvlProducts.SelectedIndices[i]].SubItems[3].Text);
                    }

                    for (int i = 0; i < codes.Count; i++)
                    {
                        int id = Product.GetProductId(codes[i], descriptions[i]);
                        int index = this.Products.FindIndex(x => x.Id_Product == id);
                        this.Products.RemoveAt(index);
                    }
                }
                else return;

                lvlProducts.Items.Clear();

                this.FinalValue -= ProductsValue;
                ProductsValue = 0;

                foreach (Request_Products item in this.Products)
                {
                    Product product = Product.CloneProduct(item.Id_Product);
                    if (product == null) continue;

                    ListViewItem lvi = null;
                    if ((item.Quantity % 1) == 0)
                    {
                        lvi = lvlProducts.Items.Add(ObjectToListView.ToIntListView(Convert.ToInt32(item.Quantity)));
                    }
                    else
                    {
                        lvi = lvlProducts.Items.Add(ObjectToListView.ToDoubleListView_ThreeDecimals(item.Quantity));
                    }

                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(item.Price * item.Quantity)));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, product.Code));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, product.Description));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(item.Price)));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(product.Position)));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToIntListView(product.PackQuantity)));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_ThreeDecimals(product.Weight)));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, Supplier.GetSupplierName(product.Id_Supplier)));

                    if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);

                    ProductsValue += (item.Price * item.Quantity);
                }

                this.FinalValue += ProductsValue;

                UpdateAdditions();
                UpdateDiscounts();
                UpdateValuesText();
            }
        }

        private void cbxExpires_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxExpires.Checked)
            {
                dtpExpiration.Enabled = true;
            }
            else
            {
                dtpExpiration.Enabled = false;
            }
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            this.FinalValue -= this.Additions;

            FRM_EditAdditions frmAdditions = new FRM_EditAdditions(AdditionsValues, AdditionsPercents);
            frmAdditions.ShowDialog();

            this.Additions = 0;
            this.AdditionsValues = frmAdditions.Values;
            this.AdditionsPercents = frmAdditions.Percents;

            if (this.AdditionsValues.Count > 0)
            {
                foreach (double item in this.AdditionsValues)
                {
                    this.Additions += item;
                    this.FinalValue += item;
                }
            }
            if (this.AdditionsPercents.Count > 0)
            {
                foreach (double item in this.AdditionsPercents)
                {
                    this.Additions += (item * this.FinalValue) / 100;
                    this.FinalValue += (item * this.FinalValue) / 100;
                }
            }

            UpdateValuesText();
        }

        private void pnlMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            pnlBackground2.BringToFront();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pnlBackground1.BringToFront();
        }

        private void btnDiscounts_Click(object sender, EventArgs e)
        {
            this.FinalValue += this.Discounts;

            FRM_EditDiscounts frmDiscounts = new FRM_EditDiscounts(DiscountsValues, DiscountsPercents);
            frmDiscounts.ShowDialog();

            this.Discounts = 0;
            this.DiscountsValues = frmDiscounts.Values;
            this.DiscountsPercents = frmDiscounts.Percents;

            if (this.DiscountsValues.Count > 0)
            {
                foreach (double item in this.DiscountsValues)
                {
                    this.Discounts += item;
                    this.FinalValue -= item;
                }
            }
            if (this.DiscountsPercents.Count > 0)
            {
                foreach (double item in this.DiscountsPercents)
                {
                    this.Discounts += (item * this.FinalValue) / 100;
                    this.FinalValue -= (item * this.FinalValue) / 100;
                }
            }

            UpdateValuesText();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (this.Products.Count == 0 && this.Jobs.Count == 0)
            {
                FRM_MessageAndOK messOk = new FRM_MessageAndOK("Você precisa selecionar pelo menos um produto ou um serviço para poder criar um pedido! Por favor, selecione.", 6);
                messOk.Show();
                return;
            }
            if (this.FinalValue <= 0)
            {
                FRM_MessageAndOK messOk = new FRM_MessageAndOK("O valor do pedido não pode ser menor ou igual a zero! Por favor, corrija e então finalize o pedido ou cancele a criação do pedido.", 1);
                messOk.Show();
                return;
            }           

            if (this.oldRequest.PaymentType == 6 && cbxPaymentMethod.SelectedIndex != 6)
            {
                int index = GlobalVariables.Costumers.FindIndex(x => x.Id == this.CostumerId);

                if (index >= 0)
                {
                    if (GlobalVariables.Costumers[index].Debt >= this.oldFinalValue)
                    {
                        GlobalVariables.Costumers[index].Debt -= this.oldFinalValue;

                        MySqlNonQuery.UpdateCostumerDebt(GlobalVariables.Costumers[index]);
                    }
                    else
                    {
                        GlobalModals.FRM_MessageAndOK.BuildAndShow("Atenção! A forma de pagamento anterior, do pedido, era 'Fiado', ela foi alterada. O valor fiado do pedido era de " + ObjectToDetailLabel.ToMoneyLabel(this.oldFinalValue) + ", mas nesse momento o cliente está devendo apenas " + ObjectToDetailLabel.ToMoneyLabel(GlobalVariables.Costumers[index].Debt) + "! O programa não deixará o cliente perder dinheiro neste estorno que você está tentando fazer. Por favor, verifique o que houve com a dívida do cliente depois que a forma de pagamento deste pedido foi criada/alterada para 'Fiado'.", 2);

                        return;
                    }
                }
            }

            FRM_MiniLoad ml = new FRM_MiniLoad();
            ml.Show();

            DateTime expiresIn = new DateTime(1, 1, 1, 0, 0, 0);
            if (cbxExpires.Checked)
            {
                expiresIn = dtpExpiration.Value;
            }

            double discount = -1, addition = -1;
            if (this.Discounts > 0) discount = this.Discounts;
            if (this.Additions > 0) addition = this.Additions;
           
            if (chxAddCostumerDiscount.Checked)
            {
                if(this.oldRequest.Occurrences != null && this.oldRequest.Occurrences.Length > 0)
                {
                    this.oldRequest.Occurrences += "\n\n";
                }
                this.oldRequest.Occurrences += "Foi adicionado o desconto acumulado do cliente, que era(m) " + ObjectToDetailLabel.ToMoneyLabel(this.Costumer.DiscountAccumulated) + "," +
                    " no valor deste pedido em " + DateTime.Now.ToString("dd/MM/yyyy") + " às " + DateTime.Now.ToString("HH:mm:ss") + ".";
            }

            Request request = new Request(this.oldRequest.Id, this.oldRequest.Number, this.FinalValue, discount, addition, FieldsToObject.ToString(rtbObservations.Text), this.oldRequest.Occurrences, this.oldRequest.Status, this.oldRequest.StartedIn, expiresIn, new DateTime(1, 1, 1, 0, 0, 0), cbxIsDelivery.Checked, Convert.ToByte(cbxPaymentMethod.SelectedIndex), this.CostumerId, GlobalVariables.User.Id);

            

            List<int> productsIds = GlobalVariables.Products.Select(x => x.Id).ToList();

            //This system is very complex. I coudn't split this is methods. The name of the system is product breakdown. A solution when a product goes out of the created request, or added more
            //quantity of it.
            // -------------------------- PRODUCT BREAKDOWN BEGIN -----------------------------------
            List<int> ignoreProducts = new List<int>();
            List<Request_Products> porsToBeConsumed = new List<Request_Products>();
            //If the two lists new and original has the same object, then update the POR
            // A1 block
            foreach (Request_Products item1 in this.Products)
            {
                foreach (Request_Products original in this.OriginalProducts)
                {
                    if (original.Id_Product == item1.Id_Product && original.Price == item1.Price)
                    {
                        // A1.1 Block
                        if(original.Quantity < item1.Quantity)
                        {
                            if (this.HasInDb)
                            {
                                MySqlNonQuery.UpdateRequestProductsQuantity(this.oldRequest.Id, item1);
                            }                            

                            Request_Products por = new Request_Products(item1.Id_Product, item1.Quantity - original.Quantity, item1.Price);
                            porsToBeConsumed.Add(por);

                            ignoreProducts.Add(item1.Id_Product);
                        }
                        // A1.2 Block
                        else if(original.Quantity > item1.Quantity)
                        {
                            if (this.HasInDb)
                            {
                                MySqlNonQuery.UpdateRequestProductsQuantity(this.oldRequest.Id, item1);
                            }                            

                            if(!this.UsedLots.Exists(x => x.Id_Product == item1.Id_Product))
                            {
                                GlobalModals.FRM_Confirmation conf3 = new FRM_Confirmation("Aviso! Um ou todos os " +
                                    "produtos que tiveram sua quantidade diminuída não tem o arquivo de estorno de lote(s) presente neste " +
                                    "computador ou o arquivo está corrompido! Não será posível estornar automaticamente a " +
                                    "quantidade dos produtos que foram removidos do pedido! Deseja continuar assim mesmo? Se sim, " +
                                    "realize o estorno manualmente.", 1);
                                conf3.Show();
                                if (!conf3.Result)
                                {
                                    GlobalModals.FRM_MessageAndOK messOk = new FRM_MessageAndOK("A janela de alteração " +
                                        "de pedidos será fechada para a preservação dos dados do pedido.", 6);
                                    messOk.Show();
                                    this.Close();
                                }

                                break;
                            }

                            double quantityLeft = original.Quantity - item1.Quantity;

                            List<Lot> lotsOfItem1 = this.UsedLots.Where(x => x.Id_Product == item1.Id_Product).Select(x => x).ToList();

                            foreach (Lot item6 in lotsOfItem1)
                            {
                                bool exists = GlobalVariables.Lots.Exists(x => x.Id == item6.Id);

                                // A1.2.1 Block
                                if (item6.Quantity == quantityLeft)
                                {
                                    if (exists)
                                    {
                                        int index = GlobalVariables.Lots.FindIndex(x => x.Id == item6.Id);
                                        GlobalVariables.Lots[index].Quantity += item6.Quantity;
                                        MySqlNonQuery.UpdateLotQuantity(item6.Id, GlobalVariables.Lots[index].Quantity);                                      
                                    }
                                    else
                                    {
                                        item6.Id = MySqlNonQuery.CreateLot(item6);
                                        GlobalVariables.Lots.Add(item6);
                                    }

                                    this.UsedLots.Remove(item6);
                                    quantityLeft = 0;
                                }
                                // A1.2.2 Block
                                else if (item6.Quantity < quantityLeft)
                                {
                                    if (exists)
                                    {
                                        int index = GlobalVariables.Lots.FindIndex(x => x.Id == item6.Id);
                                        GlobalVariables.Lots[index].Quantity += item6.Quantity;
                                        MySqlNonQuery.UpdateLotQuantity(item6.Id, GlobalVariables.Lots[index].Quantity);
                                    }
                                    else
                                    {
                                        item6.Id = MySqlNonQuery.CreateLot(item6);
                                        GlobalVariables.Lots.Add(item6);
                                    }

                                    this.UsedLots.Remove(item6);
                                    quantityLeft -= item6.Quantity;
                                }
                                // A1.2.3 Block
                                else
                                {
                                    if (exists)
                                    {
                                        int index = GlobalVariables.Lots.FindIndex(x => x.Id == item6.Id);
                                        GlobalVariables.Lots[index].Quantity += quantityLeft;
                                        MySqlNonQuery.UpdateLotQuantity(item6.Id, GlobalVariables.Lots[index].Quantity);
                                    }
                                    else
                                    {
                                        Lot lot = new Lot(item6.Id, item6.Number, quantityLeft, item6.Entry, item6.ExpiresIn, item6.Id_Product);
                                        lot.Id = MySqlNonQuery.CreateLot(lot);
                                        GlobalVariables.Lots.Add(lot);
                                    }

                                    int index3 = this.UsedLots.FindIndex(x => x.Id == item6.Id);
                                    this.UsedLots[index3].Quantity -= quantityLeft;
                                    quantityLeft = 0;
                                }

                                if (quantityLeft == 0) break;
                            }

                            ignoreProducts.Add(item1.Id_Product);
                        }
                        // A1.3 Block
                        else if(original.Quantity == item1.Quantity)
                        {
                            ignoreProducts.Add(item1.Id_Product);
                        }
                    }
                }                
            }

            //Delete the removed request_itens from DB and take back the used lots
            // B1 Block
            foreach (Request_Products item4 in this.OriginalProducts)
            {
                if (!this.Products.Exists(x => x.Id_Product == item4.Id_Product && x.Price == item4.Price))
                {
                    // B1.1 Block
                    if (this.UsedLots.Count > 0)
                    {                       
                        bool deletedProduct = false;
                        foreach (Lot item in this.UsedLots)
                        {
                            if (!productsIds.Contains(item.Id_Product))
                            {
                                deletedProduct = true;
                                break;
                            }
                        }
                        if (deletedProduct)
                        {
                            GlobalModals.FRM_Confirmation conf3 = new GlobalModals.FRM_Confirmation("Foi detectado que um" +
                                " dos produtos, que estavam neste pedido e foram removidos, não possuí o arquivo de estorno " +
                                "neste computador. Isso torna impossível o estorno automático dos lotes deste produto. " +
                                "Deseja continuar assim mesmo? Se sim, o(s) lote(s) cujo produto foi excluído não serão estornados!", 1);
                            conf3.Show();
                            if (!conf3.Result)
                            {
                                this.Close();
                            }
                        }

                        var filtered = this.UsedLots.Where(x => x.Id_Product == item4.Id_Product).Select(x => x);
                        foreach (Lot item in filtered)
                        {
                            if (!productsIds.Contains(item.Id_Product))
                            {
                                continue;
                            }

                            bool exists = GlobalVariables.Lots.Exists(x => x.Id == item.Id);

                            // B1.1.1 Block
                            if (exists)
                            {
                                int index = GlobalVariables.Lots.FindIndex(x => x.Id == item.Id);
                                GlobalVariables.Lots[index].Quantity += item.Quantity;
                                MySqlNonQuery.UpdateLotQuantity(item.Id, GlobalVariables.Lots[index].Quantity);
                            }
                            // B1.1.2 Block
                            else
                            {                                
                                item.Id = MySqlNonQuery.CreateLot(item);
                                GlobalVariables.Lots.Add(item);
                            }
                        }
                    }

                    if(this.UsedLots.Exists(x => x.Id_Product == item4.Id_Product))
                    {
                        this.UsedLots.RemoveAll(x => x.Id_Product == item4.Id_Product);
                    }

                    // B1.2 Block
                    if (this.HasInDb)
                    {
                        MySqlNonQuery.DeleteRequestProducts(this.oldRequest.Id, item4);
                    }
                }
            }

            // C1 Block
            if (this.HasInDb)
            {
                foreach (Request_Products item5 in this.Products)
                {
                    if (!this.OriginalProducts.Exists(x => x.Id_Product == item5.Id_Product && x.Price == item5.Price))
                    {
                        MySqlNonQuery.CreateRequestProducts(this.oldRequest.Id, item5);
                    }
                }
            }

            //-------------------------- JOBS OF REQUEST BEGIN ------------------------------------
            if (this.HasInDb)
            {
                foreach (Request_Jobs item3 in this.Jobs)
                {
                    if (!this.OriginalJobs.Exists(x => x.Id_Job == item3.Id_Job && x.Price == item3.Price))
                    {
                        MySqlNonQuery.CreateRequestJobs(this.oldRequest.Id, item3);
                    }
                }
                foreach (Request_Jobs item in this.OriginalJobs)
                {
                    if (!this.Jobs.Exists(x => x.Id_Job == item.Id_Job && x.Price == item.Price))
                    {
                        MySqlNonQuery.DeleteRequestJobs(this.oldRequest.Id, item);
                    }
                }                
            }            

            //We can only apply the new rps and rjs on the new Request if there are new stuff
            if (this.Jobs.Count != 0)
            {
                request.Jobs = this.Jobs.ToList();
            }
            if (this.Products.Count != 0)
            {
                request.Products = this.Products.ToList();
            }

            //Lot's consumption system.
            // C1 Block: When the demand is greater or equal of the stock we consume everything that exists of that product.
            // C2 Block: When the demand is less than the stock we consume lot by lot until get the necesary value.
            // C2.1 Block: Starts the navigation through the lots on THAT product only.
            // C2.1.1 Block: If the demand is greater or equals to lot's quantity we consume the entire lot and recalculate the
            //remaining diference.
            // C2.1.2 Block: If the demand is less than lot's quantity we recalculate the new lot's quantity without the
            //consumed amount.
            List<Lot> productsToLotsHelper = new List<Lot>();
            List<Lot> lotsConsumption = new List<Lot>();
            // C Block -> Lot's consumption system (LCS)
            foreach (Request_Products item in this.Products)
            {
                if (ignoreProducts.Exists(x => x == item.Id_Product)) continue;

                double stock = Product.GetTotalStockQuantity(item.Id_Product);

                if (stock <= 0)
                {
                    productsToLotsHelper.Add(new Lot(-1, null, item.Quantity, new DateTime(1, 1, 1, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0), item.Id_Product));
                    continue;
                }
                // C1 Block
                else if (item.Quantity >= stock)
                {
                    MySqlNonQuery.DeleteLotsByProductId(item.Id_Product);

                    var filtered = GlobalVariables.Lots.Where(x => x.Id_Product == item.Id_Product).Select(x => x);
                    foreach (Lot item3 in filtered)
                    {
                        lotsConsumption.Add(item3);
                        productsToLotsHelper.Add(item3);
                    }

                    GlobalVariables.Lots.RemoveAll(x => x.Id_Product == item.Id_Product);
                }
                // C2 Block
                else
                {
                    double quantityRemaining = item.Quantity;

                    List<Lot> lots = GlobalVariables.Lots.Where(x => x.Id_Product == item.Id_Product).Select(x => x).ToList();

                    bool hasExpirationDate = false;
                    foreach (Lot item5 in lots)
                    {
                        if (!Structs.IsDateTimeNull(item5.ExpiresIn))
                        {
                            hasExpirationDate = true;
                            break;
                        }
                    }

                    //If the product expires then we cosume by the expiration date
                    if (hasExpirationDate)
                    {
                        lots.Sort((x, y) => DateTime.Compare(x.ExpiresIn, y.ExpiresIn));
                    }
                    //Else we consume by the entry date
                    else
                    {
                        lots.Sort((x, y) => DateTime.Compare(x.Entry, y.Entry));
                    }

                    // C2.1 Block
                    foreach (Lot item2 in lots)
                    {
                        // C2.1.1 Block
                        if (quantityRemaining >= item2.Quantity)
                        {
                            MySqlNonQuery.DeleteLotById(item2.Id);

                            var filtered = GlobalVariables.Lots.Where(x => x.Id == item2.Id).Select(x => x);
                            foreach (Lot item4 in filtered)
                            {
                                lotsConsumption.Add(item4);
                                productsToLotsHelper.Add(item4);
                            }

                            GlobalVariables.Lots.RemoveAll(x => x.Id == item2.Id);
                            quantityRemaining -= item2.Quantity;
                        }
                        // C2.1.2 Block
                        else if (quantityRemaining < item2.Quantity)
                        {
                            double newQuantity = item2.Quantity - quantityRemaining;
                            MySqlNonQuery.UpdateLotQuantity(item2.Id, newQuantity);

                            Lot consumedLot = new Lot(item2.Id, item2.Number, quantityRemaining, item2.Entry, item2.ExpiresIn, item2.Id_Product);
                            lotsConsumption.Add(consumedLot);
                            productsToLotsHelper.Add(consumedLot);

                            int index = GlobalVariables.Lots.FindIndex(x => x.Id == item2.Id);
                            GlobalVariables.Lots[index].Quantity = newQuantity;
                            break;
                        }
                        if (quantityRemaining == 0)
                        {
                            break;
                        }
                    }
                }
            }

            //Duplicated code due the aditional lot's consumption of the original PORs comparated with the new PORs
            foreach (Request_Products item in porsToBeConsumed)
            {
                double stock = Product.GetTotalStockQuantity(item.Id_Product);

                if (stock <= 0)
                {
                    productsToLotsHelper.Add(new Lot(-1, null, item.Quantity, new DateTime(1, 1, 1, 0, 0, 0), new DateTime(1, 1, 1, 0, 0, 0), item.Id_Product));
                    continue;
                }
                // C1 Block
                else if (item.Quantity >= stock)
                {
                    MySqlNonQuery.DeleteLotsByProductId(item.Id_Product);

                    var filtered = GlobalVariables.Lots.Where(x => x.Id_Product == item.Id_Product).Select(x => x);
                    foreach (Lot item3 in filtered)
                    {
                        lotsConsumption.Add(item3);
                        productsToLotsHelper.Add(item3);
                    }

                    GlobalVariables.Lots.RemoveAll(x => x.Id_Product == item.Id_Product);
                }
                // C2 Block
                else
                {
                    double quantityRemaining = item.Quantity;

                    List<Lot> lots = GlobalVariables.Lots.Where(x => x.Id_Product == item.Id_Product).Select(x => x).ToList();

                    bool hasExpirationDate = false;
                    foreach (Lot item5 in lots)
                    {
                        if (!Structs.IsDateTimeNull(item5.ExpiresIn))
                        {
                            hasExpirationDate = true;
                            break;
                        }
                    }

                    //If the product expires then we cosume by the expiration date
                    if (hasExpirationDate)
                    {
                        lots.Sort((x, y) => DateTime.Compare(x.ExpiresIn, y.ExpiresIn));
                    }
                    //Else we consume by the entry date
                    else
                    {
                        lots.Sort((x, y) => DateTime.Compare(x.Entry, y.Entry));
                    }

                    // C2.1 Block
                    foreach (Lot item2 in lots)
                    {
                        // C2.1.1 Block
                        if (quantityRemaining >= item2.Quantity)
                        {
                            MySqlNonQuery.DeleteLotById(item2.Id);

                            var filtered = GlobalVariables.Lots.Where(x => x.Id == item2.Id).Select(x => x);
                            foreach (Lot item4 in filtered)
                            {
                                lotsConsumption.Add(item4);
                                productsToLotsHelper.Add(item4);
                            }

                            GlobalVariables.Lots.RemoveAll(x => x.Id == item2.Id);
                            quantityRemaining -= item2.Quantity;
                        }
                        // C2.1.2 Block
                        else if (quantityRemaining < item2.Quantity)
                        {
                            double newQuantity = item2.Quantity - quantityRemaining;
                            MySqlNonQuery.UpdateLotQuantity(item2.Id, newQuantity);

                            Lot consumedLot = new Lot(item2.Id, item2.Number, quantityRemaining, item2.Entry, item2.ExpiresIn, item2.Id_Product);
                            lotsConsumption.Add(consumedLot);
                            productsToLotsHelper.Add(consumedLot);

                            int index = GlobalVariables.Lots.FindIndex(x => x.Id == item2.Id);
                            GlobalVariables.Lots[index].Quantity = newQuantity;
                            break;
                        }
                        if (quantityRemaining == 0)
                        {
                            break;
                        }
                    }
                }
            }
            
            foreach (Lot item8 in this.UsedLots)
            {
                lotsConsumption.Add(item8);
            }          
            if (lotsConsumption.Count > 0)
            {
                string lotsFileDir = Library.Informations.Directories.LotsConsumption + this.oldRequest.Number + "_" + GlobalVariables.User.Id.ToString() + ".txt";
                Serialization.ObjectsListToTxtFile<Lot>(lotsConsumption, lotsFileDir, true);
            }
            else
            {
                Library.Files.Control.DeleteLotsConsumptionFile(this.oldRequest.Number);
            }

            List<Lot> lotsToDesc = new List<Lot>();
            foreach (Lot item7 in productsToLotsHelper)
            {
                if (item7.Number == null) continue;
                lotsToDesc.Add(item7);
            }

            //System to put the used lots into the request's description field            
            if (lotsToDesc.Count > 0)
            {
                string usedLotsToDesc = "";
                if (request.Occurrences != null && request.Occurrences.Length > 0)
                {
                    usedLotsToDesc += "\n\n";
                }

                usedLotsToDesc += "*Lotes usados no pedido em " + DateTime.Now.ToString("dd/MM/yyyy") + " às " + DateTime.Now.ToString("HH:mm:ss") + "*\n";

                for (int i = 0; i < lotsToDesc.Count; i++)
                {
                    Product product = Product.CloneProduct(lotsToDesc[i].Id_Product);
                    usedLotsToDesc += "[Produto:" + product.Code + " - Ident. Lote:" + lotsToDesc[i].Number + " - Quantidade:" + ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals(lotsToDesc[i].Quantity) + " unid./kg";

                    if (!Library.Checkers.Structs.IsDateTimeNull(lotsToDesc[i].ExpiresIn))
                    {
                        usedLotsToDesc += " - Data de Validade:" + lotsToDesc[i].ExpiresIn.ToString("dd/MM/yyyy HH:mm:ss");
                    }

                    usedLotsToDesc += "]";

                    if (i < lotsToDesc.Count - 1)
                    {
                        usedLotsToDesc += "\n";
                    }
                }

                request.Occurrences += usedLotsToDesc;
            }

            if (!Structs.IsDateTimeNull(request.ExpiresIn))
            {
                if (DateTime.Compare(request.ExpiresIn, DateTime.Now) <= 0)
                {
                    request.Status = 'A';
                }
            }

            //To inform if there are new discounts or additions
            if (this.Discounts != this.OriginalDiscounts)
            {
                if (request.Occurrences != null && request.Occurrences.Length > 0)
                {
                    request.Occurrences += "\n\n";
                }

                request.Occurrences += "Foi concedido um desconto de " + ObjectToDetailLabel.ToMoneyLabel(this.Discounts) +
                    " neste pedido em " + DateTime.Now.ToString("dd/MM/yyyy") + " às " + DateTime.Now.ToString("HH:mm:ss") + 
                    ".";
            }
            if (this.Additions != this.OriginalAdditions)
            {
                if (request.Occurrences != null && request.Occurrences.Length > 0)
                {
                    request.Occurrences += "\n\n";
                }

                request.Occurrences += "Foi acrescentado um valor de " + ObjectToDetailLabel.ToMoneyLabel(this.Additions) +
                    " neste pedido em " + DateTime.Now.ToString("dd/MM/yyyy") + " às " + DateTime.Now.ToString("HH:mm:ss") +
                    ".";
            }

            if (this.HasInDb)
            {
                MySqlNonQuery.UpdateRequest(request);
            }

            if (this.IsOld)
            {
                int index4 = GlobalVariables.OldRequests.FindIndex(x => x.Id == this.oldRequest.Id);
                GlobalVariables.OldRequests[index4] = request;
            }
            else
            {
                int index4 = GlobalVariables.Requests.FindIndex(x => x.Id == this.oldRequest.Id);
                GlobalVariables.Requests[index4] = request;
            }            

            Serialization.SerializeRequest(request);

            if (chxAddCostumerDiscount.Checked)
            {
                int index = GlobalVariables.Costumers.FindIndex(x => x.Id == this.CostumerId);
                GlobalVariables.Costumers[index].DiscountAccumulated = 0;
                MySqlNonQuery.UpdateCostumerDiscounts(GlobalVariables.Costumers[index]);
            }            

            if (this.oldRequest.PaymentType != 6 && cbxPaymentMethod.SelectedIndex == 6)
            {
                int index = GlobalVariables.Costumers.FindIndex(x => x.Id == this.CostumerId);

                if (index >= 0)
                {
                    GlobalVariables.Costumers[index].Debt += this.FinalValue;

                    MySqlNonQuery.UpdateCostumerDebt(GlobalVariables.Costumers[index]);
                }
            }
            
            //THE finish
            ml.CustomClose();

            FRM_Confirmation conf = new FRM_Confirmation("Deseja conceder algum desconto ou aumentar o contador de descontos para o cliente deste pedido?", 6);
            conf.Show();
            if (conf.Result)
            {
                FRM_OnFinishDiscounts finishDiscounts = new FRM_OnFinishDiscounts(this.Costumer.DiscountCounter, this.Costumer.DiscountAccumulated, this.FinalValue, this.Costumer); ;
                finishDiscounts.ShowDialog();

                if (finishDiscounts.Occurrences.Length > 0)
                {
                    if (request.Occurrences != null && request.Occurrences.Length > 0)
                    {
                        request.Occurrences += "\n\n";
                    }

                    request.Occurrences += finishDiscounts.Occurrences;
                    MySqlNonQuery.UpdateRequestOccurrences(request.Id, request.Occurrences);
                }
            }

            if (productsToLotsHelper.Count > 0)
            {
                FRM_ProductSeparatorHelper sepHelper = new FRM_ProductSeparatorHelper(productsToLotsHelper);
                sepHelper.ShowDialog();
            }

            this.Close();
        }
    }
}
