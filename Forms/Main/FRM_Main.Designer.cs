namespace GC.Forms.Main
{
    partial class FRM_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlWarrantiesIcon = new System.Windows.Forms.Panel();
            this.pnlHomeIcon = new System.Windows.Forms.Panel();
            this.pnlScheduleIcon = new System.Windows.Forms.Panel();
            this.pnlRequestsIcon = new System.Windows.Forms.Panel();
            this.pnlCostumersIcon = new System.Windows.Forms.Panel();
            this.pnlProductsIcon = new System.Windows.Forms.Panel();
            this.pnlJobsIcon = new System.Windows.Forms.Panel();
            this.pnlSuppliersIcon = new System.Windows.Forms.Panel();
            this.pnlStatsIcon = new System.Windows.Forms.Panel();
            this.pnlConfigIcon = new System.Windows.Forms.Panel();
            this.lblNewMessage = new System.Windows.Forms.Label();
            this.pnlNewMessage = new System.Windows.Forms.Panel();
            this.ttTabs = new System.Windows.Forms.ToolTip(this.components);
            this.PNL_OpenDocuments = new System.Windows.Forms.Panel();
            this.lblTestPeriod = new System.Windows.Forms.Label();
            this.pnlAdminMessagesBack = new System.Windows.Forms.Panel();
            this.uscHome1 = new GC.Forms.Main.Controls.USC_Home();
            this.uscStats1 = new GC.Forms.Main.Controls.USC_Stats();
            this.uscConfiguration1 = new GC.Forms.Main.Controls.USC_Configuration();
            this.uscJobs1 = new GC.Forms.Main.Controls.USC_Jobs();
            this.uscProducts1 = new GC.Forms.Main.Controls.USC_Products();
            this.uscSuppliers1 = new GC.Forms.Main.Controls.USC_Suppliers();
            this.uscRequests1 = new GC.Forms.Main.Controls.USC_Requests();
            this.uscCostumers1 = new GC.Forms.Main.Controls.USC_Costumers();
            this.uscWarranties1 = new GC.Forms.Main.Controls.USC_Warranties();
            this.uscSchedule1 = new GC.Forms.Main.Controls.USC_Schedule();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(28, 16);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "GC";
            this.lblTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseClick);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnlSidebar.Controls.Add(this.pnlWarrantiesIcon);
            this.pnlSidebar.Controls.Add(this.pnlHomeIcon);
            this.pnlSidebar.Controls.Add(this.pnlScheduleIcon);
            this.pnlSidebar.Controls.Add(this.pnlRequestsIcon);
            this.pnlSidebar.Controls.Add(this.pnlCostumersIcon);
            this.pnlSidebar.Controls.Add(this.pnlProductsIcon);
            this.pnlSidebar.Controls.Add(this.pnlJobsIcon);
            this.pnlSidebar.Controls.Add(this.pnlSuppliersIcon);
            this.pnlSidebar.Controls.Add(this.pnlStatsIcon);
            this.pnlSidebar.Controls.Add(this.pnlConfigIcon);
            this.pnlSidebar.Controls.Add(this.lblNewMessage);
            this.pnlSidebar.Controls.Add(this.pnlNewMessage);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 30);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(50, 618);
            this.pnlSidebar.TabIndex = 2;
            // 
            // pnlWarrantiesIcon
            // 
            this.pnlWarrantiesIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWarrantiesIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnlWarrantiesIcon.BackgroundImage = global::GC.Properties.Resources.icon_warranties_40x40;
            this.pnlWarrantiesIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlWarrantiesIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlWarrantiesIcon.Location = new System.Drawing.Point(0, 165);
            this.pnlWarrantiesIcon.Name = "pnlWarrantiesIcon";
            this.pnlWarrantiesIcon.Size = new System.Drawing.Size(50, 55);
            this.pnlWarrantiesIcon.TabIndex = 25;
            this.ttTabs.SetToolTip(this.pnlWarrantiesIcon, "Garantias");
            this.pnlWarrantiesIcon.Click += new System.EventHandler(this.PnlWarrantyIcon_Click);
            this.pnlWarrantiesIcon.MouseEnter += new System.EventHandler(this.PnlWarrantyIcon_MouseEnter);
            this.pnlWarrantiesIcon.MouseLeave += new System.EventHandler(this.PnlWarrantyIcon_MouseLeave);
            // 
            // pnlHomeIcon
            // 
            this.pnlHomeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHomeIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnlHomeIcon.BackgroundImage = global::GC.Properties.Resources.icon_home_40x40;
            this.pnlHomeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlHomeIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlHomeIcon.Location = new System.Drawing.Point(0, 0);
            this.pnlHomeIcon.Name = "pnlHomeIcon";
            this.pnlHomeIcon.Size = new System.Drawing.Size(50, 55);
            this.pnlHomeIcon.TabIndex = 24;
            this.ttTabs.SetToolTip(this.pnlHomeIcon, "Início");
            this.pnlHomeIcon.Click += new System.EventHandler(this.pnlHomeIcon_Click);
            this.pnlHomeIcon.MouseEnter += new System.EventHandler(this.HomeSidebar_MouseEnter);
            this.pnlHomeIcon.MouseLeave += new System.EventHandler(this.HomeSidebar_MouseLeave);
            // 
            // pnlScheduleIcon
            // 
            this.pnlScheduleIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlScheduleIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnlScheduleIcon.BackgroundImage = global::GC.Properties.Resources.icon_calendario_40x40;
            this.pnlScheduleIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlScheduleIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlScheduleIcon.Location = new System.Drawing.Point(0, 55);
            this.pnlScheduleIcon.Name = "pnlScheduleIcon";
            this.pnlScheduleIcon.Size = new System.Drawing.Size(50, 55);
            this.pnlScheduleIcon.TabIndex = 24;
            this.ttTabs.SetToolTip(this.pnlScheduleIcon, "Agenda");
            this.pnlScheduleIcon.Click += new System.EventHandler(this.PnlScheduleTab_Click);
            this.pnlScheduleIcon.MouseEnter += new System.EventHandler(this.ScheduleSidebar_MouseEnter);
            this.pnlScheduleIcon.MouseLeave += new System.EventHandler(this.ScheduleSidebar_MouseLeave);
            // 
            // pnlRequestsIcon
            // 
            this.pnlRequestsIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRequestsIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnlRequestsIcon.BackgroundImage = global::GC.Properties.Resources.icon_requests_40x40;
            this.pnlRequestsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlRequestsIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlRequestsIcon.Location = new System.Drawing.Point(0, 110);
            this.pnlRequestsIcon.Name = "pnlRequestsIcon";
            this.pnlRequestsIcon.Size = new System.Drawing.Size(50, 55);
            this.pnlRequestsIcon.TabIndex = 14;
            this.ttTabs.SetToolTip(this.pnlRequestsIcon, "Pedidos");
            this.pnlRequestsIcon.Click += new System.EventHandler(this.PnlOrdersTab_Click);
            this.pnlRequestsIcon.MouseEnter += new System.EventHandler(this.RequestsSidebar_MouseEnter);
            this.pnlRequestsIcon.MouseLeave += new System.EventHandler(this.RequestsSidebar_MouseLeave);
            // 
            // pnlCostumersIcon
            // 
            this.pnlCostumersIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCostumersIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnlCostumersIcon.BackgroundImage = global::GC.Properties.Resources.icon_costumers_40x40;
            this.pnlCostumersIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlCostumersIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlCostumersIcon.Location = new System.Drawing.Point(0, 220);
            this.pnlCostumersIcon.Name = "pnlCostumersIcon";
            this.pnlCostumersIcon.Size = new System.Drawing.Size(50, 55);
            this.pnlCostumersIcon.TabIndex = 20;
            this.ttTabs.SetToolTip(this.pnlCostumersIcon, "Clientes");
            this.pnlCostumersIcon.Click += new System.EventHandler(this.PnlCostumersTab_Click);
            this.pnlCostumersIcon.MouseEnter += new System.EventHandler(this.CostumersSidebar_MouseEnter);
            this.pnlCostumersIcon.MouseLeave += new System.EventHandler(this.CostumersSidebar_MouseLeave);
            // 
            // pnlProductsIcon
            // 
            this.pnlProductsIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProductsIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnlProductsIcon.BackgroundImage = global::GC.Properties.Resources.icon_prods_40x40;
            this.pnlProductsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlProductsIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlProductsIcon.Location = new System.Drawing.Point(0, 275);
            this.pnlProductsIcon.Name = "pnlProductsIcon";
            this.pnlProductsIcon.Size = new System.Drawing.Size(50, 55);
            this.pnlProductsIcon.TabIndex = 7;
            this.ttTabs.SetToolTip(this.pnlProductsIcon, "Produtos");
            this.pnlProductsIcon.Click += new System.EventHandler(this.pnlProductsTab_Click);
            this.pnlProductsIcon.MouseEnter += new System.EventHandler(this.ProductsSidebar_MouseEnter);
            this.pnlProductsIcon.MouseLeave += new System.EventHandler(this.ProductsSidebar_MouseLeave);
            // 
            // pnlJobsIcon
            // 
            this.pnlJobsIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlJobsIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnlJobsIcon.BackgroundImage = global::GC.Properties.Resources.icon_jobs_40x40;
            this.pnlJobsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlJobsIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlJobsIcon.Location = new System.Drawing.Point(0, 330);
            this.pnlJobsIcon.Name = "pnlJobsIcon";
            this.pnlJobsIcon.Size = new System.Drawing.Size(50, 55);
            this.pnlJobsIcon.TabIndex = 23;
            this.ttTabs.SetToolTip(this.pnlJobsIcon, "Serviços");
            this.pnlJobsIcon.Click += new System.EventHandler(this.PnlJobsTab_Click);
            this.pnlJobsIcon.MouseEnter += new System.EventHandler(this.JobsSidebar_MouseEnter);
            this.pnlJobsIcon.MouseLeave += new System.EventHandler(this.JobsSidebar_MouseLeave);
            // 
            // pnlSuppliersIcon
            // 
            this.pnlSuppliersIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSuppliersIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnlSuppliersIcon.BackgroundImage = global::GC.Properties.Resources.icon_home_40x40;
            this.pnlSuppliersIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlSuppliersIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlSuppliersIcon.Location = new System.Drawing.Point(0, 385);
            this.pnlSuppliersIcon.Name = "pnlSuppliersIcon";
            this.pnlSuppliersIcon.Size = new System.Drawing.Size(50, 55);
            this.pnlSuppliersIcon.TabIndex = 11;
            this.ttTabs.SetToolTip(this.pnlSuppliersIcon, "Fornecedores");
            this.pnlSuppliersIcon.Click += new System.EventHandler(this.pnlSuppliersTab_Click);
            this.pnlSuppliersIcon.MouseEnter += new System.EventHandler(this.SuppliersSidebar_MouseEnter);
            this.pnlSuppliersIcon.MouseLeave += new System.EventHandler(this.SuppliersSidebar_MouseLeave);
            // 
            // pnlStatsIcon
            // 
            this.pnlStatsIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatsIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatsIcon.BackgroundImage = global::GC.Properties.Resources.icon_stats_40x40;
            this.pnlStatsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlStatsIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlStatsIcon.Location = new System.Drawing.Point(0, 440);
            this.pnlStatsIcon.Name = "pnlStatsIcon";
            this.pnlStatsIcon.Size = new System.Drawing.Size(50, 55);
            this.pnlStatsIcon.TabIndex = 1;
            this.ttTabs.SetToolTip(this.pnlStatsIcon, "Estatísticas");
            this.pnlStatsIcon.Click += new System.EventHandler(this.PnlStatsTab_Click);
            this.pnlStatsIcon.MouseEnter += new System.EventHandler(this.StatsSidebar_MouseEnter);
            this.pnlStatsIcon.MouseLeave += new System.EventHandler(this.StatsSidebar_MouseLeave);
            // 
            // pnlConfigIcon
            // 
            this.pnlConfigIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConfigIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnlConfigIcon.BackgroundImage = global::GC.Properties.Resources.icon_config_40x40;
            this.pnlConfigIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlConfigIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlConfigIcon.Location = new System.Drawing.Point(0, 495);
            this.pnlConfigIcon.Name = "pnlConfigIcon";
            this.pnlConfigIcon.Size = new System.Drawing.Size(50, 55);
            this.pnlConfigIcon.TabIndex = 1;
            this.ttTabs.SetToolTip(this.pnlConfigIcon, "Configurações");
            this.pnlConfigIcon.Click += new System.EventHandler(this.PnlConfigIcon_Click);
            this.pnlConfigIcon.MouseEnter += new System.EventHandler(this.ConfigSidebar_MouseEnter);
            this.pnlConfigIcon.MouseLeave += new System.EventHandler(this.ConfigSidebar_MouseLeave);
            // 
            // lblNewMessage
            // 
            this.lblNewMessage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNewMessage.AutoSize = true;
            this.lblNewMessage.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewMessage.ForeColor = System.Drawing.Color.Gold;
            this.lblNewMessage.Location = new System.Drawing.Point(83, 272);
            this.lblNewMessage.Name = "lblNewMessage";
            this.lblNewMessage.Size = new System.Drawing.Size(91, 14);
            this.lblNewMessage.TabIndex = 10;
            this.lblNewMessage.Text = "MENSAGENS";
            // 
            // pnlNewMessage
            // 
            this.pnlNewMessage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlNewMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnlNewMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlNewMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlNewMessage.Location = new System.Drawing.Point(98, 289);
            this.pnlNewMessage.Name = "pnlNewMessage";
            this.pnlNewMessage.Size = new System.Drawing.Size(58, 50);
            this.pnlNewMessage.TabIndex = 8;
            // 
            // ttTabs
            // 
            this.ttTabs.AutoPopDelay = 8000;
            this.ttTabs.InitialDelay = 100;
            this.ttTabs.ReshowDelay = 100;
            // 
            // PNL_OpenDocuments
            // 
            this.PNL_OpenDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_OpenDocuments.BackgroundImage = global::GC.Properties.Resources.icon_folder_38_26;
            this.PNL_OpenDocuments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PNL_OpenDocuments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PNL_OpenDocuments.Location = new System.Drawing.Point(742, 0);
            this.PNL_OpenDocuments.Name = "PNL_OpenDocuments";
            this.PNL_OpenDocuments.Size = new System.Drawing.Size(40, 30);
            this.PNL_OpenDocuments.TabIndex = 46;
            this.ttTabs.SetToolTip(this.PNL_OpenDocuments, "Abrir pasta Documentos, local onde ficam salvos os PDFs.");
            this.PNL_OpenDocuments.Click += new System.EventHandler(this.PNL_OpenDocuments_Click);
            // 
            // lblTestPeriod
            // 
            this.lblTestPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTestPeriod.AutoSize = true;
            this.lblTestPeriod.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTestPeriod.Location = new System.Drawing.Point(458, 8);
            this.lblTestPeriod.Name = "lblTestPeriod";
            this.lblTestPeriod.Size = new System.Drawing.Size(45, 14);
            this.lblTestPeriod.TabIndex = 17;
            this.lblTestPeriod.Text = "label1";
            this.lblTestPeriod.Visible = false;
            // 
            // pnlAdminMessagesBack
            // 
            this.pnlAdminMessagesBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdminMessagesBack.BackgroundImage = global::GC.Properties.Resources.icon_message_30x30;
            this.pnlAdminMessagesBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlAdminMessagesBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAdminMessagesBack.Location = new System.Drawing.Point(800, 0);
            this.pnlAdminMessagesBack.Name = "pnlAdminMessagesBack";
            this.pnlAdminMessagesBack.Size = new System.Drawing.Size(40, 30);
            this.pnlAdminMessagesBack.TabIndex = 18;
            this.pnlAdminMessagesBack.Click += new System.EventHandler(this.pnlAdminMessagesBack_Click);
            // 
            // uscHome1
            // 
            this.uscHome1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscHome1.AutoScroll = true;
            this.uscHome1.BackColor = System.Drawing.SystemColors.Control;
            this.uscHome1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscHome1.Location = new System.Drawing.Point(50, 30);
            this.uscHome1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.uscHome1.Name = "uscHome1";
            this.uscHome1.Size = new System.Drawing.Size(948, 618);
            this.uscHome1.TabIndex = 19;
            // 
            // uscStats1
            // 
            this.uscStats1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscStats1.AutoScroll = true;
            this.uscStats1.BackColor = System.Drawing.SystemColors.Control;
            this.uscStats1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscStats1.Location = new System.Drawing.Point(50, 30);
            this.uscStats1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uscStats1.Name = "uscStats1";
            this.uscStats1.Size = new System.Drawing.Size(948, 618);
            this.uscStats1.TabIndex = 13;
            // 
            // uscConfiguration1
            // 
            this.uscConfiguration1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscConfiguration1.AutoScroll = true;
            this.uscConfiguration1.BackColor = System.Drawing.SystemColors.Control;
            this.uscConfiguration1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscConfiguration1.Location = new System.Drawing.Point(50, 30);
            this.uscConfiguration1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uscConfiguration1.Name = "uscConfiguration1";
            this.uscConfiguration1.Size = new System.Drawing.Size(948, 618);
            this.uscConfiguration1.TabIndex = 12;
            // 
            // uscJobs1
            // 
            this.uscJobs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscJobs1.BackColor = System.Drawing.SystemColors.Control;
            this.uscJobs1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscJobs1.Location = new System.Drawing.Point(50, 30);
            this.uscJobs1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uscJobs1.Name = "uscJobs1";
            this.uscJobs1.Size = new System.Drawing.Size(948, 618);
            this.uscJobs1.TabIndex = 6;
            // 
            // uscProducts1
            // 
            this.uscProducts1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscProducts1.BackColor = System.Drawing.SystemColors.Control;
            this.uscProducts1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscProducts1.Location = new System.Drawing.Point(50, 30);
            this.uscProducts1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uscProducts1.Name = "uscProducts1";
            this.uscProducts1.Size = new System.Drawing.Size(948, 618);
            this.uscProducts1.TabIndex = 7;
            // 
            // uscSuppliers1
            // 
            this.uscSuppliers1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscSuppliers1.BackColor = System.Drawing.SystemColors.Control;
            this.uscSuppliers1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscSuppliers1.Location = new System.Drawing.Point(50, 30);
            this.uscSuppliers1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uscSuppliers1.Name = "uscSuppliers1";
            this.uscSuppliers1.Size = new System.Drawing.Size(948, 618);
            this.uscSuppliers1.TabIndex = 8;
            // 
            // uscRequests1
            // 
            this.uscRequests1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscRequests1.BackColor = System.Drawing.SystemColors.Control;
            this.uscRequests1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscRequests1.Location = new System.Drawing.Point(50, 30);
            this.uscRequests1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uscRequests1.Name = "uscRequests1";
            this.uscRequests1.Size = new System.Drawing.Size(948, 618);
            this.uscRequests1.TabIndex = 9;
            // 
            // uscCostumers1
            // 
            this.uscCostumers1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscCostumers1.BackColor = System.Drawing.SystemColors.Control;
            this.uscCostumers1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscCostumers1.Location = new System.Drawing.Point(50, 30);
            this.uscCostumers1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uscCostumers1.Name = "uscCostumers1";
            this.uscCostumers1.Size = new System.Drawing.Size(948, 618);
            this.uscCostumers1.TabIndex = 4;
            // 
            // uscWarranties1
            // 
            this.uscWarranties1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscWarranties1.BackColor = System.Drawing.SystemColors.Control;
            this.uscWarranties1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscWarranties1.Location = new System.Drawing.Point(50, 30);
            this.uscWarranties1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uscWarranties1.Name = "uscWarranties1";
            this.uscWarranties1.Size = new System.Drawing.Size(948, 618);
            this.uscWarranties1.TabIndex = 45;
            // 
            // uscSchedule1
            // 
            this.uscSchedule1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscSchedule1.BackColor = System.Drawing.SystemColors.Control;
            this.uscSchedule1.Font = new System.Drawing.Font("Verdana", 9F);
            this.uscSchedule1.Location = new System.Drawing.Point(50, 30);
            this.uscSchedule1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.uscSchedule1.Name = "uscSchedule1";
            this.uscSchedule1.Size = new System.Drawing.Size(948, 618);
            this.uscSchedule1.TabIndex = 47;
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.uscSchedule1);
            this.Controls.Add(this.PNL_OpenDocuments);
            this.Controls.Add(this.uscWarranties1);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.uscHome1);
            this.Controls.Add(this.pnlAdminMessagesBack);
            this.Controls.Add(this.lblTestPeriod);
            this.Controls.Add(this.uscStats1);
            this.Controls.Add(this.uscConfiguration1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.uscJobs1);
            this.Controls.Add(this.uscProducts1);
            this.Controls.Add(this.uscSuppliers1);
            this.Controls.Add(this.uscRequests1);
            this.Controls.Add(this.uscCostumers1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "FRM_Main";
            this.Text = "GC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogisticMainForm_FormClosing);
            this.Shown += new System.EventHandler(this.FrmMainForm_Shown);
            this.Controls.SetChildIndex(this.uscCostumers1, 0);
            this.Controls.SetChildIndex(this.uscRequests1, 0);
            this.Controls.SetChildIndex(this.uscSuppliers1, 0);
            this.Controls.SetChildIndex(this.uscProducts1, 0);
            this.Controls.SetChildIndex(this.uscJobs1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.uscConfiguration1, 0);
            this.Controls.SetChildIndex(this.uscStats1, 0);
            this.Controls.SetChildIndex(this.lblTestPeriod, 0);
            this.Controls.SetChildIndex(this.pnlAdminMessagesBack, 0);
            this.Controls.SetChildIndex(this.uscHome1, 0);
            this.Controls.SetChildIndex(this.pnlSidebar, 0);
            this.Controls.SetChildIndex(this.uscWarranties1, 0);
            this.Controls.SetChildIndex(this.PNL_OpenDocuments, 0);
            this.Controls.SetChildIndex(this.uscSchedule1, 0);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlJobsIcon;
        private System.Windows.Forms.Panel pnlCostumersIcon;
        private System.Windows.Forms.Panel pnlRequestsIcon;
        private System.Windows.Forms.Panel pnlSuppliersIcon;
        private System.Windows.Forms.Label lblNewMessage;
        private System.Windows.Forms.Panel pnlNewMessage;
        private System.Windows.Forms.Panel pnlProductsIcon;
        private Controls.USC_Costumers uscCostumers1;
        private Controls.USC_Jobs uscJobs1;
        private Controls.USC_Products uscProducts1;
        private Controls.USC_Suppliers uscSuppliers1;
        private Controls.USC_Requests uscRequests1;
        private System.Windows.Forms.Panel pnlScheduleIcon;
        private System.Windows.Forms.ToolTip ttTabs;
        private System.Windows.Forms.Panel pnlStatsIcon;
        private System.Windows.Forms.Panel pnlConfigIcon;
        private Controls.USC_Configuration uscConfiguration1;
        private Controls.USC_Stats uscStats1;
        private System.Windows.Forms.Label lblTestPeriod;
        private System.Windows.Forms.Panel pnlHomeIcon;
        private System.Windows.Forms.Panel pnlAdminMessagesBack;
        private Controls.USC_Home uscHome1;
        private System.Windows.Forms.Panel pnlWarrantiesIcon;
        private Controls.USC_Warranties uscWarranties1;
        private System.Windows.Forms.Panel PNL_OpenDocuments;
        private Controls.USC_Schedule uscSchedule1;
    }
}