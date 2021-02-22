namespace GC.Forms.Main.Modals.Products
{
    partial class FRM_EditStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_EditStock));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlListBack = new System.Windows.Forms.Panel();
            this.btnDelete = new GC.Components.CMP_BtnDelete();
            this.btnAlter = new GC.Components.CMP_BtnAlter();
            this.btnAdd = new GC.Components.CMP_BtnAdd();
            this.lvlLots = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.entry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expires = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDetailsBack = new System.Windows.Forms.Panel();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlListBack.SuspendLayout();
            this.pnlDetailsBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pnlListBack);
            this.panel1.Controls.Add(this.pnlDetailsBack);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 408);
            this.panel1.TabIndex = 0;
            // 
            // pnlListBack
            // 
            this.pnlListBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlListBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListBack.Controls.Add(this.btnDelete);
            this.pnlListBack.Controls.Add(this.btnAlter);
            this.pnlListBack.Controls.Add(this.btnAdd);
            this.pnlListBack.Controls.Add(this.lvlLots);
            this.pnlListBack.Controls.Add(this.label1);
            this.pnlListBack.Location = new System.Drawing.Point(10, 89);
            this.pnlListBack.Name = "pnlListBack";
            this.pnlListBack.Size = new System.Drawing.Size(626, 309);
            this.pnlListBack.TabIndex = 9;
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
            this.btnDelete.Location = new System.Drawing.Point(485, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 40);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
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
            this.btnAlter.Location = new System.Drawing.Point(349, 259);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(130, 40);
            this.btnAlter.TabIndex = 23;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.BtnEdit_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(9, 259);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 40);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lvlLots
            // 
            this.lvlLots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlLots.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.qtt,
            this.entry,
            this.expires});
            this.lvlLots.FullRowSelect = true;
            this.lvlLots.GridLines = true;
            this.lvlLots.HideSelection = false;
            this.lvlLots.Location = new System.Drawing.Point(9, 27);
            this.lvlLots.Name = "lvlLots";
            this.lvlLots.Size = new System.Drawing.Size(606, 209);
            this.lvlLots.TabIndex = 3;
            this.lvlLots.UseCompatibleStateImageBehavior = false;
            this.lvlLots.View = System.Windows.Forms.View.Details;
            this.lvlLots.SelectedIndexChanged += new System.EventHandler(this.LvlLots_SelectedIndexChanged);
            // 
            // number
            // 
            this.number.Text = "Número";
            this.number.Width = 124;
            // 
            // qtt
            // 
            this.qtt.Text = "Quantidade (uni./kg)";
            this.qtt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qtt.Width = 145;
            // 
            // entry
            // 
            this.entry.Text = "Data da Entrada";
            this.entry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.entry.Width = 169;
            // 
            // expires
            // 
            this.expires.Text = "Data de Validade";
            this.expires.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.expires.Width = 164;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lotes e suas quantidades:";
            // 
            // pnlDetailsBack
            // 
            this.pnlDetailsBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetailsBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDetailsBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetailsBack.Controls.Add(this.lblCode);
            this.pnlDetailsBack.Controls.Add(this.lblDesc);
            this.pnlDetailsBack.Controls.Add(this.lblStock);
            this.pnlDetailsBack.Location = new System.Drawing.Point(10, 13);
            this.pnlDetailsBack.Name = "pnlDetailsBack";
            this.pnlDetailsBack.Size = new System.Drawing.Size(626, 70);
            this.pnlDetailsBack.TabIndex = 5;
            // 
            // lblCode
            // 
            this.lblCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.SystemColors.Control;
            this.lblCode.Location = new System.Drawing.Point(11, 5);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(60, 14);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Código: ";
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.SystemColors.Control;
            this.lblDesc.Location = new System.Drawing.Point(11, 27);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(76, 14);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Descrição: ";
            // 
            // lblStock
            // 
            this.lblStock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.SystemColors.Control;
            this.lblStock.Location = new System.Drawing.Point(11, 49);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(166, 14);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Quantidade no estoque: ";
            // 
            // FRM_EditStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(650, 440);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_EditStock";
            this.Text = "GC - Produtos > Editando Estoque";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.pnlListBack.ResumeLayout(false);
            this.pnlListBack.PerformLayout();
            this.pnlDetailsBack.ResumeLayout(false);
            this.pnlDetailsBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Panel pnlDetailsBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvlLots;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader qtt;
        private System.Windows.Forms.ColumnHeader entry;
        private System.Windows.Forms.Panel pnlListBack;
        private System.Windows.Forms.ColumnHeader expires;
        private GC.Components.CMP_BtnAdd btnAdd;
        private GC.Components.CMP_BtnAlter btnAlter;
        private GC.Components.CMP_BtnDelete btnDelete;
    }
}