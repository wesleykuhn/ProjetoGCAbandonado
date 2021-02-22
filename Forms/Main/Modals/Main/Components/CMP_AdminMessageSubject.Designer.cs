namespace GC.Forms.Main.Modals.Main.Components
{
    partial class CMP_AdminMessageSubject
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpSubject = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblDelivered = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.flpSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSubject
            // 
            this.flpSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpSubject.Controls.Add(this.lblSubject);
            this.flpSubject.Location = new System.Drawing.Point(4, 4);
            this.flpSubject.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flpSubject.Name = "flpSubject";
            this.flpSubject.Size = new System.Drawing.Size(254, 36);
            this.flpSubject.TabIndex = 0;
            this.flpSubject.Click += new System.EventHandler(this.flpSubject_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubject.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(2, 2);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(2);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(67, 14);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Assunto: ";
            this.lblSubject.Click += new System.EventHandler(this.lblSubject_Click);
            // 
            // lblDelivered
            // 
            this.lblDelivered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDelivered.AutoSize = true;
            this.lblDelivered.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivered.Location = new System.Drawing.Point(6, 54);
            this.lblDelivered.Name = "lblDelivered";
            this.lblDelivered.Size = new System.Drawing.Size(129, 13);
            this.lblDelivered.TabIndex = 1;
            this.lblDelivered.Text = "20/20/2020 00:00:00";
            this.lblDelivered.Click += new System.EventHandler(this.lblDelivered_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(201, 53);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(55, 13);
            this.lblDelete.TabIndex = 3;
            this.lblDelete.Text = "(Excluir)";
            this.lblDelete.Click += new System.EventHandler(this.pnlDelete_Click);
            // 
            // cmpAdminMessageSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblDelivered);
            this.Controls.Add(this.flpSubject);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "cmpAdminMessageSubject";
            this.Size = new System.Drawing.Size(300, 70);
            this.Click += new System.EventHandler(this.cmpAdminMessageSubject_Click);
            this.flpSubject.ResumeLayout(false);
            this.flpSubject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblDelivered;
        private System.Windows.Forms.Label lblDelete;
    }
}
