namespace GC.Forms.ForgotPassword
{
    partial class FRM_ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ForgotPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new GC.Components.CMP_BtnDelete();
            this.btnContinue = new GC.Components.CMP_BtnRegular();
            this.pnlStage1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlStage2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.pnlStage3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlStage1.SuspendLayout();
            this.pnlStage2.SuspendLayout();
            this.pnlStage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnContinue);
            this.panel1.Controls.Add(this.pnlStage1);
            this.panel1.Controls.Add(this.pnlStage2);
            this.panel1.Controls.Add(this.pnlStage3);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 193);
            this.panel1.TabIndex = 3;
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
            this.btnCancel.Location = new System.Drawing.Point(260, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnContinue.Location = new System.Drawing.Point(253, 89);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(90, 32);
            this.btnContinue.TabIndex = 11;
            this.btnContinue.Text = "Continuar";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // pnlStage1
            // 
            this.pnlStage1.Controls.Add(this.label1);
            this.pnlStage1.Controls.Add(this.txtEmail);
            this.pnlStage1.Location = new System.Drawing.Point(10, 8);
            this.pnlStage1.Name = "pnlStage1";
            this.pnlStage1.Size = new System.Drawing.Size(576, 80);
            this.pnlStage1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Por favor, insira seu e-mail no campo abaixo e clique em continuar:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(145, 26);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 22);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlStage2
            // 
            this.pnlStage2.Controls.Add(this.label3);
            this.pnlStage2.Controls.Add(this.txtPhoneNumber);
            this.pnlStage2.Location = new System.Drawing.Point(10, 8);
            this.pnlStage2.Name = "pnlStage2";
            this.pnlStage2.Size = new System.Drawing.Size(576, 80);
            this.pnlStage2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Agora, insira o número do seu celular:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(145, 26);
            this.txtPhoneNumber.MaxLength = 11;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(286, 22);
            this.txtPhoneNumber.TabIndex = 0;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlStage3
            // 
            this.pnlStage3.Controls.Add(this.label5);
            this.pnlStage3.Controls.Add(this.txtCode);
            this.pnlStage3.Location = new System.Drawing.Point(10, 8);
            this.pnlStage3.Name = "pnlStage3";
            this.pnlStage3.Size = new System.Drawing.Size(576, 80);
            this.pnlStage3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(448, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Por fim, insira o código que você recebeu por e-mail no campo abaixo:";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(217, 23);
            this.txtCode.MaxLength = 6;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(155, 37);
            this.txtCode.TabIndex = 7;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FRM_ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(600, 225);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_ForgotPassword";
            this.Text = "GC - Recuperação de Senha";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.pnlStage1.ResumeLayout(false);
            this.pnlStage1.PerformLayout();
            this.pnlStage2.ResumeLayout(false);
            this.pnlStage2.PerformLayout();
            this.pnlStage3.ResumeLayout(false);
            this.pnlStage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Panel pnlStage3;
        private System.Windows.Forms.Panel pnlStage1;
        private System.Windows.Forms.Panel pnlStage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private Components.CMP_BtnRegular btnContinue;
        private Components.CMP_BtnDelete btnCancel;
    }
}