namespace GC.Forms.Main.Modals.Costumers
{
    partial class FRM_NewCostumer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NewCostumer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new GC.Components.CMP_BtnAdd();
            this.pnlAddressBack = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtComplement = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlPersonalDataBack = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.ckbWhatspp = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtMan = new System.Windows.Forms.RadioButton();
            this.rbtWoman = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_SearchCep = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlAddressBack.SuspendLayout();
            this.pnlPersonalDataBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.pnlAddressBack);
            this.panel1.Controls.Add(this.pnlPersonalDataBack);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 438);
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
            this.btnAdd.Location = new System.Drawing.Point(9, 388);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 40);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // pnlAddressBack
            // 
            this.pnlAddressBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddressBack.Controls.Add(this.BTN_SearchCep);
            this.pnlAddressBack.Controls.Add(this.label15);
            this.pnlAddressBack.Controls.Add(this.txtStreet);
            this.pnlAddressBack.Controls.Add(this.txtCep);
            this.pnlAddressBack.Controls.Add(this.txtNumber);
            this.pnlAddressBack.Controls.Add(this.label14);
            this.pnlAddressBack.Controls.Add(this.txtCountry);
            this.pnlAddressBack.Controls.Add(this.label8);
            this.pnlAddressBack.Controls.Add(this.label13);
            this.pnlAddressBack.Controls.Add(this.txtComplement);
            this.pnlAddressBack.Controls.Add(this.txtState);
            this.pnlAddressBack.Controls.Add(this.label9);
            this.pnlAddressBack.Controls.Add(this.label12);
            this.pnlAddressBack.Controls.Add(this.txtReference);
            this.pnlAddressBack.Controls.Add(this.txtCity);
            this.pnlAddressBack.Controls.Add(this.label10);
            this.pnlAddressBack.Controls.Add(this.label11);
            this.pnlAddressBack.Controls.Add(this.txtDistrict);
            this.pnlAddressBack.Controls.Add(this.label6);
            this.pnlAddressBack.Controls.Add(this.label7);
            this.pnlAddressBack.Location = new System.Drawing.Point(9, 129);
            this.pnlAddressBack.Name = "pnlAddressBack";
            this.pnlAddressBack.Size = new System.Drawing.Size(520, 232);
            this.pnlAddressBack.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(5, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "*Campos obrigatórios.";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(90, 36);
            this.txtStreet.MaxLength = 70;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(304, 22);
            this.txtStreet.TabIndex = 8;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(48, 8);
            this.txtCep.MaxLength = 8;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(179, 22);
            this.txtCep.TabIndex = 6;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            this.txtCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCep_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(5, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 14);
            this.label14.TabIndex = 46;
            this.label14.Text = "CEP:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(431, 36);
            this.txtNumber.MaxLength = 6;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(70, 22);
            this.txtNumber.TabIndex = 9;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(48, 176);
            this.txtCountry.MaxLength = 30;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(188, 22);
            this.txtCountry.TabIndex = 15;
            this.txtCountry.Text = "Brasil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(5, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 14);
            this.label8.TabIndex = 34;
            this.label8.Text = "Complemento:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(5, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 14);
            this.label13.TabIndex = 44;
            this.label13.Text = "País:";
            // 
            // txtComplement
            // 
            this.txtComplement.Location = new System.Drawing.Point(110, 64);
            this.txtComplement.MaxLength = 50;
            this.txtComplement.Name = "txtComplement";
            this.txtComplement.Size = new System.Drawing.Size(293, 22);
            this.txtComplement.TabIndex = 10;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(311, 148);
            this.txtState.MaxLength = 30;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(186, 22);
            this.txtState.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(5, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 14);
            this.label9.TabIndex = 36;
            this.label9.Text = "Referência:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(249, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 14);
            this.label12.TabIndex = 42;
            this.label12.Text = "Estado:";
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(90, 92);
            this.txtReference.MaxLength = 50;
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(314, 22);
            this.txtReference.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(67, 148);
            this.txtCity.MaxLength = 35;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(169, 22);
            this.txtCity.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(5, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 14);
            this.label10.TabIndex = 38;
            this.label10.Text = "Bairro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(5, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 14);
            this.label11.TabIndex = 40;
            this.label11.Text = "Cidade:";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(57, 120);
            this.txtDistrict.MaxLength = 50;
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(345, 22);
            this.txtDistrict.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(5, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 14);
            this.label6.TabIndex = 30;
            this.label6.Text = "*Endereço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(394, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 14);
            this.label7.TabIndex = 32;
            this.label7.Text = "*N°:";
            // 
            // pnlPersonalDataBack
            // 
            this.pnlPersonalDataBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPersonalDataBack.Controls.Add(this.txtName);
            this.pnlPersonalDataBack.Controls.Add(this.label1);
            this.pnlPersonalDataBack.Controls.Add(this.label3);
            this.pnlPersonalDataBack.Controls.Add(this.txtEmail);
            this.pnlPersonalDataBack.Controls.Add(this.txtPhoneNumber);
            this.pnlPersonalDataBack.Controls.Add(this.ckbWhatspp);
            this.pnlPersonalDataBack.Controls.Add(this.label5);
            this.pnlPersonalDataBack.Controls.Add(this.rbtMan);
            this.pnlPersonalDataBack.Controls.Add(this.rbtWoman);
            this.pnlPersonalDataBack.Controls.Add(this.label4);
            this.pnlPersonalDataBack.Location = new System.Drawing.Point(7, 6);
            this.pnlPersonalDataBack.Name = "pnlPersonalDataBack";
            this.pnlPersonalDataBack.Size = new System.Drawing.Size(522, 115);
            this.pnlPersonalDataBack.TabIndex = 49;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 6);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(342, 22);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "*Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(63, 34);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(342, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(135, 62);
            this.txtPhoneNumber.MaxLength = 15;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(220, 22);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // ckbWhatspp
            // 
            this.ckbWhatspp.AutoSize = true;
            this.ckbWhatspp.BackColor = System.Drawing.Color.Transparent;
            this.ckbWhatspp.Location = new System.Drawing.Point(361, 64);
            this.ckbWhatspp.Name = "ckbWhatspp";
            this.ckbWhatspp.Size = new System.Drawing.Size(103, 18);
            this.ckbWhatspp.TabIndex = 3;
            this.ckbWhatspp.Text = "É Whatsapp";
            this.ckbWhatspp.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(7, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 27;
            this.label5.Text = "*Sexo:";
            // 
            // rbtMan
            // 
            this.rbtMan.AutoSize = true;
            this.rbtMan.BackColor = System.Drawing.Color.Transparent;
            this.rbtMan.Checked = true;
            this.rbtMan.Location = new System.Drawing.Point(59, 89);
            this.rbtMan.Name = "rbtMan";
            this.rbtMan.Size = new System.Drawing.Size(86, 18);
            this.rbtMan.TabIndex = 4;
            this.rbtMan.TabStop = true;
            this.rbtMan.Text = "Masculino";
            this.rbtMan.UseVisualStyleBackColor = false;
            // 
            // rbtWoman
            // 
            this.rbtWoman.AutoSize = true;
            this.rbtWoman.BackColor = System.Drawing.Color.Transparent;
            this.rbtWoman.Location = new System.Drawing.Point(151, 89);
            this.rbtWoman.Name = "rbtWoman";
            this.rbtWoman.Size = new System.Drawing.Size(81, 18);
            this.rbtWoman.TabIndex = 5;
            this.rbtWoman.Text = "Feminino";
            this.rbtWoman.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 14);
            this.label4.TabIndex = 24;
            this.label4.Text = "*Telefone/Celular:";
            // 
            // BTN_SearchCep
            // 
            this.BTN_SearchCep.Location = new System.Drawing.Point(234, 8);
            this.BTN_SearchCep.Name = "BTN_SearchCep";
            this.BTN_SearchCep.Size = new System.Drawing.Size(90, 22);
            this.BTN_SearchCep.TabIndex = 7;
            this.BTN_SearchCep.Text = "Procurar";
            this.BTN_SearchCep.UseVisualStyleBackColor = true;
            this.BTN_SearchCep.Click += new System.EventHandler(this.BTN_SearchCep_Click);
            // 
            // FRM_NewCostumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(540, 470);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_NewCostumer";
            this.Text = "GC - Clientes > Adicionar Cliente";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.pnlAddressBack.ResumeLayout(false);
            this.pnlAddressBack.PerformLayout();
            this.pnlPersonalDataBack.ResumeLayout(false);
            this.pnlPersonalDataBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbWhatspp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtWoman;
        private System.Windows.Forms.RadioButton rbtMan;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtComplement;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlPersonalDataBack;
        private System.Windows.Forms.Panel pnlAddressBack;
        private GC.Components.CMP_BtnAdd btnAdd;
        private System.Windows.Forms.Button BTN_SearchCep;
    }
}