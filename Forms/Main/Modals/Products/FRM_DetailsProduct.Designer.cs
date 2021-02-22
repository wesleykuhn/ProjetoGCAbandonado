namespace GC.Forms.Main.Modals.Products
{
    partial class frmModal_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModal_Details));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIdeal_stock = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblPackQtt = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblIdeal_stock);
            this.panel1.Controls.Add(this.lblStock);
            this.panel1.Controls.Add(this.lblSupplier);
            this.panel1.Controls.Add(this.lblWeight);
            this.panel1.Controls.Add(this.lblPackQtt);
            this.panel1.Controls.Add(this.lblPosition);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.lblCode);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 278);
            this.panel1.TabIndex = 0;
            // 
            // lblIdeal_stock
            // 
            this.lblIdeal_stock.AutoSize = true;
            this.lblIdeal_stock.Location = new System.Drawing.Point(10, 151);
            this.lblIdeal_stock.Name = "lblIdeal_stock";
            this.lblIdeal_stock.Size = new System.Drawing.Size(140, 14);
            this.lblIdeal_stock.TabIndex = 10;
            this.lblIdeal_stock.Text = "Estoque necessário: ";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(10, 237);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(224, 18);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Quantidade no estoque: ";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(10, 174);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(87, 14);
            this.lblSupplier.TabIndex = 6;
            this.lblSupplier.Text = "Fornecedor: ";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(10, 128);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(51, 14);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Peso:  ";
            // 
            // lblPackQtt
            // 
            this.lblPackQtt.AutoSize = true;
            this.lblPackQtt.Location = new System.Drawing.Point(10, 105);
            this.lblPackQtt.Name = "lblPackQtt";
            this.lblPackQtt.Size = new System.Drawing.Size(196, 14);
            this.lblPackQtt.TabIndex = 4;
            this.lblPackQtt.Text = "Quantidade por embalagem:  ";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(10, 82);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(141, 14);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "Posição/Localização: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(10, 59);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 14);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Preço: R$ ";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(10, 36);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(76, 14);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Descrição: ";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(10, 12);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(60, 14);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Código: ";
            // 
            // frmModal_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(564, 310);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModal_Details";
            this.Text = "GC - Produtos > Detalhes do Produto";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPackQtt;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblIdeal_stock;
    }
}