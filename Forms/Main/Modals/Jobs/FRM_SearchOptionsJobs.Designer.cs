namespace GC.Forms.Main.Modals.Jobs
{
    partial class FRM_SearchOptionsJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SearchOptionsJobs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new GC.Components.CMP_BtnRegular();
            this.ckbDesc = new System.Windows.Forms.CheckBox();
            this.ckbPrice = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbName = new System.Windows.Forms.CheckBox();
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
            this.panel1.Controls.Add(this.ckbDesc);
            this.panel1.Controls.Add(this.ckbPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ckbName);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 135);
            this.panel1.TabIndex = 6;
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
            this.btnReset.Location = new System.Drawing.Point(366, 85);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 40);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "Redefinir";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // ckbDesc
            // 
            this.ckbDesc.AutoSize = true;
            this.ckbDesc.Checked = true;
            this.ckbDesc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbDesc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDesc.Location = new System.Drawing.Point(32, 60);
            this.ckbDesc.Name = "ckbDesc";
            this.ckbDesc.Size = new System.Drawing.Size(82, 17);
            this.ckbDesc.TabIndex = 1;
            this.ckbDesc.Text = "Descrição";
            this.ckbDesc.UseVisualStyleBackColor = true;
            // 
            // ckbPrice
            // 
            this.ckbPrice.AutoSize = true;
            this.ckbPrice.Checked = true;
            this.ckbPrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbPrice.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPrice.Location = new System.Drawing.Point(32, 83);
            this.ckbPrice.Name = "ckbPrice";
            this.ckbPrice.Size = new System.Drawing.Size(55, 17);
            this.ckbPrice.TabIndex = 2;
            this.ckbPrice.Text = "Valor";
            this.ckbPrice.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 14);
            this.label1.TabIndex = 27;
            this.label1.Text = "Selecione pelo o que você deseja pesquisar na lista de serviços:";
            // 
            // ckbName
            // 
            this.ckbName.AutoSize = true;
            this.ckbName.Checked = true;
            this.ckbName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbName.Location = new System.Drawing.Point(32, 37);
            this.ckbName.Name = "ckbName";
            this.ckbName.Size = new System.Drawing.Size(59, 17);
            this.ckbName.TabIndex = 0;
            this.ckbName.Text = "Nome";
            this.ckbName.UseVisualStyleBackColor = true;
            // 
            // FRM_SearchOptionsJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(500, 167);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_SearchOptionsJobs";
            this.Text = "GC - Serviços > Opções de Filtro de Pesquisa";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.CheckBox ckbDesc;
        internal System.Windows.Forms.CheckBox ckbPrice;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.CheckBox ckbName;
        private GC.Components.CMP_BtnRegular btnReset;
    }
}