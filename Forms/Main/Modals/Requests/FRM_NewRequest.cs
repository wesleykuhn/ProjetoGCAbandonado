using System.Drawing;
using System.Windows.Forms;
using GC.Library.Objects;
using GC.Library.Translators;
using System.Linq;
using GC.GlobalModals;
using GC.Forms.Main.Modals.Requests.SubModals.NewRequest;
using System.Collections.Generic;
using System;
using GC.Library.Entities;
using GC.Library.Objects.SubObjects.Request;
using GC.Library;
using GC.Library.Objects.SubObjects.Product;
using GC.Library.Database;
using GC.Library.Checkers;

namespace GC.Forms.Main.Modals.Requests
{
    public partial class FRM_NewRequest : Bases.FRM_Full
    {
        FRM_MiniLoad Ml = new FRM_MiniLoad();

        internal bool Canceled = false;

        private double FinalValue = 0, JobsValue = 0, ProductsValue = 0;
        private int CostumerId = -1;
        private Costumer Costumer = null;
        private string RequestNumber;

        private List<Job> Jobs = new List<Job>();
        private List<Request_Products> Products = new List<Request_Products>();

        private List<double> AdditionsValues = new List<double>();
        private List<double> AdditionsPercents = new List<double>();
        private double Additions = 0;

        private List<double> DiscountsValues = new List<double>();
        private List<double> DiscountsPercents = new List<double>();
        private double Discounts = 0;

        public FRM_NewRequest()
        {
            InitializeComponent();

            this.ReadyForm();

            int number = GlobalVariables.User.RequestCounter + 1;
            string aux = number.ToString();
            this.RequestNumber = "";
            for (int i = 0; i < 10 - aux.Length; i++)
            {
                this.RequestNumber += "0";
            }
            this.RequestNumber += aux;          
            lblRequestNumber.Text += this.RequestNumber;

            cbxPaymentMethod.SelectedIndex = 0;
            
            UpdateCostumerUI();
            UpdateValuesText();

            this.Resize += new EventHandler(CenterLabels);
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
            if(this.FinalValue > 9999999)
            {
                FRM_MessageAndOK messOk = new FRM_MessageAndOK("Erro no sistema! O valor total do pedido não pode ultrapassar R$ 9999999,99!", 2);
                messOk.Show();

                this.Close();
            }

            lblValue.Text = ObjectToDetailLabel.ToMoneyLabel(this.FinalValue);         
            lblValue.Left = pnlBackground1.Width - (lblValue.Width + 10);
            lblTotalValue.Left = lblValue.Left - 97;

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
                lblAdditions.Left = lblTotalValue.Left - (20 + lblAdditions.Width);
                lblAdditionsText.Left = lblAdditions.Left - 100;
            }

            if(this.Discounts == 0)
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
                    lblDiscounts.Left = lblTotalValue.Left - (20 + lblDiscounts.Width);
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
            if (this.CostumerId == -1)
            {
                this.Costumer = null;
                lblCostumerName.Text = "Selecione um cliente...";
                lblCostumerAddress.Hide();
                lblCostumerDiscountAccumulated.Hide();
                lblCostumerDiscountCounter.Hide();
                cbxAddCostumerDiscount.Hide();

                pnlCostumerIcon.BackgroundImage = Properties.Resources.icon_mais_30x30;
                pnlCostumerIcon.BackgroundImageLayout = ImageLayout.Center;
            }
            else
            {
                var filtered = GlobalVariables.Costumers.Where(x => x.Id == this.CostumerId).Select(x => x);
                foreach (Costumer item in filtered)
                {
                    this.Costumer = item;
                }

                if (this.Costumer.Sex == 'M')
                {
                    pnlCostumerIcon.BackgroundImage = Properties.Resources.icon_perfil_menpadrao_100x100;
                }
                else
                {
                    pnlCostumerIcon.BackgroundImage = Properties.Resources.icon_perfil_woman_100x100;
                }

                pnlCostumerIcon.BackgroundImageLayout = ImageLayout.Stretch;

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
                cbxAddCostumerDiscount.Show();
            }
        }

