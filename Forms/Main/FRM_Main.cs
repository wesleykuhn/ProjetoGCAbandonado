using System;
using System.Drawing;
using System.Windows.Forms;
using GC.Library.Objects;
using GC.GlobalModals;
using System.Linq;
using GC.Library.Style;
using GC.Library.Errors;
using GC.Library.Checkers;
using GC.Library;
using GC.Library.Sounds;
using GC.Library.Auth;

namespace GC.Forms.Main
{
    public partial class FRM_Main : Bases.FRM_Full
    {
        //Sidebar variables
        byte SelectedTab = 1;
        byte OldSelected = 1;

        //Others
        bool FirstActiveted = true;

        public FRM_Main()
        {
            InitializeComponent();

            this.ReadyForm();
            this.SwitchCloseToTurnoffIcon();

            TabSelectedShows(0);

            //Events to refresh controls from another controls
            //Requests to dependencies
            uscRequests1.RequestAltered += new EventHandler(RequestsGotAlterations);

            // Costumers
            uscCostumers1.CostumerUpdatedDeleted += new EventHandler(CostumersGotAlterations);

            // Suppliers
            uscSuppliers1.SupplierAlteredDeleted += new EventHandler(SuppliersGotAlterations);

            // Jobs
            uscJobs1.JobAlteredDeleted += new EventHandler(JobsGotAlterations);

            // Products
            uscProducts1.ProductAlteredDeleted += new EventHandler(ProductsGotAlterations);

            if (!Care.AntiInvalidInstance)
            {
                //Check if there's user document folder
                Library.Folders.StartupCheckIn.CheckFoldersAfterLoad();

                if (Structs.IsDateOlderOrEqualsToDate(DateTime.Now, GlobalVariables.User.Joined.AddMonths(1)))
                {
                    //Top label that says the time to expiration
                    DateTime testEnd = GlobalVariables.User.Joined.AddMonths(1);

                    TimeSpan days = testEnd.Subtract(DateTime.Now);
                    int dif2 = (int)days.TotalDays;

                    lblTestPeriod.Text = "(" + dif2.ToString() + " dias para acabar o teste grátis)";
                    lblTestPeriod.Visible = true;
                }

                if (GlobalVariables.AdminMessages.Where(x => Structs.IsDateTimeNull(x.ReadIn)).Count() > 0)
                {
                    pnlAdminMessagesBack.BackgroundImage = Properties.Resources.icon_new_message_30x30;
                }

                Library.Routines.AwaysActive.RunRoutine = true;
                Library.Routines.AwaysActive.Start(pnlAdminMessagesBack);
            }
        }

        private void GiveActive(object sender, EventArgs e)
        {
            this.Activate();
        }

        // Speech and Modals alerts system ------------------------------------------------------------------->
        private void FrmMainForm_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            GlobalModals.FRM_MessageAndOK messOk;

            bool jump = false;
            if (Structs.IsDateOlderOrEqualsToDate(DateTime.Now, GlobalVariables.User.Joined.AddMonths(1)))
            {
                DateTime dateOfExpiration = Library.Translators.SqlToObject.ToDate(Library.Database.MySqlReader.ReadOnlyOneColumn("user_metadata", "expiration", new string[] { "id_user" }, new string[] { GlobalVariables.User.Id.ToString() }, null, new bool[] { false }));

                TimeSpan aux = dateOfExpiration.Subtract(DateTime.Now);
                double dif = aux.TotalDays;

                if (dif < 7)
                {
                    GlobalModals.FRM_Confirmation conf = new FRM_Confirmation("Sua conta está perto de vencer. Você está gostando do programa? Gostaria de ver os detalhes e preços dos planos e talvez até mesmo recarregar sua conta?", 6);
                    conf.Show();
                    if (conf.Result)
                    {
                        TabSelectedShows(9);

                        System.Diagnostics.Process.Start("https://www.kuhnper.com.br/gc/planos");

                        jump = true;
                    }
                }
            }

