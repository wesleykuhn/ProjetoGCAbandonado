namespace GC.Forms.Main.Modals.Reminders.SubModals
{
    partial class frmModal_NewOrAlterReminder_HourAndMinutesSelector
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
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlHourBack = new System.Windows.Forms.Panel();
            this.lblHourSelected = new System.Windows.Forms.Label();
            this.lblHourP3 = new System.Windows.Forms.Label();
            this.lblHourP2 = new System.Windows.Forms.Label();
            this.lblHourP1 = new System.Windows.Forms.Label();
            this.lblHourM1 = new System.Windows.Forms.Label();
            this.lblHourM2 = new System.Windows.Forms.Label();
            this.lblHourM3 = new System.Windows.Forms.Label();
            this.pnlSelectedHourBack = new System.Windows.Forms.Panel();
            this.pnlMinuteBack = new System.Windows.Forms.Panel();
            this.lblMinuteSelected = new System.Windows.Forms.Label();
            this.lblMinuteP3 = new System.Windows.Forms.Label();
            this.lblMinuteP2 = new System.Windows.Forms.Label();
            this.lblMinuteP1 = new System.Windows.Forms.Label();
            this.lblMinuteM1 = new System.Windows.Forms.Label();
            this.lblMinuteM2 = new System.Windows.Forms.Label();
            this.lblMinuteM3 = new System.Windows.Forms.Label();
            this.pnlSelectedMinuteBack = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.pnlHourBack.SuspendLayout();
            this.pnlMinuteBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBackground.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBackground.Controls.Add(this.label1);
            this.pnlBackground.Controls.Add(this.pnlMinuteBack);
            this.pnlBackground.Controls.Add(this.pnlHourBack);
            this.pnlBackground.Location = new System.Drawing.Point(2, 30);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(352, 277);
            this.pnlBackground.TabIndex = 37;
            // 
            // pnlHourBack
            // 
            this.pnlHourBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnlHourBack.Controls.Add(this.lblHourSelected);
            this.pnlHourBack.Controls.Add(this.lblHourP3);
            this.pnlHourBack.Controls.Add(this.lblHourP2);
            this.pnlHourBack.Controls.Add(this.lblHourP1);
            this.pnlHourBack.Controls.Add(this.lblHourM1);
            this.pnlHourBack.Controls.Add(this.lblHourM2);
            this.pnlHourBack.Controls.Add(this.lblHourM3);
            this.pnlHourBack.Controls.Add(this.pnlSelectedHourBack);
            this.pnlHourBack.ForeColor = System.Drawing.Color.White;
            this.pnlHourBack.Location = new System.Drawing.Point(59, 40);
            this.pnlHourBack.Name = "pnlHourBack";
            this.pnlHourBack.Size = new System.Drawing.Size(100, 192);
            this.pnlHourBack.TabIndex = 1;
            // 
            // lblHourSelected
            // 
            this.lblHourSelected.AutoSize = true;
            this.lblHourSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(192)))), ((int)(((byte)(202)))));
            this.lblHourSelected.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHourSelected.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourSelected.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHourSelected.Location = new System.Drawing.Point(27, 81);
            this.lblHourSelected.Name = "lblHourSelected";
            this.lblHourSelected.Size = new System.Drawing.Size(47, 29);
            this.lblHourSelected.TabIndex = 6;
            this.lblHourSelected.Text = "09";
            // 
            // lblHourP3
            // 
            this.lblHourP3.AutoSize = true;
            this.lblHourP3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHourP3.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblHourP3.ForeColor = System.Drawing.Color.White;
            this.lblHourP3.Location = new System.Drawing.Point(40, 160);
            this.lblHourP3.Name = "lblHourP3";
            this.lblHourP3.Size = new System.Drawing.Size(21, 13);
            this.lblHourP3.TabIndex = 5;
            this.lblHourP3.Text = "12";
            this.lblHourP3.Click += new System.EventHandler(this.lblHourP3_Click);
            // 
            // lblHourP2
            // 
            this.lblHourP2.AutoSize = true;
            this.lblHourP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHourP2.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblHourP2.ForeColor = System.Drawing.Color.White;
            this.lblHourP2.Location = new System.Drawing.Point(37, 138);
            this.lblHourP2.Name = "lblHourP2";
            this.lblHourP2.Size = new System.Drawing.Size(26, 17);
            this.lblHourP2.TabIndex = 4;
            this.lblHourP2.Text = "11";
            this.lblHourP2.Click += new System.EventHandler(this.lblHourP2_Click);
            // 
            // lblHourP1
            // 
            this.lblHourP1.AutoSize = true;
            this.lblHourP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHourP1.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblHourP1.ForeColor = System.Drawing.Color.White;
            this.lblHourP1.Location = new System.Drawing.Point(36, 115);
            this.lblHourP1.Name = "lblHourP1";
            this.lblHourP1.Size = new System.Drawing.Size(28, 18);
            this.lblHourP1.TabIndex = 3;
            this.lblHourP1.Text = "10";
            this.lblHourP1.Click += new System.EventHandler(this.lblHourP1_Click);
            // 
            // lblHourM1
            // 
            this.lblHourM1.AutoSize = true;
            this.lblHourM1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHourM1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourM1.ForeColor = System.Drawing.Color.White;
            this.lblHourM1.Location = new System.Drawing.Point(36, 58);
            this.lblHourM1.Name = "lblHourM1";
            this.lblHourM1.Size = new System.Drawing.Size(28, 18);
            this.lblHourM1.TabIndex = 2;
            this.lblHourM1.Text = "08";
            this.lblHourM1.Click += new System.EventHandler(this.lblHourM1_Click);
            // 
            // lblHourM2
            // 
            this.lblHourM2.AutoSize = true;
            this.lblHourM2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHourM2.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblHourM2.ForeColor = System.Drawing.Color.White;
            this.lblHourM2.Location = new System.Drawing.Point(37, 36);
            this.lblHourM2.Name = "lblHourM2";
            this.lblHourM2.Size = new System.Drawing.Size(26, 17);
            this.lblHourM2.TabIndex = 1;
            this.lblHourM2.Text = "07";
            this.lblHourM2.Click += new System.EventHandler(this.lblHourM2_Click);
            // 
            // lblHourM3
            // 
            this.lblHourM3.AutoSize = true;
            this.lblHourM3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHourM3.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblHourM3.ForeColor = System.Drawing.Color.White;
            this.lblHourM3.Location = new System.Drawing.Point(40, 18);
            this.lblHourM3.Name = "lblHourM3";
            this.lblHourM3.Size = new System.Drawing.Size(21, 13);
            this.lblHourM3.TabIndex = 0;
            this.lblHourM3.Text = "06";
            this.lblHourM3.Click += new System.EventHandler(this.lblHourM3_Click);
            // 
            // pnlSelectedHourBack
            // 
            this.pnlSelectedHourBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(192)))), ((int)(((byte)(202)))));
            this.pnlSelectedHourBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlSelectedHourBack.Location = new System.Drawing.Point(0, 80);
            this.pnlSelectedHourBack.Name = "pnlSelectedHourBack";
            this.pnlSelectedHourBack.Size = new System.Drawing.Size(100, 31);
            this.pnlSelectedHourBack.TabIndex = 7;
            // 
            // pnlMinuteBack
            // 
            this.pnlMinuteBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnlMinuteBack.Controls.Add(this.lblMinuteSelected);
            this.pnlMinuteBack.Controls.Add(this.lblMinuteP3);
            this.pnlMinuteBack.Controls.Add(this.lblMinuteP2);
            this.pnlMinuteBack.Controls.Add(this.lblMinuteP1);
            this.pnlMinuteBack.Controls.Add(this.lblMinuteM1);
            this.pnlMinuteBack.Controls.Add(this.lblMinuteM2);
            this.pnlMinuteBack.Controls.Add(this.lblMinuteM3);
            this.pnlMinuteBack.Controls.Add(this.pnlSelectedMinuteBack);
            this.pnlMinuteBack.ForeColor = System.Drawing.Color.White;
            this.pnlMinuteBack.Location = new System.Drawing.Point(193, 40);
            this.pnlMinuteBack.Name = "pnlMinuteBack";
            this.pnlMinuteBack.Size = new System.Drawing.Size(100, 192);
            this.pnlMinuteBack.TabIndex = 3;
            // 
            // lblMinuteSelected
            // 
            this.lblMinuteSelected.AutoSize = true;
            this.lblMinuteSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(192)))), ((int)(((byte)(202)))));
            this.lblMinuteSelected.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMinuteSelected.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuteSelected.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMinuteSelected.Location = new System.Drawing.Point(27, 81);
            this.lblMinuteSelected.Name = "lblMinuteSelected";
            this.lblMinuteSelected.Size = new System.Drawing.Size(47, 29);
            this.lblMinuteSelected.TabIndex = 6;
            this.lblMinuteSelected.Text = "30";
            // 
            // lblMinuteP3
            // 
            this.lblMinuteP3.AutoSize = true;
            this.lblMinuteP3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinuteP3.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblMinuteP3.ForeColor = System.Drawing.Color.White;
            this.lblMinuteP3.Location = new System.Drawing.Point(40, 160);
            this.lblMinuteP3.Name = "lblMinuteP3";
            this.lblMinuteP3.Size = new System.Drawing.Size(21, 13);
            this.lblMinuteP3.TabIndex = 5;
            this.lblMinuteP3.Text = "33";
            this.lblMinuteP3.Click += new System.EventHandler(this.lblMinuteP3_Click);
            // 
            // lblMinuteP2
            // 
            this.lblMinuteP2.AutoSize = true;
            this.lblMinuteP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinuteP2.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblMinuteP2.ForeColor = System.Drawing.Color.White;
            this.lblMinuteP2.Location = new System.Drawing.Point(37, 138);
            this.lblMinuteP2.Name = "lblMinuteP2";
            this.lblMinuteP2.Size = new System.Drawing.Size(26, 17);
            this.lblMinuteP2.TabIndex = 4;
            this.lblMinuteP2.Text = "32";
            this.lblMinuteP2.Click += new System.EventHandler(this.lblMinuteP2_Click);
            // 
            // lblMinuteP1
            // 
            this.lblMinuteP1.AutoSize = true;
            this.lblMinuteP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinuteP1.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblMinuteP1.ForeColor = System.Drawing.Color.White;
            this.lblMinuteP1.Location = new System.Drawing.Point(36, 115);
            this.lblMinuteP1.Name = "lblMinuteP1";
            this.lblMinuteP1.Size = new System.Drawing.Size(28, 18);
            this.lblMinuteP1.TabIndex = 3;
            this.lblMinuteP1.Text = "31";
            this.lblMinuteP1.Click += new System.EventHandler(this.lblMinuteP1_Click);
            // 
            // lblMinuteM1
            // 
            this.lblMinuteM1.AutoSize = true;
            this.lblMinuteM1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinuteM1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuteM1.ForeColor = System.Drawing.Color.White;
            this.lblMinuteM1.Location = new System.Drawing.Point(36, 58);
            this.lblMinuteM1.Name = "lblMinuteM1";
            this.lblMinuteM1.Size = new System.Drawing.Size(28, 18);
            this.lblMinuteM1.TabIndex = 2;
            this.lblMinuteM1.Text = "29";
            this.lblMinuteM1.Click += new System.EventHandler(this.lblMinuteM1_Click);
            // 
            // lblMinuteM2
            // 
            this.lblMinuteM2.AutoSize = true;
            this.lblMinuteM2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinuteM2.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblMinuteM2.ForeColor = System.Drawing.Color.White;
            this.lblMinuteM2.Location = new System.Drawing.Point(37, 36);
            this.lblMinuteM2.Name = "lblMinuteM2";
            this.lblMinuteM2.Size = new System.Drawing.Size(26, 17);
            this.lblMinuteM2.TabIndex = 1;
            this.lblMinuteM2.Text = "28";
            this.lblMinuteM2.Click += new System.EventHandler(this.lblMinuteM2_Click);
            // 
            // lblMinuteM3
            // 
            this.lblMinuteM3.AutoSize = true;
            this.lblMinuteM3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinuteM3.Font = new System.Drawing.Font("Verdana", 8F);
            this.lblMinuteM3.ForeColor = System.Drawing.Color.White;
            this.lblMinuteM3.Location = new System.Drawing.Point(40, 18);
            this.lblMinuteM3.Name = "lblMinuteM3";
            this.lblMinuteM3.Size = new System.Drawing.Size(21, 13);
            this.lblMinuteM3.TabIndex = 0;
            this.lblMinuteM3.Text = "27";
            this.lblMinuteM3.Click += new System.EventHandler(this.lblMinuteM3_Click);
            // 
            // pnlSelectedMinuteBack
            // 
            this.pnlSelectedMinuteBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(192)))), ((int)(((byte)(202)))));
            this.pnlSelectedMinuteBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlSelectedMinuteBack.Location = new System.Drawing.Point(0, 80);
            this.pnlSelectedMinuteBack.Name = "pnlSelectedMinuteBack";
            this.pnlSelectedMinuteBack.Size = new System.Drawing.Size(100, 31);
            this.pnlSelectedMinuteBack.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // frmModal_NewOrAlterReminder_HourAndMinutesSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 309);
            this.Controls.Add(this.pnlBackground);
            this.Name = "frmModal_NewOrAlterReminder_HourAndMinutesSelector";
            this.Text = "GC - Agenda > Adicionar Lembrete > Selecionando Horário";
            this.Controls.SetChildIndex(this.pnlBackground, 0);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.pnlHourBack.ResumeLayout(false);
            this.pnlHourBack.PerformLayout();
            this.pnlMinuteBack.ResumeLayout(false);
            this.pnlMinuteBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlHourBack;
        private System.Windows.Forms.Label lblHourSelected;
        private System.Windows.Forms.Label lblHourP3;
        private System.Windows.Forms.Label lblHourP2;
        private System.Windows.Forms.Label lblHourP1;
        private System.Windows.Forms.Label lblHourM1;
        private System.Windows.Forms.Label lblHourM2;
        private System.Windows.Forms.Label lblHourM3;
        private System.Windows.Forms.Panel pnlSelectedHourBack;
        private System.Windows.Forms.Panel pnlMinuteBack;
        private System.Windows.Forms.Label lblMinuteSelected;
        private System.Windows.Forms.Label lblMinuteP3;
        private System.Windows.Forms.Label lblMinuteP2;
        private System.Windows.Forms.Label lblMinuteP1;
        private System.Windows.Forms.Label lblMinuteM1;
        private System.Windows.Forms.Label lblMinuteM2;
        private System.Windows.Forms.Label lblMinuteM3;
        private System.Windows.Forms.Panel pnlSelectedMinuteBack;
        private System.Windows.Forms.Label label1;
    }
}