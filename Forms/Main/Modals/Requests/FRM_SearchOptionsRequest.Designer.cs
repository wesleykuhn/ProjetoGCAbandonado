namespace GC.Forms.Main.Modals.Requests
{
    partial class FRM_SearchOptionsRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SearchOptionsRequest));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new GC.Components.CMP_BtnRegular();
            this.cbkIsDelivery = new System.Windows.Forms.CheckBox();
            this.ckbObservations = new System.Windows.Forms.CheckBox();
            this.ckbExpire = new System.Windows.Forms.CheckBox();
            this.ckbCostumer = new System.Windows.Forms.CheckBox();
            this.ckbValue = new System.Windows.Forms.CheckBox();
            this.ckbStart = new System.Windows.Forms.CheckBox();
            this.ckbNumber = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.cbkIsDelivery);
            this.panel1.Controls.Add(this.ckbObservations);
            this.panel1.Controls.Add(this.ckbExpire);
            this.panel1.Controls.Add(this.ckbCostumer);
            this.panel1.Controls.Add(this.ckbValue);
            this.panel1.Controls.Add(this.ckbStart);
            this.panel1.Controls.Add(this.ckbNumber);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 225);
            this.panel1.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnReset.Location = new System.Drawing.Point(306, 175);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 40);
            this.btnReset.TabIndex = 42;
            this.btnReset.Text = "Redefinir";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // cbkIsDelivery
            // 
            this.cbkIsDelivery.AutoSize = true;
            this.cbkIsDelivery.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkIsDelivery.Location = new System.Drawing.Point(37, 176);
            this.cbkIsDelivery.Name = "cbkIsDelivery";
            this.cbkIsDelivery.Size = new System.Drawing.Size(168, 17);
            this.cbkIsDelivery.TabIndex = 37;
            this.cbkIsDelivery.Text = "Mostrar apenas entregas";
            this.cbkIsDelivery.UseVisualStyleBackColor = true;
            // 
            // ckbObservations
            // 
            this.ckbObservations.AutoSize = true;
            this.ckbObservations.Checked = true;
            this.ckbObservations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbObservations.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbObservations.Location = new System.Drawing.Point(37, 153);
            this.ckbObservations.Name = "ckbObservations";
            this.ckbObservations.Size = new System.Drawing.Size(100, 17);
            this.ckbObservations.TabIndex = 35;
            this.ckbObservations.Text = "Observações";
            this.ckbObservations.UseVisualStyleBackColor = true;
            // 
            // ckbExpire
            // 
            this.ckbExpire.AutoSize = true;
            this.ckbExpire.Checked = true;
            this.ckbExpire.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbExpire.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbExpire.Location = new System.Drawing.Point(37, 130);
            this.ckbExpire.Name = "ckbExpire";
            this.ckbExpire.Size = new System.Drawing.Size(141, 17);
            this.ckbExpire.TabIndex = 34;
            this.ckbExpire.Text = "Data de vencimento";
            this.ckbExpire.UseVisualStyleBackColor = true;
            // 
            // ckbCostumer
            // 
            this.ckbCostumer.AutoSize = true;
            this.ckbCostumer.Checked = true;
            this.ckbCostumer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbCostumer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCostumer.Location = new System.Drawing.Point(37, 107);
            this.ckbCostumer.Name = "ckbCostumer";
            this.ckbCostumer.Size = new System.Drawing.Size(66, 17);
            this.ckbCostumer.TabIndex = 33;
            this.ckbCostumer.Text = "Cliente";
            this.ckbCostumer.UseVisualStyleBackColor = true;
            // 
            // ckbValue
            // 
            this.ckbValue.AutoSize = true;
            this.ckbValue.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbValue.Location = new System.Drawing.Point(37, 84);
            this.ckbValue.Name = "ckbValue";
            this.ckbValue.Size = new System.Drawing.Size(55, 17);
            this.ckbValue.TabIndex = 36;
            this.ckbValue.Text = "Valor";
            this.ckbValue.UseVisualStyleBackColor = true;
            // 
            // ckbStart
            // 
            this.ckbStart.AutoSize = true;
            this.ckbStart.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStart.Location = new System.Drawing.Point(37, 61);
            this.ckbStart.Name = "ckbStart";
            this.ckbStart.Size = new System.Drawing.Size(104, 17);
            this.ckbStart.TabIndex = 32;
            this.ckbStart.Text = "Data de início";
            this.ckbStart.UseVisualStyleBackColor = true;
            // 
            // ckbNumber
            // 
            this.ckbNumber.AutoSize = true;
            this.ckbNumber.Checked = true;
            this.ckbNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbNumber.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNumber.Location = new System.Drawing.Point(37, 38);
            this.ckbNumber.Name = "ckbNumber";
            this.ckbNumber.Size = new System.Drawing.Size(71, 17);
            this.ckbNumber.TabIndex = 31;
            this.ckbNumber.Text = "Número";
            this.ckbNumber.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 14);
            this.label4.TabIndex = 30;
            this.label4.Text = "de pedidos:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 14);
            this.label1.TabIndex = 28;
            this.label1.Text = "Selecione pelo o que você deseja pesquisar no quadro";
            // 
            // FRM_SearchOptionsRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(440, 257);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_SearchOptionsRequest";
            this.Text = "GC - Pedidos > Opções de Filtro de Pesquisa";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.CheckBox ckbObservations;
        internal System.Windows.Forms.CheckBox ckbExpire;
        internal System.Windows.Forms.CheckBox ckbCostumer;
        internal System.Windows.Forms.CheckBox ckbValue;
        internal System.Windows.Forms.CheckBox ckbStart;
        internal System.Windows.Forms.CheckBox ckbNumber;
        internal System.Windows.Forms.CheckBox cbkIsDelivery;
        private GC.Components.CMP_BtnRegular btnReset;
    }
}