            if (!jump)
            {
                if ((this.FirstActiveted && GlobalVariables.User.Cnpj == null) || (this.FirstActiveted && GlobalVariables.User.Cnpj == ""))
                {
                    GlobalModals.FRM_Confirmation conf = new FRM_Confirmation("Você ainda não tem um CNPJ definido. Gostaria de definir um agora? " +
                        "Isso poderá ajudar você ao enviar E-mails com detalhes dos pedidos de seus clientes.", 6);
                    conf.Show();
                    if (conf.Result)
                    {
                        Modals.Main.FRM_EditCnpj editCnpj = new Modals.Main.FRM_EditCnpj();
                        editCnpj.ShowDialog();
                    }
                }

                if (this.FirstActiveted && GlobalVariables.Configuration.Enable_windows_voice_alerts)
                {
                    string startingReports = "Olá. ";

                    int counter = GlobalVariables.Lots.Count(x => !Structs.IsDateTimeNull(x.ExpiresIn) && DateTime.Compare(DateTime.Now.AddDays(GlobalVariables.Configuration.Days_before_expiration), x.ExpiresIn) == 0 || !Structs.IsDateTimeNull(x.ExpiresIn) && DateTime.Compare(DateTime.Now.AddDays(GlobalVariables.Configuration.Days_before_expiration), x.ExpiresIn) == 1);
                    if (counter > 0)
                    {
                        if (counter == 1)
                        {
                            startingReports += counter.ToString() + " lote de produto está perto de vencer. ";
                        }
                        else
                        {
                            startingReports += counter.ToString() + " lotes de produtos estão perto de vencer. ";
                        }
                    }

                    counter = GlobalVariables.Requests.Count(x => x.Status == 'A');
                    if (counter > 0)
                    {
                        if (counter == 1)
                        {
                            startingReports += counter.ToString() + " pedido está atrasado. ";
                        }
                        else
                        {
                            startingReports += counter.ToString() + " pedidos estão atrasados. ";
                        }
                    }

                    Speech.AddSpeechToSpeakRow_TaskRun(startingReports);
                }

                if (this.FirstActiveted && GlobalVariables.Configuration.Enable_modal_alerts)
                {
                    int counter = GlobalVariables.Lots.Count(x => !Structs.IsDateTimeNull(x.ExpiresIn) && DateTime.Compare(DateTime.Now.AddDays(GlobalVariables.Configuration.Days_before_expiration), x.ExpiresIn) == 0 || !Structs.IsDateTimeNull(x.ExpiresIn) && DateTime.Compare(DateTime.Now.AddDays(GlobalVariables.Configuration.Days_before_expiration), x.ExpiresIn) == 1);

                    if (counter > 0)
                    {
                        messOk = new GlobalModals.FRM_MessageAndOK(counter.ToString() + " lote(s) de produto está(ão) perto de " +
                        "vencer! Para mais detalhes clique em 'Produtos Perto Do Vencimento' no painel de 'Produtos'.", 6);
                        messOk.Show();
                    }

                    if (GlobalVariables.Configuration.Enable_critical_stock_system)
                    {
                        counter = 0;
                        foreach (Product item in GlobalVariables.Products)
                        {
                            if (Product.GetTotalStockQuantity(item.Id) < item.IdealStock || Product.GetTotalStockQuantity(item.Id) == 0)
                            {
                                counter++;
                            }
                        }

                        if (counter > 0)
                        {
                            messOk = new GlobalModals.FRM_MessageAndOK(counter.ToString() + " produto(s) está(ão) com o estoque baixo! " +
                            "Mais detalhes, clique em 'Produtos Com Estoque Baixo' no painel de 'Produtos'.", 6);
                            messOk.Show();
                        }
                    }

                    counter = GlobalVariables.Requests.Count(x => x.Status == 'A');

                    if (counter > 0)
                    {
                        messOk = new GlobalModals.FRM_MessageAndOK("Atenção! " + counter.ToString() + " pedido(s) está(ão) atrasado(s)!", 6);
                        messOk.Show();
                    }
                }
            }
            
