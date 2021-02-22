namespace GC.Forms.Main.Modals.Requests.SubModals.NewRequest
{
    partial class FRM_OnFinishDiscounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_OnFinishDiscounts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new GC.Components.CMP_BtnAlter();
            this.pnlAccumulatedBack = new System.Windows.Forms.Panel();
            this.lblNewAccumulated = new System.Windows.Forms.Label();
            this.rbtAccumulatedReset = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAccumulatedPercent = new System.Windows.Forms.NumericUpDown();
            this.rbtAccumulatedPercent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAccumulatedManual = new System.Windows.Forms.NumericUpDown();
            this.rbtAccumulatedManual = new System.Windows.Forms.RadioButton();
            this.cbxAccumulated = new System.Windows.Forms.CheckBox();
            this.lblActualAccumulated = new System.Windows.Forms.Label();
            this.pnlCounterBack = new System.Windows.Forms.Panel();
            this.lblNewCounter = new System.Windows.Forms.Label();
            this.rbtCounterReset = new System.Windows.Forms.RadioButton();
            this.rbtCounterDecrease = new System.Windows.Forms.RadioButton();
            this.rbtCounterIncrease = new System.Windows.Forms.RadioButton();
            this.cbxCounter = new System.Windows.Forms.CheckBox();
            this.lblActualCounter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlAccumulatedBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccumulatedPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccumulatedManual)).BeginInit();
            this.pnlCounterBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.pnlAccumulatedBack);
            this.panel1.Controls.Add(this.pnlCounterBack);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 416);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(215)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSave.Image = global::GC.Properties.Resources.icon_lapis_30x30;
            this.btnSave.Location = new System.Drawing.Point(12, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // pnlAccumulatedBack
            // 
            this.pnlAccumulatedBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAccumulatedBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAccumulatedBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAccumulatedBack.Controls.Add(this.lblNewAccumulated);
            this.pnlAccumulatedBack.Controls.Add(this.rbtAccumulatedReset);
            this.pnlAccumulatedBack.Controls.Add(this.label3);
            this.pnlAccumulatedBack.Controls.Add(this.nudAccumulatedPercent);
            this.pnlAccumulatedBack.Controls.Add(this.rbtAccumulatedPercent);
            this.pnlAccumulatedBack.Controls.Add(this.label1);
            this.pnlAccumulatedBack.Controls.Add(this.nudAccumulatedManual);
            this.pnlAccumulatedBack.Controls.Add(this.rbtAccumulatedManual);
            this.pnlAccumulatedBack.Controls.Add(this.cbxAccumulated);
            this.pnlAccumulatedBack.Controls.Add(this.lblActualAccumulated);
            this.pnlAccumulatedBack.Location = new System.Drawing.Point(13, 160);
            this.pnlAccumulatedBack.Name = "pnlAccumulatedBack";
            this.pnlAccumulatedBack.Size = new System.Drawing.Size(506, 186);
            this.pnlAccumulatedBack.TabIndex = 3;
            // 
            // lblNewAccumulated
            // 
            this.lblNewAccumulated.AutoSize = true;
            this.lblNewAccumulated.BackColor = System.Drawing.SystemColors.Control;
            this.lblNewAccumulated.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewAccumulated.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblNewAccumulated.Location = new System.Drawing.Point(6, 154);
            this.lblNewAccumulated.Name = "lblNewAccumulated";
            this.lblNewAccumulated.Size = new System.Drawing.Size(233, 18);
            this.lblNewAccumulated.TabIndex = 12;
            this.lblNewAccumulated.Text = "Novo desconto acumulado: ";
            // 
            // rbtAccumulatedReset
            // 
            this.rbtAccumulatedReset.AutoSize = true;
            this.rbtAccumulatedReset.BackColor = System.Drawing.SystemColors.Control;
            this.rbtAccumulatedReset.Enabled = false;
            this.rbtAccumulatedReset.Location = new System.Drawing.Point(9, 121);
            this.rbtAccumulatedReset.Name = "rbtAccumulatedReset";
            this.rbtAccumulatedReset.Size = new System.Drawing.Size(59, 18);
            this.rbtAccumulatedReset.TabIndex = 11;
            this.rbtAccumulatedReset.TabStop = true;
            this.rbtAccumulatedReset.Text = "Zerar";
            this.rbtAccumulatedReset.UseVisualStyleBackColor = false;
            this.rbtAccumulatedReset.CheckedChanged += new System.EventHandler(this.rbtAccumulatedReset_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(475, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "%";
            // 
            // nudAccumulatedPercent
            // 
            this.nudAccumulatedPercent.DecimalPlaces = 5;
            this.nudAccumulatedPercent.Enabled = false;
            this.nudAccumulatedPercent.Location = new System.Drawing.Point(343, 97);
            this.nudAccumulatedPercent.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudAccumulatedPercent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nudAccumulatedPercent.Name = "nudAccumulatedPercent";
            this.nudAccumulatedPercent.Size = new System.Drawing.Size(130, 22);
            this.nudAccumulatedPercent.TabIndex = 9;
            this.nudAccumulatedPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAccumulatedPercent.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudAccumulatedPercent.Value = new decimal(new int[] {
            100000,
            0,
            0,
            327680});
            this.nudAccumulatedPercent.ValueChanged += new System.EventHandler(this.nudAccumulatedPercent_ValueChanged);
            // 
            // rbtAccumulatedPercent
            // 
            this.rbtAccumulatedPercent.AutoSize = true;
            this.rbtAccumulatedPercent.BackColor = System.Drawing.SystemColors.Control;
            this.rbtAccumulatedPercent.Enabled = false;
            this.rbtAccumulatedPercent.Location = new System.Drawing.Point(9, 97);
            this.rbtAccumulatedPercent.Name = "rbtAccumulatedPercent";
            this.rbtAccumulatedPercent.Size = new System.Drawing.Size(339, 18);
            this.rbtAccumulatedPercent.TabIndex = 8;
            this.rbtAccumulatedPercent.TabStop = true;
            this.rbtAccumulatedPercent.Text = "Adicionar percentual em cima do valor do pedido: ";
            this.rbtAccumulatedPercent.UseVisualStyleBackColor = false;
            this.rbtAccumulatedPercent.CheckedChanged += new System.EventHandler(this.rbtAccumulatedPercent_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(217, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "R$";
            // 
            // nudAccumulatedManual
            // 
            this.nudAccumulatedManual.DecimalPlaces = 2;
            this.nudAccumulatedManual.Enabled = false;
            this.nudAccumulatedManual.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudAccumulatedManual.Location = new System.Drawing.Point(241, 71);
            this.nudAccumulatedManual.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudAccumulatedManual.Name = "nudAccumulatedManual";
            this.nudAccumulatedManual.Size = new System.Drawing.Size(154, 22);
            this.nudAccumulatedManual.TabIndex = 6;
            this.nudAccumulatedManual.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAccumulatedManual.ValueChanged += new System.EventHandler(this.nudAccumulatedManual_ValueChanged);
            // 
            // rbtAccumulatedManual
            // 
            this.rbtAccumulatedManual.AutoSize = true;
            this.rbtAccumulatedManual.BackColor = System.Drawing.SystemColors.Control;
            this.rbtAccumulatedManual.Enabled = false;
            this.rbtAccumulatedManual.Location = new System.Drawing.Point(9, 71);
            this.rbtAccumulatedManual.Name = "rbtAccumulatedManual";
            this.rbtAccumulatedManual.Size = new System.Drawing.Size(216, 18);
            this.rbtAccumulatedManual.TabIndex = 5;
            this.rbtAccumulatedManual.TabStop = true;
            this.rbtAccumulatedManual.Text = "Adicionar valor manualmente: ";
            this.rbtAccumulatedManual.UseVisualStyleBackColor = false;
            this.rbtAccumulatedManual.CheckedChanged += new System.EventHandler(this.rbtAccumulatedManual_CheckedChanged);
            // 
            // cbxAccumulated
            // 
            this.cbxAccumulated.AutoSize = true;
            this.cbxAccumulated.BackColor = System.Drawing.SystemColors.Control;
            this.cbxAccumulated.Location = new System.Drawing.Point(9, 47);
            this.cbxAccumulated.Name = "cbxAccumulated";
            this.cbxAccumulated.Size = new System.Drawing.Size(215, 18);
            this.cbxAccumulated.TabIndex = 2;
            this.cbxAccumulated.Text = "Modificar desconto acumulado";
            this.cbxAccumulated.UseVisualStyleBackColor = false;
            this.cbxAccumulated.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblActualAccumulated
            // 
            this.lblActualAccumulated.AutoSize = true;
            this.lblActualAccumulated.BackColor = System.Drawing.SystemColors.Control;
            this.lblActualAccumulated.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualAccumulated.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblActualAccumulated.Location = new System.Drawing.Point(6, 12);
            this.lblActualAccumulated.Name = "lblActualAccumulated";
            this.lblActualAccumulated.Size = new System.Drawing.Size(234, 18);
            this.lblActualAccumulated.TabIndex = 1;
            this.lblActualAccumulated.Text = "Desconto acumulado atual: ";
            // 
            // pnlCounterBack
            // 
            this.pnlCounterBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCounterBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCounterBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCounterBack.Controls.Add(this.lblNewCounter);
            this.pnlCounterBack.Controls.Add(this.rbtCounterReset);
            this.pnlCounterBack.Controls.Add(this.rbtCounterDecrease);
            this.pnlCounterBack.Controls.Add(this.rbtCounterIncrease);
            this.pnlCounterBack.Controls.Add(this.cbxCounter);
            this.pnlCounterBack.Controls.Add(this.lblActualCounter);
            this.pnlCounterBack.Location = new System.Drawing.Point(12, 17);
            this.pnlCounterBack.Name = "pnlCounterBack";
            this.pnlCounterBack.Size = new System.Drawing.Size(506, 133);
            this.pnlCounterBack.TabIndex = 2;
            // 
            // lblNewCounter
            // 
            this.lblNewCounter.AutoSize = true;
            this.lblNewCounter.BackColor = System.Drawing.SystemColors.Control;
            this.lblNewCounter.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCounter.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblNewCounter.Location = new System.Drawing.Point(7, 99);
            this.lblNewCounter.Name = "lblNewCounter";
            this.lblNewCounter.Size = new System.Drawing.Size(290, 18);
            this.lblNewCounter.TabIndex = 5;
            this.lblNewCounter.Text = "Novo compras/pedidos anotados: ";
            // 
            // rbtCounterReset
            // 
            this.rbtCounterReset.AutoSize = true;
            this.rbtCounterReset.BackColor = System.Drawing.SystemColors.Control;
            this.rbtCounterReset.Enabled = false;
            this.rbtCounterReset.Location = new System.Drawing.Point(118, 66);
            this.rbtCounterReset.Name = "rbtCounterReset";
            this.rbtCounterReset.Size = new System.Drawing.Size(59, 18);
            this.rbtCounterReset.TabIndex = 4;
            this.rbtCounterReset.Text = "Zerar";
            this.rbtCounterReset.UseVisualStyleBackColor = false;
            this.rbtCounterReset.CheckedChanged += new System.EventHandler(this.rbtCounterReset_CheckedChanged);
            // 
            // rbtCounterDecrease
            // 
            this.rbtCounterDecrease.AutoSize = true;
            this.rbtCounterDecrease.BackColor = System.Drawing.SystemColors.Control;
            this.rbtCounterDecrease.Enabled = false;
            this.rbtCounterDecrease.Location = new System.Drawing.Point(66, 66);
            this.rbtCounterDecrease.Name = "rbtCounterDecrease";
            this.rbtCounterDecrease.Size = new System.Drawing.Size(38, 18);
            this.rbtCounterDecrease.TabIndex = 3;
            this.rbtCounterDecrease.Text = "-1";
            this.rbtCounterDecrease.UseVisualStyleBackColor = false;
            this.rbtCounterDecrease.CheckedChanged += new System.EventHandler(this.rbtCounterDecrease_CheckedChanged);
            // 
            // rbtCounterIncrease
            // 
            this.rbtCounterIncrease.AutoSize = true;
            this.rbtCounterIncrease.BackColor = System.Drawing.SystemColors.Control;
            this.rbtCounterIncrease.Enabled = false;
            this.rbtCounterIncrease.Location = new System.Drawing.Point(10, 66);
            this.rbtCounterIncrease.Name = "rbtCounterIncrease";
            this.rbtCounterIncrease.Size = new System.Drawing.Size(42, 18);
            this.rbtCounterIncrease.TabIndex = 2;
            this.rbtCounterIncrease.Text = "+1";
            this.rbtCounterIncrease.UseVisualStyleBackColor = false;
            this.rbtCounterIncrease.CheckedChanged += new System.EventHandler(this.rbtCounterIncrease_CheckedChanged);
            // 
            // cbxCounter
            // 
            this.cbxCounter.AutoSize = true;
            this.cbxCounter.BackColor = System.Drawing.SystemColors.Control;
            this.cbxCounter.Location = new System.Drawing.Point(10, 42);
            this.cbxCounter.Name = "cbxCounter";
            this.cbxCounter.Size = new System.Drawing.Size(257, 18);
            this.cbxCounter.TabIndex = 1;
            this.cbxCounter.Text = "Modificar compras/pedidos anotados";
            this.cbxCounter.UseVisualStyleBackColor = false;
            this.cbxCounter.CheckedChanged += new System.EventHandler(this.cbxCounter_CheckedChanged);
            // 
            // lblActualCounter
            // 
            this.lblActualCounter.AutoSize = true;
            this.lblActualCounter.BackColor = System.Drawing.SystemColors.Control;
            this.lblActualCounter.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualCounter.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblActualCounter.Location = new System.Drawing.Point(7, 13);
            this.lblActualCounter.Name = "lblActualCounter";
            this.lblActualCounter.Size = new System.Drawing.Size(292, 18);
            this.lblActualCounter.TabIndex = 0;
            this.lblActualCounter.Text = "Compras/pedidos anotados atual: ";
            // 
            // FRM_OnFinishDiscounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(535, 448);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_OnFinishDiscounts";
            this.Text = "GC - Pedidos > Criando Pedido > Descontos Do Cliente";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.pnlAccumulatedBack.ResumeLayout(false);
            this.pnlAccumulatedBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccumulatedPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccumulatedManual)).EndInit();
            this.pnlCounterBack.ResumeLayout(false);
            this.pnlCounterBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblActualCounter;
        private System.Windows.Forms.Label lblActualAccumulated;
        private System.Windows.Forms.CheckBox cbxAccumulated;
        private System.Windows.Forms.CheckBox cbxCounter;
        private System.Windows.Forms.RadioButton rbtCounterReset;
        private System.Windows.Forms.RadioButton rbtCounterDecrease;
        private System.Windows.Forms.RadioButton rbtCounterIncrease;
        private System.Windows.Forms.RadioButton rbtAccumulatedManual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAccumulatedManual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAccumulatedPercent;
        private System.Windows.Forms.RadioButton rbtAccumulatedPercent;
        private System.Windows.Forms.RadioButton rbtAccumulatedReset;
        private System.Windows.Forms.Label lblNewAccumulated;
        private System.Windows.Forms.Label lblNewCounter;
        private GC.Components.CMP_BtnAlter btnSave;
        private System.Windows.Forms.Panel pnlAccumulatedBack;
        private System.Windows.Forms.Panel pnlCounterBack;
    }
}