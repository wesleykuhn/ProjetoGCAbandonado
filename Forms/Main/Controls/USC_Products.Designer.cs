namespace GC.Forms.Main.Controls
{
    partial class USC_Products
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProductsCount = new System.Windows.Forms.Label();
            this.lvlProducts = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new GC.Components.CMP_BtnAdd();
            this.btnCriticalStock = new GC.Components.CMP_BtnRegular();
            this.btnExpiration = new GC.Components.CMP_BtnRegular();
            this.btnProductStock = new GC.Components.CMP_BtnRegular();
            this.btnAlter = new GC.Components.CMP_BtnAlter();
            this.btnDelete = new GC.Components.CMP_BtnDelete();
            this.btnSearchOptions = new GC.Components.CMP_BtnRegular();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProductsCount
            // 
            this.lblProductsCount.AutoSize = true;
            this.lblProductsCount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsCount.Location = new System.Drawing.Point(4, 10);
            this.lblProductsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductsCount.Name = "lblProductsCount";
            this.lblProductsCount.Size = new System.Drawing.Size(217, 14);
            this.lblProductsCount.TabIndex = 8;
            this.lblProductsCount.Text = "Total De Produtos Cadastrados:  ";
            // 
            // lvlProducts
            // 
            this.lvlProducts.AllowColumnReorder = true;
            this.lvlProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvlProducts.FullRowSelect = true;
            this.lvlProducts.GridLines = true;
            this.lvlProducts.HideSelection = false;
            this.lvlProducts.Location = new System.Drawing.Point(4, 45);
            this.lvlProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvlProducts.MultiSelect = false;
            this.lvlProducts.Name = "lvlProducts";
            this.lvlProducts.Size = new System.Drawing.Size(966, 417);
            this.lvlProducts.TabIndex = 0;
            this.lvlProducts.UseCompatibleStateImageBehavior = false;
            this.lvlProducts.View = System.Windows.Forms.View.Details;
            this.lvlProducts.SelectedIndexChanged += new System.EventHandler(this.LvlProducts_SelectedIndexChanged);
            this.lvlProducts.DoubleClick += new System.EventHandler(this.lvlProducts_DoubleClick);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Código";
            this.columnHeader0.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Descrição";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Estoque (Unid./kg)";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Estoque Necessário (Unid./kg)";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Preço (R$)";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Posição/Localização";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Qtd. Pacote";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Peso (kg)";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fornecedor";
            this.columnHeader8.Width = 140;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pesquisar:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(632, 17);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 22);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(91)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnAdd.Image = global::GC.Properties.Resources.icon_mais_30x30;
            this.btnAdd.Location = new System.Drawing.Point(4, 468);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 40);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnCriticalStock
            // 
            this.btnCriticalStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCriticalStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCriticalStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnCriticalStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCriticalStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriticalStock.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriticalStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCriticalStock.Location = new System.Drawing.Point(140, 468);
            this.btnCriticalStock.Name = "btnCriticalStock";
            this.btnCriticalStock.Size = new System.Drawing.Size(130, 40);
            this.btnCriticalStock.TabIndex = 19;
            this.btnCriticalStock.Text = "Controle de Estoque";
            this.btnCriticalStock.UseVisualStyleBackColor = true;
            this.btnCriticalStock.Click += new System.EventHandler(this.BtnCriticalStock_Click);
            // 
            // btnExpiration
            // 
            this.btnExpiration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExpiration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnExpiration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnExpiration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnExpiration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpiration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpiration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnExpiration.Location = new System.Drawing.Point(276, 468);
            this.btnExpiration.Name = "btnExpiration";
            this.btnExpiration.Size = new System.Drawing.Size(130, 40);
            this.btnExpiration.TabIndex = 20;
            this.btnExpiration.Text = "Controle de Vencimento";
            this.btnExpiration.UseVisualStyleBackColor = true;
            this.btnExpiration.Click += new System.EventHandler(this.btnExpiration_Click);
            // 
            // btnProductStock
            // 
            this.btnProductStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductStock.Enabled = false;
            this.btnProductStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnProductStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnProductStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnProductStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductStock.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnProductStock.Location = new System.Drawing.Point(568, 468);
            this.btnProductStock.Name = "btnProductStock";
            this.btnProductStock.Size = new System.Drawing.Size(130, 40);
            this.btnProductStock.TabIndex = 21;
            this.btnProductStock.Text = "Estoque do Produto";
            this.btnProductStock.UseVisualStyleBackColor = true;
            this.btnProductStock.Click += new System.EventHandler(this.btnAddProductStock_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlter.Enabled = false;
            this.btnAlter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAlter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(215)))));
            this.btnAlter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAlter.Image = global::GC.Properties.Resources.icon_lapis_30x30;
            this.btnAlter.Location = new System.Drawing.Point(704, 468);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(130, 40);
            this.btnAlter.TabIndex = 22;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Crimson;
            this.btnDelete.Image = global::GC.Properties.Resources.icon_lixeira_30x30;
            this.btnDelete.Location = new System.Drawing.Point(840, 468);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 40);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnSearchOptions.Location = new System.Drawing.Point(888, 16);
            this.btnSearchOptions.Name = "btnSearchOptions";
            this.btnSearchOptions.Size = new System.Drawing.Size(81, 23);
            this.btnSearchOptions.TabIndex = 24;
            this.btnSearchOptions.Text = "Opções";
            this.btnSearchOptions.UseVisualStyleBackColor = true;
            this.btnSearchOptions.Click += new System.EventHandler(this.btnSearchOptions_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "(Precione Enter para realizar a pesquisa)";
            // 
            // USC_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchOptions);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.btnProductStock);
            this.Controls.Add(this.btnExpiration);
            this.Controls.Add(this.btnCriticalStock);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvlProducts);
            this.Controls.Add(this.lblProductsCount);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "USC_Products";
            this.Size = new System.Drawing.Size(974, 515);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductsCount;
        private System.Windows.Forms.ListView lvlProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private GC.Components.CMP_BtnAdd btnAdd;
        private GC.Components.CMP_BtnRegular btnCriticalStock;
        private GC.Components.CMP_BtnRegular btnExpiration;
        private GC.Components.CMP_BtnRegular btnProductStock;
        private GC.Components.CMP_BtnAlter btnAlter;
        private GC.Components.CMP_BtnDelete btnDelete;
        private GC.Components.CMP_BtnRegular btnSearchOptions;
        private System.Windows.Forms.Label label1;
    }
}
