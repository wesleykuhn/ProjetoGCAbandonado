namespace GC.Forms.NewAccount
{
    partial class FRM_NewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NewAccount));
            this.pnlBack = new System.Windows.Forms.Panel();
            this.pnlStage1 = new System.Windows.Forms.Panel();
            this.btnCreateNewAccount = new GC.Components.CMP_BtnRegular();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlUserPhoneNumberIcon = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlUserPasswordConfirmationIcon = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlUserPasswordIcon = new System.Windows.Forms.Panel();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.pnlUserEmailIcon = new System.Windows.Forms.Panel();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.pnlUserNameIcon = new System.Windows.Forms.Panel();
            this.txtUserPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserPhoneNumber = new System.Windows.Forms.TextBox();
            this.flpHelper = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHelperText = new System.Windows.Forms.Label();
            this.pnlStage2 = new System.Windows.Forms.Panel();
            this.btnFinishCreation = new GC.Components.CMP_BtnRegularGreen();
            this.label8 = new System.Windows.Forms.Label();
            this.lblInsertCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnCancel = new GC.Components.CMP_BtnRegularCrimson();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBack.SuspendLayout();
            this.pnlStage1.SuspendLayout();
            this.flpHelper.SuspendLayout();
            this.pnlStage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBack.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBack.Controls.Add(this.pnlStage1);
            this.pnlBack.Controls.Add(this.pnlStage2);
            this.pnlBack.Controls.Add(this.btnCancel);
            this.pnlBack.Controls.Add(this.label2);
            this.pnlBack.Location = new System.Drawing.Point(2, 30);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(796, 307);
            this.pnlBack.TabIndex = 0;
            // 
            // pnlStage1
            // 
            this.pnlStage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStage1.Controls.Add(this.btnCreateNewAccount);
            this.pnlStage1.Controls.Add(this.txtUserName);
            this.pnlStage1.Controls.Add(this.label1);
            this.pnlStage1.Controls.Add(this.label3);
            this.pnlStage1.Controls.Add(this.label4);
            this.pnlStage1.Controls.Add(this.pnlUserPhoneNumberIcon);
            this.pnlStage1.Controls.Add(this.label6);
            this.pnlStage1.Controls.Add(this.pnlUserPasswordConfirmationIcon);
            this.pnlStage1.Controls.Add(this.label7);
            this.pnlStage1.Controls.Add(this.pnlUserPasswordIcon);
            this.pnlStage1.Controls.Add(this.txtUserEmail);
            this.pnlStage1.Controls.Add(this.pnlUserEmailIcon);
            this.pnlStage1.Controls.Add(this.txtUserPassword);
            this.pnlStage1.Controls.Add(this.pnlUserNameIcon);
            this.pnlStage1.Controls.Add(this.txtUserPasswordConfirmation);
            this.pnlStage1.Controls.Add(this.label5);
            this.pnlStage1.Controls.Add(this.txtUserPhoneNumber);
            this.pnlStage1.Controls.Add(this.flpHelper);
            this.pnlStage1.Location = new System.Drawing.Point(3, 40);
            this.pnlStage1.Name = "pnlStage1";
            this.pnlStage1.Size = new System.Drawing.Size(788, 204);
            this.pnlStage1.TabIndex = 26;
            // 
            // btnCreateNewAccount
            // 
            this.btnCreateNewAccount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateNewAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCreateNewAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnCreateNewAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCreateNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewAccount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCreateNewAccount.Location = new System.Drawing.Point(334, 161);
            this.btnCreateNewAccount.Name = "btnCreateNewAccount";
            this.btnCreateNewAccount.Size = new System.Drawing.Size(121, 40);
            this.btnCreateNewAccount.TabIndex = 25;
            this.btnCreateNewAccount.Text = "Continuar";
            this.btnCreateNewAccount.UseVisualStyleBackColor = true;
            this.btnCreateNewAccount.Click += new System.EventHandler(this.btnCreateNewAccount_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(127, 10);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(226, 22);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_ShowInformation);
            this.txtUserName.MouseHover += new System.EventHandler(this.txtUserName_ShowInformation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome Completo:";
            // 
            // pnlUserPhoneNumberIcon
            // 
            this.pnlUserPhoneNumberIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlUserPhoneNumberIcon.Location = new System.Drawing.Point(320, 65);
            this.pnlUserPhoneNumberIcon.Name = "pnlUserPhoneNumberIcon";
            this.pnlUserPhoneNumberIcon.Size = new System.Drawing.Size(22, 22);
            this.pnlUserPhoneNumberIcon.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Confirme sua senha:";
            // 
            // pnlUserPasswordConfirmationIcon
            // 
            this.pnlUserPasswordConfirmationIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlUserPasswordConfirmationIcon.Location = new System.Drawing.Point(359, 121);
            this.pnlUserPasswordConfirmationIcon.Name = "pnlUserPasswordConfirmationIcon";
            this.pnlUserPasswordConfirmationIcon.Size = new System.Drawing.Size(22, 22);
            this.pnlUserPasswordConfirmationIcon.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "Celular:";
            // 
            // pnlUserPasswordIcon
            // 
            this.pnlUserPasswordIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlUserPasswordIcon.Location = new System.Drawing.Point(277, 93);
            this.pnlUserPasswordIcon.Name = "pnlUserPasswordIcon";
            this.pnlUserPasswordIcon.Size = new System.Drawing.Size(22, 22);
            this.pnlUserPasswordIcon.TabIndex = 18;
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(65, 38);
            this.txtUserEmail.MaxLength = 50;
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(243, 22);
            this.txtUserEmail.TabIndex = 1;
            this.txtUserEmail.TextChanged += new System.EventHandler(this.txtUserEmail_TextChanged);
            this.txtUserEmail.Enter += new System.EventHandler(this.txtUserEmail_ShowInformation);
            this.txtUserEmail.MouseHover += new System.EventHandler(this.txtUserEmail_ShowInformation);
            // 
            // pnlUserEmailIcon
            // 
            this.pnlUserEmailIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlUserEmailIcon.Location = new System.Drawing.Point(314, 38);
            this.pnlUserEmailIcon.Name = "pnlUserEmailIcon";
            this.pnlUserEmailIcon.Size = new System.Drawing.Size(22, 22);
            this.pnlUserEmailIcon.TabIndex = 17;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(67, 93);
            this.txtUserPassword.MaxLength = 14;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(204, 22);
            this.txtUserPassword.TabIndex = 3;
            this.txtUserPassword.UseSystemPasswordChar = true;
            this.txtUserPassword.TextChanged += new System.EventHandler(this.txtUserPassword_TextChanged);
            this.txtUserPassword.Enter += new System.EventHandler(this.txtUserPassword_ShowInformation);
            this.txtUserPassword.MouseHover += new System.EventHandler(this.txtUserPassword_ShowInformation);
            // 
            // pnlUserNameIcon
            // 
            this.pnlUserNameIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlUserNameIcon.Location = new System.Drawing.Point(359, 10);
            this.pnlUserNameIcon.Name = "pnlUserNameIcon";
            this.pnlUserNameIcon.Size = new System.Drawing.Size(22, 22);
            this.pnlUserNameIcon.TabIndex = 16;
            // 
            // txtUserPasswordConfirmation
            // 
            this.txtUserPasswordConfirmation.Location = new System.Drawing.Point(153, 121);
            this.txtUserPasswordConfirmation.MaxLength = 14;
            this.txtUserPasswordConfirmation.Name = "txtUserPasswordConfirmation";
            this.txtUserPasswordConfirmation.Size = new System.Drawing.Size(200, 22);
            this.txtUserPasswordConfirmation.TabIndex = 4;
            this.txtUserPasswordConfirmation.UseSystemPasswordChar = true;
            this.txtUserPasswordConfirmation.TextChanged += new System.EventHandler(this.txtUserPasswordConfirmation_TextChanged);
            this.txtUserPasswordConfirmation.Enter += new System.EventHandler(this.txtUserPasswordCOnfirmation_ShowInformation);
            this.txtUserPasswordConfirmation.MouseHover += new System.EventHandler(this.txtUserPasswordCOnfirmation_ShowInformation);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(142)))), ((int)(((byte)(152)))));
            this.label5.Location = new System.Drawing.Point(554, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "Informações:";
            // 
            // txtUserPhoneNumber
            // 
            this.txtUserPhoneNumber.Location = new System.Drawing.Point(71, 65);
            this.txtUserPhoneNumber.MaxLength = 11;
            this.txtUserPhoneNumber.Name = "txtUserPhoneNumber";
            this.txtUserPhoneNumber.Size = new System.Drawing.Size(243, 22);
            this.txtUserPhoneNumber.TabIndex = 2;
            this.txtUserPhoneNumber.TextChanged += new System.EventHandler(this.txtUserPhoneNumber_TextChanged);
            this.txtUserPhoneNumber.Enter += new System.EventHandler(this.txtUserPhoneNumber_ShowInformation);
            this.txtUserPhoneNumber.MouseHover += new System.EventHandler(this.txtUserPhoneNumber_ShowInformation);
            // 
            // flpHelper
            // 
            this.flpHelper.BackColor = System.Drawing.Color.Gainsboro;
            this.flpHelper.Controls.Add(this.lblHelperText);
            this.flpHelper.Location = new System.Drawing.Point(412, 26);
            this.flpHelper.Margin = new System.Windows.Forms.Padding(7);
            this.flpHelper.Name = "flpHelper";
            this.flpHelper.Size = new System.Drawing.Size(367, 118);
            this.flpHelper.TabIndex = 13;
            // 
            // lblHelperText
            // 
            this.lblHelperText.AutoSize = true;
            this.lblHelperText.BackColor = System.Drawing.Color.Gainsboro;
            this.lblHelperText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHelperText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHelperText.Location = new System.Drawing.Point(3, 1);
            this.lblHelperText.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblHelperText.Name = "lblHelperText";
            this.lblHelperText.Size = new System.Drawing.Size(63, 14);
            this.lblHelperText.TabIndex = 0;
            this.lblHelperText.Text = "Test Text";
            this.lblHelperText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlStage2
            // 
            this.pnlStage2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStage2.Controls.Add(this.btnFinishCreation);
            this.pnlStage2.Controls.Add(this.label8);
            this.pnlStage2.Controls.Add(this.lblInsertCode);
            this.pnlStage2.Controls.Add(this.txtCode);
            this.pnlStage2.Location = new System.Drawing.Point(3, 40);
            this.pnlStage2.Name = "pnlStage2";
            this.pnlStage2.Size = new System.Drawing.Size(788, 204);
            this.pnlStage2.TabIndex = 27;
            // 
            // btnFinishCreation
            // 
            this.btnFinishCreation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFinishCreation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnFinishCreation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(91)))));
            this.btnFinishCreation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnFinishCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishCreation.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishCreation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnFinishCreation.Location = new System.Drawing.Point(331, 163);
            this.btnFinishCreation.Name = "btnFinishCreation";
            this.btnFinishCreation.Size = new System.Drawing.Size(126, 38);
            this.btnFinishCreation.TabIndex = 27;
            this.btnFinishCreation.Text = "CRIAR!";
            this.btnFinishCreation.UseVisualStyleBackColor = true;
            this.btnFinishCreation.Click += new System.EventHandler(this.btnFinishCreation_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(142)))), ((int)(((byte)(152)))));
            this.label8.Location = new System.Drawing.Point(23, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(742, 32);
            this.label8.TabIndex = 26;
            this.label8.Text = "Dica: Não se esqueça de verificar se o e-mail enviado está na sua lixeira. \r\nSe v" +
    "ocê não recebeu o e-mail, por favor, clique em Cancelar e tente criar uma conta " +
    "com um e-mail diferente.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInsertCode
            // 
            this.lblInsertCode.AutoSize = true;
            this.lblInsertCode.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertCode.Location = new System.Drawing.Point(149, 71);
            this.lblInsertCode.Margin = new System.Windows.Forms.Padding(3);
            this.lblInsertCode.Name = "lblInsertCode";
            this.lblInsertCode.Size = new System.Drawing.Size(490, 16);
            this.lblInsertCode.TabIndex = 20;
            this.lblInsertCode.Text = "Por favor, digite o código que você recebeu por e-mail no campo abaixo:";
            this.lblInsertCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(317, 97);
            this.txtCode.MaxLength = 6;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(155, 37);
            this.txtCode.TabIndex = 6;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Crimson;
            this.btnCancel.Location = new System.Drawing.Point(347, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 33);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(527, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preencha os dados abaixo para criar uma nova conta:";
            // 
            // FRM_NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.pnlBack);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_NewAccount";
            this.ShowInTaskbar = true;
            this.Text = "GC - Criação de Conta";
            this.Controls.SetChildIndex(this.pnlBack, 0);
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            this.pnlStage1.ResumeLayout(false);
            this.pnlStage1.PerformLayout();
            this.flpHelper.ResumeLayout(false);
            this.flpHelper.PerformLayout();
            this.pnlStage2.ResumeLayout(false);
            this.pnlStage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.FlowLayoutPanel flpHelper;
        private System.Windows.Forms.TextBox txtUserPhoneNumber;
        private System.Windows.Forms.TextBox txtUserPasswordConfirmation;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHelperText;
        private System.Windows.Forms.Panel pnlUserPhoneNumberIcon;
        private System.Windows.Forms.Panel pnlUserPasswordConfirmationIcon;
        private System.Windows.Forms.Panel pnlUserPasswordIcon;
        private System.Windows.Forms.Panel pnlUserEmailIcon;
        private System.Windows.Forms.Panel pnlUserNameIcon;
        private System.Windows.Forms.Label lblInsertCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Panel pnlStage2;
        private System.Windows.Forms.Panel pnlStage1;
        private System.Windows.Forms.Label label8;
        private Components.CMP_BtnRegular btnCreateNewAccount;
        private Components.CMP_BtnRegularGreen btnFinishCreation;
        private Components.CMP_BtnRegularCrimson btnCancel;
    }
}