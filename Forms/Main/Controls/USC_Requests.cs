using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GC.Library;
using GC.Library.Checkers;
using GC.Library.Database;
using GC.Library.Entities;
using GC.Library.Files;
using GC.Library.Objects;

namespace GC.Forms.Main.Controls
{
    public partial class USC_Requests : UserControl
    {
        internal static Request SelectedRequest = null;
        internal static Point mousePosition = new Point();

        internal event EventHandler RequestAltered;

        private bool IsOldShown = false;
        private bool FirstSeeCancelled = true;
        private bool IsSearch = false;

        Modals.Requests.FRM_SearchOptionsRequest FrmSO = new Modals.Requests.FRM_SearchOptionsRequest();

        public USC_Requests()
        {
            InitializeComponent();

            if (!Library.Errors.Care.AntiInvalidInstance)
            {
                UpdateAll();
                UpdateOpen();
                UpdateLate();
                UpdateDone();

                if (GlobalVariables.Requests.Count(x => x.Status == 'A') > 0)
                {
                    tbcTabs.SelectedTab = tabLate;

                    lblRequestsCount.Text = "Total de Pedidos Atrasados: " + flpTabLate.Controls.Count;
                }
                else
                {
                    lblRequestsCount.Text = "Total de Pedidos Pendentes: " + flpTabOpen.Controls.Count;
                }
            }         
        }

        internal void UpdateEverything()
        {
            if (!this.IsSearch)
            {
                UpdateAll();
                UpdateOpen();
                UpdateLate();
                UpdateDone();
            }
        }

        internal void UpdateAll()
        {
            if (!this.IsSearch)
            {
                flpTabAll.Controls.Clear();

                if (GlobalVariables.OldRequests.Count > 0 && this.IsOldShown)
                {
                    foreach (Request item in GlobalVariables.OldRequests)
                    {
                        Components.CMP_RequestLittleBox box = new Components.CMP_RequestLittleBox(item);
                        box.OnChildRequestClick += new MouseEventHandler(onParentRequestClick);
                        flpTabAll.Controls.Add(box);
                    }
                }

                foreach (Request item2 in GlobalVariables.Requests)
                {
                    Components.CMP_RequestLittleBox box = new Components.CMP_RequestLittleBox(item2);
                    box.OnChildRequestClick += new MouseEventHandler(onParentRequestClick);
                    flpTabAll.Controls.Add(box);
                }
            }
        }

        private void UpdateOpen()
        {
            if (!this.IsSearch)
            {
                flpTabOpen.Controls.Clear();

                if (GlobalVariables.OldRequests.Count > 0 && this.IsOldShown)
                {
                    var filtered2 = GlobalVariables.OldRequests.Where(x => x.Status == 'P').Select(x => x);
                    foreach (Request item in filtered2)
                    {
                        Components.CMP_RequestLittleBox box = new Components.CMP_RequestLittleBox(item);
                        box.OnChildRequestClick += new MouseEventHandler(onParentRequestClick);
                        flpTabOpen.Controls.Add(box);
                    }
                }

                var filtered = GlobalVariables.Requests.Where(x => x.Status == 'P').Select(x => x);
                foreach (Request item in filtered)
                {
                    Components.CMP_RequestLittleBox box = new Components.CMP_RequestLittleBox(item);
                    box.OnChildRequestClick += new MouseEventHandler(onParentRequestClick);
                    flpTabOpen.Controls.Add(box);
                }
            }            
        }

        private void UpdateCanceled()
        {
            if (!this.IsSearch)
            {
                flpTabCancelled.Controls.Clear();

                foreach (Request item in GlobalVariables.CancelledRequests)
                {
                    Components.CMP_RequestLittleBox box = new Components.CMP_RequestLittleBox(item);
                    box.OnChildRequestClick += new MouseEventHandler(onParentRequestClick);
                    flpTabCancelled.Controls.Add(box);
                }
            }
        }

        private void UpdateLate()
        {
            if (!this.IsSearch)
            {
                flpTabLate.Controls.Clear();

                if (GlobalVariables.OldRequests.Count > 0 && this.IsOldShown)
                {
                    var filtered2 = GlobalVariables.OldRequests.Where(x => x.Status == 'A').Select(x => x);
                    foreach (Request item in filtered2)
                    {
                        Components.CMP_RequestLittleBox box = new Components.CMP_RequestLittleBox(item);
                        box.OnChildRequestClick += new MouseEventHandler(onParentRequestClick);
                        flpTabLate.Controls.Add(box);
                    }
                }

                var filtered = GlobalVariables.Requests.Where(x => x.Status == 'A').Select(x => x);
                foreach (Request item in filtered)
                {
                    Components.CMP_RequestLittleBox box = new Components.CMP_RequestLittleBox(item);
                    box.OnChildRequestClick += new MouseEventHandler(onParentRequestClick);
                    flpTabLate.Controls.Add(box);
                }
            }
        }

