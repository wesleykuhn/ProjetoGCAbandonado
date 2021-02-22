namespace GC.Forms.Main.Controls
{
    partial class USC_Warranties
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
            this.lblWarrantiesCount = new System.Windows.Forms.Label();
            this.btnSearchOptions = new GC.Components.CMP_BtnRegular();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new GC.Components.CMP_BtnAdd();
            this.btnDelete = new GC.Components.CMP_BtnDelete();
            this.btnAlter = new GC.Components.CMP_BtnAlter();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlWarranties = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShowOld = new GC.Components.CMP_BtnRegular();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWarrantiesCount
            // 
            this.lblWarrantiesCount.AutoSize = true;
            this.lblWarrantiesCount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarrantiesCount.Location = new System.Drawing.Point(4, 11);
            this.lblWarrantiesCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarrantiesCount.Name = "lblWarrantiesCount";
            this.lblWarrantiesCount.Size = new System.Drawing.Size(132, 14);
            this.lblWarrantiesCount.TabIndex = 9;
            this.lblWarrantiesCount.Text = "Total De Garantias: ";
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
            this.btnSearchOptions.TabIndex = 30;
            this.btnSearchOptions.Text = "Opções";
            this.btnSearchOptions.UseVisualStyleBackColor = true;
            this.btnSearchOptions.Click += new System.EventHandler(this.btnSearchOptions_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(632, 18);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 22);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "Pesquisar:";
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
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnAlter.TabIndex = 32;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Número";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Garantia De";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Criada Em";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Termina Em";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 180;
            // 
            // lvlWarranties
            // 
            this.lvlWarranties.AllowColumnReorder = true;
            this.lvlWarranties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlWarranties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvlWarranties.FullRowSelect = true;
            this.lvlWarranties.GridLines = true;
            this.lvlWarranties.HideSelection = false;
            this.lvlWarranties.Location = new System.Drawing.Point(4, 46);
            this.lvlWarranties.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvlWarranties.MultiSelect = false;
            this.lvlWarranties.Name = "lvlWarranties";
            this.lvlWarranties.Size = new System.Drawing.Size(966, 416);
            this.lvlWarranties.TabIndex = 25;
            this.lvlWarranties.UseCompatibleStateImageBehavior = false;
            this.lvlWarranties.View = System.Windows.Forms.View.Details;
            this.lvlWarranties.SelectedIndexChanged += new System.EventHandler(this.lvlWarranties_SelectedIndexChanged);
            this.lvlWarranties.DoubleClick += new System.EventHandler(this.lvlWarranties_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cliente - Endereço";
            this.columnHeader1.Width = 340;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Produto/Serviço";
            this.columnHeader4.Width = 320;
            // 
            // btnShowOld
            // 
            this.btnShowOld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowOld.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnShowOld.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnShowOld.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnShowOld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOld.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnShowOld.Location = new System.Drawing.Point(568, 468);
            this.btnShowOld.Name = "btnShowOld";
            this.btnShowOld.Size = new System.Drawing.Size(130, 40);
            this.btnShowOld.TabIndex = 34;
            this.btnShowOld.Text = "Mostrar Antigas";
            this.btnShowOld.UseVisualStyleBackColor = true;
            this.btnShowOld.Click += new System.EventHandler(this.btnShowOld_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "(Precione Enter para realizar a pesquisa)";
            // 
            // USC_Warranties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowOld);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearchOptions);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvlWarranties);
            this.Controls.Add(this.lblWarrantiesCount);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "USC_Warranties";
            this.Size = new System.Drawing.Size(974, 515);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarrantiesCount;
        private GC.Components.CMP_BtnRegular btnSearchOptions;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private GC.Components.CMP_BtnAdd btnAdd;
        private GC.Components.CMP_BtnDelete btnDelete;
        private GC.Components.CMP_BtnAlter btnAlter;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvlWarranties;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private GC.Components.CMP_BtnRegular btnShowOld;
        private System.Windows.Forms.Label label1;
    }
}
