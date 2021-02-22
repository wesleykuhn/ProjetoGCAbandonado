namespace GC.Forms.Main.Modals.Warranties
{
    partial class FRM_NewWarranty
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
            this.PNL_Background1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_SelectedItem = new System.Windows.Forms.Label();
            this.LBL_WarrantyNumber = new System.Windows.Forms.Label();
            this.btnNextPage = new GC.Components.CMP_BtnRegular();
            this.btnSearchOptions = new GC.Components.CMP_BtnRegular();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RBT_Job = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.RBT_Product = new System.Windows.Forms.RadioButton();
            this.lvlProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlJobs = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PNL_Background2 = new System.Windows.Forms.Panel();
            this.pnlObsBack = new System.Windows.Forms.Panel();
            this.rtbObservations = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreate = new GC.Components.CMP_BtnAdd();
            this.PNL_ExpirationBack = new System.Windows.Forms.Panel();
            this.LBL_TotalDuration = new System.Windows.Forms.Label();
            this.BTN_M_Year = new GC.Components.CMP_BtnRegular();
            this.BTN_M_3Month = new GC.Components.CMP_BtnRegular();
            this.BTN_M_Month = new GC.Components.CMP_BtnRegular();
            this.BTN_M_Day = new GC.Components.CMP_BtnRegular();
            this.BTN_P_Year = new GC.Components.CMP_BtnRegular();
            this.BTN_P_3Month = new GC.Components.CMP_BtnRegular();
            this.BTN_P_Month = new GC.Components.CMP_BtnRegular();
            this.BTN_P_Day = new GC.Components.CMP_BtnRegular();
            this.dtpExpiration = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrevious = new GC.Components.CMP_BtnRegular();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlCostumerIcon = new System.Windows.Forms.Panel();
            this.btnChangeCostumer = new GC.Components.CMP_BtnRegular();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCostumerAddress = new System.Windows.Forms.Label();
            this.lblCostumerName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblConstCost = new System.Windows.Forms.Label();
            this.PNL_Background1.SuspendLayout();
            this.PNL_Background2.SuspendLayout();
            this.pnlObsBack.SuspendLayout();
            this.PNL_ExpirationBack.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Background1
            // 
            this.PNL_Background1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Background1.BackColor = System.Drawing.SystemColors.Control;
            this.PNL_Background1.Controls.Add(this.label4);
            this.PNL_Background1.Controls.Add(this.LBL_SelectedItem);
            this.PNL_Background1.Controls.Add(this.LBL_WarrantyNumber);
            this.PNL_Background1.Controls.Add(this.btnNextPage);
            this.PNL_Background1.Controls.Add(this.btnSearchOptions);
            this.PNL_Background1.Controls.Add(this.txtSearch);
            this.PNL_Background1.Controls.Add(this.label2);
            this.PNL_Background1.Controls.Add(this.RBT_Job);
            this.PNL_Background1.Controls.Add(this.label1);
            this.PNL_Background1.Controls.Add(this.RBT_Product);
            this.PNL_Background1.Controls.Add(this.lvlProducts);
            this.PNL_Background1.Controls.Add(this.lvlJobs);
            this.PNL_Background1.Location = new System.Drawing.Point(2, 30);
            this.PNL_Background1.Name = "PNL_Background1";
            this.PNL_Background1.Size = new System.Drawing.Size(907, 521);
            this.PNL_Background1.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "(Precione Enter para realizar a pesquisa)";
            // 
            // LBL_SelectedItem
            // 
            this.LBL_SelectedItem.AutoSize = true;
            this.LBL_SelectedItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBL_SelectedItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(106)))), ((int)(((byte)(102)))));
            this.LBL_SelectedItem.Location = new System.Drawing.Point(8, 482);
            this.LBL_SelectedItem.Name = "LBL_SelectedItem";
            this.LBL_SelectedItem.Size = new System.Drawing.Size(202, 16);
            this.LBL_SelectedItem.TabIndex = 36;
            this.LBL_SelectedItem.Text = "Nenhum item selecionado!";
            // 
            // LBL_WarrantyNumber
            // 
            this.LBL_WarrantyNumber.AutoSize = true;
            this.LBL_WarrantyNumber.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_WarrantyNumber.Location = new System.Drawing.Point(8, 5);
            this.LBL_WarrantyNumber.Name = "LBL_WarrantyNumber";
            this.LBL_WarrantyNumber.Size = new System.Drawing.Size(187, 25);
            this.LBL_WarrantyNumber.TabIndex = 35;
            this.LBL_WarrantyNumber.Text = "Nº da Garantia: ";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnNextPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnNextPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnNextPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnNextPage.Location = new System.Drawing.Point(774, 471);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(122, 40);
            this.btnNextPage.TabIndex = 34;
            this.btnNextPage.Text = "Avançar >>";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnSearchOptions
            // 
            this.btnSearchOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchOptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnSearchOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnSearchOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnSearchOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchOptions.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnSearchOptions.Location = new System.Drawing.Point(815, 46);
            this.btnSearchOptions.Name = "btnSearchOptions";
            this.btnSearchOptions.Size = new System.Drawing.Size(81, 23);
            this.btnSearchOptions.TabIndex = 32;
            this.btnSearchOptions.Text = "Opções";
            this.btnSearchOptions.UseVisualStyleBackColor = true;
            this.btnSearchOptions.Click += new System.EventHandler(this.btnSearchOptions_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(559, 47);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 22);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 31;
            this.label2.Text = "Pesquisar:";
            // 
            // RBT_Job
            // 
            this.RBT_Job.AutoSize = true;
            this.RBT_Job.Location = new System.Drawing.Point(135, 49);
            this.RBT_Job.Name = "RBT_Job";
            this.RBT_Job.Size = new System.Drawing.Size(70, 18);
            this.RBT_Job.TabIndex = 2;
            this.RBT_Job.Text = "Serviço";
            this.RBT_Job.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo:";
            // 
            // RBT_Product
            // 
            this.RBT_Product.AutoSize = true;
            this.RBT_Product.Checked = true;
            this.RBT_Product.Location = new System.Drawing.Point(54, 49);
            this.RBT_Product.Name = "RBT_Product";
            this.RBT_Product.Size = new System.Drawing.Size(75, 18);
            this.RBT_Product.TabIndex = 0;
            this.RBT_Product.TabStop = true;
            this.RBT_Product.Text = "Produto";
            this.RBT_Product.UseVisualStyleBackColor = true;
            this.RBT_Product.CheckedChanged += new System.EventHandler(this.RBT_Product_CheckedChanged);
            // 
            // lvlProducts
            // 
            this.lvlProducts.AllowColumnReorder = true;
            this.lvlProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.lvlProducts.FullRowSelect = true;
            this.lvlProducts.GridLines = true;
            this.lvlProducts.HideSelection = false;
            this.lvlProducts.Location = new System.Drawing.Point(11, 73);
            this.lvlProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvlProducts.MultiSelect = false;
            this.lvlProducts.Name = "lvlProducts";
            this.lvlProducts.Size = new System.Drawing.Size(885, 386);
            this.lvlProducts.TabIndex = 1;
            this.lvlProducts.UseCompatibleStateImageBehavior = false;
            this.lvlProducts.View = System.Windows.Forms.View.Details;
            this.lvlProducts.SelectedIndexChanged += new System.EventHandler(this.lvlProducts_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Preço (R$)";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Posição/Localização";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Peso (kg)";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fornecedor";
            this.columnHeader7.Width = 140;
            // 
            // lvlJobs
            // 
            this.lvlJobs.AllowColumnReorder = true;
            this.lvlJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlJobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvlJobs.FullRowSelect = true;
            this.lvlJobs.GridLines = true;
            this.lvlJobs.HideSelection = false;
            this.lvlJobs.Location = new System.Drawing.Point(11, 73);
            this.lvlJobs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvlJobs.MultiSelect = false;
            this.lvlJobs.Name = "lvlJobs";
            this.lvlJobs.Size = new System.Drawing.Size(885, 386);
            this.lvlJobs.TabIndex = 33;
            this.lvlJobs.UseCompatibleStateImageBehavior = false;
            this.lvlJobs.View = System.Windows.Forms.View.Details;
            this.lvlJobs.SelectedIndexChanged += new System.EventHandler(this.lvlJobs_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nome";
            this.columnHeader9.Width = 250;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Descrição";
            this.columnHeader10.Width = 360;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Valor";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 150;
            // 
            // PNL_Background2
            // 
            this.PNL_Background2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Background2.BackColor = System.Drawing.SystemColors.Control;
            this.PNL_Background2.Controls.Add(this.pnlObsBack);
            this.PNL_Background2.Controls.Add(this.btnCreate);
            this.PNL_Background2.Controls.Add(this.PNL_ExpirationBack);
            this.PNL_Background2.Controls.Add(this.btnPrevious);
            this.PNL_Background2.Controls.Add(this.panel2);
            this.PNL_Background2.Location = new System.Drawing.Point(2, 63);
            this.PNL_Background2.Name = "PNL_Background2";
            this.PNL_Background2.Size = new System.Drawing.Size(907, 488);
            this.PNL_Background2.TabIndex = 35;
            // 
            // pnlObsBack
            // 
            this.pnlObsBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlObsBack.BackColor = System.Drawing.SystemColors.Control;
            this.pnlObsBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlObsBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlObsBack.Controls.Add(this.rtbObservations);
            this.pnlObsBack.Controls.Add(this.label6);
            this.pnlObsBack.Location = new System.Drawing.Point(14, 254);
            this.pnlObsBack.Name = "pnlObsBack";
            this.pnlObsBack.Size = new System.Drawing.Size(884, 159);
            this.pnlObsBack.TabIndex = 92;
            // 
            // rtbObservations
            // 
            this.rtbObservations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbObservations.DetectUrls = false;
            this.rtbObservations.Location = new System.Drawing.Point(11, 27);
            this.rtbObservations.MaxLength = 255;
            this.rtbObservations.Name = "rtbObservations";
            this.rtbObservations.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbObservations.ShortcutsEnabled = false;
            this.rtbObservations.Size = new System.Drawing.Size(858, 117);
            this.rtbObservations.TabIndex = 1;
            this.rtbObservations.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Observações (Opcional):";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(91)))));
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnCreate.Image = global::GC.Properties.Resources.icon_mais_30x30;
            this.btnCreate.Location = new System.Drawing.Point(753, 419);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(144, 59);
            this.btnCreate.TabIndex = 91;
            this.btnCreate.Text = "Concluído";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // PNL_ExpirationBack
            // 
            this.PNL_ExpirationBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_ExpirationBack.Controls.Add(this.LBL_TotalDuration);
            this.PNL_ExpirationBack.Controls.Add(this.BTN_M_Year);
            this.PNL_ExpirationBack.Controls.Add(this.BTN_M_3Month);
            this.PNL_ExpirationBack.Controls.Add(this.BTN_M_Month);
            this.PNL_ExpirationBack.Controls.Add(this.BTN_M_Day);
            this.PNL_ExpirationBack.Controls.Add(this.BTN_P_Year);
            this.PNL_ExpirationBack.Controls.Add(this.BTN_P_3Month);
            this.PNL_ExpirationBack.Controls.Add(this.BTN_P_Month);
            this.PNL_ExpirationBack.Controls.Add(this.BTN_P_Day);
            this.PNL_ExpirationBack.Controls.Add(this.dtpExpiration);
            this.PNL_ExpirationBack.Controls.Add(this.panel3);
            this.PNL_ExpirationBack.Location = new System.Drawing.Point(14, 8);
            this.PNL_ExpirationBack.Name = "PNL_ExpirationBack";
            this.PNL_ExpirationBack.Size = new System.Drawing.Size(370, 240);
            this.PNL_ExpirationBack.TabIndex = 90;
            // 
            // LBL_TotalDuration
            // 
            this.LBL_TotalDuration.AutoSize = true;
            this.LBL_TotalDuration.Location = new System.Drawing.Point(103, 195);
            this.LBL_TotalDuration.Name = "LBL_TotalDuration";
            this.LBL_TotalDuration.Size = new System.Drawing.Size(162, 14);
            this.LBL_TotalDuration.TabIndex = 19;
            this.LBL_TotalDuration.Text = "Duração Total: 36 Meses";
            // 
            // BTN_M_Year
            // 
            this.BTN_M_Year.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_M_Year.BackColor = System.Drawing.Color.Salmon;
            this.BTN_M_Year.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_M_Year.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.BTN_M_Year.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_M_Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_M_Year.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_M_Year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_M_Year.Location = new System.Drawing.Point(275, 132);
            this.BTN_M_Year.Name = "BTN_M_Year";
            this.BTN_M_Year.Size = new System.Drawing.Size(82, 32);
            this.BTN_M_Year.TabIndex = 18;
            this.BTN_M_Year.Text = "-1 Ano";
            this.BTN_M_Year.UseVisualStyleBackColor = false;
            this.BTN_M_Year.Click += new System.EventHandler(this.BTN_M_Year_Click);
            // 
            // BTN_M_3Month
            // 
            this.BTN_M_3Month.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_M_3Month.BackColor = System.Drawing.Color.Salmon;
            this.BTN_M_3Month.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_M_3Month.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.BTN_M_3Month.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_M_3Month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_M_3Month.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_M_3Month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_M_3Month.Location = new System.Drawing.Point(187, 132);
            this.BTN_M_3Month.Name = "BTN_M_3Month";
            this.BTN_M_3Month.Size = new System.Drawing.Size(82, 32);
            this.BTN_M_3Month.TabIndex = 17;
            this.BTN_M_3Month.Text = "-3 Meses";
            this.BTN_M_3Month.UseVisualStyleBackColor = false;
            this.BTN_M_3Month.Click += new System.EventHandler(this.BTN_M_3Month_Click);
            // 
            // BTN_M_Month
            // 
            this.BTN_M_Month.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_M_Month.BackColor = System.Drawing.Color.Salmon;
            this.BTN_M_Month.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_M_Month.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.BTN_M_Month.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_M_Month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_M_Month.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_M_Month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_M_Month.Location = new System.Drawing.Point(99, 132);
            this.BTN_M_Month.Name = "BTN_M_Month";
            this.BTN_M_Month.Size = new System.Drawing.Size(82, 32);
            this.BTN_M_Month.TabIndex = 16;
            this.BTN_M_Month.Text = "-1 Mês";
            this.BTN_M_Month.UseVisualStyleBackColor = false;
            this.BTN_M_Month.Click += new System.EventHandler(this.BTN_M_Month_Click);
            // 
            // BTN_M_Day
            // 
            this.BTN_M_Day.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_M_Day.BackColor = System.Drawing.Color.Salmon;
            this.BTN_M_Day.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_M_Day.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.BTN_M_Day.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_M_Day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_M_Day.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_M_Day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_M_Day.Location = new System.Drawing.Point(11, 132);
            this.BTN_M_Day.Name = "BTN_M_Day";
            this.BTN_M_Day.Size = new System.Drawing.Size(82, 32);
            this.BTN_M_Day.TabIndex = 15;
            this.BTN_M_Day.Text = "-1 Dia";
            this.BTN_M_Day.UseVisualStyleBackColor = false;
            this.BTN_M_Day.Click += new System.EventHandler(this.BTN_M_Day_Click);
            // 
            // BTN_P_Year
            // 
            this.BTN_P_Year.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_P_Year.BackColor = System.Drawing.Color.SpringGreen;
            this.BTN_P_Year.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_P_Year.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.BTN_P_Year.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_P_Year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_P_Year.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_P_Year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_P_Year.Location = new System.Drawing.Point(275, 77);
            this.BTN_P_Year.Name = "BTN_P_Year";
            this.BTN_P_Year.Size = new System.Drawing.Size(82, 32);
            this.BTN_P_Year.TabIndex = 14;
            this.BTN_P_Year.Text = "+1 Ano";
            this.BTN_P_Year.UseVisualStyleBackColor = false;
            this.BTN_P_Year.Click += new System.EventHandler(this.BTN_P_Year_Click);
            // 
            // BTN_P_3Month
            // 
            this.BTN_P_3Month.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_P_3Month.BackColor = System.Drawing.Color.SpringGreen;
            this.BTN_P_3Month.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_P_3Month.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.BTN_P_3Month.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_P_3Month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_P_3Month.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_P_3Month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_P_3Month.Location = new System.Drawing.Point(187, 77);
            this.BTN_P_3Month.Name = "BTN_P_3Month";
            this.BTN_P_3Month.Size = new System.Drawing.Size(82, 32);
            this.BTN_P_3Month.TabIndex = 13;
            this.BTN_P_3Month.Text = "+3 Meses";
            this.BTN_P_3Month.UseVisualStyleBackColor = false;
            this.BTN_P_3Month.Click += new System.EventHandler(this.BTN_P_3Month_Click);
            // 
            // BTN_P_Month
            // 
            this.BTN_P_Month.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_P_Month.BackColor = System.Drawing.Color.SpringGreen;
            this.BTN_P_Month.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_P_Month.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.BTN_P_Month.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_P_Month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_P_Month.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_P_Month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_P_Month.Location = new System.Drawing.Point(99, 77);
            this.BTN_P_Month.Name = "BTN_P_Month";
            this.BTN_P_Month.Size = new System.Drawing.Size(82, 32);
            this.BTN_P_Month.TabIndex = 12;
            this.BTN_P_Month.Text = "+1 Mês";
            this.BTN_P_Month.UseVisualStyleBackColor = false;
            this.BTN_P_Month.Click += new System.EventHandler(this.BTN_P_Month_Click);
            // 
            // BTN_P_Day
            // 
            this.BTN_P_Day.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_P_Day.BackColor = System.Drawing.Color.SpringGreen;
            this.BTN_P_Day.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_P_Day.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.BTN_P_Day.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_P_Day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_P_Day.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_P_Day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTN_P_Day.Location = new System.Drawing.Point(11, 77);
            this.BTN_P_Day.Name = "BTN_P_Day";
            this.BTN_P_Day.Size = new System.Drawing.Size(82, 32);
            this.BTN_P_Day.TabIndex = 11;
            this.BTN_P_Day.Text = "+1 Dia";
            this.BTN_P_Day.UseVisualStyleBackColor = false;
            this.BTN_P_Day.Click += new System.EventHandler(this.BTN_P_Day_Click);
            // 
            // dtpExpiration
            // 
            this.dtpExpiration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpExpiration.CustomFormat = "dddd, dd MMMM yyyy HH:mm:ss";
            this.dtpExpiration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiration.Location = new System.Drawing.Point(11, 45);
            this.dtpExpiration.Name = "dtpExpiration";
            this.dtpExpiration.Size = new System.Drawing.Size(346, 22);
            this.dtpExpiration.TabIndex = 10;
            this.dtpExpiration.ValueChanged += new System.EventHandler(this.dtpExpiration_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 30);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(142, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "VÁLIDA ATÉ";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnPrevious.Location = new System.Drawing.Point(14, 438);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(105, 40);
            this.btnPrevious.TabIndex = 89;
            this.btnPrevious.Text = "<< Voltar";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pnlCostumerIcon);
            this.panel2.Controls.Add(this.btnChangeCostumer);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.lblCostumerName);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(494, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 240);
            this.panel2.TabIndex = 35;
            // 
            // pnlCostumerIcon
            // 
            this.pnlCostumerIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnlCostumerIcon.BackgroundImage = global::GC.Properties.Resources.icon_mais_30x30;
            this.pnlCostumerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlCostumerIcon.Location = new System.Drawing.Point(6, 36);
            this.pnlCostumerIcon.Name = "pnlCostumerIcon";
            this.pnlCostumerIcon.Size = new System.Drawing.Size(90, 90);
            this.pnlCostumerIcon.TabIndex = 18;
            // 
            // btnChangeCostumer
            // 
            this.btnChangeCostumer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChangeCostumer.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeCostumer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnChangeCostumer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnChangeCostumer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnChangeCostumer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeCostumer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeCostumer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnChangeCostumer.Location = new System.Drawing.Point(123, 190);
            this.btnChangeCostumer.Name = "btnChangeCostumer";
            this.btnChangeCostumer.Size = new System.Drawing.Size(155, 37);
            this.btnChangeCostumer.TabIndex = 44;
            this.btnChangeCostumer.Text = "Selecionar Cliente";
            this.btnChangeCostumer.UseVisualStyleBackColor = false;
            this.btnChangeCostumer.Click += new System.EventHandler(this.btnChangeCostumer_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.lblCostumerAddress);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(104, 56);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 70);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // lblCostumerAddress
            // 
            this.lblCostumerAddress.AutoSize = true;
            this.lblCostumerAddress.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostumerAddress.Location = new System.Drawing.Point(3, 0);
            this.lblCostumerAddress.Name = "lblCostumerAddress";
            this.lblCostumerAddress.Size = new System.Drawing.Size(59, 14);
            this.lblCostumerAddress.TabIndex = 10;
            this.lblCostumerAddress.Text = "Nenhum";
            // 
            // lblCostumerName
            // 
            this.lblCostumerName.AutoSize = true;
            this.lblCostumerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCostumerName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCostumerName.Location = new System.Drawing.Point(107, 36);
            this.lblCostumerName.Name = "lblCostumerName";
            this.lblCostumerName.Size = new System.Drawing.Size(173, 16);
            this.lblCostumerName.TabIndex = 9;
            this.lblCostumerName.Text = "Selecione um cliente...";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel5.Controls.Add(this.lblConstCost);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(403, 30);
            this.panel5.TabIndex = 7;
            // 
            // lblConstCost
            // 
            this.lblConstCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConstCost.AutoSize = true;
            this.lblConstCost.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConstCost.ForeColor = System.Drawing.Color.White;
            this.lblConstCost.Location = new System.Drawing.Point(169, 8);
            this.lblConstCost.Name = "lblConstCost";
            this.lblConstCost.Size = new System.Drawing.Size(64, 14);
            this.lblConstCost.TabIndex = 3;
            this.lblConstCost.Text = "CLIENTE";
            // 
            // FRM_NewWarranty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 553);
            this.Controls.Add(this.PNL_Background1);
            this.Controls.Add(this.PNL_Background2);
            this.Name = "FRM_NewWarranty";
            this.Text = "GC - Garantias > Adicionar Garantia";
            this.Controls.SetChildIndex(this.PNL_Background2, 0);
            this.Controls.SetChildIndex(this.PNL_Background1, 0);
            this.PNL_Background1.ResumeLayout(false);
            this.PNL_Background1.PerformLayout();
            this.PNL_Background2.ResumeLayout(false);
            this.pnlObsBack.ResumeLayout(false);
            this.pnlObsBack.PerformLayout();
            this.PNL_ExpirationBack.ResumeLayout(false);
            this.PNL_ExpirationBack.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Background1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBT_Product;
        private System.Windows.Forms.RadioButton RBT_Job;
        private System.Windows.Forms.ListView lvlProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private GC.Components.CMP_BtnRegular btnSearchOptions;
        private System.Windows.Forms.ListView lvlJobs;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Panel PNL_Background2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlCostumerIcon;
        private GC.Components.CMP_BtnRegular btnChangeCostumer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblCostumerAddress;
        private System.Windows.Forms.Label lblCostumerName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblConstCost;
        private GC.Components.CMP_BtnRegular btnNextPage;
        private GC.Components.CMP_BtnRegular btnPrevious;
        private System.Windows.Forms.Label LBL_WarrantyNumber;
        private System.Windows.Forms.Panel PNL_ExpirationBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_TotalDuration;
        private GC.Components.CMP_BtnRegular BTN_M_Year;
        private GC.Components.CMP_BtnRegular BTN_M_3Month;
        private GC.Components.CMP_BtnRegular BTN_M_Month;
        private GC.Components.CMP_BtnRegular BTN_M_Day;
        private GC.Components.CMP_BtnRegular BTN_P_Year;
        private GC.Components.CMP_BtnRegular BTN_P_3Month;
        private GC.Components.CMP_BtnRegular BTN_P_Month;
        private GC.Components.CMP_BtnRegular BTN_P_Day;
        private System.Windows.Forms.DateTimePicker dtpExpiration;
        private GC.Components.CMP_BtnAdd btnCreate;
        private System.Windows.Forms.Label LBL_SelectedItem;
        private System.Windows.Forms.Panel pnlObsBack;
        private System.Windows.Forms.RichTextBox rtbObservations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}