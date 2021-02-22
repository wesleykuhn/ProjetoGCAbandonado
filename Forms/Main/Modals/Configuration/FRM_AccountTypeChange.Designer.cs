namespace GC.Forms.Main.Modals.Configuration
{
    partial class FRM_AccountTypeChange
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSend = new GC.Components.CMP_BtnRegular();
            this.pnlNewType = new System.Windows.Forms.Panel();
            this.rbtM = new System.Windows.Forms.RadioButton();
            this.rbtG = new System.Windows.Forms.RadioButton();
            this.rbtP = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lkbDetails = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlNewType.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.pnlNewType);
            this.panel1.Controls.Add(this.lkbDetails);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 202);
            this.panel1.TabIndex = 90;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnSend.Location = new System.Drawing.Point(10, 152);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(130, 40);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Enviar Solicitação";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pnlNewType
            // 
            this.pnlNewType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNewType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewType.Controls.Add(this.rbtM);
            this.pnlNewType.Controls.Add(this.rbtG);
            this.pnlNewType.Controls.Add(this.rbtP);
            this.pnlNewType.Controls.Add(this.label3);
            this.pnlNewType.Location = new System.Drawing.Point(10, 59);
            this.pnlNewType.Name = "pnlNewType";
            this.pnlNewType.Size = new System.Drawing.Size(476, 82);
            this.pnlNewType.TabIndex = 4;
            // 
            // rbtM
            // 
            this.rbtM.AutoSize = true;
            this.rbtM.BackColor = System.Drawing.Color.Transparent;
            this.rbtM.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtM.Location = new System.Drawing.Point(198, 41);
            this.rbtM.Name = "rbtM";
            this.rbtM.Size = new System.Drawing.Size(81, 22);
            this.rbtM.TabIndex = 6;
            this.rbtM.TabStop = true;
            this.rbtM.Text = "MÉDIO";
            this.rbtM.UseVisualStyleBackColor = false;
            // 
            // rbtG
            // 
            this.rbtG.AutoSize = true;
            this.rbtG.BackColor = System.Drawing.Color.Transparent;
            this.rbtG.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtG.Location = new System.Drawing.Point(305, 41);
            this.rbtG.Name = "rbtG";
            this.rbtG.Size = new System.Drawing.Size(94, 22);
            this.rbtG.TabIndex = 5;
            this.rbtG.TabStop = true;
            this.rbtG.Text = "GRANDE";
            this.rbtG.UseVisualStyleBackColor = false;
            // 
            // rbtP
            // 
            this.rbtP.AutoSize = true;
            this.rbtP.BackColor = System.Drawing.Color.Transparent;
            this.rbtP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtP.Location = new System.Drawing.Point(66, 41);
            this.rbtP.Name = "rbtP";
            this.rbtP.Size = new System.Drawing.Size(106, 22);
            this.rbtP.TabIndex = 4;
            this.rbtP.TabStop = true;
            this.rbtP.Text = "PEQUENO";
            this.rbtP.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(120, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Para qual plano você deseja mudar?";
            // 
            // lkbDetails
            // 
            this.lkbDetails.AutoSize = true;
            this.lkbDetails.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkbDetails.Location = new System.Drawing.Point(347, 28);
            this.lkbDetails.Name = "lkbDetails";
            this.lkbDetails.Size = new System.Drawing.Size(97, 14);
            this.lkbDetails.TabIndex = 2;
            this.lkbDetails.TabStop = true;
            this.lkbDetails.Text = "clicando aqui.";
            this.lkbDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbDetails_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(53, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "com atenção os detalhes e preços do planos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(60, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antes de solicitar a mudança do plano de sua conta veja\r\n";
            // 
            // FRM_AccountTypeChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 234);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_AccountTypeChange";
            this.Text = "GC - Configurações > Solicitando Mudança de Plano";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNewType.ResumeLayout(false);
            this.pnlNewType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lkbDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlNewType;
        private System.Windows.Forms.RadioButton rbtM;
        private System.Windows.Forms.RadioButton rbtG;
        private System.Windows.Forms.RadioButton rbtP;
        private System.Windows.Forms.Label label3;
        private GC.Components.CMP_BtnRegular btnSend;
    }
}