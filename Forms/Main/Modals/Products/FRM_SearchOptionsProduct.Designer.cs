namespace GC.Forms.Main.Modals.Products
{
    partial class FRM_SearchOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SearchOptions));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new GC.Components.CMP_BtnRegular();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbWeight = new System.Windows.Forms.CheckBox();
            this.ckbPackQuant = new System.Windows.Forms.CheckBox();
            this.ckbPos = new System.Windows.Forms.CheckBox();
            this.ckbPrice = new System.Windows.Forms.CheckBox();
            this.ckbDesc = new System.Windows.Forms.CheckBox();
            this.ckbCode = new System.Windows.Forms.CheckBox();
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ckbWeight);
            this.panel1.Controls.Add(this.ckbPackQuant);
            this.panel1.Controls.Add(this.ckbPos);
            this.panel1.Controls.Add(this.ckbPrice);
            this.panel1.Controls.Add(this.ckbDesc);
            this.panel1.Controls.Add(this.ckbCode);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 183);
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
            this.btnReset.Location = new System.Drawing.Point(366, 133);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 40);
            this.btnReset.TabIndex = 41;
            this.btnReset.Text = "Redefinir";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 14);
            this.label1.TabIndex = 27;
            this.label1.Text = "Selecione pelo o que você deseja pesquisar na lista de produtos:";
            // 
            // ckbWeight
            // 
            this.ckbWeight.AutoSize = true;
            this.ckbWeight.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbWeight.Location = new System.Drawing.Point(37, 152);
            this.ckbWeight.Name = "ckbWeight";
            this.ckbWeight.Size = new System.Drawing.Size(81, 17);
            this.ckbWeight.TabIndex = 6;
            this.ckbWeight.Text = "Peso (kg)";
            this.ckbWeight.UseVisualStyleBackColor = true;
            // 
            // ckbPackQuant
            // 
            this.ckbPackQuant.AutoSize = true;
            this.ckbPackQuant.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPackQuant.Location = new System.Drawing.Point(37, 129);
            this.ckbPackQuant.Name = "ckbPackQuant";
            this.ckbPackQuant.Size = new System.Drawing.Size(92, 17);
            this.ckbPackQuant.TabIndex = 5;
            this.ckbPackQuant.Text = "Qtd. Pacote";
            this.ckbPackQuant.UseVisualStyleBackColor = true;
            // 
            // ckbPos
            // 
            this.ckbPos.AutoSize = true;
            this.ckbPos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPos.Location = new System.Drawing.Point(37, 106);
            this.ckbPos.Name = "ckbPos";
            this.ckbPos.Size = new System.Drawing.Size(127, 17);
            this.ckbPos.TabIndex = 4;
            this.ckbPos.Text = "Endereço/Posição";
            this.ckbPos.UseVisualStyleBackColor = true;
            // 
            // ckbPrice
            // 
            this.ckbPrice.AutoSize = true;
            this.ckbPrice.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPrice.Location = new System.Drawing.Point(37, 83);
            this.ckbPrice.Name = "ckbPrice";
            this.ckbPrice.Size = new System.Drawing.Size(58, 17);
            this.ckbPrice.TabIndex = 13;
            this.ckbPrice.Text = "Preço";
            this.ckbPrice.UseVisualStyleBackColor = true;
            // 
            // ckbDesc
            // 
            this.ckbDesc.AutoSize = true;
            this.ckbDesc.Checked = true;
            this.ckbDesc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbDesc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDesc.Location = new System.Drawing.Point(37, 60);
            this.ckbDesc.Name = "ckbDesc";
            this.ckbDesc.Size = new System.Drawing.Size(82, 17);
            this.ckbDesc.TabIndex = 1;
            this.ckbDesc.Text = "Descrição";
            this.ckbDesc.UseVisualStyleBackColor = true;
            // 
            // ckbCode
            // 
            this.ckbCode.AutoSize = true;
            this.ckbCode.Checked = true;
            this.ckbCode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbCode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCode.Location = new System.Drawing.Point(37, 37);
            this.ckbCode.Name = "ckbCode";
            this.ckbCode.Size = new System.Drawing.Size(66, 17);
            this.ckbCode.TabIndex = 0;
            this.ckbCode.Text = "Código";
            this.ckbCode.UseVisualStyleBackColor = true;
            // 
            // FRM_SearchOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(500, 215);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_SearchOptions";
            this.Text = "GC - Produtos > Opções de FIltro de Pesquisa";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.CheckBox ckbWeight;
        internal System.Windows.Forms.CheckBox ckbPackQuant;
        internal System.Windows.Forms.CheckBox ckbPos;
        internal System.Windows.Forms.CheckBox ckbPrice;
        internal System.Windows.Forms.CheckBox ckbDesc;
        internal System.Windows.Forms.CheckBox ckbCode;
        private GC.Components.CMP_BtnRegular btnReset;
    }
}