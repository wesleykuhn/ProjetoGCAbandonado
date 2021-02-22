using System;
using System.Windows.Forms;

namespace GC.Forms.Main.Modals.Reminders.SubModals
{
    public partial class frmModal_NewOrAlterReminder_HourAndMinutesSelector : Bases.FRM_Default
    {
        internal int SelectedMinute;
        internal int SelectedHour;

        public frmModal_NewOrAlterReminder_HourAndMinutesSelector(DateTime defaultTime)
        {
            InitializeComponent();

            this.ReadyForm();
            this.UnableMinimize();
            this.EnableLabelTrainAnimation();

            this.SelectedMinute = defaultTime.Minute;
            this.SelectedHour = defaultTime.Hour;

            this.UpdateHoursPanel();
            this.UpdateMinutesPanel();

            //Set the events on the components
            pnlHourBack.MouseWheel += new MouseEventHandler(this.Hours_MouseWheel);
            pnlMinuteBack.MouseWheel += new MouseEventHandler(this.Minutes_MouseWheel);
        }

        private void UpdateHoursPanel()
        {
            // 1st hour label handler
            if(this.SelectedHour - 3 < 0)
            {
                lblHourM3.Text = (24 + this.SelectedHour - 3).ToString("00");
            }
            else
            {
                lblHourM3.Text = (this.SelectedHour - 3).ToString("00");
            }

            // 2nd hour label handler
            if (this.SelectedHour - 2 < 0)
            {
                lblHourM2.Text = (24 + this.SelectedHour - 2).ToString("00");
            }
            else
            {
                lblHourM2.Text = (this.SelectedHour - 2).ToString("00");
            }

            // 3rd hour label handler
            if (this.SelectedHour - 1 < 0)
            {
                lblHourM1.Text = (24 + this.SelectedHour - 1).ToString("00");
            }
            else
            {
                lblHourM1.Text = (this.SelectedHour - 1).ToString("00");
            }

            // The middle hour label doesnt require handler
            lblHourSelected.Text = this.SelectedHour.ToString("00");

            // 5th hour label handler
            if (this.SelectedHour + 1 > 23)
            {
                lblHourP1.Text = (this.SelectedHour + 1 - 24).ToString("00");
            }
            else
            {
                lblHourP1.Text = (this.SelectedHour + 1).ToString("00");
            }

            // 6th hour label handler
            if (this.SelectedHour + 2 > 23)
            {
                lblHourP2.Text = (this.SelectedHour + 2 - 24).ToString("00");
            }
            else
            {
                lblHourP2.Text = (this.SelectedHour + 2).ToString("00");
            }

            // 7th hour label handler
            if (this.SelectedHour + 3 > 23)
            {
                lblHourP3.Text = (this.SelectedHour + 3 - 24).ToString("00");
            }
            else
            {
                lblHourP3.Text = (this.SelectedHour + 3).ToString("00");
            }
        }

        private void UpdateMinutesPanel()
        {
            // 1st hour label handler
            if (this.SelectedMinute - 3 < 0)
            {
                lblMinuteM3.Text = (60 + this.SelectedMinute - 3).ToString("00");
            }
            else
            {
                lblMinuteM3.Text = (this.SelectedMinute - 3).ToString("00");
            }

            // 2nd hour label handler
            if (this.SelectedMinute - 2 < 0)
            {
                lblMinuteM2.Text = (60 + this.SelectedMinute - 2).ToString("00");
            }
            else
            {
                lblMinuteM2.Text = (this.SelectedMinute - 2).ToString("00");
            }

            // 3rd hour label handler
            if (this.SelectedMinute - 1 < 0)
            {
                lblMinuteM1.Text = (60 + this.SelectedMinute - 1).ToString("00");
            }
            else
            {
                lblMinuteM1.Text = (this.SelectedMinute - 1).ToString("00");
            }

            // The middle hour label doesnt require handler
            lblMinuteSelected.Text = this.SelectedMinute.ToString("00");

            // 5th hour label handler
            if (this.SelectedMinute + 1 > 59)
            {
                lblMinuteP1.Text = (this.SelectedMinute + 1 - 60).ToString("00");
            }
            else
            {
                lblMinuteP1.Text = (this.SelectedMinute + 1).ToString("00");
            }

            // 6th hour label handler
            if (this.SelectedMinute + 2 > 59)
            {
                lblMinuteP2.Text = (this.SelectedMinute + 2 - 60).ToString("00");
            }
            else
            {
                lblMinuteP2.Text = (this.SelectedMinute + 2).ToString("00");
            }

            // 7th hour label handler
            if (this.SelectedMinute + 3 > 59)
            {
                lblMinuteP3.Text = (this.SelectedMinute + 3 - 60).ToString("00");
            }
            else
            {
                lblMinuteP3.Text = (this.SelectedMinute + 3).ToString("00");
            }
        }

