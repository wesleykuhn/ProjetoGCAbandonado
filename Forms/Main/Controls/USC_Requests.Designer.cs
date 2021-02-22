namespace GC.Forms.Main.Controls
{
    partial class USC_Requests
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
            this.lblRequestsCount = new System.Windows.Forms.Label();
            this.tbcTabs = new System.Windows.Forms.TabControl();
            this.tabOpen = new System.Windows.Forms.TabPage();
            this.flpTabOpen = new System.Windows.Forms.FlowLayoutPanel();
            this.tabLate = new System.Windows.Forms.TabPage();
            this.flpTabLate = new System.Windows.Forms.FlowLayoutPanel();
            this.tabDone = new System.Windows.Forms.TabPage();
            this.flpTabDone = new System.Windows.Forms.FlowLayoutPanel();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.flpTabAll = new System.Windows.Forms.FlowLayoutPanel();
            this.tabCancelled = new System.Windows.Forms.TabPage();
            this.flpTabCancelled = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsMenuPedidos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alterarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchOptions = new GC.Components.CMP_BtnRegular();
            this.btnRefresh = new GC.Components.CMP_BtnRegular();
            this.btnShowOld = new GC.Components.CMP_BtnRegular();
            this.btnNewRequest = new GC.Components.CMP_BtnAdd();
            this.tbcTabs.SuspendLayout();
            this.tabOpen.SuspendLayout();
            this.tabLate.SuspendLayout();
            this.tabDone.SuspendLayout();
            this.tabAll.SuspendLayout();
            this.tabCancelled.SuspendLayout();
            this.cmsMenuPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRequestsCount
            // 
            this.lblRequestsCount.AutoSize = true;
            this.lblRequestsCount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestsCount.Location = new System.Drawing.Point(4, 4);
            this.lblRequestsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestsCount.Name = "lblRequestsCount";
            this.lblRequestsCount.Size = new System.Drawing.Size(122, 14);
            this.lblRequestsCount.TabIndex = 13;
            this.lblRequestsCount.Text = "Todos os Pedidos:";
            // 
            // tbcTabs
            // 
            this.tbcTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcTabs.Controls.Add(this.tabOpen);
            this.tbcTabs.Controls.Add(this.tabLate);
            this.tbcTabs.Controls.Add(this.tabDone);
            this.tbcTabs.Controls.Add(this.tabAll);
            this.tbcTabs.Controls.Add(this.tabCancelled);
            this.tbcTabs.Location = new System.Drawing.Point(4, 27);
            this.tbcTabs.Name = "tbcTabs";
            this.tbcTabs.SelectedIndex = 0;
            this.tbcTabs.Size = new System.Drawing.Size(966, 437);
            this.tbcTabs.TabIndex = 14;
            this.tbcTabs.SelectedIndexChanged += new System.EventHandler(this.TbcTabs_SelectedIndexChanged);
            this.tbcTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.TbcTabs_Selected);
            // 
            // tabOpen
            // 
            this.tabOpen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabOpen.Controls.Add(this.flpTabOpen);
            this.tabOpen.Location = new System.Drawing.Point(4, 23);
            this.tabOpen.Name = "tabOpen";
            this.tabOpen.Padding = new System.Windows.Forms.Padding(3);
            this.tabOpen.Size = new System.Drawing.Size(958, 410);
            this.tabOpen.TabIndex = 1;
            this.tabOpen.Text = "Pendentes";
            // 
            // flpTabOpen
            // 
            this.flpTabOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTabOpen.AutoScroll = true;
            this.flpTabOpen.BackColor = System.Drawing.SystemColors.Window;
            this.flpTabOpen.Location = new System.Drawing.Point(0, 0);
            this.flpTabOpen.Name = "flpTabOpen";
            this.flpTabOpen.Size = new System.Drawing.Size(958, 409);
            this.flpTabOpen.TabIndex = 0;
            // 
            // tabLate
            // 
            this.tabLate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabLate.Controls.Add(this.flpTabLate);
            this.tabLate.Location = new System.Drawing.Point(4, 23);
            this.tabLate.Name = "tabLate";
            this.tabLate.Size = new System.Drawing.Size(958, 410);
            this.tabLate.TabIndex = 3;
            this.tabLate.Text = "Atrasados";
            // 
            // flpTabLate
            // 
            this.flpTabLate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTabLate.AutoScroll = true;
            this.flpTabLate.BackColor = System.Drawing.SystemColors.Window;
            this.flpTabLate.Location = new System.Drawing.Point(0, 0);
            this.flpTabLate.Name = "flpTabLate";
            this.flpTabLate.Size = new System.Drawing.Size(958, 410);
            this.flpTabLate.TabIndex = 0;
            // 
            // tabDone
            // 
            this.tabDone.BackColor = System.Drawing.SystemColors.Control;
            this.tabDone.Controls.Add(this.flpTabDone);
            this.tabDone.Location = new System.Drawing.Point(4, 23);
            this.tabDone.Name = "tabDone";
            this.tabDone.Size = new System.Drawing.Size(958, 410);
            this.tabDone.TabIndex = 4;
            this.tabDone.Text = "Finalizados";
            // 
            // flpTabDone
            // 
            this.flpTabDone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTabDone.AutoScroll = true;
            this.flpTabDone.BackColor = System.Drawing.SystemColors.Window;
            this.flpTabDone.Location = new System.Drawing.Point(0, 0);
            this.flpTabDone.Name = "flpTabDone";
            this.flpTabDone.Size = new System.Drawing.Size(958, 410);
            this.flpTabDone.TabIndex = 0;
            // 
            // tabAll
            // 
            this.tabAll.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabAll.Controls.Add(this.flpTabAll);
            this.tabAll.Location = new System.Drawing.Point(4, 23);
            this.tabAll.Name = "tabAll";
            this.tabAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabAll.Size = new System.Drawing.Size(958, 410);
            this.tabAll.TabIndex = 0;
            this.tabAll.Text = "Todos";
            // 
            // flpTabAll
            // 
            this.flpTabAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTabAll.AutoScroll = true;
            this.flpTabAll.AutoScrollMinSize = new System.Drawing.Size(0, 390);
            this.flpTabAll.BackColor = System.Drawing.SystemColors.Window;
            this.flpTabAll.Location = new System.Drawing.Point(0, 0);
            this.flpTabAll.Name = "flpTabAll";
            this.flpTabAll.Size = new System.Drawing.Size(958, 410);
            this.flpTabAll.TabIndex = 0;
            // 
            // tabCancelled
            // 
            this.tabCancelled.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabCancelled.Controls.Add(this.flpTabCancelled);
            this.tabCancelled.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCancelled.Location = new System.Drawing.Point(4, 23);
            this.tabCancelled.Name = "tabCancelled";
            this.tabCancelled.Size = new System.Drawing.Size(958, 410);
            this.tabCancelled.TabIndex = 2;
            this.tabCancelled.Text = "Cancelados";
            // 
            // flpTabCancelled
            // 
            this.flpTabCancelled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTabCancelled.AutoScroll = true;
            this.flpTabCancelled.BackColor = System.Drawing.SystemColors.Window;
            this.flpTabCancelled.Location = new System.Drawing.Point(0, 0);
            this.flpTabCancelled.Name = "flpTabCancelled";
            this.flpTabCancelled.Size = new System.Drawing.Size(958, 411);
            this.flpTabCancelled.TabIndex = 0;
            // 
            // cmsMenuPedidos
            // 
            this.cmsMenuPedidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarPedidoToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.cmsMenuPedidos.Name = "cmsMenuPedidos";
            this.cmsMenuPedidos.Size = new System.Drawing.Size(110, 48);
            // 
            // alterarPedidoToolStripMenuItem
            // 
            this.alterarPedidoToolStripMenuItem.Name = "alterarPedidoToolStripMenuItem";
            this.alterarPedidoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.alterarPedidoToolStripMenuItem.Text = "Alterar";
            this.alterarPedidoToolStripMenuItem.Click += new System.EventHandler(this.alterarPedidoToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(629, 24);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 22);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pesquisar:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(634, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "(Precione Enter para realizar a pesquisa)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "(Clique com o botão direito do mouse em um pedido para mais opções)";
            // 
            // btnSearchOptions
            // 
            this.btnSearchOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchOptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnSearchOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnSearchOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnSearchOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchOptions.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnSearchOptions.Location = new System.Drawing.Point(882, 23);
            this.btnSearchOptions.Name = "btnSearchOptions";
            this.btnSearchOptions.Size = new System.Drawing.Size(81, 23);
            this.btnSearchOptions.TabIndex = 25;
            this.btnSearchOptions.Text = "Opções";
            this.btnSearchOptions.UseVisualStyleBackColor = true;
            this.btnSearchOptions.Click += new System.EventHandler(this.BtnSearchOptions_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnRefresh.Location = new System.Drawing.Point(866, 470);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 40);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnShowOld
            // 
            this.btnShowOld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowOld.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnShowOld.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnShowOld.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnShowOld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOld.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnShowOld.Location = new System.Drawing.Point(750, 470);
            this.btnShowOld.Name = "btnShowOld";
            this.btnShowOld.Size = new System.Drawing.Size(110, 40);
            this.btnShowOld.TabIndex = 23;
            this.btnShowOld.Text = "Ver antigos";
            this.btnShowOld.UseVisualStyleBackColor = true;
            this.btnShowOld.Click += new System.EventHandler(this.btnShowOld_Click);
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnNewRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(91)))));
            this.btnNewRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnNewRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRequest.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnNewRequest.Image = global::GC.Properties.Resources.icon_mais_30x30;
            this.btnNewRequest.Location = new System.Drawing.Point(4, 470);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(150, 40);
            this.btnNewRequest.TabIndex = 22;
            this.btnNewRequest.Text = "Novo Pedido";
            this.btnNewRequest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewRequest.UseVisualStyleBackColor = true;
            this.btnNewRequest.Click += new System.EventHandler(this.BtnNewRequest_Click);
            // 
            // USC_Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearchOptions);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnShowOld);
            this.Controls.Add(this.btnNewRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbcTabs);
            this.Controls.Add(this.lblRequestsCount);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "USC_Requests";
            this.Size = new System.Drawing.Size(974, 515);
            this.tbcTabs.ResumeLayout(false);
            this.tabOpen.ResumeLayout(false);
            this.tabLate.ResumeLayout(false);
            this.tabDone.ResumeLayout(false);
            this.tabAll.ResumeLayout(false);
            this.tabCancelled.ResumeLayout(false);
            this.cmsMenuPedidos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequestsCount;
        private System.Windows.Forms.TabControl tbcTabs;
        private System.Windows.Forms.TabPage tabAll;
        private System.Windows.Forms.FlowLayoutPanel flpTabAll;
        private System.Windows.Forms.TabPage tabOpen;
        private System.Windows.Forms.FlowLayoutPanel flpTabOpen;
        private System.Windows.Forms.TabPage tabCancelled;
        private System.Windows.Forms.FlowLayoutPanel flpTabCancelled;
        private System.Windows.Forms.TabPage tabLate;
        private System.Windows.Forms.FlowLayoutPanel flpTabLate;
        private System.Windows.Forms.TabPage tabDone;
        private System.Windows.Forms.FlowLayoutPanel flpTabDone;
        private System.Windows.Forms.ContextMenuStrip cmsMenuPedidos;
        private System.Windows.Forms.ToolStripMenuItem alterarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private GC.Components.CMP_BtnAdd btnNewRequest;
        private GC.Components.CMP_BtnRegular btnShowOld;
        private GC.Components.CMP_BtnRegular btnRefresh;
        private GC.Components.CMP_BtnRegular btnSearchOptions;
        private System.Windows.Forms.Label label3;
    }
}