        private void UpdateDone()
        {
            if (!this.IsSearch)
            {
                flpTabDone.Controls.Clear();
                if (GlobalVariables.OldRequests.Count > 0 && this.IsOldShown)
                {
                    var filtered2 = GlobalVariables.OldRequests.Where(x => x.Status == 'F').Select(x => x);
                    foreach (Request item in filtered2)
                    {
                        Components.CMP_RequestLittleBox box = new Components.CMP_RequestLittleBox(item);
                        box.OnChildRequestClick += new MouseEventHandler(onParentRequestClick);
                        flpTabDone.Controls.Add(box);
                    }
                }

                var filtered = GlobalVariables.Requests.Where(x => x.Status == 'F').Select(x => x);
                foreach (Request item in filtered)
                {
                    Components.CMP_RequestLittleBox box = new Components.CMP_RequestLittleBox(item);
                    box.OnChildRequestClick += new MouseEventHandler(onParentRequestClick);
                    flpTabDone.Controls.Add(box);
                }
            }
        }

        private void TbcTabs_Selected(object sender, TabControlEventArgs e)
        {
            if (tbcTabs.SelectedTab == tabAll)
            {
                lblRequestsCount.Text = "Total de Pedidos: " + GlobalVariables.Requests.Count();
                btnShowOld.Show();
            }
            else if (tbcTabs.SelectedTab == tabOpen)
            {
                lblRequestsCount.Text = "Total de Pedidos Pendentes: " + flpTabOpen.Controls.Count;
                btnShowOld.Show();
            }
            else if (tbcTabs.SelectedTab == tabCancelled)
            {
                if (this.FirstSeeCancelled)
                {
                    SeekFor.CancelledRequests();

                    this.FirstSeeCancelled = false;
                }

                lblRequestsCount.Text = "Total de Pedidos Cancelados: " + flpTabCancelled.Controls.Count;
                btnShowOld.Hide();
            }
            else if (tbcTabs.SelectedTab == tabLate)
            {
                lblRequestsCount.Text = "Total de Pedidos Atrasados: " + flpTabLate.Controls.Count;
                btnShowOld.Show();
            }
            else
            {
                lblRequestsCount.Text = "Total de Pedidos Finalizados: " + flpTabDone.Controls.Count;
                btnShowOld.Show();
            }
        }

