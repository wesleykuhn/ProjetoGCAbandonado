using GC.Library.Database;
using GC.Library.Objects;
using GC.Library.Translators;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using GC.GlobalModals;
using GC.Forms.Main.Modals.Requests.SubModals.NewRequest;
using GC.Library.Checkers;
using GC.Library.Entities;
using GC.Library;
using GC.Library.Objects.SubObjects.Request;
using GC.Library.Objects.SubObjects.Product;

namespace GC.Forms.Main.Modals.Requests
{
    public partial class FRM_DetailsRequest : Bases.FRM_Full
    {
        Request Request;

        internal bool ChangedToOpened = false;
        internal bool ChangedToCanceled = false;
        internal bool ChangedToDone = false;
        private bool HasInDb = true;
        private bool IsOldRequest = false;

        internal FRM_DetailsRequest(Request request)
        {
            InitializeComponent();

            this.ReadyForm();

            switch (request.Status)
            {
                case 'P':
                    lbl_status.Text += "Pendente.";
                    break;

                case 'C':
                    lbl_status.Text += "Cancelado.";
                    break;

                case 'F':
                    lbl_status.Text += "Finalizado.";
                    break;

                default:
                    lbl_status.Text += "Atrasado!";
                    break;
            }

            btnSendToEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BTN_GeneratePDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            this.Resize += new EventHandler(CenterLabels);            

            //Request
            if (request.Status == 'P' || request.Status == 'A')
            {
                btnOpenRequest.Enabled = false;
            }
            else if(request.Status == 'F')
            {
                btnDoneRequest.Enabled = false;
                btnCancelRequest.Enabled = false;
            }
            else if (request.Status == 'C')
            {
                btnCancelRequest.Enabled = false;
                btnDoneRequest.Enabled = false;
            }

                lblNumber.Text += request.Number;

            if (Structs.IsDateTimeNull(request.ExpiresIn))
            {
                lblExpiration.Text += "Não possui";
            }
            else
            {
                lblExpiration.Text += request.ExpiresIn.ToString();
            }

            if (!Structs.IsDateTimeNull(request.DoneIn))
            {
                lblDoneIn.Text = "Finalizado em " + request.DoneIn.ToString("dd/MM/yyyy") + " às " + request.DoneIn.ToString("HH:mm:ss") + "!";
                lblDoneIn.Visible = true;
            }
            
            lblTotalValue.Text += ObjectToDetailLabel.ToMoneyLabel(request.Value);

            if (request.Discount == -1)
            {
                lblDiscount.Text += "Não possui";
            }
            else
            {
                lblDiscount.Text += ObjectToDetailLabel.ToMoneyLabel(request.Discount);
            }

            if (request.Addition == -1)
            {
                lblAdditions.Text += "Não possui";
            }
            else
            {
                lblAdditions.Text += ObjectToDetailLabel.ToMoneyLabel(request.Addition);
            }

            if (request.IsDelivery)
            {
                lblIsDelivery.Text += "Sim";
            }
            else
            {
                lblIsDelivery.Text += "Não";
            }

            lblCreatedAt.Text += request.StartedIn.ToString("dd/MM/yyyy") + " às " + request.StartedIn.ToString("HH:mm:ss");
            lblObservations.Text = ObjectToListView.ToStringListView(request.Observations);
            lblOccurrences.Text = ObjectToListView.ToStringListView(request.Occurrences);

            switch (request.PaymentType)
            {
                case 0:
                    lblPayment.Text += "Dinheiro";
                    break;
                case 1:
                    lblPayment.Text += "Cartão de Débito";
                    break;
                case 2:
                    lblPayment.Text += "Cartão de Crédito";
                    break;
                case 3:
                    lblPayment.Text += "Cheque";
                    break;
                case 4:
                    lblPayment.Text += "Boleto";
                    break;
                case 5:
                    lblPayment.Text += "Débito recorrente";
                    break;
                case 6:
                    lblPayment.Text += "Fiado";
                    break;
            }

            //Costumer
            Costumer costumer = null;

            if (request.Id_Costumer == -1 || !GlobalVariables.Costumers.Exists(x => x.Id == request.Id_Costumer))
            {
                lblName.Text = "Este cliente foi excluído!";
                lblPhone.Hide();
                pnlWhatsapp.Hide();
                lblEmail.Hide();
                lblAddress.Hide();
                lblComplement.Hide();
                lblCep.Hide();
                lblReference.Hide();
                lblDistrict.Hide();
                lblCity.Hide();
                lblState.Hide();
                lblCountry.Hide();

                pnlCostumerIcon.BackgroundImage = Properties.Resources.icon_lixeira_30x30;
                pnlCostumerIcon.BackgroundImageLayout = ImageLayout.Center;
            }
            else
            {
                int index = GlobalVariables.Costumers.FindIndex(x => x.Id == request.Id_Costumer);
                costumer = GlobalVariables.Costumers[index];

                lblName.Text = costumer.Name;
                lblPhone.Text += costumer.PhoneNumber;
                pnlWhatsapp.Left = lblPhone.Left + lblPhone.Width + 5;
                if (costumer.IsPhoneWhatsapp)
                {
                    pnlWhatsapp.Visible = true;
                }

                if (costumer.Email == null || costumer.Email == "")
                {
                    lblEmail.Text = "E-mail não informado";
                }
                else
                {
                    lblEmail.Text += costumer.Email;
                }

                if (costumer.Sex == 'M')
                {
                    pnlCostumerIcon.BackgroundImage = Properties.Resources.icon_perfil_menpadrao_100x100;
                }
                else
                {
                    pnlCostumerIcon.BackgroundImage = Properties.Resources.icon_perfil_woman_100x100;
                }

                lblAddress.Text += costumer.Street + ", " + costumer.Number;

                lblComplement.Text += ObjectToDetailLabel.ToLabelMasculino(costumer.Complement);
                lblCep.Text += ObjectToDetailLabel.ToLabelMasculino(costumer.Cep);
                lblReference.Text += ObjectToDetailLabel.ToLabelFeminino(costumer.Reference);
                lblDistrict.Text += ObjectToDetailLabel.ToLabelMasculino(costumer.District);
                lblCity.Text += ObjectToDetailLabel.ToLabelMasculino(costumer.City);
                lblState.Text += ObjectToDetailLabel.ToLabelMasculino(costumer.State);
                lblCountry.Text += ObjectToDetailLabel.ToLabelMasculino(costumer.Country);
            }            

            //Products
            foreach (Request_Products reqProd in request.Products)
            {
                Product product = Product.CloneProduct(reqProd.Id_Product);
                if (product == null) continue;

                ListViewItem lvi = lvlProducts.Items.Add(product.Code);
                lvi.SubItems.Add(product.Description);
                lvi.SubItems.Add(ObjectToListView.ToDoubleListView_TwoDecimals(reqProd.Price));
                lvi.SubItems.Add(ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals(reqProd.Quantity));

                double totalValue = reqProd.Quantity * reqProd.Price;
                lvi.SubItems.Add(ObjectToListView.ToDoubleListView_TwoDecimals(totalValue));
                lvi.SubItems.Add(ObjectToListView.ToStringListView(product.Position));
                lvi.SubItems.Add(ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals(product.PackQuantity));
                lvi.SubItems.Add(ObjectToListView.ToDoubleListView_ThreeDecimals(product.Weight));
                lvi.SubItems.Add(Supplier.GetSupplierName(product.Id_Supplier));

                if (lvi.Index % 2 != 0)
                {
                    lvi.BackColor = Color.FromArgb(0, 200, 200, 200);
                }
            }

            //Jobs
            foreach (Request_Jobs reqJob in request.Jobs)
            {
                Job job = Job.CloneJob(reqJob.Id_Job);
                if (job == null) continue;

                ListViewItem lvi = lvlJobs.Items.Add(job.Name);
                lvi.SubItems.Add(job.Description);
                lvi.SubItems.Add(ObjectToListView.ToDoubleListView_TwoDecimals(reqJob.Price));

                if (lvi.Index % 2 != 0)
                {
                    lvi.BackColor = Color.FromArgb(0, 200, 200, 200);
                }
            }

            CenterLabels(this, new EventArgs());

            this.Request = request;

            this.IsOldRequest = Request.RequestIsOld(this.Request.StartedIn);

            this.HasInDb = MySqlReader.ObjectExistsInDB("request", "idrequest", this.Request.Id.ToString());

            if (!this.HasInDb && this.Request.Status != 'C')
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Atenção! Este " +
                    "pedido já tem mais de 4 meses desde que foi criado! Por isso, ele não está mais salvo na sua conta. " +
                    "Por isso, você só poderá acessá-lo neste computador/notebook.", 6);

