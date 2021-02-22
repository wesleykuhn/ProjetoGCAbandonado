namespace GC.Forms.Main.Modals.Products
{
    partial class FRM_AlterProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AlterProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlter = new GC.Components.CMP_BtnAlter();
            this.nudIdeal_stock = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ckbAutoCode = new System.Windows.Forms.CheckBox();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudPackQuant = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdeal_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPackQuant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnAlter);
            this.panel1.Controls.Add(this.nudIdeal_stock);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ckbAutoCode);
            this.panel1.Controls.Add(this.cbxSupplier);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.nudWeight);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.nudPackQuant);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nudPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 353);
            this.panel1.TabIndex = 0;
            // 
            // btnAlter
            // 
            this.btnAlter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAlter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(215)))));
            this.btnAlter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAlter.Image = global::GC.Properties.Resources.icon_lapis_30x30;
            this.btnAlter.Location = new System.Drawing.Point(10, 303);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(130, 40);
            this.btnAlter.TabIndex = 86;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // nudIdeal_stock
            // 
            this.nudIdeal_stock.DecimalPlaces = 3;
            this.nudIdeal_stock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudIdeal_stock.Location = new System.Drawing.Point(322, 200);
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(306, 14);
            this.label13.TabIndex = 43;
            this.label13.Text = "Me avise quando o estoque estiver menor que:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(10, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "*Campo obrigatórios.";
            // 
            // ckbAutoCode
            // 
            this.ckbAutoCode.AutoSize = true;
            this.ckbAutoCode.Location = new System.Drawing.Point(13, 36);
            this.ckbAutoCode.Name = "ckbAutoCode";
            this.ckbAutoCode.Size = new System.Drawing.Size(328, 18);
            this.ckbAutoCode.TabIndex = 1;
            this.ckbAutoCode.Text = "Dar um código automaticamente a este produto";
            this.ckbAutoCode.UseVisualStyleBackColor = true;
            this.ckbAutoCode.CheckedChanged += new System.EventHandler(this.ckbAutoCode_CheckedChanged);
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(99, 224);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(270, 22);
            this.cbxSupplier.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 14);
            this.label8.TabIndex = 34;
            this.label8.Text = "Fornecedor:";
            // 
            // nudWeight
            // 
            this.nudWeight.DecimalPlaces = 3;
            this.nudWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudWeight.Location = new System.Drawing.Point(88, 172);
            this.nudWeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(130, 22);
            this.nudWeight.TabIndex = 6;
            this.nudWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 14);
            this.label7.TabIndex = 33;
            this.label7.Text = "Peso (kg):";
            // 
            // nudPackQuant
            // 
            this.nudPackQuant.Location = new System.Drawing.Point(204, 144);
            this.nudPackQuant.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPackQuant.Name = "nudPackQuant";
            this.nudPackQuant.Size = new System.Drawing.Size(112, 22);
            this.nudPackQuant.TabIndex = 5;
            this.nudPackQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 14);
            this.label6.TabIndex = 32;
            this.label6.Text = "Quantidade por embalagem:";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPrice.Location = new System.Drawing.Point(71, 88);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 29;
            this.label5.Text = "*Preço:";
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(140, 116);
            this.txtPos.MaxLength = 12;
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(215, 22);
            this.txtPos.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 14);
            this.label4.TabIndex = 26;
            this.label4.Text = "Posição/Endereço:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(96, 60);
            this.txtDesc.MaxLength = 50;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(314, 22);
            this.txtDesc.TabIndex = 2;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "*Descrição:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(80, 8);
            this.txtCode.MaxLength = 16;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(217, 22);
            this.txtCode.TabIndex = 0;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "*Código:";
            // 
            // FRM_AlterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(429, 385);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_AlterProduct";
            this.Text = "GC - Produtos > Alteração de Produto";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdeal_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPackQuant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.CheckBox ckbAutoCode;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudPackQuant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudIdeal_stock;
        private System.Windows.Forms.Label label13;
        private GC.Components.CMP_BtnAlter btnAlter;
    }
}