        private void BtnChangeCostumer_Click(object sender, EventArgs e)
        {
            cbxAddCostumerDiscount.Checked = false;

            FRM_CostumersList costumersList = new FRM_CostumersList();
            costumersList.ShowDialog();
            
            this.CostumerId = costumersList.SelectedCostumerId;
            if(this.CostumerId == -1)
            {
                this.Costumer = null;
                lblCostumerDiscountAccumulated.ForeColor = Color.Black;
            }
            else
            {
                var filtered = GlobalVariables.Costumers.Where(x => x.Id == this.CostumerId).Select(x => x);
                foreach (Costumer item in filtered)
                {
                    this.Costumer = item;
                }

                if(this.Costumer.DiscountAccumulated > 0)
                {
                    lblCostumerDiscountAccumulated.ForeColor = Color.ForestGreen;
                }
                else
                {
                    lblCostumerDiscountAccumulated.ForeColor = Color.Black;
                }
            }

            UpdateCostumerUI();
        }

        private void BtnAddJobs_Click(object sender, EventArgs e)
        {
            if(GlobalVariables.Jobs.Count == 0)
            {
                FRM_MessageAndOK messOk = new FRM_MessageAndOK("Você não tem nenhum serviço adicionado no sistema!", 1);
                messOk.Show();
                return;
            }

            lvlJobs.Items.Clear();

            this.FinalValue -= JobsValue;
            JobsValue = 0;

            FRM_JobsList jobsList = new FRM_JobsList(this.Jobs);
            jobsList.ShowDialog();

            this.Jobs = jobsList.SelectedJobs;

            lvlJobs.Items.Clear();
            foreach (Job item in this.Jobs)
            {
                ListViewItem lvi = lvlJobs.Items.Add(item.Name);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(item.Description)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(item.Price)));