                messOk.Show();
            }
        }   

        private void frmModal_AlterRequest_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        // <------------------------------------------------------------------------------------

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CenterLabels(object sender, EventArgs e)
        {            
            lblConstCostumer.Left = (panel3.Width - lblConstCostumer.Width) / 2;
            lblConstProd.Left = (panel5.Width - lblConstProd.Width) / 2;
            lblConstObs.Left = (panel9.Width - lblConstObs.Width) / 2;
            lblConstJobs.Left = (panel7.Width - lblConstJobs.Width) / 2;
            lblConstOccu.Left = (panel11.Width - lblConstOccu.Width) / 2;
        }

        private void BtnDoneRequest_Click(object sender, EventArgs e)
        {         
            GlobalModals.FRM_Confirmation conf = new GlobalModals.FRM_Confirmation("Deseja realmente mudar a situação deste pedido para 'Finalizado?", 6);
            conf.Show();
            if (!conf.Result) return;

            int index = 0;

            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
            ml.Show();            

            if (this.IsOldRequest)
            {
                index = GlobalVariables.OldRequests.FindIndex(x => x.Id == this.Request.Id);
                GlobalVariables.OldRequests[index].Status = 'F';
                GlobalVariables.OldRequests[index].DoneIn = DateTime.Now;

                if (GlobalVariables.OldRequests[index].Occurrences != null && GlobalVariables.OldRequests[index].Occurrences.Length > 0)
                {
                    GlobalVariables.OldRequests[index].Occurrences += "\n\n";
                }
                GlobalVariables.OldRequests[index].Occurrences += "-Este pedido foi finalizado em " + DateTime.Now.ToString("dd/MM/yyyy") +
                    " às " + DateTime.Now.ToString("HH:mm:ss") + ".";

                Serialization.SerializeRequest(GlobalVariables.OldRequests[index]);
            }
            else
            {
                MySqlNonQuery.UpdateRequestStatus(this.Request.Id, 'F');

                index = GlobalVariables.Requests.FindIndex(x => x.Id == this.Request.Id);
                GlobalVariables.Requests[index].Status = 'F';
                GlobalVariables.Requests[index].DoneIn = DateTime.Now;

                if (GlobalVariables.Requests[index].Occurrences != null && GlobalVariables.Requests[index].Occurrences.Length > 0)
                {
                    GlobalVariables.Requests[index].Occurrences += "\n\n";
                }
                GlobalVariables.Requests[index].Occurrences += "-Este pedido foi finalizado em " + DateTime.Now.ToString("dd/MM/yyyy") +
                    " às " + DateTime.Now.ToString("HH:mm:ss") + ".";
                MySqlNonQuery.UpdateRequestOccurrences(GlobalVariables.Requests[index].Id, GlobalVariables.Requests[index].Occurrences);
                MySqlNonQuery.UpdateRequestDoneIn(GlobalVariables.Requests[index].Id, GlobalVariables.Requests[index].DoneIn);

                Serialization.SerializeRequest(GlobalVariables.Requests[index]);
            }

            //Stats -------------------------------------------------->
            //Stats Update 
            GlobalVariables.SalesRecords.Profits_amount += this.Request.Value;
            GlobalVariables.SalesRecords.Requests_done_amount_total += this.Request.Value;
            GlobalVariables.SalesRecords.Requests_done_counter_total++;

            int counter = 0;
            double amount = 0;
            foreach (Request_Products item in this.Request.Products)
            {
                amount += item.Price * item.Quantity;
                if (Variables.IsValueDouble(item.Quantity))
                {
                    counter++;
                }
                else
                {
                    counter += Convert.ToInt32(item.Quantity);
                }
            }
            GlobalVariables.SalesRecords.Products_sales_counter_total += counter;
            GlobalVariables.SalesRecords.Products_sales_amount_total += amount;

            counter = 0;
            amount = 0;
            foreach (Request_Jobs item in this.Request.Jobs)
            {
                counter++;
                amount += item.Price;
            }
            GlobalVariables.SalesRecords.Jobs_sales_counter_total += counter;
            GlobalVariables.SalesRecords.Jobs_sales_amount_total += amount;

            MySqlNonQuery.UpdateCommercerStats();
            // <------------------------------------------------------------------

            //Register on the daily sale -------------->
            DayRecord.DaysRecordsUpdater(this.Request.Value);
            // <--------------------------------------

            ml.CustomClose();

            conf = new FRM_Confirmation("Deseja informar o cliente de que o pedido foi finalizado?", 6);
            conf.Show();
            if (conf.Result)
            {
                FRM_SendRequestInfoToEmail email = new FRM_SendRequestInfoToEmail(this.Request.Id_Costumer, this.Request.Number);
                email.ShowDialog();
            }

            if (this.Request.Id_Costumer != -1)
            {
                conf = new FRM_Confirmation("Deseja modificar o desconto acumulado ou o contador de " +
                    "descontos para o cliente deste pedido?", 6);
                conf.Show();
                if (conf.Result)
                {
                    Costumer costumer = Costumer.CloneCostumer(this.Request.Id_Costumer);
                    FRM_OnFinishDiscounts discouts = new FRM_OnFinishDiscounts(costumer.DiscountCounter, costumer.DiscountAccumulated, this.Request.Value, costumer); ;
                    discouts.ShowDialog();

                    if (discouts.Occurrences.Length > 0)
                    {
                        if (this.Request.Occurrences != null && this.Request.Occurrences.Length > 0)
                        {
                            this.Request.Occurrences += "\n\n";
                        }

                        this.Request.Occurrences += discouts.Occurrences;
                        if (this.IsOldRequest)
                        {
                            GlobalVariables.OldRequests[index].Occurrences = this.Request.Occurrences;
                            Serialization.SerializeRequest(GlobalVariables.OldRequests[index]);
                        }
                        else
                        {
                            GlobalVariables.Requests[index].Occurrences = this.Request.Occurrences;
                            MySqlNonQuery.UpdateRequestOccurrences(this.Request.Id, GlobalVariables.Requests[index].Occurrences);
                            Serialization.SerializeRequest(GlobalVariables.Requests[index]);
                        }                 
                    }
                }
            }

            this.ChangedToDone = true;            

            this.Close();
        }

        private void BtnOpenRequest_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_Confirmation conf = new GlobalModals.FRM_Confirmation("Deseja realmente mudar a situação deste pedido para 'Pendente?", 6);
            conf.Show();
            if (!conf.Result) return;

            int index = 0;   

            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
            ml.Show();

            DateTime wasDone_in = this.Request.DoneIn;            

            if (this.Request.Status == 'F')
            {
                if (this.IsOldRequest)
                {
                    char newStatus = 'P';
                    if (!Structs.IsDateTimeNull(this.Request.ExpiresIn))
                    {
                        if (DateTime.Compare(this.Request.ExpiresIn, DateTime.Now) <= 0)
                        {
                            newStatus = 'A';
                        }
                    }

                    index = GlobalVariables.OldRequests.FindIndex(x => x.Id == this.Request.Id);
                    GlobalVariables.OldRequests[index].Status = newStatus;
                    GlobalVariables.OldRequests[index].DoneIn = new DateTime(1, 1, 1, 0, 0, 0);

                    if (GlobalVariables.OldRequests[index].Occurrences != null && GlobalVariables.OldRequests[index].Occurrences.Length > 0)
                    {
                        GlobalVariables.OldRequests[index].Occurrences += "\n\n";
                    }
                    GlobalVariables.OldRequests[index].Occurrences += "-Este pedido foi reaberto em " + DateTime.Now.ToString("dd/MM/yyyy") +
                        " às " + DateTime.Now.ToString("HH:mm:ss") + ".";

                    Serialization.SerializeRequest(GlobalVariables.OldRequests[index]);
                }
                else
                {
                    char newStatus = 'P';
                    if (!Structs.IsDateTimeNull(this.Request.ExpiresIn))
                    {
                        if (DateTime.Compare(this.Request.ExpiresIn, DateTime.Now) <= 0)
                        {
                            newStatus = 'A';
                        }
                    }

                    index = GlobalVariables.Requests.FindIndex(x => x.Id == this.Request.Id);
                    if (this.HasInDb)
                    {
                        MySqlNonQuery.UpdateRequestStatus(this.Request.Id, newStatus);
                    }

                    GlobalVariables.Requests[index].Status = newStatus;
                    GlobalVariables.Requests[index].DoneIn = new DateTime(1, 1, 1, 0, 0, 0);

                    if (GlobalVariables.Requests[index].Occurrences != null && GlobalVariables.Requests[index].Occurrences.Length > 0)
                    {
                        GlobalVariables.Requests[index].Occurrences += "\n\n";
                    }
                    GlobalVariables.Requests[index].Occurrences += "-Este pedido foi reaberto em " + DateTime.Now.ToString("dd/MM/yyyy") +
                        " às " + DateTime.Now.ToString("HH:mm:ss") + ".";
                    MySqlNonQuery.UpdateRequestOccurrences(GlobalVariables.Requests[index].Id, GlobalVariables.Requests[index].Occurrences);
                    MySqlNonQuery.UpdateRequestDoneIn(GlobalVariables.Requests[index].Id, GlobalVariables.Requests[index].DoneIn);

                    Serialization.SerializeRequest(GlobalVariables.Requests[index]);
                }         
            }
            else
            {
                char newStatus = 'P';
                if (!Structs.IsDateTimeNull(this.Request.ExpiresIn))
                {
                    if (DateTime.Compare(this.Request.ExpiresIn, DateTime.Now) <= 0)
                    {
                        newStatus = 'A';
                    }
                }

                if (this.Request.Id_Costumer != 1)
                {
                    if (this.Request.PaymentType == 6)
                    {
                        index = GlobalVariables.Costumers.FindIndex(x => x.Id == this.Request.Id_Costumer);
                        GlobalVariables.Costumers[index].Debt += this.Request.Value;

                        MySqlNonQuery.UpdateCostumerDebt(GlobalVariables.Costumers[index]);
                    }
                }

                index = GlobalVariables.CancelledRequests.FindIndex(x => x.Id == this.Request.Id);
                GlobalVariables.CancelledRequests[index].Status = newStatus;
                int isOld = Request.CompareStartedToOld(this.Request);

                if(isOld <= 0)
                {                    
                    GlobalVariables.OldRequests.Add(GlobalVariables.CancelledRequests[index]);
                    Request.SortGlobalOldRequests();

                    if (GlobalVariables.CancelledRequests[index].Occurrences != null && GlobalVariables.CancelledRequests[index].Occurrences.Length > 0)
                    {
                        GlobalVariables.CancelledRequests[index].Occurrences += "\n\n";
                    }
                    GlobalVariables.CancelledRequests[index].Occurrences += "-Este pedido foi reaberto em " + DateTime.Now.ToString("dd/MM/yyyy") +
                        " às " + DateTime.Now.ToString("HH:mm:ss") + ".";

                    Serialization.SerializeRequest(GlobalVariables.CancelledRequests[index]);

                    GlobalVariables.CancelledRequests.RemoveAt(index);
                }
                else
                {
                    this.Request.Status = newStatus;

                    GlobalVariables.CancelledRequests[index].Id = MySqlNonQuery.CreateRequest(this.Request);
                    GlobalVariables.Requests.Add(GlobalVariables.CancelledRequests[index]);
                    Request.SortGlobalRequests();

                    if (GlobalVariables.CancelledRequests[index].Occurrences != null && GlobalVariables.CancelledRequests[index].Occurrences.Length > 0)
                    {
                        GlobalVariables.CancelledRequests[index].Occurrences += "\n\n";
                    }
                    GlobalVariables.CancelledRequests[index].Occurrences += "-Este pedido foi reaberto em " + DateTime.Now.ToString("dd/MM/yyyy") +
                        " às " + DateTime.Now.ToString("HH:mm:ss") + ".";
                    MySqlNonQuery.UpdateRequestOccurrences(GlobalVariables.CancelledRequests[index].Id, GlobalVariables.CancelledRequests[index].Occurrences);

                    Serialization.SerializeRequest(GlobalVariables.CancelledRequests[index]);

                    GlobalVariables.CancelledRequests.RemoveAt(index);                                      
                }
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
            foreach (Request_Products item in this.Request.Products)
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

                            index = GlobalVariables.Lots.FindIndex(x => x.Id == item2.Id);
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
                string lotsFileDir = Library.Informations.Directories.LotsConsumption + this.Request.Number + "_" + GlobalVariables.User.Id.ToString() + ".txt";
                Serialization.ObjectsListToTxtFile<Lot>(lotsConsumption, lotsFileDir, true);
            }
            else
            {
                Library.Files.Control.DeleteLotsConsumptionFile(this.Request.Number);
            }

            //Stats (Giving back) -------------------------------------------->
            //Stats Update 
            GlobalVariables.SalesRecords.Profits_amount -= this.Request.Value;
            GlobalVariables.SalesRecords.Requests_done_amount_total -= this.Request.Value;
            GlobalVariables.SalesRecords.Requests_done_counter_total--;

            int counter = 0;
            double amount = 0;
            foreach (Request_Products item in this.Request.Products)
            {
                amount += item.Price * item.Quantity;
                if (Variables.IsValueDouble(item.Quantity))
                {
                    counter++;
                }
                else
                {
                    counter += Convert.ToInt32(item.Quantity);
                }
            }
            GlobalVariables.SalesRecords.Products_sales_counter_total -= counter;
            GlobalVariables.SalesRecords.Products_sales_amount_total -= amount;

            counter = 0;
            amount = 0;
            foreach (Request_Jobs item in this.Request.Jobs)
            {
                counter++;
                amount += item.Price;
            }
            GlobalVariables.SalesRecords.Jobs_sales_counter_total -= counter;
            GlobalVariables.SalesRecords.Jobs_sales_amount_total -= amount;

            MySqlNonQuery.UpdateCommercerStats();
            // <------------------------------------------------------------------

            //Register on the daily sale -------------->
            DayRecord.DaysRecordsUpdater(this.Request.Value * -1, wasDone_in);
            // <--------------------------------------

            ml.CustomClose();

            if (this.Request.Id_Costumer != -1)
            {
                FRM_Confirmation conf2 = new FRM_Confirmation("Deseja modificar o desconto acumulado ou o contador de " +
                    "descontos para o cliente deste pedido?", 6);
                conf2.Show();
                if (conf2.Result)
                {
                    Costumer costumer = Costumer.CloneCostumer(this.Request.Id_Costumer);
                    FRM_OnFinishDiscounts discouts = new FRM_OnFinishDiscounts(costumer.DiscountCounter, costumer.DiscountAccumulated, this.Request.Value, costumer); ;
                    discouts.ShowDialog();

                    if (discouts.Occurrences.Length > 0)
                    {
                        if (this.Request.Occurrences != null && this.Request.Occurrences.Length > 0)
                        {
                            this.Request.Occurrences += "\n\n";
                        }

                        this.Request.Occurrences += discouts.Occurrences;
                        if (this.IsOldRequest)
                        {
                            index = GlobalVariables.OldRequests.FindIndex(x => x.Id == this.Request.Id);
                            GlobalVariables.OldRequests[index].Occurrences = this.Request.Occurrences;
                            Serialization.SerializeRequest(GlobalVariables.OldRequests[index]);
                        }
                        else
                        {
                            index = GlobalVariables.Requests.FindIndex(x => x.Id == this.Request.Id);
                            GlobalVariables.Requests[index].Occurrences = this.Request.Occurrences;
                            MySqlNonQuery.UpdateRequestOccurrences(this.Request.Id, GlobalVariables.Requests[index].Occurrences);
                            Serialization.SerializeRequest(GlobalVariables.Requests[index]);
                        }
                    }
                }
            }

            this.ChangedToOpened = true;

            this.Close();
        }

        private void BtnCancelRequest_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_Confirmation conf = new GlobalModals.FRM_Confirmation("Deseja realmente cancelar este pedido? Todo os produtos usados neste pedido, que ainda estão cadastrados, irão voltar para o estoque do sistema.", 6);
            conf.Show();
            if (!conf.Result) return;

            int index = 0;

            if (this.Request.PaymentType == 6)
            {
                index = GlobalVariables.Costumers.FindIndex(x => x.Id == this.Request.Id_Costumer);

                if (index >= 0)
                {
                    if (GlobalVariables.Costumers[index].Debt >= this.Request.Value)
                    {
                        GlobalVariables.Costumers[index].Debt -= this.Request.Value;

                        MySqlNonQuery.UpdateCostumerDebt(GlobalVariables.Costumers[index]);
                    }
                    else
                    {
                        GlobalModals.FRM_MessageAndOK.BuildAndShow("Atenção! A forma de pagamento do pedido é 'Fiado'. O valor fiado do pedido é " + ObjectToDetailLabel.ToMoneyLabel(this.Request.Value) + ", mas nesse momento o cliente está devendo apenas " + ObjectToDetailLabel.ToMoneyLabel(GlobalVariables.Costumers[index].Debt) + "! O programa não deixará o cliente perder dinheiro neste estorno que você está tentando fazer. Por favor, verifique o que houve com a dívida do cliente depois que a forma de pagamento deste pedido foi criada/alterada para 'Fiado'.", 2);

                        return;
                    }
                }
            }

            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();            

            if(this.Request.Products.Count > 0)
            {
                List<Lot> lots = Library.Files.SeekFor.InactiveUsedLots(this.Request.Number);
                if (lots.Count <= 0)
                {
                    GlobalModals.FRM_Confirmation conf2 = new GlobalModals.FRM_Confirmation("Erro! Não foi possível localizar " +
                        "o arquivo necessário para o estorno do(s) lote(s) do(s) produto(s) deste pedido! Talvez porque você " +
                        " não criou estoque para este produto, pode ser também que você " +
                        "não esteja no mesmo computador/notebook onde este pedido foi criado, o arquivo foi excluído ou está " +
                        " então está corrompido. Por isso nenhum produto será devolvido ao estoque. Deseja continuar assim mesmo?", 2);
                    conf2.Show();
                    if (!conf2.Result)
                    {
                        return;
                    }
                }
                else
                {
                    ml.Show();

                    List<int> productsIds = GlobalVariables.Products.Select(x => x.Id).ToList();

                    bool deletedProduct = false;
                    foreach (Lot item in lots)
                    {
                        if (!productsIds.Contains(item.Id_Product))
                        {
                            deletedProduct = true;
                            break;
                        }
                    }
                    if (deletedProduct)
                    {
                        GlobalModals.FRM_Confirmation conf3 = new GlobalModals.FRM_Confirmation("Foi detectado que o produto de um dos lotes, que você quer estornar, foi excluído. Deseja continuar assim mesmo? Se sim, o(s) lote(s) cujo produto foi excluído não serão estornados!", 1);
                        conf3.Show();
                        if (!conf3.Result)
                        {
                            return;
                        }
                    }

                    foreach (Lot item in lots)
                    {
                        if (!productsIds.Contains(item.Id_Product))
                        {
                            continue;
                        }

                        bool exists = GlobalVariables.Lots.Exists(x => x.Id == item.Id);
                        if (exists)
                        {
                            index = GlobalVariables.Lots.FindIndex(x => x.Id == item.Id);
                            GlobalVariables.Lots[index].Quantity += item.Quantity;
                            MySqlNonQuery.UpdateLotQuantity(item.Id, GlobalVariables.Lots[index].Quantity);
                        }
                        else
                        {
                            item.Id = MySqlNonQuery.CreateLot(item);
                            GlobalVariables.Lots.Add(item);
                        }
                    }

                    Library.Files.Control.DeleteFile(Library.Informations.Directories.LotsConsumption + this.Request.Number + "_" + GlobalVariables.User.Id.ToString() + ".txt");
                }
            }            

            if (this.Request.Occurrences != null && this.Request.Occurrences.Length > 0)
            {
                this.Request.Occurrences += "\n\n";
            }
            this.Request.Occurrences += "-Este pedido foi cancelado em " + DateTime.Now.ToString("dd/MM/yyyy") +
                " às " + DateTime.Now.ToString("HH:mm:ss") + ".";                               

            if (this.IsOldRequest)
            {
                index = GlobalVariables.OldRequests.FindIndex(x => x.Id == this.Request.Id);
                GlobalVariables.OldRequests[index].Status = 'C';
                Serialization.SerializeRequest(GlobalVariables.OldRequests[index]);
                GlobalVariables.CancelledRequests.Add(GlobalVariables.OldRequests[index]);
                Request.SortGlobalCancelledRequests();
                GlobalVariables.OldRequests.RemoveAt(index);
            }
            else
            {              
                MySqlNonQuery.DeleteRequestById(this.Request.Id);
                index = GlobalVariables.Requests.FindIndex(x => x.Id == this.Request.Id);
                GlobalVariables.Requests[index].Status = 'C';
                Serialization.SerializeRequest(GlobalVariables.Requests[index]);
                GlobalVariables.CancelledRequests.Add(GlobalVariables.Requests[index]);
                Request.SortGlobalCancelledRequests();
                GlobalVariables.Requests.RemoveAt(index);
            }            

            ml.CustomClose();

            if (this.Request.Id_Costumer != -1)
            {
                FRM_Confirmation conf2 = new FRM_Confirmation("Deseja modificar o desconto acumulado ou o contador de " +
                    "descontos para o cliente deste pedido? Lembre-se: Se foi aumentado o contador de descontos quando este pedido" +
                    "foi criado você precisa diminuir o contador.", 6);
                conf2.Show();
                if (conf2.Result)
                {
                    Costumer costumer = Costumer.CloneCostumer(this.Request.Id_Costumer);
                    FRM_OnFinishDiscounts discouts = new FRM_OnFinishDiscounts(costumer.DiscountCounter, costumer.DiscountAccumulated, this.Request.Value, costumer); ;
                    discouts.ShowDialog();

                    if (discouts.Occurrences.Length > 0)
                    {
                        if (this.Request.Occurrences != null && this.Request.Occurrences.Length > 0)
                        {
                            this.Request.Occurrences += "\n\n";
                        }

                        index = GlobalVariables.CancelledRequests.FindIndex(x => x.Id == this.Request.Id);
                        this.Request.Occurrences += discouts.Occurrences;
                        GlobalVariables.CancelledRequests[index].Occurrences = this.Request.Occurrences;
                        Serialization.SerializeRequest(GlobalVariables.CancelledRequests[index]);
                    }
                }
            }            

            this.ChangedToCanceled = true;

            this.Close();
        }

        private void btnSendToEmail_Click(object sender, EventArgs e)
        {
            FRM_SendRequestInfoToEmail mail = new FRM_SendRequestInfoToEmail(this.Request);
            mail.ShowDialog();
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

        private void BTN_GeneratePDF_Click(object sender, EventArgs e)
        {
            Library.Outputs.Pdf.RequestToPdf(this.Request);

            Library.Files.Open.RequestPdf(this.Request);
        }
    }
}
