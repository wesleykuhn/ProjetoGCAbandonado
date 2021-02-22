namespace GC.Forms.Main.Modals.Products
{
    partial class FRM_NewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NewProduct));
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnAdd = new GC.Components.CMP_BtnAdd();
            this.pnlCodeDescBack = new System.Windows.Forms.Panel();
            this.btnCreate = new GC.Components.CMP_BtnRegular();
            this.label1 = new System.Windows.Forms.Label();
            this.nudIdeal_stock = new System.Windows.Forms.NumericUpDown();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudPackQuant = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ckbAutoCode = new System.Windows.Forms.CheckBox();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lvlAddedProducts = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.pnlCodeDescBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdeal_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPackQuant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBackground.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBackground.Controls.Add(this.btnAdd);
            this.pnlBackground.Controls.Add(this.pnlCodeDescBack);
            this.pnlBackground.Controls.Add(this.label10);
            this.pnlBackground.Controls.Add(this.lvlAddedProducts);
            this.pnlBackground.Controls.Add(this.label11);
            this.pnlBackground.Location = new System.Drawing.Point(2, 30);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(885, 371);
            this.pnlBackground.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(91)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnAdd.Image = global::GC.Properties.Resources.icon_mais_30x30;
            this.btnAdd.Location = new System.Drawing.Point(745, 318);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 40);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // pnlCodeDescBack
            // 
            this.pnlCodeDescBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCodeDescBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCodeDescBack.Controls.Add(this.btnCreate);
            this.pnlCodeDescBack.Controls.Add(this.label1);
            this.pnlCodeDescBack.Controls.Add(this.nudIdeal_stock);
            this.pnlCodeDescBack.Controls.Add(this.txtCode);
            this.pnlCodeDescBack.Controls.Add(this.label13);
            this.pnlCodeDescBack.Controls.Add(this.label3);
            this.pnlCodeDescBack.Controls.Add(this.txtDesc);
            this.pnlCodeDescBack.Controls.Add(this.label4);
            this.pnlCodeDescBack.Controls.Add(this.txtPos);
            this.pnlCodeDescBack.Controls.Add(this.label5);
            this.pnlCodeDescBack.Controls.Add(this.nudPrice);
            this.pnlCodeDescBack.Controls.Add(this.label6);
            this.pnlCodeDescBack.Controls.Add(this.nudPackQuant);
            this.pnlCodeDescBack.Controls.Add(this.label9);
            this.pnlCodeDescBack.Controls.Add(this.label7);
            this.pnlCodeDescBack.Controls.Add(this.ckbAutoCode);
            this.pnlCodeDescBack.Controls.Add(this.nudWeight);
            this.pnlCodeDescBack.Controls.Add(this.label8);
            this.pnlCodeDescBack.Controls.Add(this.cbxSupplier);
            this.pnlCodeDescBack.Location = new System.Drawing.Point(10, 10);
            this.pnlCodeDescBack.Name = "pnlCodeDescBack";
            this.pnlCodeDescBack.Size = new System.Drawing.Size(419, 348);
            this.pnlCodeDescBack.TabIndex = 31;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCreate.Location = new System.Drawing.Point(285, 299);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 40);
            this.btnCreate.TabIndex = 38;
            this.btnCreate.Text = "Criar";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Código:";
            // 
            // nudIdeal_stock
            // 
            this.nudIdeal_stock.DecimalPlaces = 3;
            this.nudIdeal_stock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIdeal_stock.Location = new System.Drawing.Point(319, 205);
            this.nudIdeal_stock.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudIdeal_stock.Name = "nudIdeal_stock";
            this.nudIdeal_stock.Size = new System.Drawing.Size(88, 21);
            this.nudIdeal_stock.TabIndex = 7;
            this.nudIdeal_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(77, 13);
            this.txtCode.MaxLength = 16;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(236, 22);
            this.txtCode.TabIndex = 0;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(7, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(306, 14);
            this.label13.TabIndex = 30;
            this.label13.Text = "Me avise quando o estoque estiver menor que:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Descrição:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(93, 65);
            this.txtDesc.MaxLength = 50;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(313, 22);
            this.txtDesc.TabIndex = 2;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Posição/Endereço:";
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(137, 121);
            this.txtPos.MaxLength = 12;
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(218, 22);
            this.txtPos.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(7, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "*Preço(R$):";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPrice.Location = new System.Drawing.Point(88, 93);
            this.nudPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(127, 22);
            this.nudPrice.TabIndex = 3;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(7, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quantidade por embalagem:";
            // 
            // nudPackQuant
            // 
            this.nudPackQuant.Location = new System.Drawing.Point(201, 149);
            this.nudPackQuant.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPackQuant.Name = "nudPackQuant";
            this.nudPackQuant.Size = new System.Drawing.Size(137, 22);
            this.nudPackQuant.TabIndex = 5;
            this.nudPackQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(7, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "*Campos obrigatórios.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(7, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Peso (kg):";
            // 
            // ckbAutoCode
            // 
            this.ckbAutoCode.AutoSize = true;
            this.ckbAutoCode.BackColor = System.Drawing.SystemColors.Control;
            this.ckbAutoCode.Location = new System.Drawing.Point(10, 41);
            this.ckbAutoCode.Name = "ckbAutoCode";
            this.ckbAutoCode.Size = new System.Drawing.Size(328, 18);
            this.ckbAutoCode.TabIndex = 1;
            this.ckbAutoCode.Text = "Dar um código automaticamente a este produto";
            this.ckbAutoCode.UseVisualStyleBackColor = false;
            this.ckbAutoCode.CheckedChanged += new System.EventHandler(this.ckbAutoCode_CheckedChanged);
            // 
            // nudWeight
            // 
            this.nudWeight.DecimalPlaces = 3;
            this.nudWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudWeight.Location = new System.Drawing.Point(85, 177);
            this.nudWeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(132, 22);
            this.nudWeight.TabIndex = 6;
            this.nudWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(7, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fornecedor:";
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(96, 232);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(308, 22);
            this.cbxSupplier.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(475, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Duplo clique num item da lista para removê-lo.";
            // 
            // lvlAddedProducts
            // 
            this.lvlAddedProducts.AutoArrange = false;
            this.lvlAddedProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvlAddedProducts.FullRowSelect = true;
            this.lvlAddedProducts.GridLines = true;
            this.lvlAddedProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvlAddedProducts.HideSelection = false;
            this.lvlAddedProducts.Location = new System.Drawing.Point(478, 27);
            this.lvlAddedProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvlAddedProducts.MultiSelect = false;
            this.lvlAddedProducts.Name = "lvlAddedProducts";
            this.lvlAddedProducts.Size = new System.Drawing.Size(397, 260);
            this.lvlAddedProducts.TabIndex = 11;
            this.lvlAddedProducts.UseCompatibleStateImageBehavior = false;
            this.lvlAddedProducts.View = System.Windows.Forms.View.Details;
            this.lvlAddedProducts.DoubleClick += new System.EventHandler(this.lvlAddedProducts_DoubleClick);
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
            this.columnHeader2.Text = "Estoque Maior Que";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 90;
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
            // columnHeader5
            // 
            this.columnHeader5.Text = "Qtd. Pacote";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 90;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(475, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(393, 14);
            this.label11.TabIndex = 22;
            this.label11.Text = "Itens que você criou e que estão prontos para serem salvos:";
            // 
            // FRM_NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(889, 403);
            this.Controls.Add(this.pnlBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_NewProduct";
            this.Text = "GC - Produtos > Adicionar Produtos";
            this.Controls.SetChildIndex(this.pnlBackground, 0);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.pnlCodeDescBack.ResumeLayout(false);
            this.pnlCodeDescBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdeal_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPackQuant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudPackQuant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lvlAddedProducts;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        internal System.Windows.Forms.CheckBox ckbAutoCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudIdeal_stock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlCodeDescBack;
        private GC.Components.CMP_BtnRegular btnCreate;
        private GC.Components.CMP_BtnAdd btnAdd;
    }
}