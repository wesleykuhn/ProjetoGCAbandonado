namespace GC.Forms.Main.Controls
{
    partial class USC_Schedule
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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange6 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange7 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange8 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange9 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange10 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.pnlCalendarBack = new System.Windows.Forms.Panel();
            this.btnCalendarMonthFoward = new GC.Components.CMP_BtnRegular();
            this.btnCalendarMonthBack = new GC.Components.CMP_BtnRegular();
            this.pnlMonthBack = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCalendarSelectedMonth = new System.Windows.Forms.Label();
            this.cldCalendar = new System.Windows.Forms.Calendar.Calendar();
            this.pnlDayScheduleBack = new System.Windows.Forms.Panel();
            this.cldDaysSchedule = new System.Windows.Forms.Calendar.Calendar();
            this.btnDaysScheduleZoomOut = new GC.Components.CMP_BtnRegular();
            this.btnDaysScheduleZoomIn = new GC.Components.CMP_BtnRegular();
            this.chxShowOld = new System.Windows.Forms.CheckBox();
            this.pnlCalendarBack.SuspendLayout();
            this.pnlMonthBack.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDayScheduleBack.SuspendLayout();
            this.cldDaysSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCalendarBack
            // 
            this.pnlCalendarBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCalendarBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pnlCalendarBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCalendarBack.Controls.Add(this.chxShowOld);
            this.pnlCalendarBack.Controls.Add(this.btnCalendarMonthFoward);
            this.pnlCalendarBack.Controls.Add(this.btnCalendarMonthBack);
            this.pnlCalendarBack.Controls.Add(this.pnlMonthBack);
            this.pnlCalendarBack.Controls.Add(this.cldCalendar);
            this.pnlCalendarBack.Location = new System.Drawing.Point(3, 3);
            this.pnlCalendarBack.Name = "pnlCalendarBack";
            this.pnlCalendarBack.Size = new System.Drawing.Size(500, 509);
            this.pnlCalendarBack.TabIndex = 0;
            // 
            // btnCalendarMonthFoward
            // 
            this.btnCalendarMonthFoward.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCalendarMonthFoward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.btnCalendarMonthFoward.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCalendarMonthFoward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnCalendarMonthFoward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCalendarMonthFoward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarMonthFoward.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarMonthFoward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCalendarMonthFoward.Location = new System.Drawing.Point(345, 3);
            this.btnCalendarMonthFoward.Name = "btnCalendarMonthFoward";
            this.btnCalendarMonthFoward.Size = new System.Drawing.Size(44, 36);
            this.btnCalendarMonthFoward.TabIndex = 3;
            this.btnCalendarMonthFoward.Text = ">";
            this.btnCalendarMonthFoward.UseVisualStyleBackColor = false;
            this.btnCalendarMonthFoward.Click += new System.EventHandler(this.btnCalendarMonthFoward_Click);
            // 
            // btnCalendarMonthBack
            // 
            this.btnCalendarMonthBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCalendarMonthBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.btnCalendarMonthBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCalendarMonthBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnCalendarMonthBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCalendarMonthBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendarMonthBack.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarMonthBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCalendarMonthBack.Location = new System.Drawing.Point(109, 3);
            this.btnCalendarMonthBack.Name = "btnCalendarMonthBack";
            this.btnCalendarMonthBack.Size = new System.Drawing.Size(44, 36);
            this.btnCalendarMonthBack.TabIndex = 2;
            this.btnCalendarMonthBack.Text = "<";
            this.btnCalendarMonthBack.UseVisualStyleBackColor = false;
            this.btnCalendarMonthBack.Click += new System.EventHandler(this.btnCalendarMonthBack_Click);
            // 
            // pnlMonthBack
            // 
            this.pnlMonthBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMonthBack.Controls.Add(this.panel1);
            this.pnlMonthBack.Location = new System.Drawing.Point(159, 3);
            this.pnlMonthBack.Name = "pnlMonthBack";
            this.pnlMonthBack.Size = new System.Drawing.Size(180, 36);
            this.pnlMonthBack.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblCalendarSelectedMonth);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 34);
            this.panel1.TabIndex = 2;
            // 
            // lblCalendarSelectedMonth
            // 
            this.lblCalendarSelectedMonth.AutoSize = true;
            this.lblCalendarSelectedMonth.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarSelectedMonth.Location = new System.Drawing.Point(29, 7);
            this.lblCalendarSelectedMonth.Name = "lblCalendarSelectedMonth";
            this.lblCalendarSelectedMonth.Size = new System.Drawing.Size(121, 23);
            this.lblCalendarSelectedMonth.TabIndex = 0;
            this.lblCalendarSelectedMonth.Text = "NOVEMBRO";
            // 
            // cldCalendar
            // 
            this.cldCalendar.AllowItemEdit = false;
            this.cldCalendar.AllowItemResize = false;
            this.cldCalendar.AllowNew = false;
            this.cldCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cldCalendar.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00");
            this.cldCalendar.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5};
            this.cldCalendar.Location = new System.Drawing.Point(1, 45);
            this.cldCalendar.Name = "cldCalendar";
            this.cldCalendar.Size = new System.Drawing.Size(498, 461);
            this.cldCalendar.TabIndex = 0;
            this.cldCalendar.Text = "Calendário Mensal";
            this.cldCalendar.ItemCreating += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.cldCalendar_ItemCreating);
            this.cldCalendar.ItemDeleting += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.cldCalendar_ItemDeleting);
            this.cldCalendar.ItemDoubleClick += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.cldCalendar_ItemDoubleClick);
            this.cldCalendar.ItemSelected += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.cldCalendar_ItemSelected);
            this.cldCalendar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cldCalendar_MouseUp);
            // 
            // pnlDayScheduleBack
            // 
            this.pnlDayScheduleBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDayScheduleBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDayScheduleBack.Controls.Add(this.cldDaysSchedule);
            this.pnlDayScheduleBack.Location = new System.Drawing.Point(509, 3);
            this.pnlDayScheduleBack.Name = "pnlDayScheduleBack";
            this.pnlDayScheduleBack.Size = new System.Drawing.Size(462, 509);
            this.pnlDayScheduleBack.TabIndex = 1;
            // 
            // cldDaysSchedule
            // 
            this.cldDaysSchedule.Controls.Add(this.btnDaysScheduleZoomOut);
            this.cldDaysSchedule.Controls.Add(this.btnDaysScheduleZoomIn);
            this.cldDaysSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cldDaysSchedule.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange6.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange6.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange6.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange7.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange7.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange7.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange8.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange8.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange8.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange9.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange9.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange9.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange10.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange10.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange10.StartTime = System.TimeSpan.Parse("08:00:00");
            this.cldDaysSchedule.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange6,
        calendarHighlightRange7,
        calendarHighlightRange8,
        calendarHighlightRange9,
        calendarHighlightRange10};
            this.cldDaysSchedule.Location = new System.Drawing.Point(0, 0);
            this.cldDaysSchedule.MaximumFullDays = 5;
            this.cldDaysSchedule.Name = "cldDaysSchedule";
            this.cldDaysSchedule.Size = new System.Drawing.Size(460, 507);
            this.cldDaysSchedule.TabIndex = 0;
            this.cldDaysSchedule.Text = "Horários do Dia";
            this.cldDaysSchedule.ItemCreating += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.cldDaysSchedule_ItemCreating);
            this.cldDaysSchedule.ItemDeleting += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.cldDaysSchedule_ItemDeleting);
            this.cldDaysSchedule.ItemDatesChanged += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.cldDaysSchedule_ItemDatesChanged);
            this.cldDaysSchedule.ItemDoubleClick += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.cldDaysSchedule_ItemDoubleClick);
            // 
            // btnDaysScheduleZoomOut
            // 
            this.btnDaysScheduleZoomOut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDaysScheduleZoomOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.btnDaysScheduleZoomOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnDaysScheduleZoomOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnDaysScheduleZoomOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnDaysScheduleZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaysScheduleZoomOut.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaysScheduleZoomOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnDaysScheduleZoomOut.Location = new System.Drawing.Point(6, 17);
            this.btnDaysScheduleZoomOut.Name = "btnDaysScheduleZoomOut";
            this.btnDaysScheduleZoomOut.Size = new System.Drawing.Size(22, 22);
            this.btnDaysScheduleZoomOut.TabIndex = 1;
            this.btnDaysScheduleZoomOut.Text = "";
            this.btnDaysScheduleZoomOut.UseVisualStyleBackColor = false;
            this.btnDaysScheduleZoomOut.Click += new System.EventHandler(this.btnDaysScheduleZoomOut_Click);
            // 
            // btnDaysScheduleZoomIn
            // 
            this.btnDaysScheduleZoomIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDaysScheduleZoomIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.btnDaysScheduleZoomIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnDaysScheduleZoomIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnDaysScheduleZoomIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnDaysScheduleZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaysScheduleZoomIn.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaysScheduleZoomIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnDaysScheduleZoomIn.Location = new System.Drawing.Point(33, 17);
            this.btnDaysScheduleZoomIn.Name = "btnDaysScheduleZoomIn";
            this.btnDaysScheduleZoomIn.Size = new System.Drawing.Size(22, 22);
            this.btnDaysScheduleZoomIn.TabIndex = 0;
            this.btnDaysScheduleZoomIn.Text = "";
            this.btnDaysScheduleZoomIn.UseVisualStyleBackColor = false;
            this.btnDaysScheduleZoomIn.Click += new System.EventHandler(this.btnDaysScheduleZoomIn_Click);
            // 
            // chxShowOld
            // 
            this.chxShowOld.AutoSize = true;
            this.chxShowOld.Location = new System.Drawing.Point(3, 3);
            this.chxShowOld.Name = "chxShowOld";
            this.chxShowOld.Size = new System.Drawing.Size(73, 18);
            this.chxShowOld.TabIndex = 4;
            this.chxShowOld.Text = "Antigos";
            this.chxShowOld.UseVisualStyleBackColor = true;
            this.chxShowOld.CheckedChanged += new System.EventHandler(this.chxShowOld_CheckedChanged);
            // 
            // USC_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDayScheduleBack);
            this.Controls.Add(this.pnlCalendarBack);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "USC_Schedule";
            this.Size = new System.Drawing.Size(974, 515);
            this.Resize += new System.EventHandler(this.USC_Schedule_Resize);
            this.pnlCalendarBack.ResumeLayout(false);
            this.pnlCalendarBack.PerformLayout();
            this.pnlMonthBack.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDayScheduleBack.ResumeLayout(false);
            this.cldDaysSchedule.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCalendarBack;
        private System.Windows.Forms.Calendar.Calendar cldCalendar;
        private GC.Components.CMP_BtnRegular btnCalendarMonthFoward;
        private GC.Components.CMP_BtnRegular btnCalendarMonthBack;
        private System.Windows.Forms.Panel pnlMonthBack;
        private System.Windows.Forms.Label lblCalendarSelectedMonth;
        private System.Windows.Forms.Panel pnlDayScheduleBack;
        private System.Windows.Forms.Calendar.Calendar cldDaysSchedule;
        private GC.Components.CMP_BtnRegular btnDaysScheduleZoomOut;
        private GC.Components.CMP_BtnRegular btnDaysScheduleZoomIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chxShowOld;
    }
}
