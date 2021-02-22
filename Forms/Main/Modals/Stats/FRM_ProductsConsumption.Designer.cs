namespace GC.Forms.Main.Modals.Stats
{
    partial class FRM_ProductsConsumption
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
            this.LVL_Products = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PNL_Background = new System.Windows.Forms.Panel();
            this.CBX_OnlyFinished = new System.Windows.Forms.CheckBox();
            this.PNL_Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // LVL_Products
            // 
            this.LVL_Products.AllowColumnReorder = true;
            this.LVL_Products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LVL_Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.LVL_Products.FullRowSelect = true;
            this.LVL_Products.GridLines = true;
            this.LVL_Products.HideSelection = false;
            this.LVL_Products.Location = new System.Drawing.Point(2, 38);
            this.LVL_Products.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LVL_Products.MultiSelect = false;
            this.LVL_Products.Name = "LVL_Products";
            this.LVL_Products.Size = new System.Drawing.Size(842, 478);
            this.LVL_Products.TabIndex = 1;
            this.LVL_Products.UseCompatibleStateImageBehavior = false;
            this.LVL_Products.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Código";
            this.columnHeader0.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Descrição";
            this.columnHeader3.Width = 220;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Consumo Total";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Consumo díario (Média)";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 170;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Estoque (Unid./kg)";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Estoque Necessário (Unid./kg)";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Preço (R$)";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Posição/Localização";
            this.columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Qtd. Pacote";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 90;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Peso (kg)";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Fornecedor";
            this.columnHeader10.Width = 140;
            // 
            // PNL_Background
            // 
            this.PNL_Background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Background.BackColor = System.Drawing.SystemColors.Control;
            this.PNL_Background.Controls.Add(this.CBX_OnlyFinished);
            this.PNL_Background.Controls.Add(this.LVL_Products);
            this.PNL_Background.Location = new System.Drawing.Point(2, 30);
            this.PNL_Background.Name = "PNL_Background";
            this.PNL_Background.Size = new System.Drawing.Size(846, 518);
            this.PNL_Background.TabIndex = 45;
            // 
            // CBX_OnlyFinished
            // 
            this.CBX_OnlyFinished.AutoSize = true;
            this.CBX_OnlyFinished.Location = new System.Drawing.Point(2, 12);
            this.CBX_OnlyFinished.Name = "CBX_OnlyFinished";
            this.CBX_OnlyFinished.Size = new System.Drawing.Size(198, 18);
            this.CBX_OnlyFinished.TabIndex = 2;
            this.CBX_OnlyFinished.Text = "Apenas pedidos finalizados";
            this.CBX_OnlyFinished.UseVisualStyleBackColor = true;
            this.CBX_OnlyFinished.CheckedChanged += new System.EventHandler(this.CBX_OnlyFinished_CheckedChanged);
            // 
            // FRM_ProductsConsumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.PNL_Background);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "FRM_ProductsConsumption";
            this.Text = "GC - Estatísticas > Consumo de Produtos";
            this.Controls.SetChildIndex(this.PNL_Background, 0);
            this.PNL_Background.ResumeLayout(false);
            this.PNL_Background.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVL_Products;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel PNL_Background;
        private System.Windows.Forms.CheckBox CBX_OnlyFinished;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}