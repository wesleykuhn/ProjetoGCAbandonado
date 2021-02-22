namespace GC.Forms.Main.Components
{
    partial class CMP_RequestLittleBox
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
            this.components = new System.ComponentModel.Container();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblStarted = new System.Windows.Forms.Label();
            this.lblExpires = new System.Windows.Forms.Label();
            this.lblCostumer = new System.Windows.Forms.Label();
            this.pnlIsDelivery = new System.Windows.Forms.Panel();
            this.lblObservations = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHasInDb = new System.Windows.Forms.Panel();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumber.Location = new System.Drawing.Point(2, 4);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(109, 20);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "0123456789";
            this.lblNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblNumber_MouseClick);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblValue.Location = new System.Drawing.Point(4, 40);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(45, 13);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Valor: ";
            this.lblValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblValue_MouseClick);
            // 
            // lblStarted
            // 
            this.lblStarted.AutoSize = true;
            this.lblStarted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStarted.Location = new System.Drawing.Point(4, 25);
            this.lblStarted.Name = "lblStarted";
            this.lblStarted.Size = new System.Drawing.Size(47, 13);
            this.lblStarted.TabIndex = 3;
            this.lblStarted.Text = "Início: ";
            this.lblStarted.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblStarted_MouseClick);
            // 
            // lblExpires
            // 
            this.lblExpires.AutoSize = true;
            this.lblExpires.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblExpires.Location = new System.Drawing.Point(4, 70);
            this.lblExpires.Name = "lblExpires";
            this.lblExpires.Size = new System.Drawing.Size(82, 13);
            this.lblExpires.TabIndex = 4;
            this.lblExpires.Text = "Vencimento: ";
            this.lblExpires.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblExpires_MouseClick);
            // 
            // lblCostumer
            // 
            this.lblCostumer.AutoSize = true;
            this.lblCostumer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCostumer.Location = new System.Drawing.Point(4, 55);
            this.lblCostumer.Name = "lblCostumer";
            this.lblCostumer.Size = new System.Drawing.Size(56, 13);
            this.lblCostumer.TabIndex = 5;
            this.lblCostumer.Text = "Cliente: ";
            this.lblCostumer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblCostumer_MouseClick);
            // 
            // pnlIsDelivery
            // 
            this.pnlIsDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlIsDelivery.Location = new System.Drawing.Point(246, 5);
            this.pnlIsDelivery.Name = "pnlIsDelivery";
            this.pnlIsDelivery.Size = new System.Drawing.Size(30, 30);
            this.pnlIsDelivery.TabIndex = 7;
            this.ToolTip1.SetToolTip(this.pnlIsDelivery, "Este pedido, ou parte dele, deverá ser entregue ao cliente.");
            this.pnlIsDelivery.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlIsDelivery_MouseClick);
            // 
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblObservations.Location = new System.Drawing.Point(0, 0);
            this.lblObservations.Margin = new System.Windows.Forms.Padding(0);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(90, 13);
            this.lblObservations.TabIndex = 9;
            this.lblObservations.Text = "Observações: ";
            this.lblObservations.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblObservations_MouseClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.lblObservations);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 84);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(272, 37);
            this.flowLayoutPanel1.TabIndex = 10;
            this.flowLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FlowLayoutPanel1_MouseClick);
            // 
            // pnlHasInDb
            // 
            this.pnlHasInDb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHasInDb.Location = new System.Drawing.Point(210, 5);
            this.pnlHasInDb.Name = "pnlHasInDb";
            this.pnlHasInDb.Size = new System.Drawing.Size(30, 30);
            this.pnlHasInDb.TabIndex = 8;
            this.pnlHasInDb.Tag = "";
            this.ToolTip1.SetToolTip(this.pnlHasInDb, "Este pedido não está salvo na sua conta! Está salvo apenas neste computador. Por " +
        "isso, você só\r\npoderá ver detalhes, mudar a situação, alterar e excluir ele apen" +
        "as neste computador.");
            this.pnlHasInDb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlHasInDb_MouseClick);
            // 
            // ToolTip1
            // 
            this.ToolTip1.AutoPopDelay = 15000;
            this.ToolTip1.InitialDelay = 500;
            this.ToolTip1.ReshowDelay = 100;
            // 
            // cmpRequestLittleBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlHasInDb);
            this.Controls.Add(this.pnlIsDelivery);
            this.Controls.Add(this.lblCostumer);
            this.Controls.Add(this.lblExpires);
            this.Controls.Add(this.lblStarted);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblNumber);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "cmpRequestLittleBox";
            this.Size = new System.Drawing.Size(280, 126);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmpRequestLittleBox_MouseClick);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblStarted;
        private System.Windows.Forms.Label lblExpires;
        private System.Windows.Forms.Label lblCostumer;
        private System.Windows.Forms.Panel pnlIsDelivery;
        private System.Windows.Forms.Panel pnlHasInDb;
        private System.Windows.Forms.Label lblObservations;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolTip ToolTip1;
    }
}
