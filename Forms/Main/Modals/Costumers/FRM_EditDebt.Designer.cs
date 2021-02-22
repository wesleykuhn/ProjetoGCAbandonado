namespace GC.Forms.Main.Modals.Costumers
{
    partial class FRM_EditDebt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_EditDebt));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlter = new GC.Components.CMP_BtnAlter();
            this.nudEditedDebt = new System.Windows.Forms.NumericUpDown();
            this.lblSignal = new System.Windows.Forms.Label();
            this.pnlToolsBack = new System.Windows.Forms.Panel();
            this.btnMakeZero = new System.Windows.Forms.Button();
            this.btnP0_10 = new System.Windows.Forms.Button();
            this.btnP0_05 = new System.Windows.Forms.Button();
            this.btnM0_10 = new System.Windows.Forms.Button();
            this.btnM0_05 = new System.Windows.Forms.Button();
            this.btnP100 = new System.Windows.Forms.Button();
            this.btnP10 = new System.Windows.Forms.Button();
            this.btnP1 = new System.Windows.Forms.Button();
            this.btnM10 = new System.Windows.Forms.Button();
            this.btnM100 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnM1000 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtDown = new System.Windows.Forms.RadioButton();
            this.rbtUp = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentDebt = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditedDebt)).BeginInit();
            this.pnlToolsBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnAlter);
            this.panel1.Controls.Add(this.nudEditedDebt);
            this.panel1.Controls.Add(this.lblSignal);
            this.panel1.Controls.Add(this.pnlToolsBack);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rbtDown);
            this.panel1.Controls.Add(this.rbtUp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCurrentDebt);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 365);
            this.panel1.TabIndex = 34;
            // 
            // btnAlter
            // 
            this.btnAlter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAlter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(215)))));
            this.btnAlter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAlter.Image = global::GC.Properties.Resources.icon_lapis_30x30;
            this.btnAlter.Location = new System.Drawing.Point(10, 318);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(130, 40);
            this.btnAlter.TabIndex = 86;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // nudEditedDebt
            // 
            this.nudEditedDebt.DecimalPlaces = 2;
            this.nudEditedDebt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEditedDebt.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudEditedDebt.Location = new System.Drawing.Point(286, 112);
            this.nudEditedDebt.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudEditedDebt.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudEditedDebt.Name = "nudEditedDebt";
            this.nudEditedDebt.Size = new System.Drawing.Size(182, 23);
            this.nudEditedDebt.TabIndex = 3;
            this.nudEditedDebt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEditedDebt.ValueChanged += new System.EventHandler(this.NudEditedDebt_ValueChanged);
            // 
            // lblSignal
            // 
            this.lblSignal.AutoSize = true;
            this.lblSignal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignal.Location = new System.Drawing.Point(268, 111);
            this.lblSignal.Margin = new System.Windows.Forms.Padding(0);
            this.lblSignal.Name = "lblSignal";
            this.lblSignal.Size = new System.Drawing.Size(22, 22);
            this.lblSignal.TabIndex = 22;
            this.lblSignal.Text = "+";
            // 
            // pnlToolsBack
            // 
            this.pnlToolsBack.BackColor = System.Drawing.SystemColors.Control;
            this.pnlToolsBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlToolsBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolsBack.Controls.Add(this.btnMakeZero);
            this.pnlToolsBack.Controls.Add(this.btnP0_10);
            this.pnlToolsBack.Controls.Add(this.btnP0_05);
            this.pnlToolsBack.Controls.Add(this.btnM0_10);
            this.pnlToolsBack.Controls.Add(this.btnM0_05);
            this.pnlToolsBack.Controls.Add(this.btnP100);
            this.pnlToolsBack.Controls.Add(this.btnP10);
            this.pnlToolsBack.Controls.Add(this.btnP1);
            this.pnlToolsBack.Controls.Add(this.btnM10);
            this.pnlToolsBack.Controls.Add(this.btnM100);
            this.pnlToolsBack.Controls.Add(this.label5);
            this.pnlToolsBack.Controls.Add(this.btnM1000);
            this.pnlToolsBack.Location = new System.Drawing.Point(10, 150);
            this.pnlToolsBack.Name = "pnlToolsBack";
            this.pnlToolsBack.Size = new System.Drawing.Size(456, 145);
            this.pnlToolsBack.TabIndex = 18;
            // 
            // btnMakeZero
            // 
            this.btnMakeZero.BackColor = System.Drawing.SystemColors.Control;
            this.btnMakeZero.Location = new System.Drawing.Point(121, 104);
            this.btnMakeZero.Name = "btnMakeZero";
            this.btnMakeZero.Size = new System.Drawing.Size(211, 28);
            this.btnMakeZero.TabIndex = 14;
            this.btnMakeZero.Text = "Zerar número antes da vírgula";
            this.btnMakeZero.UseVisualStyleBackColor = false;
            this.btnMakeZero.Click += new System.EventHandler(this.BtnMakeZero_Click);
            // 
            // btnP0_10
            // 
            this.btnP0_10.BackColor = System.Drawing.SystemColors.Control;
            this.btnP0_10.Location = new System.Drawing.Point(341, 64);
            this.btnP0_10.Name = "btnP0_10";
            this.btnP0_10.Size = new System.Drawing.Size(61, 28);
            this.btnP0_10.TabIndex = 13;
            this.btnP0_10.Text = "+0,10";
            this.btnP0_10.UseVisualStyleBackColor = false;
            this.btnP0_10.Click += new System.EventHandler(this.BtnP0_10_Click);
            // 
            // btnP0_05
            // 
            this.btnP0_05.BackColor = System.Drawing.SystemColors.Control;
            this.btnP0_05.Location = new System.Drawing.Point(274, 64);
            this.btnP0_05.Name = "btnP0_05";
            this.btnP0_05.Size = new System.Drawing.Size(61, 28);
            this.btnP0_05.TabIndex = 12;
            this.btnP0_05.Text = "+0,05";
            this.btnP0_05.UseVisualStyleBackColor = false;
            this.btnP0_05.Click += new System.EventHandler(this.BtnP0_05_Click);
            // 
            // btnM0_10
            // 
            this.btnM0_10.BackColor = System.Drawing.SystemColors.Control;
            this.btnM0_10.Location = new System.Drawing.Point(111, 64);
            this.btnM0_10.Name = "btnM0_10";
            this.btnM0_10.Size = new System.Drawing.Size(61, 28);
            this.btnM0_10.TabIndex = 11;
            this.btnM0_10.Text = "-0,10";
            this.btnM0_10.UseVisualStyleBackColor = false;
            this.btnM0_10.Click += new System.EventHandler(this.BtnM0_10_Click);
            // 
            // btnM0_05
            // 
            this.btnM0_05.BackColor = System.Drawing.SystemColors.Control;
            this.btnM0_05.Location = new System.Drawing.Point(44, 64);
            this.btnM0_05.Name = "btnM0_05";
            this.btnM0_05.Size = new System.Drawing.Size(61, 28);
            this.btnM0_05.TabIndex = 10;
            this.btnM0_05.Text = "-0,05";
            this.btnM0_05.UseVisualStyleBackColor = false;
            this.btnM0_05.Click += new System.EventHandler(this.BtnM0_05_Click);
            // 
            // btnP100
            // 
            this.btnP100.BackColor = System.Drawing.SystemColors.Control;
            this.btnP100.Location = new System.Drawing.Point(382, 30);
            this.btnP100.Name = "btnP100";
            this.btnP100.Size = new System.Drawing.Size(61, 28);
            this.btnP100.TabIndex = 9;
            this.btnP100.Text = "+100";
            this.btnP100.UseVisualStyleBackColor = false;
            this.btnP100.Click += new System.EventHandler(this.BtnP1000_Click);
            // 
            // btnP10
            // 
            this.btnP10.BackColor = System.Drawing.SystemColors.Control;
            this.btnP10.Location = new System.Drawing.Point(315, 30);
            this.btnP10.Name = "btnP10";
            this.btnP10.Size = new System.Drawing.Size(61, 28);
            this.btnP10.TabIndex = 8;
            this.btnP10.Text = "+10";
            this.btnP10.UseVisualStyleBackColor = false;
            this.btnP10.Click += new System.EventHandler(this.BtnP100_Click);
            // 
            // btnP1
            // 
            this.btnP1.BackColor = System.Drawing.SystemColors.Control;
            this.btnP1.Location = new System.Drawing.Point(248, 30);
            this.btnP1.Name = "btnP1";
            this.btnP1.Size = new System.Drawing.Size(61, 28);
            this.btnP1.TabIndex = 7;
            this.btnP1.Text = "+1";
            this.btnP1.UseVisualStyleBackColor = false;
            this.btnP1.Click += new System.EventHandler(this.BtnP10_Click);
            // 
            // btnM10
            // 
            this.btnM10.BackColor = System.Drawing.SystemColors.Control;
            this.btnM10.Location = new System.Drawing.Point(146, 30);
            this.btnM10.Name = "btnM10";
            this.btnM10.Size = new System.Drawing.Size(61, 28);
            this.btnM10.TabIndex = 6;
            this.btnM10.Text = "-1";
            this.btnM10.UseVisualStyleBackColor = false;
            this.btnM10.Click += new System.EventHandler(this.BtnM10_Click);
            // 
            // btnM100
            // 
            this.btnM100.BackColor = System.Drawing.SystemColors.Control;
            this.btnM100.Location = new System.Drawing.Point(79, 30);
            this.btnM100.Name = "btnM100";
            this.btnM100.Size = new System.Drawing.Size(61, 28);
            this.btnM100.TabIndex = 5;
            this.btnM100.Text = "-10";
            this.btnM100.UseVisualStyleBackColor = false;
            this.btnM100.Click += new System.EventHandler(this.BtnM100_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(160, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ferramentas Rápidas:";
            // 
            // btnM1000
            // 
            this.btnM1000.BackColor = System.Drawing.SystemColors.Control;
            this.btnM1000.Location = new System.Drawing.Point(12, 30);
            this.btnM1000.Name = "btnM1000";
            this.btnM1000.Size = new System.Drawing.Size(61, 28);
            this.btnM1000.TabIndex = 4;
            this.btnM1000.Text = "-100";
            this.btnM1000.UseVisualStyleBackColor = false;
            this.btnM1000.Click += new System.EventHandler(this.BtnM1000_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "Quantidade a ser aumentada/diminuída:";
            // 
            // rbtDown
            // 
            this.rbtDown.AutoSize = true;
            this.rbtDown.Location = new System.Drawing.Point(264, 83);
            this.rbtDown.Name = "rbtDown";
            this.rbtDown.Size = new System.Drawing.Size(116, 18);
            this.rbtDown.TabIndex = 2;
            this.rbtDown.Text = "Diminuir dívida";
            this.rbtDown.UseVisualStyleBackColor = true;
            this.rbtDown.CheckedChanged += new System.EventHandler(this.RbtDown_CheckedChanged);
            // 
            // rbtUp
            // 
            this.rbtUp.AutoSize = true;
            this.rbtUp.Checked = true;
            this.rbtUp.Location = new System.Drawing.Point(131, 83);
            this.rbtUp.Name = "rbtUp";
            this.rbtUp.Size = new System.Drawing.Size(127, 18);
            this.rbtUp.TabIndex = 0;
            this.rbtUp.TabStop = true;
            this.rbtUp.Text = "Aumentar dívida";
            this.rbtUp.UseVisualStyleBackColor = true;
            this.rbtUp.CheckedChanged += new System.EventHandler(this.RbtUp_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "Modo de edição: ";
            // 
            // lblCurrentDebt
            // 
            this.lblCurrentDebt.AutoSize = true;
            this.lblCurrentDebt.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDebt.Location = new System.Drawing.Point(9, 39);
            this.lblCurrentDebt.Name = "lblCurrentDebt";
            this.lblCurrentDebt.Size = new System.Drawing.Size(106, 18);
            this.lblCurrentDebt.TabIndex = 2;
            this.lblCurrentDebt.Text = "Dívida Atual: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(9, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Label1";
            // 
            // FRM_EditDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(480, 397);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_EditDebt";
            this.Text = "GC - Clientes > Alteração de Dívida do Cliente";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditedDebt)).EndInit();
            this.pnlToolsBack.ResumeLayout(false);
            this.pnlToolsBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCurrentDebt;
        private System.Windows.Forms.NumericUpDown nudEditedDebt;
        private System.Windows.Forms.Label lblSignal;
        private System.Windows.Forms.Panel pnlToolsBack;
        private System.Windows.Forms.Button btnMakeZero;
        private System.Windows.Forms.Button btnP0_10;
        private System.Windows.Forms.Button btnP0_05;
        private System.Windows.Forms.Button btnM0_05;
        private System.Windows.Forms.Button btnP100;
        private System.Windows.Forms.Button btnP10;
        private System.Windows.Forms.Button btnP1;
        private System.Windows.Forms.Button btnM10;
        private System.Windows.Forms.Button btnM100;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnM1000;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtDown;
        private System.Windows.Forms.RadioButton rbtUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnM0_10;
        private GC.Components.CMP_BtnAlter btnAlter;
    }
}