        void onParentRequestClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmsMenuPedidos.Show(USC_Requests.mousePosition);
            }
            else
            {
                Modals.Requests.FRM_DetailsRequest details = new Modals.Requests.FRM_DetailsRequest(SelectedRequest);
                details.ShowDialog();

                if (details.ChangedToDone)
                {
                    GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
                    ml.Show();
                    UpdateAll();
                    UpdateOpen();
                    UpdateLate();
                    UpdateDone();
                    this.RequestAltered(this, new EventArgs());
                    ml.CustomClose();
                }
                else if (details.ChangedToCanceled)
                {
                    GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
                    ml.Show();
                    UpdateAll();
                    UpdateCanceled();
                    UpdateOpen();
                    UpdateLate();
                    this.RequestAltered(this, new EventArgs());
                    ml.CustomClose();
                }
                else if (details.ChangedToOpened)
                {
                    GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
                    ml.Show();
                    UpdateAll();
                    UpdateLate();
                    UpdateOpen();
                    UpdateDone();
                    UpdateCanceled();
                    this.RequestAltered(this, new EventArgs());
                    ml.CustomClose();
                }
            }
        }

        private void alterarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (USC_Requests.SelectedRequest.Status == 'C' || USC_Requests.SelectedRequest.Status == 'F')
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Pedidos cancelados e finalizados " +
                    "não podem ser alterados!", 6);
                messOk.Show();
                return;
            }

            Modals.Requests.FRM_AlterRequest alter = new Modals.Requests.FRM_AlterRequest(USC_Requests.SelectedRequest);
            alter.ShowDialog();
            if (alter.Canceled) return;

            UpdateOpen();
            UpdateLate();
            UpdateAll();

            this.RequestAltered(this, new EventArgs());
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (USC_Requests.SelectedRequest.Status != 'C')
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Apenas pedidos cancelados podem ser excluídos!", 1);
                messOk.Show();
                return;
            }

            if (GlobalVariables.Requests.Exists(x => x.Id == USC_Requests.SelectedRequest.Id))
            {
                GlobalVariables.Requests.RemoveAll(x => x.Id == USC_Requests.SelectedRequest.Id);
                
                MySqlNonQuery.DeleteRequestById(USC_Requests.SelectedRequest.Id);

                UpdateAll();
                UpdateDone();
                UpdateLate();
                UpdateOpen();
            }
            else if (GlobalVariables.OldRequests.Exists(x => x.Id == USC_Requests.SelectedRequest.Id))
            {
                GlobalVariables.OldRequests.RemoveAll(x => x.Id == USC_Requests.SelectedRequest.Id);

                UpdateAll();
                UpdateDone();
                UpdateLate();
                UpdateOpen();
            }
            else
            {
                GlobalVariables.CancelledRequests.RemoveAll(x => x.Id == USC_Requests.SelectedRequest.Id);

                UpdateCanceled();
            }

            Library.Files.Control.DeleteRequestFile(USC_Requests.SelectedRequest.Number);
            Library.Files.Control.DeleteLotsConsumptionFile(USC_Requests.SelectedRequest.Number);
        }

        private void BtnNewRequest_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.Products.Count == 0 && GlobalVariables.Jobs.Count == 0)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Impossível criar um pedido sem ter ao menos um produto ou um serviço adicionado! Adicione um produto ou um serviço antes para poder criar um pedido.", 1);
                messOk.Show();
                return;
            }
            else if (GlobalVariables.Costumers.Count == 0)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Impossível criar um pedido sem ter ao menos um cliente cadastrado! Cadastre um cliente antes para poder criar um pedido.", 1);
                messOk.Show();
                return;
            }

            Modals.Requests.FRM_NewRequest newReq = new Modals.Requests.FRM_NewRequest();
            newReq.ShowDialog();

            if (newReq.Canceled) return;

            UpdateOpen();
            UpdateAll();

            RequestAltered(this, new EventArgs());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (tbcTabs.SelectedTab == tabAll)
            {
                UpdateAll();
            }
            else if (tbcTabs.SelectedTab == tabOpen)
            {
                UpdateOpen();
            }
            else if (tbcTabs.SelectedTab == tabCancelled)
            {
                SeekFor.CancelledRequests();
                UpdateCanceled();
            }
            else if (tbcTabs.SelectedTab == tabLate)
            {
                UpdateLate();
            }
            else
            {
                UpdateDone();
            }
        }

        private void btnShowOld_Click(object sender, EventArgs e)
        {
            if (this.IsOldShown)
            {
                this.IsOldShown = false;

                btnShowOld.Text = "Ver antigos";
            }
            else
            {
                this.IsOldShown = true;

                SeekFor.OldRequest();

                btnShowOld.Text = "Ocutar antigos";
            }

            UpdateAll();
            UpdateOpen();
            UpdateLate();
            UpdateDone();
        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSearch.Text.Length <= 0)
                {
                    this.IsSearch = false;

                    UpdateEverything();
                    UpdateCanceled();
                }

                List<Request> requests = new List<Request>();

                //The switch of what list to use
                if (tbcTabs.SelectedTab == tabCancelled)
                {
                    if (FrmSO.ckbNumber.Checked)
                    {
                        var filtered = GlobalVariables.CancelledRequests.Where(x => x.Number.Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Request item in filtered)
                        {
                            if(!requests.Exists(x => x.Id == item.Id))
                            {
                                requests.Add(item);
                            }                            
                        }                        
                    }
                    if (FrmSO.ckbStart.Checked)
                    {
                        var filtered = GlobalVariables.CancelledRequests.Where(x => x.StartedIn.ToString("dd/MM/yyyy HH:mm:ss").Contains(txtSearch.Text)).Select(x => x);
                        foreach (Request item in filtered)
                        {
                            if (!requests.Exists(x => x.Id == item.Id))
                            {
                                requests.Add(item);
                            }
                        }                        
                    }
                    if (FrmSO.ckbValue.Checked)
                    {
                        var filtered = GlobalVariables.CancelledRequests.Where(x => x.Value.ToString("n2").Contains(txtSearch.Text)).Select(x => x);
                        foreach (Request item in filtered)
                        {
                            if (!requests.Exists(x => x.Id == item.Id))
                            {
                                requests.Add(item);
                            }
                        }                        
                    }
                    if (FrmSO.ckbCostumer.Checked)
                    {
                        foreach (Request item in GlobalVariables.CancelledRequests)
                        {
                            if (Costumer.GetCostumerName(item.Id_Costumer).ToLower().Contains(txtSearch.Text))
                            {
                                if (!requests.Exists(x => x.Id == item.Id))
                                {
                                    requests.Add(item);
                                }
                            }
                        }                        
                    }
                    if (FrmSO.ckbExpire.Checked)
                    {
                        var filtered = GlobalVariables.CancelledRequests.Where(x => !Library.Checkers.Structs.IsDateTimeNull(x.ExpiresIn) && x.ExpiresIn.ToString("dd/MM/yyyy HH:mm:ss").Contains(txtSearch.Text)).Select(x => x);
                        foreach (Request item in filtered)
                        {
                            if (!requests.Exists(x => x.Id == item.Id))
                            {
                                requests.Add(item);
                            }
                        }                        
                    }
                    if (FrmSO.ckbObservations.Checked)
                    {
                        foreach (Request item in GlobalVariables.CancelledRequests)
                        {
                            if (item.Observations == null || item.Observations == "")
                            {
                                continue;
                            }
                            if (item.Observations.ToString().Contains(txtSearch.Text) && !requests.Exists(x => x.Id == item.Id))
                            {
                                requests.Add(item);
                            }
                        }                       
                    }
                    if (FrmSO.cbkIsDelivery.Checked)
                    {
                        List<Request> filtered = requests.Where(x => x.IsDelivery == true).Select(x => x).ToList();
                        requests.Clear();
                        requests = filtered.ToList();
                    }

                    ListIntoFLP(requests, ref flpTabCancelled);
                }
                else
                {
                    //Assembly of the entire requests
                    if (FrmSO.ckbNumber.Checked)
                    {
                        var filtered = GlobalVariables.Requests.Where(x => x.Number.Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Request item in filtered)
                        {
                            if (!requests.Exists(x => x.Id == item.Id))
                            {
                                requests.Add(item);
                            }
                        }
                        if (this.IsOldShown)
                        {
                            var filtered2 = GlobalVariables.OldRequests.Where(x => x.Number.Contains(txtSearch.Text.ToLower())).Select(x => x);
                            foreach (Request item2 in filtered2)
                            {
                                if (!requests.Exists(x => x.Id == item2.Id))
                                {
                                    requests.Add(item2);
                                }
                            }
                        }
                    }
                    if (FrmSO.ckbStart.Checked)
                    {
                        var filtered = GlobalVariables.Requests.Where(x => x.StartedIn.ToString("dd/MM/yyyy HH:mm:ss").Contains(txtSearch.Text)).Select(x => x);
                        foreach (Request item in filtered)
                        {
                            if (!requests.Exists(x => x.Id == item.Id))
                            {
                                requests.Add(item);
                            }
                        }
                        if (this.IsOldShown)
                        {
                            var filtered2 = GlobalVariables.OldRequests.Where(x => x.StartedIn.ToString("dd/MM/yyyy HH:mm:ss").Contains(txtSearch.Text)).Select(x => x);
                            foreach (Request item2 in filtered2)
                            {
                                if (!requests.Exists(x => x.Id == item2.Id))
                                {
                                    requests.Add(item2);
                                }
                            }
                        }
                    }
                    if (FrmSO.ckbValue.Checked)
                    {
                        var filtered = GlobalVariables.Requests.Where(x => x.Value.ToString("n2").Contains(txtSearch.Text)).Select(x => x);
                        foreach (Request item in filtered)
                        {
                            if (!requests.Exists(x => x.Id == item.Id))
                            {
                                requests.Add(item);
                            }
                        }
                        if (this.IsOldShown)
                        {
                            var filtered2 = GlobalVariables.OldRequests.Where(x => x.Value.ToString("n2").Contains(txtSearch.Text)).Select(x => x);
                            foreach (Request item2 in filtered2)
                            {
                                if (!requests.Exists(x => x.Id == item2.Id))
                                {
                                    requests.Add(item2);
                                }
                            }
                        }
                    }
                    if (FrmSO.ckbCostumer.Checked)
                    {
                        foreach (Request item in GlobalVariables.Requests)
                        {
                            if (Costumer.GetCostumerName(item.Id_Costumer).ToLower().Contains(txtSearch.Text))
                            {
                                if (!requests.Exists(x => x.Id == item.Id))
                                {
                                    requests.Add(item);
                                }
                            }
                        }
                        if (this.IsOldShown)
                        {
                            foreach (Request item2 in GlobalVariables.OldRequests)
                            {
                                if (Costumer.GetCostumerName(item2.Id_Costumer).ToLower().Contains(txtSearch.Text))
                                {
                                    if (!requests.Exists(x => x.Id == item2.Id))
                                    {
                                        requests.Add(item2);
                                    }
                                }
                            }
                        }
                    }
                    if (FrmSO.ckbExpire.Checked)
                    {
                        var filtered = GlobalVariables.Requests.Where(x => !Structs.IsDateTimeNull(x.ExpiresIn) && x.ExpiresIn.ToString("dd/MM/yyyy HH:mm:ss").Contains(txtSearch.Text)).Select(x => x);
                        foreach (Request item in filtered)
                        {
                            if (!requests.Exists(x => x.Id == item.Id))
                            {
                                requests.Add(item);
                            }
                        }
                        if (this.IsOldShown)
                        {
                            var filtered2 = GlobalVariables.OldRequests.Where(x => !Structs.IsDateTimeNull(x.ExpiresIn) && x.ExpiresIn.ToString("dd/MM/yyyy HH:mm:ss").Contains(txtSearch.Text)).Select(x => x);
                            foreach (Request item2 in filtered2)
                            {
                                if (!requests.Exists(x => x.Id == item2.Id))
                                {
                                    requests.Add(item2);
                                }
                            }
                        }
                    }
                    if (FrmSO.ckbObservations.Checked)
                    {
                        foreach (Request item in GlobalVariables.Requests)
                        {
                            if (item.Observations == null || item.Observations == "")
                            {
                                continue;
                            }
                            if (item.ExpiresIn.ToString().Contains(txtSearch.Text) && !requests.Exists(x => x.Id == item.Id))
                            {
                                requests.Add(item);
                            }
                        }
                        if (this.IsOldShown)
                        {
                            foreach (Request item in GlobalVariables.OldRequests)
                            {
                                if (item.Observations == null || item.Observations == "")
                                {
                                    continue;
                                }
                                if (item.ExpiresIn.ToString().Contains(txtSearch.Text) && !requests.Exists(x => x.Id == item.Id))
                                {
                                    requests.Add(item);
                                }
                            }
                        }
                    }
                    if (FrmSO.cbkIsDelivery.Checked)
                    {
                        List<Request> filtered = requests.Where(x => x.IsDelivery == true).Select(x => x).ToList();
                        requests.Clear();
                        requests = filtered.ToList();
                    }

                    //The selection of wich tab is it
                    if (tbcTabs.SelectedTab == tabAll)
                    {                        
                        ListIntoFLP(requests, ref flpTabAll);
                    }
                    else if (tbcTabs.SelectedTab == tabOpen)
                    {
                        List<Request> filtered = requests.Where(x => x.Status == 'P').Select(x => x).ToList();
                        requests.Clear();
                        requests = filtered.ToList();

                        ListIntoFLP(requests, ref flpTabOpen);
                    }
                    else if (tbcTabs.SelectedTab == tabLate)
                    {
                        List<Request> filtered = requests.Where(x => x.Status == 'A').Select(x => x).ToList();
                        requests.Clear();
                        requests = filtered.ToList();

                        ListIntoFLP(requests, ref flpTabLate);
                    }
                    else
                    {
                        List<Request> filtered = requests.Where(x => x.Status == 'F').Select(x => x).ToList();
                        requests.Clear();
                        requests = filtered.ToList();

                        ListIntoFLP(requests, ref flpTabDone);
                    }
                }                             
            }
        }

        private void ListIntoFLP(List<Request> requests, ref FlowLayoutPanel flp)
        {
            flp.Controls.Clear();

            if(requests.Count > 0)
            {
                foreach (Request item in requests)
                {
                    Components.CMP_RequestLittleBox box = new Components.CMP_RequestLittleBox(item);
                    box.OnChildRequestClick += new MouseEventHandler(onParentRequestClick);
                    flp.Controls.Add(box);
                }
            }
            else
            {
                Label nothing = new Label();
                nothing.AutoSize = true;
                nothing.Font = Library.Style.Labels.BigLabel;
                nothing.Text = "Nenhum resultado...";
                flp.Controls.Add(nothing);
            }            

            this.IsSearch = true;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnSearchOptions_Click(object sender, EventArgs e)
        {
            this.FrmSO.ShowDialog();
        }

        private void TbcTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tbcTabs.SelectedTab == tabCancelled)
            {
                GlobalModals.FRM_Confirmation conf = new GlobalModals.FRM_Confirmation("Atenção! Carregar todos os pedidos cancelados pode demorar alguns minutos, dependendo da quantidade. Deseja continuar assim mesmo?", 1);
                conf.Show();
                if (!conf.Result)
                {
                    tbcTabs.SelectTab(tabOpen);

                    return;
                }
                else
                {
                    if (GlobalVariables.CancelledRequests.Count < 1) SeekFor.CancelledRequests();

                    this.UpdateCanceled();
                }                
            }
        }
    }
}