            this.FirstActiveted = false;
        }
        // <-----------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------
        // CONTROLS COMMUNICATIONS (EVENTS) --------------------------------------------------------
        // -----------------------------------------------------------------------------------------
        private void RequestsGotAlterations(object sender, EventArgs e)
        {
            uscProducts1.UpdateStats();
            uscCostumers1.UpdateStats();
        }

        private void CostumersGotAlterations(object sender, EventArgs e)
        {
            uscRequests1.UpdateEverything();
            uscWarranties1.UpdateList();
        }

        private void SuppliersGotAlterations(object sender, EventArgs e)
        {
            uscProducts1.UpdateStats();
        }

        private void JobsGotAlterations(object sender, EventArgs e)
        {
            uscWarranties1.UpdateList();
        }

        private void ProductsGotAlterations(object sender, EventArgs e)
        {
            uscWarranties1.UpdateList();
        }        
        // ------------------------------------------------------------------------------------------

        private void pnlAdminMessagesBack_Click(object sender, EventArgs e)
        {
            Modals.Main.FRM_AdminMessages adminMsg = new Modals.Main.FRM_AdminMessages();
            adminMsg.ShowDialog();

            int counter = GlobalVariables.AdminMessages.Where(x => Structs.IsDateTimeNull(x.ReadIn)).Count();

            if (counter == 0)
            {
                pnlAdminMessagesBack.BackgroundImage = Properties.Resources.icon_message_30x30;
            }
        }

        //Sidebar system ----------------------------------------------------------------------------------------------->
        private void TabSelectedShows(byte newTab)
        {
            if (newTab == this.SelectedTab) return;
            this.OldSelected = SelectedTab;
            this.SelectedTab = newTab;

            ChangeSidebarItemBackColor();

            switch (this.SelectedTab)
            {
                //Home
                case 0:
                    lblTitle.Text = "GC - Início";
                    uscHome1.BringToFront();
                    break;

                //Schedule
                case 1:
                    lblTitle.Text = "GC - Agenda";
                    uscSchedule1.BringToFront();
                    break;

                //Orders
                case 2:
                    lblTitle.Text = "GC - Pedidos";
                    uscRequests1.BringToFront();
                    break;

                //Warranty
                case 3:
                    lblTitle.Text = "GC - Garantias";
                    uscWarranties1.BringToFront();
                    break;

                //Costumers
                case 4:
                    lblTitle.Text = "GC - Clientes";
                    uscCostumers1.BringToFront();
                    break;

                //Products
                case 5:
                    lblTitle.Text = "GC - Produtos";
                    uscProducts1.BringToFront();
                    break;

                //Jobs
                case 6:
                    lblTitle.Text = "GC - Serviços";
                    uscJobs1.BringToFront();
                    break;

                //Suppliers
                case 7:
                    lblTitle.Text = "GC - Fornecedores";
                    uscSuppliers1.BringToFront();
                    break;

                //Stats
                case 8:
                    lblTitle.Text = "GC - Estatísticas";

                    if (!uscStats1.AlreadyBuilt)
                    {
                        uscStats1.UpdateAllData();

                        if (uscStats1.CanAnimate)
                        {
                            uscStats1.GeneralTotalProfitAnimation(this, new EventArgs());
                        }
                    }

                    uscStats1.BringToFront();
                    break;

                //Cofigurations
                case 9:
                    lblTitle.Text = "GC - Configurações";

                    uscConfiguration1.BringToFront();
                    break;
            }

            this.Text = lblTitle.Text;

            pnlSidebar.BringToFront();
        }

