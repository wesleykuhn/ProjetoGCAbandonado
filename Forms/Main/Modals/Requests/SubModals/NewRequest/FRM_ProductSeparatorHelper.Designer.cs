namespace GC.Forms.Main.Modals.Requests.SubModals.NewRequest
{
    partial class FRM_ProductSeparatorHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ProductSeparatorHelper));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lvlProducts = new System.Windows.Forms.ListView();
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lvlProducts);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 315);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(8, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "*Clique nos itens da lista que você já separou para marca-los.";
            // 
            // lvlProducts
            // 
            this.lvlProducts.AllowColumnReorder = true;
            this.lvlProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.code,
            this.description,
            this.quantity,
            this.lot,
            this.position});
            this.lvlProducts.FullRowSelect = true;
            this.lvlProducts.GridLines = true;
            this.lvlProducts.HideSelection = false;
            this.lvlProducts.Location = new System.Drawing.Point(11, 26);
            this.lvlProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvlProducts.MultiSelect = false;
            this.lvlProducts.Name = "lvlProducts";
            this.lvlProducts.Size = new System.Drawing.Size(664, 262);
            this.lvlProducts.TabIndex = 1;
            this.lvlProducts.UseCompatibleStateImageBehavior = false;
            this.lvlProducts.View = System.Windows.Forms.View.Details;
            this.lvlProducts.Click += new System.EventHandler(this.LvlProducts_Click);
            // 
            // code
            // 
            this.code.Text = "Código";
            this.code.Width = 130;
            // 
            // description
            // 
            this.description.Text = "Descrição";
            this.description.Width = 170;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantidade(uni./kg)";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantity.Width = 100;
            // 
            // lot
            // 
            this.lot.Text = "Lote";
            this.lot.Width = 120;
            // 
            // position
            // 
            this.position.Text = "Posição/Localização";
            this.position.Width = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Separe os seguintes produtos pelo(s) seguinte(s) lote(s):";
            // 
            // FRM_ProductSeparatorHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(690, 347);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_ProductSeparatorHelper";
            this.Text = "GC - Pedidos > Criando Pedido > Separação De Produtos";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvlProducts;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader lot;
        private System.Windows.Forms.ColumnHeader position;
        private System.Windows.Forms.Label label3;
    }
}