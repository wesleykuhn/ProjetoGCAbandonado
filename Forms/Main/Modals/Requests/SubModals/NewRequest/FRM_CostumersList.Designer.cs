namespace GC.Forms.Main.Modals.Requests.SubModals.NewRequest
{
    partial class FRM_CostumersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CostumersList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelect = new GC.Components.CMP_BtnRegular();
            this.lblSelected = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchOptions = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.lblSelected);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSearchOptions);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lvlCostumers);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 418);
            this.panel1.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnSelect.Location = new System.Drawing.Point(11, 370);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(136, 38);
            this.btnSelect.TabIndex = 42;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.lblSelected.Location = new System.Drawing.Point(146, 15);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(65, 14);
            this.lblSelected.TabIndex = 17;
            this.lblSelected.Text = "Ninguém";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cliente selecionado:";
            // 
            // btnSearchOptions
            // 
            this.btnSearchOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchOptions.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOptions.Location = new System.Drawing.Point(853, 11);
            this.btnSearchOptions.Name = "btnSearchOptions";
            this.btnSearchOptions.Size = new System.Drawing.Size(81, 22);
            this.btnSearchOptions.TabIndex = 14;
            this.btnSearchOptions.Text = "Opções";
            this.btnSearchOptions.UseVisualStyleBackColor = true;
            this.btnSearchOptions.Click += new System.EventHandler(this.BtnSearchOptions_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(597, 11);
            this.txtSearch.MaxLength = 60;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 22);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pesquisar:";
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
            this.lvlCostumers.Location = new System.Drawing.Point(11, 38);
            this.lvlCostumers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvlCostumers.MultiSelect = false;
            this.lvlCostumers.Name = "lvlCostumers";
            this.lvlCostumers.Size = new System.Drawing.Size(923, 326);
            this.lvlCostumers.TabIndex = 12;
            this.lvlCostumers.UseCompatibleStateImageBehavior = false;
            this.lvlCostumers.View = System.Windows.Forms.View.Details;
            this.lvlCostumers.SelectedIndexChanged += new System.EventHandler(this.LvlCostumers_SelectedIndexChanged);
            this.lvlCostumers.DoubleClick += new System.EventHandler(this.LvlCostumers_DoubleClick);
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
            // discount_accumulated
            // 
            this.discount_accumulated.Text = "Desconto Acumulado (R$)";
            this.discount_accumulated.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discount_accumulated.Width = 120;
            // 
            // FRM_CostumersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_CostumersList";
            this.Text = "GC - Pedidos > Criando Pedido > Selecionando Cliente";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchOptions;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvlCostumers;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader phone_number;
        private System.Windows.Forms.ColumnHeader sex;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader complement;
        private System.Windows.Forms.ColumnHeader cep;
        private System.Windows.Forms.ColumnHeader district;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.ColumnHeader country;
        private System.Windows.Forms.ColumnHeader debt;
        private System.Windows.Forms.ColumnHeader discount_counter;
        private System.Windows.Forms.ColumnHeader discount_accumulated;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label label3;
        private GC.Components.CMP_BtnRegular btnSelect;
    }
}