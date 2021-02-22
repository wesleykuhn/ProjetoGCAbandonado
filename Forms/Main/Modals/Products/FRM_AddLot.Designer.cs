namespace GC.Forms.Main.Modals.Products
{
    partial class FRM_AddLot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AddLot));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new GC.Components.CMP_BtnAdd();
            this.pnlExpiresBack = new System.Windows.Forms.Panel();
            this.cbxExpiresIn = new System.Windows.Forms.CheckBox();
            this.dtpExpiresIn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlQttBack = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtWeight = new System.Windows.Forms.RadioButton();
            this.rbtUnit = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlExpiresBack.SuspendLayout();
            this.pnlQttBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.pnlExpiresBack);
            this.panel1.Controls.Add(this.pnlQttBack);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 280);
            this.panel1.TabIndex = 0;
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
            this.btnAdd.Location = new System.Drawing.Point(13, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 40);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // pnlExpiresBack
            // 
            this.pnlExpiresBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExpiresBack.Controls.Add(this.cbxExpiresIn);
            this.pnlExpiresBack.Controls.Add(this.dtpExpiresIn);
            this.pnlExpiresBack.Controls.Add(this.label6);
            this.pnlExpiresBack.Location = new System.Drawing.Point(13, 132);
            this.pnlExpiresBack.Name = "pnlExpiresBack";
            this.pnlExpiresBack.Size = new System.Drawing.Size(476, 62);
            this.pnlExpiresBack.TabIndex = 12;
            // 
            // cbxExpiresIn
            // 
            this.cbxExpiresIn.AutoSize = true;
            this.cbxExpiresIn.BackColor = System.Drawing.SystemColors.Control;
            this.cbxExpiresIn.Location = new System.Drawing.Point(18, 9);
            this.cbxExpiresIn.Name = "cbxExpiresIn";
            this.cbxExpiresIn.Size = new System.Drawing.Size(162, 18);
            this.cbxExpiresIn.TabIndex = 11;
            this.cbxExpiresIn.Text = "Tem Data de Validade";
            this.cbxExpiresIn.UseVisualStyleBackColor = false;
            this.cbxExpiresIn.CheckedChanged += new System.EventHandler(this.CbxExpiresIn_CheckedChanged);
            // 
            // dtpExpiresIn
            // 
            this.dtpExpiresIn.CustomFormat = "dddd, dd MMMM yyyy HH:mm:ss";
            this.dtpExpiresIn.Enabled = false;
            this.dtpExpiresIn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiresIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiresIn.Location = new System.Drawing.Point(140, 33);
            this.dtpExpiresIn.Name = "dtpExpiresIn";
            this.dtpExpiresIn.Size = new System.Drawing.Size(322, 22);
            this.dtpExpiresIn.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(15, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data de Validade:";
            // 
            // pnlQttBack
            // 
            this.pnlQttBack.BackColor = System.Drawing.SystemColors.Control;
            this.pnlQttBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlQttBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQttBack.Controls.Add(this.label5);
            this.pnlQttBack.Controls.Add(this.nudValue);
            this.pnlQttBack.Controls.Add(this.label4);
            this.pnlQttBack.Controls.Add(this.rbtWeight);
            this.pnlQttBack.Controls.Add(this.rbtUnit);
            this.pnlQttBack.Controls.Add(this.lblType);
            this.pnlQttBack.Location = new System.Drawing.Point(13, 47);
            this.pnlQttBack.Name = "pnlQttBack";
            this.pnlQttBack.Size = new System.Drawing.Size(332, 74);
            this.pnlQttBack.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(15, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantidade:";
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(105, 37);
            this.nudValue.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(150, 22);
            this.nudValue.TabIndex = 6;
            this.nudValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudValue.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo:";
            // 
            // rbtWeight
            // 
            this.rbtWeight.AutoSize = true;
            this.rbtWeight.BackColor = System.Drawing.SystemColors.Control;
            this.rbtWeight.Location = new System.Drawing.Point(139, 13);
            this.rbtWeight.Name = "rbtWeight";
            this.rbtWeight.Size = new System.Drawing.Size(85, 18);
            this.rbtWeight.TabIndex = 4;
            this.rbtWeight.Text = "Peso (kg)";
            this.rbtWeight.UseVisualStyleBackColor = false;
            this.rbtWeight.CheckedChanged += new System.EventHandler(this.RbtWeight_CheckedChanged);
            // 
            // rbtUnit
            // 
            this.rbtUnit.AutoSize = true;
            this.rbtUnit.BackColor = System.Drawing.SystemColors.Control;
            this.rbtUnit.Checked = true;
            this.rbtUnit.Location = new System.Drawing.Point(59, 13);
            this.rbtUnit.Name = "rbtUnit";
            this.rbtUnit.Size = new System.Drawing.Size(74, 18);
            this.rbtUnit.TabIndex = 3;
            this.rbtUnit.TabStop = true;
            this.rbtUnit.Text = "Unitário";
            this.rbtUnit.UseVisualStyleBackColor = false;
            this.rbtUnit.CheckedChanged += new System.EventHandler(this.RbtUnit_CheckedChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.SystemColors.Control;
            this.lblType.Location = new System.Drawing.Point(255, 40);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 14);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Unid.";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(230, 15);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(216, 22);
            this.txtNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número/Identificação (Opcional):";
            // 
            // FRM_AddLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(523, 312);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_AddLot";
            this.Text = "GC - Produtos > Editando Estoque > Adicionando Lote";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlExpiresBack.ResumeLayout(false);
            this.pnlExpiresBack.PerformLayout();
            this.pnlQttBack.ResumeLayout(false);
            this.pnlQttBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlQttBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtWeight;
        private System.Windows.Forms.RadioButton rbtUnit;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel pnlExpiresBack;
        private System.Windows.Forms.CheckBox cbxExpiresIn;
        private System.Windows.Forms.DateTimePicker dtpExpiresIn;
        private System.Windows.Forms.Label label6;
        private GC.Components.CMP_BtnAdd btnAdd;
    }
}