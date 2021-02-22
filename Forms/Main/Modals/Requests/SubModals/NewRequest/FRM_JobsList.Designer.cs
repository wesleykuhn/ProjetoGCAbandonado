namespace GC.Forms.Main.Modals.Requests.SubModals.NewRequest
{
    partial class FRM_JobsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_JobsList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelect = new GC.Components.CMP_BtnRegular();
            this.lblSelectedCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchOptions = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvlJobs = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.lblSelectedCount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSearchOptions);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lvlJobs);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 418);
            this.panel1.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnSelect.Location = new System.Drawing.Point(10, 370);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(136, 38);
            this.btnSelect.TabIndex = 43;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // lblSelectedCount
            // 
            this.lblSelectedCount.AutoSize = true;
            this.lblSelectedCount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.lblSelectedCount.Location = new System.Drawing.Point(164, 22);
            this.lblSelectedCount.Name = "lblSelectedCount";
            this.lblSelectedCount.Size = new System.Drawing.Size(16, 14);
            this.lblSelectedCount.TabIndex = 19;
            this.lblSelectedCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 14);
            this.label3.TabIndex = 18;
            this.label3.Text = "Serviços selecionados:";
            // 
            // btnSearchOptions
            // 
            this.btnSearchOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchOptions.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOptions.Location = new System.Drawing.Point(853, 20);
            this.btnSearchOptions.Name = "btnSearchOptions";
            this.btnSearchOptions.Size = new System.Drawing.Size(81, 22);
            this.btnSearchOptions.TabIndex = 10;
            this.btnSearchOptions.Text = "Opções";
            this.btnSearchOptions.UseVisualStyleBackColor = true;
            this.btnSearchOptions.Click += new System.EventHandler(this.BtnSearchOptions_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(597, 20);
            this.txtSearch.MaxLength = 60;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 22);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pesquisar:";
            // 
            // lvlJobs
            // 
            this.lvlJobs.AllowColumnReorder = true;
            this.lvlJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlJobs.CheckBoxes = true;
            this.lvlJobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.description,
            this.price});
            this.lvlJobs.FullRowSelect = true;
            this.lvlJobs.GridLines = true;
            this.lvlJobs.HideSelection = false;
            this.lvlJobs.Location = new System.Drawing.Point(10, 47);
            this.lvlJobs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvlJobs.MultiSelect = false;
            this.lvlJobs.Name = "lvlJobs";
            this.lvlJobs.Size = new System.Drawing.Size(923, 317);
            this.lvlJobs.TabIndex = 1;
            this.lvlJobs.UseCompatibleStateImageBehavior = false;
            this.lvlJobs.View = System.Windows.Forms.View.Details;
            this.lvlJobs.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LvlJobs_ItemChecked);
            // 
            // name
            // 
            this.name.Text = "Nome";
            this.name.Width = 300;
            // 
            // description
            // 
            this.description.Text = "Descrição";
            this.description.Width = 410;
            // 
            // price
            // 
            this.price.Text = "Valor";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.price.Width = 200;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "(Precione Enter para realizar a pesquisa)";
            // 
            // FRM_JobsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_JobsList";
            this.Text = "GC - Pedidos > Criando Pedido > Selecionando Serviços";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvlJobs;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Button btnSearchOptions;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelectedCount;
        private System.Windows.Forms.Label label3;
        private GC.Components.CMP_BtnRegular btnSelect;
        private System.Windows.Forms.Label label1;
    }
}