        private void ChangeSidebarItemBackColor()
        {
            //Return the old to dark
            switch (this.OldSelected)
            {
                case 0:
                    pnlHomeIcon.BackColor = Color.FromArgb(33, 33, 33);
                    break;
                case 1:
                    pnlScheduleIcon.BackColor = Color.FromArgb(33, 33, 33);
                    break;
                case 2:
                    pnlRequestsIcon.BackColor = Color.FromArgb(33, 33, 33);
                    break;
                case 3:
                    pnlWarrantiesIcon.BackColor = Color.FromArgb(33, 33, 33);
                    break;
                case 4:
                    pnlCostumersIcon.BackColor = Color.FromArgb(33, 33, 33);
                    break;
                case 5:
                    pnlProductsIcon.BackColor = Color.FromArgb(33, 33, 33);
                    break;
                case 6:
                    pnlJobsIcon.BackColor = Color.FromArgb(33, 33, 33);
                    break;
                case 7:
                    pnlSuppliersIcon.BackColor = Color.FromArgb(33, 33, 33);
                    break;
                case 8:
                    pnlStatsIcon.BackColor = Color.FromArgb(33, 33, 33);
                    break;
                case 9:
                    pnlConfigIcon.BackColor = Color.FromArgb(33, 33, 33);
                    break;
            }

            //Give the new color to the selected
            switch (this.SelectedTab)
            {
                case 0:
                    pnlHomeIcon.BackColor = ColorsPalette.GDE_Info;
                    break;
                case 1:
                    pnlScheduleIcon.BackColor = ColorsPalette.GDE_Info;
                    break;
                case 2:
                    pnlRequestsIcon.BackColor = ColorsPalette.GDE_Info;
                    break;
                case 3:
                    pnlWarrantiesIcon.BackColor = ColorsPalette.GDE_Info;
                    break;
                case 4:
                    pnlCostumersIcon.BackColor = ColorsPalette.GDE_Info;
                    break;
                case 5:
                    pnlProductsIcon.BackColor = ColorsPalette.GDE_Info;
                    break;
                case 6:
                    pnlJobsIcon.BackColor = ColorsPalette.GDE_Info;
                    break;
                case 7:
                    pnlSuppliersIcon.BackColor = ColorsPalette.GDE_Info;
                    break;
                case 8:
                    pnlStatsIcon.BackColor = ColorsPalette.GDE_Info;
                    break;
                default:
                    pnlConfigIcon.BackColor = ColorsPalette.GDE_Info;
                    break;
            }
        }

        //The clicks events --->
        private void pnlHomeIcon_Click(object sender, EventArgs e)
        {
            TabSelectedShows(0);
        }

        private void PnlScheduleTab_Click(object sender, EventArgs e)
        {
            TabSelectedShows(1);
        }

        private void PnlOrdersTab_Click(object sender, EventArgs e)
        {
            TabSelectedShows(2);
        }

        private void PnlWarrantyIcon_Click(object sender, EventArgs e)
        {
            TabSelectedShows(3);
        }

        private void PnlCostumersTab_Click(object sender, EventArgs e)
        {
            TabSelectedShows(4);
        }

        private void pnlProductsTab_Click(object sender, EventArgs e)
        {
            TabSelectedShows(5);
        }

        private void PnlJobsTab_Click(object sender, EventArgs e)
        {
            TabSelectedShows(6);
        }

        private void pnlSuppliersTab_Click(object sender, EventArgs e)
        {
            TabSelectedShows(7);
        }

        private void PnlStatsTab_Click(object sender, EventArgs e)
        {
            TabSelectedShows(8);
        }

        private void PnlConfigIcon_Click(object sender, EventArgs e)
        {
            TabSelectedShows(9);
        }       
        // <----            

