namespace GC.Forms.Main.Modals.Requests.SubModals.NewRequest
{
    partial class FRM_EditAdditions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_EditAdditions));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new GC.Components.CMP_BtnRegular();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNudAux = new System.Windows.Forms.Label();
            this.rbtPercent = new System.Windows.Forms.RadioButton();
            this.rbtValue = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.pnlColumns = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvlPercents = new System.Windows.Forms.ListView();
            this.percent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlValues = new System.Windows.Forms.ListView();
            this.value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.pnlColumns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblNudAux);
            this.panel1.Controls.Add(this.rbtPercent);
            this.panel1.Controls.Add(this.rbtValue);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nudValue);
            this.panel1.Controls.Add(this.pnlColumns);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 303);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnAdd.Location = new System.Drawing.Point(13, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 46);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor:";
            // 
            // lblNudAux
            // 
            this.lblNudAux.AutoSize = true;
            this.lblNudAux.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNudAux.Location = new System.Drawing.Point(204, 160);
            this.lblNudAux.Name = "lblNudAux";
            this.lblNudAux.Size = new System.Drawing.Size(23, 14);
            this.lblNudAux.TabIndex = 7;
            this.lblNudAux.Text = "R$";
            // 
            // rbtPercent
            // 
            this.rbtPercent.AutoSize = true;
            this.rbtPercent.Location = new System.Drawing.Point(13, 130);
            this.rbtPercent.Name = "rbtPercent";
            this.rbtPercent.Size = new System.Drawing.Size(92, 18);
            this.rbtPercent.TabIndex = 6;
            this.rbtPercent.TabStop = true;
            this.rbtPercent.Text = "Percentual";
            this.rbtPercent.UseVisualStyleBackColor = true;
            this.rbtPercent.CheckedChanged += new System.EventHandler(this.RbtPercent_CheckedChanged);
            // 
            // rbtValue
            // 
            this.rbtValue.AutoSize = true;
            this.rbtValue.Checked = true;
            this.rbtValue.Location = new System.Drawing.Point(13, 109);
            this.rbtValue.Name = "rbtValue";
            this.rbtValue.Size = new System.Drawing.Size(86, 18);
            this.rbtValue.TabIndex = 5;
            this.rbtValue.TabStop = true;
            this.rbtValue.Text = "Valor (R$)";
            this.rbtValue.UseVisualStyleBackColor = true;
            this.rbtValue.CheckedChanged += new System.EventHandler(this.RbtValue_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo do acréscimo:";
            // 
            // nudValue
            // 
            this.nudValue.DecimalPlaces = 2;
            this.nudValue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudValue.Location = new System.Drawing.Point(57, 158);
            this.nudValue.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(146, 22);
            this.nudValue.TabIndex = 3;
            this.nudValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudValue.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValue.ValueChanged += new System.EventHandler(this.NudValue_ValueChanged);
            // 
            // pnlColumns
            // 
            this.pnlColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlColumns.BackColor = System.Drawing.SystemColors.Control;
            this.pnlColumns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColumns.Controls.Add(this.label3);
            this.pnlColumns.Controls.Add(this.label1);
            this.pnlColumns.Controls.Add(this.lvlPercents);
            this.pnlColumns.Controls.Add(this.lvlValues);
            this.pnlColumns.Location = new System.Drawing.Point(323, 16);
            this.pnlColumns.Name = "pnlColumns";
            this.pnlColumns.Size = new System.Drawing.Size(311, 268);
            this.pnlColumns.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "(Duplo clique para remover)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Acréscimos já aplicados ao pedido:";
            // 
            // lvlPercents
            // 
            this.lvlPercents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlPercents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.percent});
            this.lvlPercents.GridLines = true;
            this.lvlPercents.HideSelection = false;
            this.lvlPercents.Location = new System.Drawing.Point(161, 49);
            this.lvlPercents.Name = "lvlPercents";
            this.lvlPercents.Size = new System.Drawing.Size(135, 200);
            this.lvlPercents.TabIndex = 1;
            this.lvlPercents.UseCompatibleStateImageBehavior = false;
            this.lvlPercents.View = System.Windows.Forms.View.Details;
            this.lvlPercents.DoubleClick += new System.EventHandler(this.LvlPercents_DoubleClick);
            // 
            // percent
            // 
            this.percent.Text = "%";
            this.percent.Width = 120;
            // 
            // lvlValues
            // 
            this.lvlValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvlValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.value});
            this.lvlValues.GridLines = true;
            this.lvlValues.HideSelection = false;
            this.lvlValues.Location = new System.Drawing.Point(13, 48);
            this.lvlValues.Name = "lvlValues";
            this.lvlValues.Size = new System.Drawing.Size(135, 200);
            this.lvlValues.TabIndex = 0;
            this.lvlValues.UseCompatibleStateImageBehavior = false;
            this.lvlValues.View = System.Windows.Forms.View.Details;
            this.lvlValues.DoubleClick += new System.EventHandler(this.LvlValues_DoubleClick);
            // 
            // value
            // 
            this.value.Text = "R$";
            this.value.Width = 120;
            // 
            // FRM_EditAdditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(648, 335);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_EditAdditions";
            this.Text = "GC - Pedidos > Criando Pedido > Editando Acréscimos";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.pnlColumns.ResumeLayout(false);
            this.pnlColumns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvlPercents;
        private System.Windows.Forms.ColumnHeader percent;
        private System.Windows.Forms.ListView lvlValues;
        private System.Windows.Forms.ColumnHeader value;
        private System.Windows.Forms.Label lblNudAux;
        private System.Windows.Forms.RadioButton rbtPercent;
        private System.Windows.Forms.RadioButton rbtValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Label label5;
        private GC.Components.CMP_BtnRegular btnAdd;
        private System.Windows.Forms.Panel pnlColumns;
    }
}