        // Scrolling events
        private void Hours_MouseWheel(object sender, MouseEventArgs e)
        {
            //Sensible wheels
            if((e.Delta < 0 && e.Delta * -1 < 120) || (e.Delta > 0 && e.Delta < 120))
            {
                // Sensible negative
                if(e.Delta < 0)
                {
                    this.SelectedHour += e.Delta * -1 / 5;

                    if (this.SelectedHour > 23) this.SelectedHour = this.SelectedHour - 24;
                }
                // Sensible positive
                else
                {
                    this.SelectedHour -= e.Delta / 5;

                    if (this.SelectedHour < 0) this.SelectedHour = 24 + this.SelectedHour;
                }
            }
            // Trasher Wheels like mine
            else if((e.Delta < 0 && e.Delta * -1 >= 120) || (e.Delta > 0 && e.Delta >= 120))
            {
                // Here it is :/
                if(e.Delta == -120)
                {
                    this.SelectedHour--;

                    if (this.SelectedHour < 0) this.SelectedHour = 24 + this.SelectedHour;
                }
                else if(e.Delta == 120)
                {
                    this.SelectedHour++;

                    if (this.SelectedHour > 23) this.SelectedHour = this.SelectedHour - 24;
                }
                // Hold on, or it's not a trasher wheel or is a desquised one!
                else
                {
                    if(e.Delta > 0)
                    {
                        this.SelectedHour -= 6;

                        if (this.SelectedHour < 0) this.SelectedHour = 24 + this.SelectedHour;
                    }
                    else
                    {
                        this.SelectedHour += 6;

                        if (this.SelectedHour > 23) this.SelectedHour = this.SelectedHour - 24;
                    }
                }
            }

            this.UpdateHoursPanel();
        }

        // Scrolling events
        private void Minutes_MouseWheel(object sender, MouseEventArgs e)
        {
            //Sensible wheels
            if ((e.Delta < 0 && e.Delta * -1 < 120) || (e.Delta > 0 && e.Delta < 120))
            {
                // Sensible negative
                if (e.Delta < 0)
                {
                    this.SelectedMinute += e.Delta * -1 / 5;

                    if (this.SelectedMinute > 59) this.SelectedMinute = this.SelectedMinute - 60;
                }
                // Sensible positive
                else
                {
                    this.SelectedMinute -= e.Delta / 5;

                    if (this.SelectedMinute < 0) this.SelectedMinute = 60 + this.SelectedMinute;
                }
            }
            // Trasher Wheels like mine
            else if ((e.Delta < 0 && e.Delta * -1 >= 120) || (e.Delta > 0 && e.Delta >= 120))
            {
                // Here it is :/
                if (e.Delta == -120)
                {
                    this.SelectedMinute--;

                    if (this.SelectedMinute < 0) this.SelectedMinute = 60 + this.SelectedMinute;
                }
                else if (e.Delta == 120)
                {
                    this.SelectedMinute++;

                    if (this.SelectedMinute > 59) this.SelectedMinute = this.SelectedMinute - 60;
                }
                // Hold on, or it's not a trasher wheel or is a desquised one!
                else
                {
                    if (e.Delta > 0)
                    {
                        this.SelectedMinute -= 6;

                        if (this.SelectedMinute < 0) this.SelectedMinute = 60 + this.SelectedMinute;
                    }
                    else
                    {
                        this.SelectedMinute += 6;

                        if (this.SelectedMinute > 59) this.SelectedMinute = this.SelectedMinute - 60;
                    }
                }
            }

            this.UpdateMinutesPanel();
        }

        // Labels click events
        // Hours
        private void SelectedHourValidator(int incrementValue)
        {
            this.SelectedHour += incrementValue;

            if (this.SelectedHour < 0) this.SelectedHour = 24 + this.SelectedHour;
            else if (this.SelectedHour > 23) this.SelectedHour = this.SelectedHour - 24;

            this.UpdateHoursPanel();
        }

        private void lblHourM3_Click(object sender, EventArgs e)
        {
            this.SelectedHourValidator(-3);
        }

        private void lblHourM2_Click(object sender, EventArgs e)
        {
            this.SelectedHourValidator(-2);
        }

        private void lblHourM1_Click(object sender, EventArgs e)
        {
            this.SelectedHourValidator(-1);
        }

        private void lblHourP1_Click(object sender, EventArgs e)
        {
            this.SelectedHourValidator(1);
        }

        private void lblHourP2_Click(object sender, EventArgs e)
        {
            this.SelectedHourValidator(2);
        }

        private void lblHourP3_Click(object sender, EventArgs e)
        {
            this.SelectedHourValidator(3);
        }

        // Minutes
        private void SelectedMinuteValidator(int incrementValue)
        {
            this.SelectedMinute += incrementValue;

            if (this.SelectedMinute < 0) this.SelectedMinute = 60 + this.SelectedMinute;
            else if (this.SelectedMinute > 59) this.SelectedMinute = this.SelectedMinute - 60;

            this.UpdateMinutesPanel();
        }

        private void lblMinuteM3_Click(object sender, EventArgs e)
        {
            this.SelectedMinuteValidator(-3);
        }

        private void lblMinuteM2_Click(object sender, EventArgs e)
        {
            this.SelectedMinuteValidator(-2);
        }

        private void lblMinuteM1_Click(object sender, EventArgs e)
        {
            this.SelectedMinuteValidator(-1);
        }

        private void lblMinuteP1_Click(object sender, EventArgs e)
        {
            this.SelectedMinuteValidator(1);
        }

        private void lblMinuteP2_Click(object sender, EventArgs e)
        {
            this.SelectedMinuteValidator(2);
        }

        private void lblMinuteP3_Click(object sender, EventArgs e)
        {
            this.SelectedMinuteValidator(3);
        }
    }
}
