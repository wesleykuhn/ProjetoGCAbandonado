namespace GC.Forms.Main.Modals.Jobs
{
    partial class FRM_NewJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NewJob));
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnAdd = new GC.Components.CMP_BtnAdd();
            this.pnlNameDescBack = new System.Windows.Forms.Panel();
            this.btnCreate = new GC.Components.CMP_BtnRegular();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lvlAddedJobs = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.pnlNameDescBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBackground.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBackground.Controls.Add(this.btnAdd);
            this.pnlBackground.Controls.Add(this.pnlNameDescBack);
            this.pnlBackground.Controls.Add(this.label10);
            this.pnlBackground.Controls.Add(this.lvlAddedJobs);
            this.pnlBackground.Controls.Add(this.label11);
            this.pnlBackground.Location = new System.Drawing.Point(2, 30);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(432, 482);
            this.pnlBackground.TabIndex = 30;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(91)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnAdd.Image = global::GC.Properties.Resources.icon_mais_30x30;
            this.btnAdd.Location = new System.Drawing.Point(16, 432);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 40);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // pnlNameDescBack
            // 
            this.pnlNameDescBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNameDescBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNameDescBack.Controls.Add(this.btnCreate);
            this.pnlNameDescBack.Controls.Add(this.label1);
            this.pnlNameDescBack.Controls.Add(this.nudPrice);
            this.pnlNameDescBack.Controls.Add(this.txtName);
            this.pnlNameDescBack.Controls.Add(this.label3);
            this.pnlNameDescBack.Controls.Add(this.label9);
            this.pnlNameDescBack.Controls.Add(this.txtDesc);
            this.pnlNameDescBack.Controls.Add(this.label5);
            this.pnlNameDescBack.Location = new System.Drawing.Point(16, 12);
            this.pnlNameDescBack.Name = "pnlNameDescBack";
            this.pnlNameDescBack.Size = new System.Drawing.Size(397, 175);
            this.pnlNameDescBack.TabIndex = 30;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCreate.Location = new System.Drawing.Point(12, 126);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 40);
            this.btnCreate.TabIndex = 38;
            this.btnCreate.Text = "Criar";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnAddJob_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Nome:";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPrice.Location = new System.Drawing.Point(77, 66);
            this.nudPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(135, 22);
            this.nudPrice.TabIndex = 2;
            this.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 10);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "Valor(R$):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(9, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "*Campo obrigatório.";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(87, 38);
            this.txtDesc.MaxLength = 50;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(296, 22);
            this.txtDesc.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(9, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 14);
            this.label5.TabIndex = 27;
            this.label5.Text = "Descrição:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Duplo clique num item da lista para removê-lo.";
            // 
            // lvlAddedJobs
            // 
            this.lvlAddedJobs.AutoArrange = false;
            this.lvlAddedJobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.description,
            this.price});
            this.lvlAddedJobs.FullRowSelect = true;
            this.lvlAddedJobs.GridLines = true;
            this.lvlAddedJobs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvlAddedJobs.HideSelection = false;
            this.lvlAddedJobs.Location = new System.Drawing.Point(16, 222);
            this.lvlAddedJobs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvlAddedJobs.MultiSelect = false;
            this.lvlAddedJobs.Name = "lvlAddedJobs";
            this.lvlAddedJobs.Size = new System.Drawing.Size(397, 169);
            this.lvlAddedJobs.TabIndex = 4;
            this.lvlAddedJobs.UseCompatibleStateImageBehavior = false;
            this.lvlAddedJobs.View = System.Windows.Forms.View.Details;
            this.lvlAddedJobs.DoubleClick += new System.EventHandler(this.LvlAddedJobs_DoubleClick);
            // 
            // name
            // 
            this.name.Text = "Nome";
            this.name.Width = 130;
            // 
            // description
            // 
            this.description.Text = "Descrição";
            this.description.Width = 150;
            // 
            // price
            // 
            this.price.Text = "Valor";
            this.price.Width = 120;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(305, 14);
            this.label11.TabIndex = 22;
            this.label11.Text = "Serviços que estão prontos para serem salvos:";
            // 
            // FRM_NewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(436, 514);
            this.Controls.Add(this.pnlBackground);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_NewJob";
            this.Text = "GC - Serviços > Adicionar Serviços";
            this.Controls.SetChildIndex(this.pnlBackground, 0);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.pnlNameDescBack.ResumeLayout(false);
            this.pnlNameDescBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lvlAddedJobs;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlNameDescBack;
        private GC.Components.CMP_BtnRegular btnCreate;
        private GC.Components.CMP_BtnAdd btnAdd;
    }
}