namespace GC.Forms.Main.Modals.Requests.SubModals.NewRequest
{
    partial class FRM_ProductsListQuantitySelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ProductsListQuantitySelector));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new GC.Components.CMP_BtnRegular();
            this.pnlCodeDescBack = new System.Windows.Forms.Panel();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblKind = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtWeight = new System.Windows.Forms.RadioButton();
            this.rbtUnit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlCodeDescBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.pnlCodeDescBack);
            this.panel1.Controls.Add(this.nudQuantity);
            this.panel1.Controls.Add(this.lblKind);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbtWeight);
            this.panel1.Controls.Add(this.rbtUnit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 192);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnAdd.Location = new System.Drawing.Point(15, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 39);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            this.btnAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnAdd_KeyUp);
            // 
            // pnlCodeDescBack
            // 
            this.pnlCodeDescBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCodeDescBack.Controls.Add(this.lblCode);
            this.pnlCodeDescBack.Controls.Add(this.lblDescription);
            this.pnlCodeDescBack.Location = new System.Drawing.Point(5, 3);
            this.pnlCodeDescBack.Name = "pnlCodeDescBack";
            this.pnlCodeDescBack.Size = new System.Drawing.Size(386, 46);
            this.pnlCodeDescBack.TabIndex = 10;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.SystemColors.Control;
            this.lblCode.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(5, 6);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(74, 18);
            this.lblCode.TabIndex = 8;
            this.lblCode.Text = "Código: ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(5, 26);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(103, 14);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Sem descrição";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(155, 89);
            this.nudQuantity.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(155, 26);
            this.nudQuantity.TabIndex = 2;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQuantity.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NudQuantity_KeyUp);
            // 
            // lblKind
            // 
            this.lblKind.AutoSize = true;
            this.lblKind.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKind.Location = new System.Drawing.Point(50, 91);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(99, 18);
            this.lblKind.TabIndex = 4;
            this.lblKind.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "/";
            // 
            // rbtWeight
            // 
            this.rbtWeight.AutoSize = true;
            this.rbtWeight.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtWeight.Location = new System.Drawing.Point(289, 49);
            this.rbtWeight.Name = "rbtWeight";
            this.rbtWeight.Size = new System.Drawing.Size(92, 22);
            this.rbtWeight.TabIndex = 4;
            this.rbtWeight.Text = "Por peso";
            this.rbtWeight.UseVisualStyleBackColor = true;
            this.rbtWeight.CheckedChanged += new System.EventHandler(this.RbtWeight_CheckedChanged);
            // 
            // rbtUnit
            // 
            this.rbtUnit.AutoSize = true;
            this.rbtUnit.Checked = true;
            this.rbtUnit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtUnit.Location = new System.Drawing.Point(154, 49);
            this.rbtUnit.Name = "rbtUnit";
            this.rbtUnit.Size = new System.Drawing.Size(113, 22);
            this.rbtUnit.TabIndex = 3;
            this.rbtUnit.TabStop = true;
            this.rbtUnit.Text = "Por unidade";
            this.rbtUnit.UseVisualStyleBackColor = true;
            this.rbtUnit.CheckedChanged += new System.EventHandler(this.RbtUnit_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo do preço:";
            // 
            // FRM_ProductsListQuantitySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(400, 224);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_ProductsListQuantitySelector";
            this.Text = "GC - Pedidos > Criando Pedido > Selecionando Produtos > Selecionando Quantidade";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmModal_NewRequestProductsListQuantitySelector_KeyUp);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCodeDescBack.ResumeLayout(false);
            this.pnlCodeDescBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtWeight;
        private System.Windows.Forms.RadioButton rbtUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Panel pnlCodeDescBack;
        private GC.Components.CMP_BtnRegular btnAdd;
    }
}