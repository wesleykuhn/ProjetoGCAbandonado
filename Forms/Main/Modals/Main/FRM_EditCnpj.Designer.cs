namespace GC.Forms.Main.Modals.Main
{
    partial class FRM_EditCnpj
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
            this.btnRemoveCnpj = new GC.Components.CMP_BtnDelete();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new GC.Components.CMP_BtnRegular();
            this.txtCnpj = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.btnRemoveCnpj);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.txtCnpj);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 157);
            this.panel1.TabIndex = 0;
            // 
            // btnRemoveCnpj
            // 
            this.btnRemoveCnpj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemoveCnpj.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnRemoveCnpj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.btnRemoveCnpj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnRemoveCnpj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCnpj.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCnpj.ForeColor = System.Drawing.Color.Crimson;
            this.btnRemoveCnpj.Image = global::GC.Properties.Resources.icon_lixeira_30x30;
            this.btnRemoveCnpj.Location = new System.Drawing.Point(385, 107);
            this.btnRemoveCnpj.Name = "btnRemoveCnpj";
            this.btnRemoveCnpj.Size = new System.Drawing.Size(143, 40);
            this.btnRemoveCnpj.TabIndex = 4;
            this.btnRemoveCnpj.Text = "Deixar Sem CNPJ";
            this.btnRemoveCnpj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveCnpj.UseVisualStyleBackColor = true;
            this.btnRemoveCnpj.Click += new System.EventHandler(this.btnRemoveCnpj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "CNPJ:";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnEdit.Location = new System.Drawing.Point(10, 107);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 40);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(56, 39);
            this.txtCnpj.MaxLength = 14;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(212, 22);
            this.txtCnpj.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor, informe abaixo seu cnpj sem os pontos ou a barra, apenas os números:";
            // 
            // FRM_EditCnpj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(542, 189);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_EditCnpj";
            this.Text = "GC - Configurações > Edição de CNPJ";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private GC.Components.CMP_BtnRegular btnEdit;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private GC.Components.CMP_BtnDelete btnRemoveCnpj;
    }
}