namespace GC.Forms.Main.Modals.Requests
{
    partial class FRM_SendRequestInfoToEmail
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rbtOther = new System.Windows.Forms.RadioButton();
            this.rbtCostumer = new System.Windows.Forms.RadioButton();
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
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.rbtOther);
            this.panel1.Controls.Add(this.rbtCostumer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 168);
            this.panel1.TabIndex = 37;
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
            this.btnSend.Location = new System.Drawing.Point(13, 118);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(130, 40);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(79, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(311, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // rbtOther
            // 
            this.rbtOther.AutoSize = true;
            this.rbtOther.Location = new System.Drawing.Point(13, 64);
            this.rbtOther.Name = "rbtOther";
            this.rbtOther.Size = new System.Drawing.Size(66, 18);
            this.rbtOther.TabIndex = 2;
            this.rbtOther.TabStop = true;
            this.rbtOther.Text = "Outro:";
            this.rbtOther.UseVisualStyleBackColor = true;
            this.rbtOther.CheckedChanged += new System.EventHandler(this.rbtOther_CheckedChanged);
            // 
            // rbtCostumer
            // 
            this.rbtCostumer.AutoSize = true;
            this.rbtCostumer.Location = new System.Drawing.Point(13, 36);
            this.rbtCostumer.Name = "rbtCostumer";
            this.rbtCostumer.Size = new System.Drawing.Size(249, 18);
            this.rbtCostumer.TabIndex = 1;
            this.rbtCostumer.TabStop = true;
            this.rbtCostumer.Text = "Para o e-mail do cliente do pedido: ";
            this.rbtCostumer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para qual e-mail você deseja enviar os detalhes do pedido?";
            // 
            // FRM_SendRequestInfoToEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 200);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_SendRequestInfoToEmail";
            this.Text = "GC - Pedidos > Detalhes do Pedido > Enviar Por E-mail";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rbtOther;
        private System.Windows.Forms.RadioButton rbtCostumer;
        private System.Windows.Forms.Label label1;
        private GC.Components.CMP_BtnRegular btnSend;
    }
}