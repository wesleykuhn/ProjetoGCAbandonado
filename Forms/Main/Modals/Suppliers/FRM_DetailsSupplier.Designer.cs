namespace GC.Forms.Main.Modals.Suppliers
{
    partial class FRM_DetailsSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DetailsSupplier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNameDesc = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone_number = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlNameDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pnlNameDesc);
            this.panel1.Controls.Add(this.lblTotalProducts);
            this.panel1.Controls.Add(this.lvlProducts);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 388);
            this.panel1.TabIndex = 0;
            // 
            // pnlNameDesc
            // 
            this.pnlNameDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNameDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNameDesc.Controls.Add(this.lblName);
            this.pnlNameDesc.Controls.Add(this.lblPhone_number);
            this.pnlNameDesc.Controls.Add(this.lblEmail);
            this.pnlNameDesc.Controls.Add(this.lblDesc);
            this.pnlNameDesc.Controls.Add(this.lblCpfCnpj);
            this.pnlNameDesc.Location = new System.Drawing.Point(10, 3);
            this.pnlNameDesc.Name = "pnlNameDesc";
            this.pnlNameDesc.Size = new System.Drawing.Size(724, 72);
            this.pnlNameDesc.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Control;
            this.lblName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Location = new System.Drawing.Point(3, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome";
            // 
            // lblPhone_number
            // 
            this.lblPhone_number.AutoSize = true;
            this.lblPhone_number.BackColor = System.Drawing.SystemColors.Control;
            this.lblPhone_number.Location = new System.Drawing.Point(3, 51);
            this.lblPhone_number.Name = "lblPhone_number";
            this.lblPhone_number.Size = new System.Drawing.Size(118, 14);
            this.lblPhone_number.TabIndex = 12;
            this.lblPhone_number.Text = "Telefone/Celular: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(422, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 14);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail: ";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.SystemColors.Control;
            this.lblDesc.Location = new System.Drawing.Point(3, 30);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(76, 14);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.Text = "Descrição: ";
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.BackColor = System.Drawing.SystemColors.Control;
            this.lblCpfCnpj.Location = new System.Drawing.Point(422, 51);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(76, 14);
            this.lblCpfCnpj.TabIndex = 2;
            this.lblCpfCnpj.Text = "CPF/CNPJ: ";
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.Location = new System.Drawing.Point(537, 81);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(43, 13);
            this.lblTotalProducts.TabIndex = 5;
            this.lblTotalProducts.Text = "Total: ";
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
            this.lvlProducts.Location = new System.Drawing.Point(11, 96);
            this.lvlProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvlProducts.MultiSelect = false;
            this.lvlProducts.Name = "lvlProducts";
            this.lvlProducts.Size = new System.Drawing.Size(724, 279);
            this.lvlProducts.TabIndex = 0;
            this.lvlProducts.UseCompatibleStateImageBehavior = false;
            this.lvlProducts.View = System.Windows.Forms.View.Details;
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
            this.columnHeader2.Text = "Estoque";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Estoque Necessário";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 90;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produtos desse fornecedor:";
            // 
            // FRM_DetailsSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(750, 420);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_DetailsSupplier";
            this.Text = "GC - Fornecedores > Detalhes do Fornecedor";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNameDesc.ResumeLayout(false);
            this.pnlNameDesc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.ListView lvlProducts;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPhone_number;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel pnlNameDesc;
    }
}