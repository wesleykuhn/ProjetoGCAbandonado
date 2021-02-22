namespace GC.Forms.Main.Controls
{
    partial class USC_Home
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
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lkbUpdates = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lkbTutorials = new System.Windows.Forms.LinkLabel();
            this.lkbAccountTypes = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.wbsNews = new System.Windows.Forms.WebBrowser();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pnlFooter.Controls.Add(this.lkbUpdates);
            this.pnlFooter.Controls.Add(this.label2);
            this.pnlFooter.Controls.Add(this.lkbTutorials);
            this.pnlFooter.Controls.Add(this.lkbAccountTypes);
            this.pnlFooter.Controls.Add(this.label1);
            this.pnlFooter.Location = new System.Drawing.Point(0, 483);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(974, 32);
            this.pnlFooter.TabIndex = 0;
            // 
            // lkbUpdates
            // 
            this.lkbUpdates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lkbUpdates.AutoSize = true;
            this.lkbUpdates.BackColor = System.Drawing.Color.Transparent;
            this.lkbUpdates.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.lkbUpdates.Location = new System.Drawing.Point(647, 9);
            this.lkbUpdates.Name = "lkbUpdates";
            this.lkbUpdates.Size = new System.Drawing.Size(197, 14);
            this.lkbUpdates.TabIndex = 4;
            this.lkbUpdates.TabStop = true;
            this.lkbUpdates.Text = "informações das atualizações.";
            this.lkbUpdates.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(100)))), ((int)(((byte)(228)))));
            this.lkbUpdates.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbUpdates_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(632, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "e";
            // 
            // lkbTutorials
            // 
            this.lkbTutorials.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lkbTutorials.AutoSize = true;
            this.lkbTutorials.BackColor = System.Drawing.Color.Transparent;
            this.lkbTutorials.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.lkbTutorials.Location = new System.Drawing.Point(407, 9);
            this.lkbTutorials.Name = "lkbTutorials";
            this.lkbTutorials.Size = new System.Drawing.Size(225, 14);
            this.lkbTutorials.TabIndex = 2;
            this.lkbTutorials.TabStop = true;
            this.lkbTutorials.Text = "tutoriais de como usar o programa";
            this.lkbTutorials.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(100)))), ((int)(((byte)(228)))));
            this.lkbTutorials.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbTutorials_LinkClicked);
            // 
            // lkbAccountTypes
            // 
            this.lkbAccountTypes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lkbAccountTypes.AutoSize = true;
            this.lkbAccountTypes.BackColor = System.Drawing.Color.Transparent;
            this.lkbAccountTypes.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.lkbAccountTypes.Location = new System.Drawing.Point(209, 9);
            this.lkbAccountTypes.Name = "lkbAccountTypes";
            this.lkbAccountTypes.Size = new System.Drawing.Size(198, 14);
            this.lkbAccountTypes.TabIndex = 1;
            this.lkbAccountTypes.TabStop = true;
            this.lkbAccountTypes.Text = "Detalhes e preços dos planos,";
            this.lkbAccountTypes.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(100)))), ((int)(((byte)(228)))));
            this.lkbAccountTypes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbAccountTypes_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Links Úteis:";
            // 
            // wbsNews
            // 
            this.wbsNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbsNews.Location = new System.Drawing.Point(3, 3);
            this.wbsNews.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbsNews.Name = "wbsNews";
            this.wbsNews.Size = new System.Drawing.Size(968, 474);
            this.wbsNews.TabIndex = 1;
            this.wbsNews.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.wbsNews_Navigating);
            // 
            // USC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.wbsNews);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "USC_Home";
            this.Size = new System.Drawing.Size(974, 515);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.LinkLabel lkbAccountTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lkbUpdates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lkbTutorials;
        private System.Windows.Forms.WebBrowser wbsNews;
    }
}
