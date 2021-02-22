namespace GC.Forms.Main.Modals.Suppliers
{
    partial class FRM_NewSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NewSupplier));
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnAdd = new GC.Components.CMP_BtnAdd();
            this.pnlNameDesc = new System.Windows.Forms.Panel();
            this.btnCreate = new GC.Components.CMP_BtnRegular();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone_number = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lvlAddedSuppliers = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpf_cnpj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.pnlNameDesc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBackground.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBackground.Controls.Add(this.btnAdd);
            this.pnlBackground.Controls.Add(this.pnlNameDesc);
            this.pnlBackground.Controls.Add(this.label10);
            this.pnlBackground.Controls.Add(this.lvlAddedSuppliers);
            this.pnlBackground.Controls.Add(this.label11);
            this.pnlBackground.Location = new System.Drawing.Point(2, 30);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(446, 508);
            this.pnlBackground.TabIndex = 28;
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
            this.btnAdd.Location = new System.Drawing.Point(12, 458);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 40);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // pnlNameDesc
            // 
            this.pnlNameDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNameDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlNameDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNameDesc.Controls.Add(this.btnCreate);
            this.pnlNameDesc.Controls.Add(this.label1);
            this.pnlNameDesc.Controls.Add(this.txtPhone_number);
            this.pnlNameDesc.Controls.Add(this.txtName);
            this.pnlNameDesc.Controls.Add(this.label6);
            this.pnlNameDesc.Controls.Add(this.label3);
            this.pnlNameDesc.Controls.Add(this.txtDesc);
            this.pnlNameDesc.Controls.Add(this.txtEmail);
            this.pnlNameDesc.Controls.Add(this.label5);
            this.pnlNameDesc.Controls.Add(this.label4);
            this.pnlNameDesc.Controls.Add(this.txtCpfCnpj);
            this.pnlNameDesc.Controls.Add(this.label9);
            this.pnlNameDesc.Location = new System.Drawing.Point(12, 7);
            this.pnlNameDesc.Name = "pnlNameDesc";
            this.pnlNameDesc.Size = new System.Drawing.Size(424, 233);
            this.pnlNameDesc.TabIndex = 30;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Enabled = false;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCreate.Location = new System.Drawing.Point(11, 182);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 40);
            this.btnCreate.TabIndex = 39;
            this.btnCreate.Text = "Criar";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Nome:";
            // 
            // txtPhone_number
            // 
            this.txtPhone_number.Location = new System.Drawing.Point(130, 95);
            this.txtPhone_number.MaxLength = 15;
            this.txtPhone_number.Name = "txtPhone_number";
            this.txtPhone_number.Size = new System.Drawing.Size(195, 22);
            this.txtPhone_number.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 11);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(310, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(10, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 14);
            this.label6.TabIndex = 29;
            this.label6.Text = "Telefone/Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(88, 39);
            this.txtDesc.MaxLength = 50;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(307, 22);
            this.txtDesc.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(66, 67);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(10, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 14);
            this.label5.TabIndex = 27;
            this.label5.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(10, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPF/CNPJ:";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(88, 123);
            this.txtCpfCnpj.MaxLength = 14;
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(213, 22);
            this.txtCpfCnpj.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(10, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "*Campo obrigatório.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(85, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Duplo clique num item da lista para removê-lo.";
            // 
            // lvlAddedSuppliers
            // 
            this.lvlAddedSuppliers.AutoArrange = false;
            this.lvlAddedSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.description,
            this.email,
            this.phone_number,
            this.cpf_cnpj});
            this.lvlAddedSuppliers.FullRowSelect = true;
            this.lvlAddedSuppliers.GridLines = true;
            this.lvlAddedSuppliers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvlAddedSuppliers.HideSelection = false;
            this.lvlAddedSuppliers.Location = new System.Drawing.Point(12, 272);
            this.lvlAddedSuppliers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvlAddedSuppliers.MultiSelect = false;
            this.lvlAddedSuppliers.Name = "lvlAddedSuppliers";
            this.lvlAddedSuppliers.Size = new System.Drawing.Size(424, 152);
            this.lvlAddedSuppliers.TabIndex = 6;
            this.lvlAddedSuppliers.UseCompatibleStateImageBehavior = false;
            this.lvlAddedSuppliers.View = System.Windows.Forms.View.Details;
            this.lvlAddedSuppliers.DoubleClick += new System.EventHandler(this.lvlAddedSuppliers_DoubleClick);
            // 
            // name
            // 
            this.name.Text = "Nome";
            this.name.Width = 130;
            // 
            // description
            // 
            this.description.Text = "Descrição";
            this.description.Width = 150;
            // 
            // email
            // 
            this.email.Text = "E-mail";
            this.email.Width = 120;
            // 
            // phone_number
            // 
            this.phone_number.Text = "Telefone/Celular";
            this.phone_number.Width = 120;
            // 
            // cpf_cnpj
            // 
            this.cpf_cnpj.Text = "CPF/CNPJ";
            this.cpf_cnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cpf_cnpj.Width = 150;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(339, 14);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fornecedores que estão prontos para serem salvos:";
            // 
            // FRM_NewSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(450, 540);
            this.Controls.Add(this.pnlBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_NewSupplier";
            this.Text = "GC - Fornecedores > Adicionar Fornecedores";
            this.Controls.SetChildIndex(this.pnlBackground, 0);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.pnlNameDesc.ResumeLayout(false);
            this.pnlNameDesc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lvlAddedSuppliers;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader cpf_cnpj;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader phone_number;
        private System.Windows.Forms.TextBox txtPhone_number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlNameDesc;
        private GC.Components.CMP_BtnRegular btnCreate;
        private GC.Components.CMP_BtnAdd btnAdd;
    }
}