                if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);

                JobsValue += item.Price;
            }

            this.FinalValue += JobsValue;

            UpdateAdditions();
            UpdateDiscounts();
            UpdateValuesText();
        }

        private void BtnRemoveProducts_Click(object sender, EventArgs e)
        {
            if (lvlProducts.SelectedItems.Count == 0)
            {
                FRM_MessageAndOK messOk = new FRM_MessageAndOK("Você precisa selecionar pelo menos um produto antes de clicar em remover!", 1);
                messOk.Show();
                return;
            }
            else
            {
                FRM_Confirmation confirmation = new FRM_Confirmation("Este(s) produto(s) será(ão) removido(s) do pedido. Tem certeza que deseja continuar?", 1);
                confirmation.Show();

                //Loading window
                FRM_MiniLoad Ml = new FRM_MiniLoad();

                if (confirmation.Result)
                {
                    Ml.Show();

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
                        List<Request_Products> toBeDeleted = this.Products.Where(x => x.Id_Product == id).Select(x => x).ToList();
                        this.Products.Remove(toBeDeleted[0]);
                    }
                }
                else return;

                lvlProducts.Items.Clear();

                this.FinalValue -= ProductsValue;
                ProductsValue = 0;

                foreach (Request_Products item in this.Products)
                {
                    Product product = Product.CloneProduct(item.Id_Product);

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

                    ProductsValue += (product.Price * item.Quantity);
                }

                this.FinalValue += ProductsValue;

                UpdateAdditions();
                UpdateDiscounts();
                UpdateValuesText();

                Ml.CustomClose();
            }
        }

        private void CbxExpires_CheckedChanged(object sender, EventArgs e)
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

        private void BtnCreate_Click(object sender, EventArgs e)
        {          
            if (this.Costumer == null)
            {
                FRM_MessageAndOK messOk = new FRM_MessageAndOK("Você precisa selecionar um cliente para poder criar um pedido! Por favor, selecione.", 1);
                messOk.Show();
                return;
            }
            else if(this.Products.Count == 0 && this.Jobs.Count == 0)
            {
                FRM_MessageAndOK messOk = new FRM_MessageAndOK("Você precisa selecionar pelo menos um produto ou um serviço para poder criar um pedido! Por favor, selecione.", 1);
                messOk.Show();
                return;
            }
            if(this.FinalValue <= 0)
            {
                FRM_MessageAndOK messOk = new FRM_MessageAndOK("O valor do pedido não pode ser menor ou igual a zero! Por favor, corrija e então finalize o pedido ou cancele a criação do pedido.", 1);
                messOk.Show();
                return;
            }

            Ml.Show();

            DateTime expiresIn = new DateTime(1, 1, 1, 0, 0, 0);
            if (cbxExpires.Checked)
            {
                expiresIn = dtpExpiration.Value;
            }            

            double discount = -1, addition = -1;
            if (this.Discounts > 0) discount = this.Discounts;
            if (this.Additions > 0) addition = this.Additions;

            string occurrences = null;

            if (cbxAddCostumerDiscount.Checked)
            {
                occurrences = "";
                occurrences += "Foi adicionado o desconto acumulado do cliente, que era(m) " + ObjectToDetailLabel.ToMoneyLabel(this.Costumer.DiscountAccumulated) + "," +
                    " no valor deste pedido na criação do mesmo.";
            }

            Request request = new Request(-1, this.RequestNumber, this.FinalValue, discount, addition, FieldsToObject.ToString(rtbObservations.Text), occurrences, 'P', DateTime.Now, expiresIn, new DateTime(1, 1, 1, 0, 0, 0), cbxIsDelivery.Checked, Convert.ToByte(cbxPaymentMethod.SelectedIndex), this.CostumerId, GlobalVariables.User.Id);

            if(this.Jobs.Count != 0)
            {
                List<Request_Jobs> jobs = new List<Request_Jobs>();
                foreach (Job item in this.Jobs)
                {
                    jobs.Add(new Request_Jobs(item.Id, item.Price));
                }
                request.Jobs = jobs;
            }

            if(this.Products.Count != 0)
            {
                request.Products = this.Products;
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

            if (lotsConsumption.Count > 0)
            {
                string lotsFileDir = Library.Informations.Directories.LotsConsumption + this.RequestNumber + "_" + GlobalVariables.User.Id.ToString() + ".txt";
                Serialization.ObjectsListToTxtFile<Lot>(lotsConsumption, lotsFileDir, true);
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
                if (request.Occurrences != null)
                {
                    usedLotsToDesc += "\n\n";
                }

                usedLotsToDesc += "*Lotes usados no pedido*\n";

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

            if(this.Discounts > 0)
            {
                if (request.Occurrences != null && request.Occurrences.Length > 0)
                {
                    request.Occurrences += "\n\n";
                }

                request.Occurrences += "Foi concedido um desconto de " + ObjectToDetailLabel.ToMoneyLabel(this.Discounts) +
                    " neste pedido na criação do mesmo.";
            }
            if(this.Additions > 0)
            {
                if (request.Occurrences != null && request.Occurrences.Length > 0)
                {
                    request.Occurrences += "\n\n";
                }

                request.Occurrences += "Foi acrescentado um valor de " + ObjectToDetailLabel.ToMoneyLabel(this.Additions) +
                    " neste pedido na criação do mesmo.";
            }            

            GlobalVariables.User.RequestCounter++;
            MySqlNonQuery.UpdateUser("request_counter", GlobalVariables.User.RequestCounter.ToString());
            MySqlNonQuery.CreateRequest(request);
            request.Id = Int32.Parse(Library.Database.MySqlReader.ReadOnlyOneColumn("request", "idrequest", new string[] { "number", "id_user" }, new string[] { this.RequestNumber, GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }));
            GlobalVariables.Requests.Add(request);
            Serialization.SerializeRequest(request);

            if (cbxAddCostumerDiscount.Checked)
            {
                int index = GlobalVariables.Costumers.FindIndex(x => x.Id == this.CostumerId);
                GlobalVariables.Costumers[index].DiscountAccumulated = 0;
                MySqlNonQuery.UpdateCostumerDiscounts(GlobalVariables.Costumers[index]);
            }

            if (cbxPaymentMethod.SelectedIndex == 6)
            {
                var filtered = GlobalVariables.Costumers.Where(x => x.Id == this.CostumerId).Select(x => x);
                foreach (Costumer item in filtered)
                {
                    int index = GlobalVariables.Costumers.IndexOf(item);
                    GlobalVariables.Costumers[index].Debt += this.FinalValue;

                    MySqlNonQuery.UpdateCostumerDebt(GlobalVariables.Costumers[index]);
                }
            }

            //THE finish
            Ml.CustomClose();

            FRM_Confirmation conf = new FRM_Confirmation("Deseja conceder algum desconto ou aumentar o contador de descontos para o cliente deste pedido?", 6);
            conf.Show();           
            if (conf.Result)
            {
                FRM_OnFinishDiscounts finishDiscounts = new FRM_OnFinishDiscounts(this.Costumer.DiscountCounter, this.Costumer.DiscountAccumulated, this.FinalValue, this.Costumer); ;
                finishDiscounts.ShowDialog();

                if(finishDiscounts.Occurrences.Length > 0)
                {
                    if(request.Occurrences != null && request.Occurrences.Length > 0)
                    {
                        request.Occurrences += "\n\n";
                    }

                    request.Occurrences += finishDiscounts.Occurrences;
                    MySqlNonQuery.UpdateRequestOccurrences(request.Id, request.Occurrences);
                }
            }

            if(productsToLotsHelper.Count > 0)
            {
                FRM_ProductSeparatorHelper sepHelper = new FRM_ProductSeparatorHelper(productsToLotsHelper);
                sepHelper.ShowDialog();
            }            

            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Canceled = true;

            this.Close();
        }

        private void BtnFees_Click(object sender, EventArgs e)
        {
            this.FinalValue -= this.Additions;

            FRM_EditAdditions frmAdditions = new FRM_EditAdditions(AdditionsValues, AdditionsPercents);
            frmAdditions.ShowDialog();

            this.Additions = 0;
            this.AdditionsValues = frmAdditions.Values;
            this.AdditionsPercents = frmAdditions.Percents;

            if(this.AdditionsValues.Count > 0)
            {
                foreach (double item in this.AdditionsValues)
                {
                    this.Additions += item;
                    this.FinalValue += item;
                }
            }
            if(this.AdditionsPercents.Count > 0)
            {
                foreach (double item in this.AdditionsPercents)
                {
                    this.Additions += (item * this.FinalValue) / 100;
                    this.FinalValue += (item * this.FinalValue) / 100;
                }
            }

            UpdateValuesText();
        }

        private void BtnDiscounts_Click(object sender, EventArgs e)
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

        private void CbxAddCostumerDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAddCostumerDiscount.Checked)
            {
                if (this.Costumer.DiscountAccumulated == -1 || this.Costumer.DiscountAccumulated == 0)
                {
                    FRM_MessageAndOK messOk = new FRM_MessageAndOK("O cliente selecionado não possuí nenhum desconto acumulado!", 6);
                    messOk.Show();
                    cbxAddCostumerDiscount.Checked = false;
                    return;
                }

                if(this.Costumer.DiscountAccumulated > 0)
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

        private void BtnRemoveJobs_Click(object sender, EventArgs e)
        {
            if(lvlJobs.SelectedItems.Count == 0)
            {
                GlobalModals.FRM_MessageAndOK messOk = new FRM_MessageAndOK("Você precisa selecionar pelo menos um serviço antes de clicar em remover!", 1);
                messOk.Show();
                return;
            }
            else
            {
                FRM_Confirmation confirmation = new FRM_Confirmation("Este(s) serviço(s) será(ão) removido(s) do pedido. Tem certeza que deseja continuar?", 1);
                confirmation.Show();

                //Loading window
                FRM_MiniLoad Ml = new FRM_MiniLoad();

                if (confirmation.Result)
                {
                    Ml.Show();

                    List<string> names = new List<string>();
                    for (int i = 0; i < lvlJobs.SelectedItems.Count; i++)
                    {
                        names.Add(lvlJobs.Items[lvlJobs.SelectedIndices[i]].Text);
                    }
                    
                    foreach (string item in names)
                    {
                        this.Jobs.Remove(Job.CloneJob(item));
                    }
                }
                else return;

                lvlJobs.Items.Clear();

                this.FinalValue -= JobsValue;
                JobsValue = 0;

                foreach (Job item in this.Jobs)
                {
                    ListViewItem lvi = lvlJobs.Items.Add(item.Name);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(item.Description)));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(item.Price)));

                    if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);

                    JobsValue += item.Price;
                }

                this.FinalValue += JobsValue;

                UpdateAdditions();
                UpdateDiscounts();
                UpdateValuesText();

                Ml.CustomClose();
            }
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

        private void BtnAddProducts_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Products.Count == 0)
            {
                GlobalModals.FRM_MessageAndOK messOk = new FRM_MessageAndOK("Você não tem nenhum produto adicionado no sistema!", 1);
                messOk.Show();
                return;
            }

            lvlProducts.Items.Clear();
            this.FinalValue -= this.ProductsValue;
            this.ProductsValue = 0;

            FRM_ProductsList productsList = new FRM_ProductsList(this.Products, false);
            productsList.ShowDialog();
            this.Products = productsList.SelectedProducts;                      

            lvlProducts.Items.Clear();
            foreach (Request_Products item in this.Products)
            {
                Product product = Product.CloneProduct(item.Id_Product);

                ListViewItem lvi = null;
                if ((item.Quantity % 1) == 0)
                {
                    lvi = lvlProducts.Items.Add(ObjectToListView.ToIntListView(Convert.ToInt32(item.Quantity)));
                }
                else
                {
                    lvi = lvlProducts.Items.Add(ObjectToListView.ToDoubleListView_ThreeDecimals(item.Quantity));
                }

                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(product.Price * item.Quantity)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, product.Code));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, product.Description));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(product.Price)));
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
}
