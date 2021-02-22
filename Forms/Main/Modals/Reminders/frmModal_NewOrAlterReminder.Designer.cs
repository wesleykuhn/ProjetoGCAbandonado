namespace GC.Forms.Main.Modals.Reminders
{
    partial class frmModal_NewOrAlterReminder
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
            this.btnAdd = new GC.Components.CMP_BtnAdd();
            this.rtbObservations = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEditCustomColor = new System.Windows.Forms.Label();
            this.rbtCustom = new System.Windows.Forms.RadioButton();
            this.rbtRed = new System.Windows.Forms.RadioButton();
            this.rbtYellow = new System.Windows.Forms.RadioButton();
            this.rbtGreen = new System.Windows.Forms.RadioButton();
            this.rbtBlue = new System.Windows.Forms.RadioButton();
            this.clxDark = new GC.Components.CMP_ColorBox();
            this.clxBlue = new GC.Components.CMP_ColorBox();
            this.pnlAddCustomColor = new System.Windows.Forms.Panel();
            this.clxCustom = new GC.Components.CMP_ColorBox();
            this.clxGreen = new GC.Components.CMP_ColorBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clxRed = new GC.Components.CMP_ColorBox();
            this.txtEndHour = new System.Windows.Forms.TextBox();
            this.clxYellow = new GC.Components.CMP_ColorBox();
            this.txtStartHour = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtDark = new System.Windows.Forms.RadioButton();
            this.cldColorPicker = new System.Windows.Forms.ColorDialog();
            this.btnAlter = new GC.Components.CMP_BtnAlter();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBackground.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBackground.Controls.Add(this.btnAlter);
            this.pnlBackground.Controls.Add(this.btnAdd);
            this.pnlBackground.Controls.Add(this.rtbObservations);
            this.pnlBackground.Controls.Add(this.label7);
            this.pnlBackground.Controls.Add(this.lblEditCustomColor);
            this.pnlBackground.Controls.Add(this.rbtCustom);
            this.pnlBackground.Controls.Add(this.rbtRed);
            this.pnlBackground.Controls.Add(this.rbtYellow);
            this.pnlBackground.Controls.Add(this.rbtGreen);
            this.pnlBackground.Controls.Add(this.rbtBlue);
            this.pnlBackground.Controls.Add(this.clxDark);
            this.pnlBackground.Controls.Add(this.clxBlue);
            this.pnlBackground.Controls.Add(this.pnlAddCustomColor);
            this.pnlBackground.Controls.Add(this.clxCustom);
            this.pnlBackground.Controls.Add(this.clxGreen);
            this.pnlBackground.Controls.Add(this.label6);
            this.pnlBackground.Controls.Add(this.clxRed);
            this.pnlBackground.Controls.Add(this.txtEndHour);
            this.pnlBackground.Controls.Add(this.clxYellow);
            this.pnlBackground.Controls.Add(this.txtStartHour);
            this.pnlBackground.Controls.Add(this.label5);
            this.pnlBackground.Controls.Add(this.label4);
            this.pnlBackground.Controls.Add(this.dtpEndDate);
            this.pnlBackground.Controls.Add(this.label3);
            this.pnlBackground.Controls.Add(this.dtpStartDate);
            this.pnlBackground.Controls.Add(this.label2);
            this.pnlBackground.Controls.Add(this.txtTitle);
            this.pnlBackground.Controls.Add(this.label1);
            this.pnlBackground.Controls.Add(this.rbtDark);
            this.pnlBackground.Location = new System.Drawing.Point(2, 30);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(439, 415);
            this.pnlBackground.TabIndex = 37;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(91)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.btnAdd.Image = global::GC.Properties.Resources.icon_mais_30x30;
            this.btnAdd.Location = new System.Drawing.Point(290, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 40);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rtbObservations
            // 
            this.rtbObservations.Location = new System.Drawing.Point(112, 227);
            this.rtbObservations.MaxLength = 255;
            this.rtbObservations.Name = "rtbObservations";
            this.rtbObservations.Size = new System.Drawing.Size(308, 96);
            this.rtbObservations.TabIndex = 27;
            this.rtbObservations.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 14);
            this.label7.TabIndex = 26;
            this.label7.Text = "Observações:";
            // 
            // lblEditCustomColor
            // 
            this.lblEditCustomColor.AutoSize = true;
            this.lblEditCustomColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditCustomColor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCustomColor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEditCustomColor.Location = new System.Drawing.Point(325, 125);
            this.lblEditCustomColor.Name = "lblEditCustomColor";
            this.lblEditCustomColor.Size = new System.Drawing.Size(40, 13);
            this.lblEditCustomColor.TabIndex = 25;
            this.lblEditCustomColor.Text = "Editar";
            this.lblEditCustomColor.Click += new System.EventHandler(this.lblEditCustomColor_Click);
            // 
            // rbtCustom
            // 
            this.rbtCustom.AutoSize = true;
            this.rbtCustom.Location = new System.Drawing.Point(338, 183);
            this.rbtCustom.Name = "rbtCustom";
            this.rbtCustom.Size = new System.Drawing.Size(14, 13);
            this.rbtCustom.TabIndex = 24;
            this.rbtCustom.UseVisualStyleBackColor = true;
            this.rbtCustom.CheckedChanged += new System.EventHandler(this.rbtCustom_CheckedChanged_1);
            // 
            // rbtRed
            // 
            this.rbtRed.AutoSize = true;
            this.rbtRed.Location = new System.Drawing.Point(283, 183);
            this.rbtRed.Name = "rbtRed";
            this.rbtRed.Size = new System.Drawing.Size(14, 13);
            this.rbtRed.TabIndex = 23;
            this.rbtRed.UseVisualStyleBackColor = true;
            // 
            // rbtYellow
            // 
            this.rbtYellow.AutoSize = true;
            this.rbtYellow.Location = new System.Drawing.Point(228, 183);
            this.rbtYellow.Name = "rbtYellow";
            this.rbtYellow.Size = new System.Drawing.Size(14, 13);
            this.rbtYellow.TabIndex = 22;
            this.rbtYellow.UseVisualStyleBackColor = true;
            // 
            // rbtGreen
            // 
            this.rbtGreen.AutoSize = true;
            this.rbtGreen.Location = new System.Drawing.Point(173, 183);
            this.rbtGreen.Name = "rbtGreen";
            this.rbtGreen.Size = new System.Drawing.Size(14, 13);
            this.rbtGreen.TabIndex = 21;
            this.rbtGreen.UseVisualStyleBackColor = true;
            // 
            // rbtBlue
            // 
            this.rbtBlue.AutoSize = true;
            this.rbtBlue.Location = new System.Drawing.Point(118, 183);
            this.rbtBlue.Name = "rbtBlue";
            this.rbtBlue.Size = new System.Drawing.Size(14, 13);
            this.rbtBlue.TabIndex = 20;
            this.rbtBlue.UseVisualStyleBackColor = true;
            // 
            // clxDark
            // 
            this.clxDark.BackColor = System.Drawing.SystemColors.Control;
            this.clxDark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clxDark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clxDark.Location = new System.Drawing.Point(50, 140);
            this.clxDark.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clxDark.Name = "clxDark";
            this.clxDark.Size = new System.Drawing.Size(40, 40);
            this.clxDark.TabIndex = 11;
            this.clxDark.Click += new System.EventHandler(this.clxDark_Click);
            // 
            // clxBlue
            // 
            this.clxBlue.BackColor = System.Drawing.SystemColors.Control;
            this.clxBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clxBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clxBlue.Location = new System.Drawing.Point(105, 140);
            this.clxBlue.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.clxBlue.Name = "clxBlue";
            this.clxBlue.Size = new System.Drawing.Size(40, 40);
            this.clxBlue.TabIndex = 12;
            this.clxBlue.Click += new System.EventHandler(this.clxBlue_Click);
            // 
            // pnlAddCustomColor
            // 
            this.pnlAddCustomColor.BackgroundImage = global::GC.Properties.Resources.icon_mais_30x30;
            this.pnlAddCustomColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlAddCustomColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddCustomColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAddCustomColor.Location = new System.Drawing.Point(325, 140);
            this.pnlAddCustomColor.Name = "pnlAddCustomColor";
            this.pnlAddCustomColor.Size = new System.Drawing.Size(40, 40);
            this.pnlAddCustomColor.TabIndex = 18;
            this.pnlAddCustomColor.Click += new System.EventHandler(this.PnlAddCustomColor_Click);
            // 
            // clxCustom
            // 
            this.clxCustom.BackColor = System.Drawing.SystemColors.Control;
            this.clxCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clxCustom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clxCustom.Location = new System.Drawing.Point(325, 140);
            this.clxCustom.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.clxCustom.Name = "clxCustom";
            this.clxCustom.Size = new System.Drawing.Size(40, 40);
            this.clxCustom.TabIndex = 17;
            this.clxCustom.Click += new System.EventHandler(this.PnlAddCustomColor_Click);
            // 
            // clxGreen
            // 
            this.clxGreen.BackColor = System.Drawing.SystemColors.Control;
            this.clxGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clxGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clxGreen.Location = new System.Drawing.Point(160, 140);
            this.clxGreen.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.clxGreen.Name = "clxGreen";
            this.clxGreen.Size = new System.Drawing.Size(40, 40);
            this.clxGreen.TabIndex = 13;
            this.clxGreen.Click += new System.EventHandler(this.clxGreen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cor:";
            // 
            // clxRed
            // 
            this.clxRed.BackColor = System.Drawing.SystemColors.Control;
            this.clxRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clxRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clxRed.Location = new System.Drawing.Point(270, 140);
            this.clxRed.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.clxRed.Name = "clxRed";
            this.clxRed.Size = new System.Drawing.Size(40, 40);
            this.clxRed.TabIndex = 16;
            this.clxRed.Click += new System.EventHandler(this.clxRed_Click);
            // 
            // txtEndHour
            // 
            this.txtEndHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEndHour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEndHour.Location = new System.Drawing.Point(362, 88);
            this.txtEndHour.MaxLength = 5;
            this.txtEndHour.Name = "txtEndHour";
            this.txtEndHour.Size = new System.Drawing.Size(45, 22);
            this.txtEndHour.TabIndex = 9;
            this.txtEndHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEndHour.Click += new System.EventHandler(this.txtEndHour_Click);
            this.txtEndHour.TextChanged += new System.EventHandler(this.txtEndHour_TextChanged);
            // 
            // clxYellow
            // 
            this.clxYellow.BackColor = System.Drawing.SystemColors.Control;
            this.clxYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clxYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clxYellow.Location = new System.Drawing.Point(214, 140);
            this.clxYellow.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.clxYellow.Name = "clxYellow";
            this.clxYellow.Size = new System.Drawing.Size(40, 40);
            this.clxYellow.TabIndex = 14;
            this.clxYellow.Click += new System.EventHandler(this.clxYellow_Click);
            // 
            // txtStartHour
            // 
            this.txtStartHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtStartHour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtStartHour.Location = new System.Drawing.Point(375, 50);
            this.txtStartHour.MaxLength = 5;
            this.txtStartHour.Name = "txtStartHour";
            this.txtStartHour.Size = new System.Drawing.Size(45, 22);
            this.txtStartHour.TabIndex = 8;
            this.txtStartHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartHour.Click += new System.EventHandler(this.txtStartHour_Click);
            this.txtStartHour.TextChanged += new System.EventHandler(this.txtStartHour_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "às";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "às";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(50, 88);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(278, 22);
            this.dtpEndDate.TabIndex = 5;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fim:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(62, 50);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(279, 22);
            this.dtpStartDate.TabIndex = 3;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Início:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(63, 12);
            this.txtTitle.MaxLength = 50;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(357, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título:";
            // 
            // rbtDark
            // 
            this.rbtDark.AutoSize = true;
            this.rbtDark.Checked = true;
            this.rbtDark.Location = new System.Drawing.Point(63, 183);
            this.rbtDark.Name = "rbtDark";
            this.rbtDark.Size = new System.Drawing.Size(14, 13);
            this.rbtDark.TabIndex = 19;
            this.rbtDark.TabStop = true;
            this.rbtDark.UseVisualStyleBackColor = true;
            // 
            // cldColorPicker
            // 
            this.cldColorPicker.AnyColor = true;
            // 
            // btnAlter
            // 
            this.btnAlter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAlter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAlter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(215)))));
            this.btnAlter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAlter.Image = global::GC.Properties.Resources.icon_lapis_30x30;
            this.btnAlter.Location = new System.Drawing.Point(154, 365);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(130, 40);
            this.btnAlter.TabIndex = 29;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // frmModal_NewOrAlterReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 447);
            this.Controls.Add(this.pnlBackground);
            this.Name = "frmModal_NewOrAlterReminder";
            this.Text = "GC - Agenda > Adicionar Lembrete";
            this.Controls.SetChildIndex(this.pnlBackground, 0);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEndHour;
        private System.Windows.Forms.TextBox txtStartHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private GC.Components.CMP_ColorBox clxDark;
        private GC.Components.CMP_ColorBox clxCustom;
        private GC.Components.CMP_ColorBox clxRed;
        private GC.Components.CMP_ColorBox clxYellow;
        private GC.Components.CMP_ColorBox clxGreen;
        private GC.Components.CMP_ColorBox clxBlue;
        private System.Windows.Forms.Panel pnlAddCustomColor;
        private System.Windows.Forms.ColorDialog cldColorPicker;
        private System.Windows.Forms.RadioButton rbtCustom;
        private System.Windows.Forms.RadioButton rbtRed;
        private System.Windows.Forms.RadioButton rbtYellow;
        private System.Windows.Forms.RadioButton rbtGreen;
        private System.Windows.Forms.RadioButton rbtBlue;
        private System.Windows.Forms.RadioButton rbtDark;
        private System.Windows.Forms.Label lblEditCustomColor;
        private System.Windows.Forms.RichTextBox rtbObservations;
        private System.Windows.Forms.Label label7;
        private GC.Components.CMP_BtnAdd btnAdd;
        private GC.Components.CMP_BtnAlter btnAlter;
    }
}