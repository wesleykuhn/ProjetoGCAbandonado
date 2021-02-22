namespace GC.Forms.Main.Controls
{
    partial class USC_Configuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USC_Configuration));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOptions2 = new System.Windows.Forms.Panel();
            this.cbxActiveWindowAlerts = new System.Windows.Forms.CheckBox();
            this.cbxActiveComputerVoice = new System.Windows.Forms.CheckBox();
            this.cbxActiveAnimations = new System.Windows.Forms.CheckBox();
            this.pnlOptions3 = new System.Windows.Forms.Panel();
            this.cbxActiveCriticalStockSystem = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDaysBeforeExpirimentProduct = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxActiveRequestSeparatorHelper = new System.Windows.Forms.CheckBox();
            this.cbxAutoClearCancelledReq = new System.Windows.Forms.CheckBox();
            this.btnSendFeedback = new System.Windows.Forms.Button();
            this.pnlOptions4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlOptions1 = new System.Windows.Forms.Panel();
            this.LBL_MyAccountInfo = new System.Windows.Forms.Label();
            this.btnChangeAccountType = new GC.Components.CMP_BtnRegular();
            this.btnRenewAccount = new GC.Components.CMP_BtnRegularGreen();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new GC.Components.CMP_BtnRegular();
            this.btnApply = new GC.Components.CMP_BtnAlter();
            this.pnlOptions2.SuspendLayout();
            this.pnlOptions3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysBeforeExpirimentProduct)).BeginInit();
            this.pnlOptions4.SuspendLayout();
            this.pnlOptions1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configurações gerais";
            // 
            // pnlOptions2
            // 
            this.pnlOptions2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOptions2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOptions2.Controls.Add(this.cbxActiveWindowAlerts);
            this.pnlOptions2.Controls.Add(this.cbxActiveComputerVoice);
            this.pnlOptions2.Controls.Add(this.cbxActiveAnimations);
            this.pnlOptions2.Controls.Add(this.label1);
            this.pnlOptions2.Location = new System.Drawing.Point(22, 137);
            this.pnlOptions2.Name = "pnlOptions2";
            this.pnlOptions2.Size = new System.Drawing.Size(930, 102);
            this.pnlOptions2.TabIndex = 1;
            // 
            // cbxActiveWindowAlerts
            // 
            this.cbxActiveWindowAlerts.AutoSize = true;
            this.cbxActiveWindowAlerts.BackColor = System.Drawing.Color.Transparent;
            this.cbxActiveWindowAlerts.Location = new System.Drawing.Point(6, 74);
            this.cbxActiveWindowAlerts.Name = "cbxActiveWindowAlerts";
            this.cbxActiveWindowAlerts.Size = new System.Drawing.Size(324, 18);
            this.cbxActiveWindowAlerts.TabIndex = 3;
            this.cbxActiveWindowAlerts.Text = "Ativar alertas/informações por meio de janelas.";
            this.toolTip1.SetToolTip(this.cbxActiveWindowAlerts, "Determina se o programa pode mostrar janelas para avisar sobre pedidos que estão " +
        "atrasados, produtos que estão para vencer, etc.");
            this.cbxActiveWindowAlerts.UseVisualStyleBackColor = false;
            // 
            // cbxActiveComputerVoice
            // 
            this.cbxActiveComputerVoice.AutoSize = true;
            this.cbxActiveComputerVoice.BackColor = System.Drawing.Color.Transparent;
            this.cbxActiveComputerVoice.Location = new System.Drawing.Point(6, 50);
            this.cbxActiveComputerVoice.Name = "cbxActiveComputerVoice";
            this.cbxActiveComputerVoice.Size = new System.Drawing.Size(300, 18);
            this.cbxActiveComputerVoice.TabIndex = 2;
            this.cbxActiveComputerVoice.Text = "Ativar alertas/informações por meio de voz.";
            this.toolTip1.SetToolTip(this.cbxActiveComputerVoice, "Determina se o programa pode usar o sistema de voz do padrão do Windows para avis" +
        "ar sobre pedidos que estão atrasados, produtos que estão para vencer, etc.");
            this.cbxActiveComputerVoice.UseVisualStyleBackColor = false;
            // 
            // cbxActiveAnimations
            // 
            this.cbxActiveAnimations.AutoSize = true;
            this.cbxActiveAnimations.BackColor = System.Drawing.Color.Transparent;
            this.cbxActiveAnimations.Location = new System.Drawing.Point(6, 26);
            this.cbxActiveAnimations.Name = "cbxActiveAnimations";
            this.cbxActiveAnimations.Size = new System.Drawing.Size(323, 18);
            this.cbxActiveAnimations.TabIndex = 1;
            this.cbxActiveAnimations.Text = "Ativar animações (Pode afetar o desempenho).";
            this.cbxActiveAnimations.UseVisualStyleBackColor = false;
            // 
            // pnlOptions3
            // 
            this.pnlOptions3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOptions3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOptions3.Controls.Add(this.cbxActiveCriticalStockSystem);
            this.pnlOptions3.Controls.Add(this.label4);
            this.pnlOptions3.Controls.Add(this.nudDaysBeforeExpirimentProduct);
            this.pnlOptions3.Controls.Add(this.label3);
            this.pnlOptions3.Controls.Add(this.label2);
            this.pnlOptions3.Location = new System.Drawing.Point(22, 245);
            this.pnlOptions3.Name = "pnlOptions3";
            this.pnlOptions3.Size = new System.Drawing.Size(930, 77);
            this.pnlOptions3.TabIndex = 2;
            // 
            // cbxActiveCriticalStockSystem
            // 
            this.cbxActiveCriticalStockSystem.AutoSize = true;
            this.cbxActiveCriticalStockSystem.BackColor = System.Drawing.Color.Transparent;
            this.cbxActiveCriticalStockSystem.Location = new System.Drawing.Point(6, 48);
            this.cbxActiveCriticalStockSystem.Name = "cbxActiveCriticalStockSystem";
            this.cbxActiveCriticalStockSystem.Size = new System.Drawing.Size(235, 18);
            this.cbxActiveCriticalStockSystem.TabIndex = 4;
            this.cbxActiveCriticalStockSystem.Text = "Ativar sistema de estoque crítico.";
            this.toolTip1.SetToolTip(this.cbxActiveCriticalStockSystem, resources.GetString("cbxActiveCriticalStockSystem.ToolTip"));
            this.cbxActiveCriticalStockSystem.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(99, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "dias de antecedência sobre o vencimento de um produto.";
            this.toolTip1.SetToolTip(this.label4, "Determina com quantos dias de antecedência você deseja ser avisado(a) sobre o ven" +
        "cimento de seus produtos.");
            // 
            // nudDaysBeforeExpirimentProduct
            // 
            this.nudDaysBeforeExpirimentProduct.Location = new System.Drawing.Point(52, 25);
            this.nudDaysBeforeExpirimentProduct.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudDaysBeforeExpirimentProduct.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDaysBeforeExpirimentProduct.Name = "nudDaysBeforeExpirimentProduct";
            this.nudDaysBeforeExpirimentProduct.Size = new System.Drawing.Size(45, 22);
            this.nudDaysBeforeExpirimentProduct.TabIndex = 2;
            this.nudDaysBeforeExpirimentProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudDaysBeforeExpirimentProduct, "Determina com quantos dias de antecedência você deseja ser avisado(a) sobre o ven" +
        "cimento de seus produtos.");
            this.nudDaysBeforeExpirimentProduct.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Avisar ";
            this.toolTip1.SetToolTip(this.label3, "Determina com quantos dias de antecedência você deseja ser avisado(a) sobre o ven" +
        "cimento de seus produtos.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Produtos";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // cbxActiveRequestSeparatorHelper
            // 
            this.cbxActiveRequestSeparatorHelper.AutoSize = true;
            this.cbxActiveRequestSeparatorHelper.BackColor = System.Drawing.Color.Transparent;
            this.cbxActiveRequestSeparatorHelper.Location = new System.Drawing.Point(6, 26);
            this.cbxActiveRequestSeparatorHelper.Name = "cbxActiveRequestSeparatorHelper";
            this.cbxActiveRequestSeparatorHelper.Size = new System.Drawing.Size(280, 18);
            this.cbxActiveRequestSeparatorHelper.TabIndex = 4;
            this.cbxActiveRequestSeparatorHelper.Text = "Ativar janela de separação de produtos.";
            this.toolTip1.SetToolTip(this.cbxActiveRequestSeparatorHelper, resources.GetString("cbxActiveRequestSeparatorHelper.ToolTip"));
            this.cbxActiveRequestSeparatorHelper.UseVisualStyleBackColor = false;
            // 
            // cbxAutoClearCancelledReq
            // 
            this.cbxAutoClearCancelledReq.AutoSize = true;
            this.cbxAutoClearCancelledReq.BackColor = System.Drawing.Color.Transparent;
            this.cbxAutoClearCancelledReq.Location = new System.Drawing.Point(6, 50);
            this.cbxAutoClearCancelledReq.Name = "cbxAutoClearCancelledReq";
            this.cbxAutoClearCancelledReq.Size = new System.Drawing.Size(503, 18);
            this.cbxAutoClearCancelledReq.TabIndex = 5;
            this.cbxAutoClearCancelledReq.Text = "Excluir automaticamente todos os pedido cancelados com mais de 6 meses.";
            this.toolTip1.SetToolTip(this.cbxAutoClearCancelledReq, "Se selecionada a opção, o programa irá verificar, sem atrapalhar você, se existem" +
        " pedidos que foram criados a mais de 6 meses atrás e que estão cancelados e entã" +
        "o irá excluí-los.");
            this.cbxAutoClearCancelledReq.UseVisualStyleBackColor = false;
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendFeedback.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnSendFeedback.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSendFeedback.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSendFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendFeedback.Image = global::GC.Properties.Resources.icon_feedback;
            this.btnSendFeedback.Location = new System.Drawing.Point(892, 7);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Size = new System.Drawing.Size(60, 30);
            this.btnSendFeedback.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnSendFeedback, "Relatar um problema ou dar uma sugestão referente ao programa.");
            this.btnSendFeedback.UseVisualStyleBackColor = true;
            this.btnSendFeedback.Click += new System.EventHandler(this.btnSendFeedback_Click);
            // 
            // pnlOptions4
            // 
            this.pnlOptions4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOptions4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOptions4.Controls.Add(this.cbxAutoClearCancelledReq);
            this.pnlOptions4.Controls.Add(this.cbxActiveRequestSeparatorHelper);
            this.pnlOptions4.Controls.Add(this.label7);
            this.pnlOptions4.Location = new System.Drawing.Point(22, 328);
            this.pnlOptions4.Name = "pnlOptions4";
            this.pnlOptions4.Size = new System.Drawing.Size(930, 81);
            this.pnlOptions4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pedidos";
            // 
            // pnlOptions1
            // 
            this.pnlOptions1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOptions1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOptions1.Controls.Add(this.LBL_MyAccountInfo);
            this.pnlOptions1.Controls.Add(this.btnChangeAccountType);
            this.pnlOptions1.Controls.Add(this.btnRenewAccount);
            this.pnlOptions1.Controls.Add(this.lblExpiration);
            this.pnlOptions1.Controls.Add(this.lblAccountType);
            this.pnlOptions1.Controls.Add(this.label6);
            this.pnlOptions1.Controls.Add(this.label5);
            this.pnlOptions1.Location = new System.Drawing.Point(22, 41);
            this.pnlOptions1.Name = "pnlOptions1";
            this.pnlOptions1.Size = new System.Drawing.Size(930, 90);
            this.pnlOptions1.TabIndex = 6;
            // 
            // LBL_MyAccountInfo
            // 
            this.LBL_MyAccountInfo.AutoSize = true;
            this.LBL_MyAccountInfo.BackColor = System.Drawing.Color.Transparent;
            this.LBL_MyAccountInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_MyAccountInfo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MyAccountInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LBL_MyAccountInfo.Location = new System.Drawing.Point(3, 60);
            this.LBL_MyAccountInfo.Name = "LBL_MyAccountInfo";
            this.LBL_MyAccountInfo.Size = new System.Drawing.Size(83, 14);
            this.LBL_MyAccountInfo.TabIndex = 19;
            this.LBL_MyAccountInfo.Text = "Meus dados";
            this.LBL_MyAccountInfo.Click += new System.EventHandler(this.LBL_MyAccountInfo_Click);
            // 
            // btnChangeAccountType
            // 
            this.btnChangeAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeAccountType.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnChangeAccountType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnChangeAccountType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnChangeAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeAccountType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeAccountType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnChangeAccountType.Location = new System.Drawing.Point(792, 13);
            this.btnChangeAccountType.Name = "btnChangeAccountType";
            this.btnChangeAccountType.Size = new System.Drawing.Size(130, 40);
            this.btnChangeAccountType.TabIndex = 16;
            this.btnChangeAccountType.Text = "Mudar de Plano";
            this.btnChangeAccountType.UseVisualStyleBackColor = true;
            this.btnChangeAccountType.Click += new System.EventHandler(this.btnChangeAccountType_Click);
            // 
            // btnRenewAccount
            // 
            this.btnRenewAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenewAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnRenewAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(91)))));
            this.btnRenewAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnRenewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenewAccount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenewAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnRenewAccount.Location = new System.Drawing.Point(656, 13);
            this.btnRenewAccount.Name = "btnRenewAccount";
            this.btnRenewAccount.Size = new System.Drawing.Size(130, 40);
            this.btnRenewAccount.TabIndex = 15;
            this.btnRenewAccount.Text = "Recarregar Conta";
            this.btnRenewAccount.UseVisualStyleBackColor = true;
            this.btnRenewAccount.Click += new System.EventHandler(this.btnRenewAccount_Click);
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.BackColor = System.Drawing.Color.Transparent;
            this.lblExpiration.Location = new System.Drawing.Point(3, 41);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(138, 14);
            this.lblExpiration.TabIndex = 14;
            this.lblExpiration.Text = "Sua conta vence em ";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(156, 23);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(74, 14);
            this.lblAccountType.TabIndex = 13;
            this.lblAccountType.Text = "PEQUENO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(3, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo do plano da conta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Conta";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnReset.Location = new System.Drawing.Point(22, 469);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 39);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Redefinir Tudo";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(215)))));
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnApply.Location = new System.Drawing.Point(842, 469);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(110, 39);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Aplicar";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // USC_Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSendFeedback);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.pnlOptions1);
            this.Controls.Add(this.pnlOptions4);
            this.Controls.Add(this.pnlOptions3);
            this.Controls.Add(this.pnlOptions2);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "USC_Configuration";
            this.Size = new System.Drawing.Size(974, 525);
            this.pnlOptions2.ResumeLayout(false);
            this.pnlOptions2.PerformLayout();
            this.pnlOptions3.ResumeLayout(false);
            this.pnlOptions3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysBeforeExpirimentProduct)).EndInit();
            this.pnlOptions4.ResumeLayout(false);
            this.pnlOptions4.PerformLayout();
            this.pnlOptions1.ResumeLayout(false);
            this.pnlOptions1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlOptions2;
        private System.Windows.Forms.CheckBox cbxActiveWindowAlerts;
        private System.Windows.Forms.CheckBox cbxActiveComputerVoice;
        private System.Windows.Forms.CheckBox cbxActiveAnimations;
        private System.Windows.Forms.Panel pnlOptions3;
        private System.Windows.Forms.NumericUpDown nudDaysBeforeExpirimentProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxActiveCriticalStockSystem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlOptions4;
        private System.Windows.Forms.CheckBox cbxActiveRequestSeparatorHelper;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlOptions1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxAutoClearCancelledReq;
        private GC.Components.CMP_BtnAlter btnApply;
        private GC.Components.CMP_BtnRegular btnReset;
        private System.Windows.Forms.Button btnSendFeedback;
        private System.Windows.Forms.Label label6;
        private GC.Components.CMP_BtnRegular btnChangeAccountType;
        private GC.Components.CMP_BtnRegularGreen btnRenewAccount;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label LBL_MyAccountInfo;
    }
}
