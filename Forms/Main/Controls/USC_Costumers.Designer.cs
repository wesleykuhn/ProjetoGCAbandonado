namespace GC.Forms.Main.Controls
{
    partial class USC_Costumers
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvlCostumers = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.complement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.district = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.debt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discount_counter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discount_accumulated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCostumersCount = new System.Windows.Forms.Label();
            this.btnAdd = new GC.Components.CMP_BtnAdd();
            this.btnUpdateDebt = new GC.Components.CMP_BtnAlter();
            this.btnUpdateDiscount = new GC.Components.CMP_BtnAlter();
            this.btnAlter = new GC.Components.CMP_BtnAlter();
            this.btnDelete = new GC.Components.CMP_BtnDelete();
            this.btnSearchOptions = new GC.Components.CMP_BtnRegular();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(632, 18);
            this.txtSearch.MaxLength = 60;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 22);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pesquisar:";
            // 
            // lvlCostumers
            // 
            this.lvlCostumers.AllowColumnReorder = true;
            this.lvlCostumers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlCostumers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.email,
            this.phone_number,
            this.sex,
            this.address,
            this.complement,
            this.cep,
            this.district,
            this.city,
            this.state,
            this.country,
            this.debt,
            this.discount_counter,
            this.discount_accumulated});
            this.lvlCostumers.FullRowSelect = true;
            this.lvlCostumers.GridLines = true;
            this.lvlCostumers.HideSelection = false;
            this.lvlCostumers.Location = new System.Drawing.Point(4, 45);
            this.lvlCostumers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvlCostumers.MultiSelect = false;
            this.lvlCostumers.Name = "lvlCostumers";
            this.lvlCostumers.Size = new System.Drawing.Size(966, 417);
            this.lvlCostumers.TabIndex = 0;
            this.lvlCostumers.UseCompatibleStateImageBehavior = false;
            this.lvlCostumers.View = System.Windows.Forms.View.Details;
            this.lvlCostumers.SelectedIndexChanged += new System.EventHandler(this.lvlCostumers_SelectedIndexChanged);
            this.lvlCostumers.DoubleClick += new System.EventHandler(this.lvlCostumers_DoubleClick);
            // 
            // name
            // 
            this.name.Text = "Nome";
            this.name.Width = 150;
            // 
            // email
            // 
            this.email.Text = "E-mail";
            this.email.Width = 170;
            // 
            // phone_number
            // 
            this.phone_number.Text = "Telefone/Celular";
            this.phone_number.Width = 150;
            // 
            // sex
            // 
            this.sex.Text = "Sexo";
            this.sex.Width = 45;
            // 
            // address
            // 
            this.address.Text = "Endereço";
            this.address.Width = 200;
            // 
            // complement
            // 
            this.complement.Text = "Complemento";
            this.complement.Width = 120;
            // 
            // cep
            // 
            this.cep.Text = "CEP";
            this.cep.Width = 100;
            // 
            // district
            // 
            this.district.Text = "Bairro";
            this.district.Width = 140;
            // 
            // city
            // 
            this.city.Text = "Cidade";
            this.city.Width = 120;
            // 
            // state
            // 
            this.state.Text = "Estado";
            this.state.Width = 110;
            // 
            // country
            // 
            this.country.Text = "País";
            this.country.Width = 100;
            // 
            // debt
            // 
            this.debt.Text = "Dívida (R$)";
            this.debt.Width = 100;
            // 
            // discount_counter
            // 
            this.discount_counter.Text = "Compras Anotadas";
            this.discount_counter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discount_counter.Width = 120;
            // 
            // discount_accumulated
            // 
            this.discount_accumulated.Text = "Desconto Acumulado (R$)";
            this.discount_accumulated.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discount_accumulated.Width = 120;
            // 
            // lblCostumersCount
            // 
            this.lblCostumersCount.AutoSize = true;
            this.lblCostumersCount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostumersCount.Location = new System.Drawing.Point(4, 10);
            this.lblCostumersCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostumersCount.Name = "lblCostumersCount";
            this.lblCostumersCount.Size = new System.Drawing.Size(211, 14);
            this.lblCostumersCount.TabIndex = 8;
            this.lblCostumersCount.Text = "Total De Clientes Cadastrados:  ";
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
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnNewCostumer_Click);
            // 
            // btnUpdateDebt
            // 
            this.btnUpdateDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateDebt.Enabled = false;
            this.btnUpdateDebt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnUpdateDebt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(215)))));
            this.btnUpdateDebt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnUpdateDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDebt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDebt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnUpdateDebt.Image = global::GC.Properties.Resources.icon_lapis_30x30;
            this.btnUpdateDebt.Location = new System.Drawing.Point(415, 468);
            this.btnUpdateDebt.Name = "btnUpdateDebt";
            this.btnUpdateDebt.Size = new System.Drawing.Size(140, 40);
            this.btnUpdateDebt.TabIndex = 15;
            this.btnUpdateDebt.Text = "Alterar Dívida";
            this.btnUpdateDebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateDebt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateDebt.UseVisualStyleBackColor = true;
            this.btnUpdateDebt.Click += new System.EventHandler(this.BtnUpdateDebt_Click);
            // 
            // btnUpdateDiscount
            // 
            this.btnUpdateDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateDiscount.Enabled = false;
            this.btnUpdateDiscount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnUpdateDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(215)))));
            this.btnUpdateDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnUpdateDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDiscount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnUpdateDiscount.Image = global::GC.Properties.Resources.icon_lapis_30x30;
            this.btnUpdateDiscount.Location = new System.Drawing.Point(561, 468);
            this.btnUpdateDiscount.Name = "btnUpdateDiscount";
            this.btnUpdateDiscount.Size = new System.Drawing.Size(138, 40);
            this.btnUpdateDiscount.TabIndex = 16;
            this.btnUpdateDiscount.Text = "Alterar Descontos";
            this.btnUpdateDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateDiscount.UseVisualStyleBackColor = true;
            this.btnUpdateDiscount.Click += new System.EventHandler(this.BtnUpdateDiscount_Click);
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
            this.btnAlter.Location = new System.Drawing.Point(705, 468);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(140, 40);
            this.btnAlter.TabIndex = 17;
            this.btnAlter.Text = "Alterar Dados";
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
            this.btnDelete.Location = new System.Drawing.Point(851, 468);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 40);
            this.btnDelete.TabIndex = 18;
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
            this.btnSearchOptions.Location = new System.Drawing.Point(888, 17);
            this.btnSearchOptions.Name = "btnSearchOptions";
            this.btnSearchOptions.Size = new System.Drawing.Size(81, 23);
            this.btnSearchOptions.TabIndex = 19;
            this.btnSearchOptions.Text = "Opções";
            this.btnSearchOptions.UseVisualStyleBackColor = true;
            this.btnSearchOptions.Click += new System.EventHandler(this.btnSearchOptions_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "(Precione Enter para realizar a pesquisa)";
            // 
            // USC_Costumers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchOptions);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.btnUpdateDiscount);
            this.Controls.Add(this.btnUpdateDebt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvlCostumers);
            this.Controls.Add(this.lblCostumersCount);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "USC_Costumers";
            this.Size = new System.Drawing.Size(974, 515);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvlCostumers;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.Label lblCostumersCount;
        private System.Windows.Forms.ColumnHeader phone_number;
        private System.Windows.Forms.ColumnHeader sex;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader district;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.ColumnHeader country;
        private System.Windows.Forms.ColumnHeader cep;
        private System.Windows.Forms.ColumnHeader discount_counter;
        private System.Windows.Forms.ColumnHeader discount_accumulated;
        private System.Windows.Forms.ColumnHeader complement;
        private System.Windows.Forms.ColumnHeader debt;
        private GC.Components.CMP_BtnAdd btnAdd;
        private GC.Components.CMP_BtnAlter btnUpdateDebt;
        private GC.Components.CMP_BtnAlter btnUpdateDiscount;
        private GC.Components.CMP_BtnAlter btnAlter;
        private GC.Components.CMP_BtnDelete btnDelete;
        private GC.Components.CMP_BtnRegular btnSearchOptions;
        private System.Windows.Forms.Label label1;
    }
}
