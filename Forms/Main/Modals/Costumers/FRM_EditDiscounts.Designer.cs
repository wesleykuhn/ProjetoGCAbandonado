namespace GC.Forms.Main.Modals.Costumers
{
    partial class FRM_EditDiscounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_EditDiscounts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlter = new GC.Components.CMP_BtnAlter();
            this.pnlAccumulatedBack = new System.Windows.Forms.Panel();
            this.nudDiscountAccumulated = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentDiscountAccumulated = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCounterBack = new System.Windows.Forms.Panel();
            this.nudDiscountCounter = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentDiscountCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlAccumulatedBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountAccumulated)).BeginInit();
            this.pnlCounterBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnAlter);
            this.panel1.Controls.Add(this.pnlAccumulatedBack);
            this.panel1.Controls.Add(this.pnlCounterBack);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 226);
            this.panel1.TabIndex = 0;
            // 
            // btnAlter
            // 
            this.btnAlter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAlter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(215)))));
            this.btnAlter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAlter.Image = global::GC.Properties.Resources.icon_lapis_30x30;
            this.btnAlter.Location = new System.Drawing.Point(13, 176);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(130, 40);
            this.btnAlter.TabIndex = 87;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // pnlAccumulatedBack
            // 
            this.pnlAccumulatedBack.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAccumulatedBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlAccumulatedBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAccumulatedBack.Controls.Add(this.nudDiscountAccumulated);
            this.pnlAccumulatedBack.Controls.Add(this.label5);
            this.pnlAccumulatedBack.Controls.Add(this.lblCurrentDiscountAccumulated);
            this.pnlAccumulatedBack.Controls.Add(this.label4);
            this.pnlAccumulatedBack.Location = new System.Drawing.Point(293, 43);
            this.pnlAccumulatedBack.Name = "pnlAccumulatedBack";
            this.pnlAccumulatedBack.Size = new System.Drawing.Size(274, 99);
            this.pnlAccumulatedBack.TabIndex = 2;
            // 
            // nudDiscountAccumulated
            // 
            this.nudDiscountAccumulated.DecimalPlaces = 2;
            this.nudDiscountAccumulated.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudDiscountAccumulated.Location = new System.Drawing.Point(114, 61);
            this.nudDiscountAccumulated.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudDiscountAccumulated.Name = "nudDiscountAccumulated";
            this.nudDiscountAccumulated.Size = new System.Drawing.Size(112, 22);
            this.nudDiscountAccumulated.TabIndex = 1;
            this.nudDiscountAccumulated.ValueChanged += new System.EventHandler(this.NudDiscountAccumulated_ValueChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(46, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Editar: R$";
            // 
            // lblCurrentDiscountAccumulated
            // 
            this.lblCurrentDiscountAccumulated.AutoSize = true;
            this.lblCurrentDiscountAccumulated.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentDiscountAccumulated.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDiscountAccumulated.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCurrentDiscountAccumulated.Location = new System.Drawing.Point(66, 42);
            this.lblCurrentDiscountAccumulated.Name = "lblCurrentDiscountAccumulated";
            this.lblCurrentDiscountAccumulated.Size = new System.Drawing.Size(91, 16);
            this.lblCurrentDiscountAccumulated.TabIndex = 8;
            this.lblCurrentDiscountAccumulated.Text = "Valor atual: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Desconto Acumulado:";
            // 
            // pnlCounterBack
            // 
            this.pnlCounterBack.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCounterBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCounterBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCounterBack.Controls.Add(this.nudDiscountCounter);
            this.pnlCounterBack.Controls.Add(this.label3);
            this.pnlCounterBack.Controls.Add(this.lblCurrentDiscountCounter);
            this.pnlCounterBack.Controls.Add(this.label1);
            this.pnlCounterBack.Location = new System.Drawing.Point(13, 43);
            this.pnlCounterBack.Name = "pnlCounterBack";
            this.pnlCounterBack.Size = new System.Drawing.Size(274, 99);
            this.pnlCounterBack.TabIndex = 1;
            // 
            // nudDiscountCounter
            // 
            this.nudDiscountCounter.Location = new System.Drawing.Point(107, 62);
            this.nudDiscountCounter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDiscountCounter.Name = "nudDiscountCounter";
            this.nudDiscountCounter.Size = new System.Drawing.Size(112, 22);
            this.nudDiscountCounter.TabIndex = 0;
            this.nudDiscountCounter.ValueChanged += new System.EventHandler(this.NudDiscountCounter_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(48, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Editar: ";
            // 
            // lblCurrentDiscountCounter
            // 
            this.lblCurrentDiscountCounter.AutoSize = true;
            this.lblCurrentDiscountCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentDiscountCounter.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDiscountCounter.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCurrentDiscountCounter.Location = new System.Drawing.Point(66, 40);
            this.lblCurrentDiscountCounter.Name = "lblCurrentDiscountCounter";
            this.lblCurrentDiscountCounter.Size = new System.Drawing.Size(125, 16);
            this.lblCurrentDiscountCounter.TabIndex = 1;
            this.lblCurrentDiscountCounter.Text = "Contagem atual: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compras/Pedidos Anotados:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(10, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Label1";
            // 
            // FRM_EditDiscounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(586, 258);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_EditDiscounts";
            this.Text = "GC - Clientes > Alteração de Descontos do Cliente";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAccumulatedBack.ResumeLayout(false);
            this.pnlAccumulatedBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountAccumulated)).EndInit();
            this.pnlCounterBack.ResumeLayout(false);
            this.pnlCounterBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscountCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlCounterBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAccumulatedBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDiscountCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrentDiscountCounter;
        private System.Windows.Forms.Label lblCurrentDiscountAccumulated;
        private System.Windows.Forms.NumericUpDown nudDiscountAccumulated;
        private System.Windows.Forms.Label label5;
        private GC.Components.CMP_BtnAlter btnAlter;
    }
}