        //Sidebar, blue effect on hover
        private void HomeSidebar_MouseEnter(object sender, EventArgs e)
        {
            if (this.SelectedTab == 0) return;
            pnlHomeIcon.BackColor = Color.FromArgb(55, 55, 55);
        }
        private void HomeSidebar_MouseLeave(object sender, EventArgs e)
        {
            if (this.SelectedTab == 0) return;
            pnlHomeIcon.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void ScheduleSidebar_MouseEnter(object sender, EventArgs e)
        {
            if (this.SelectedTab == 1) return;
            pnlScheduleIcon.BackColor = Color.FromArgb(55, 55, 55);
        }
        private void ScheduleSidebar_MouseLeave(object sender, EventArgs e)
        {
            if (this.SelectedTab == 1) return;
            pnlScheduleIcon.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void RequestsSidebar_MouseEnter(object sender, EventArgs e)
        {
            if (this.SelectedTab == 2) return;
            pnlRequestsIcon.BackColor = Color.FromArgb(55, 55, 55);
        }
        private void RequestsSidebar_MouseLeave(object sender, EventArgs e)
        {
            if (this.SelectedTab == 2) return;
            pnlRequestsIcon.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void PnlWarrantyIcon_MouseEnter(object sender, EventArgs e)
        {
            if (this.SelectedTab == 3) return;
            pnlWarrantiesIcon.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void PnlWarrantyIcon_MouseLeave(object sender, EventArgs e)
        {
            if (this.SelectedTab == 3) return;
            pnlWarrantiesIcon.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void CostumersSidebar_MouseEnter(object sender, EventArgs e)
        {
            if (this.SelectedTab == 4) return;
            pnlCostumersIcon.BackColor = Color.FromArgb(55, 55, 55);
        }
        private void CostumersSidebar_MouseLeave(object sender, EventArgs e)
        {
            if (this.SelectedTab == 4) return;
            pnlCostumersIcon.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void ProductsSidebar_MouseEnter(object sender, EventArgs e)
        {
            if (this.SelectedTab == 5) return;
            pnlProductsIcon.BackColor = Color.FromArgb(55, 55, 55);
        }
        private void ProductsSidebar_MouseLeave(object sender, EventArgs e)
        {
            if (this.SelectedTab == 5) return;
            pnlProductsIcon.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void JobsSidebar_MouseEnter(object sender, EventArgs e)
        {
            if (this.SelectedTab == 6) return;
            pnlJobsIcon.BackColor = Color.FromArgb(55, 55, 55);
        }
        private void JobsSidebar_MouseLeave(object sender, EventArgs e)
        {
            if (this.SelectedTab == 6) return;
            pnlJobsIcon.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void SuppliersSidebar_MouseEnter(object sender, EventArgs e)
        {
            if (this.SelectedTab == 7) return;
            pnlSuppliersIcon.BackColor = Color.FromArgb(55, 55, 55);
        }
        private void SuppliersSidebar_MouseLeave(object sender, EventArgs e)
        {
            if (this.SelectedTab == 7) return;
            pnlSuppliersIcon.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void StatsSidebar_MouseEnter(object sender, EventArgs e)
        {
            if (this.SelectedTab == 8) return;
            pnlStatsIcon.BackColor = Color.FromArgb(55, 55, 55);
        }
        private void StatsSidebar_MouseLeave(object sender, EventArgs e)
        {
            if (this.SelectedTab == 8) return;
            pnlStatsIcon.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void ConfigSidebar_MouseEnter(object sender, EventArgs e)
        {
            if (this.SelectedTab == 9) return;
            pnlConfigIcon.BackColor = Color.FromArgb(55, 55, 55);
        }
        private void ConfigSidebar_MouseLeave(object sender, EventArgs e)
        {
            if (this.SelectedTab == 9) return;
            pnlConfigIcon.BackColor = Color.FromArgb(33, 33, 33);
        }
        // -------------------------------------------------------------------------------------------------------------------->

        private void frmLogisticMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FRM_Confirmation frmExitConfirmantion = new FRM_Confirmation("Deseja realmente encerrar a sua sessão?", 1);
            frmExitConfirmantion.ShowDialog();
            if (frmExitConfirmantion.Result)
            {
                // Stoping the windows voice on leaving
                

                Token.ClearToken();
            }
            else
            {
                e.Cancel = true;
            }
        }

        // KeyControl to choose what USC will take the key event ----------------------------------------->
        private void lblTitle_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                Modals.Main.FRM_MemoryUsage infoMem = new Modals.Main.FRM_MemoryUsage();
                infoMem.ShowDialog();
            }
        }

        private void PNL_OpenDocuments_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Library.Informations.Directories.UserDocuments);
        }
        // <-----------------------------------------------------------------------------------------
    }
}
