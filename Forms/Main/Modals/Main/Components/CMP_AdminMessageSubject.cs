using System;
using System.Drawing;
using System.Windows.Forms;
using GC.Library.Objects;
using GC.Library.Style;

namespace GC.Forms.Main.Modals.Main.Components
{
    public partial class CMP_AdminMessageSubject : UserControl
    {
        internal event EventHandler OnChildDelete;
        internal event EventHandler OnChildClick;
        private AdminMessage AdminMessage;

        internal CMP_AdminMessageSubject(AdminMessage adminMessage)
        {
            InitializeComponent();

            if (adminMessage.Subject.Length > 85)
            {
                lblSubject.Text += adminMessage.Subject.Substring(0, 85) + "...";
            }
            else
            {
                lblSubject.Text += adminMessage.Subject;
            }

            lblDelivered.Text = adminMessage.DeliveredIn.ToString("dd/MM/yyyy HH:mm:ss");

            switch (adminMessage.Color)
            {
                case 0:
                    ChangeBackColor(ColorsPalette.GDE_Dark);
                    ChangeForeColor(Color.White);

                    this.MouseEnter += new EventHandler(Mouse_Enter_0);
                    this.MouseLeave += new EventHandler(Mouse_Leave_0);
                    lblDelivered.MouseEnter += new EventHandler(Mouse_Enter_0);
                    lblDelivered.MouseLeave += new EventHandler(Mouse_Leave_0);
                    lblSubject.MouseEnter += new EventHandler(Mouse_Enter_0);
                    lblSubject.MouseLeave += new EventHandler(Mouse_Leave_0);
                    flpSubject.MouseEnter += new EventHandler(Mouse_Enter_0);
                    flpSubject.MouseLeave += new EventHandler(Mouse_Leave_0);
                    break;

                case 1:
                    ChangeBackColor(ColorsPalette.GDE_Info);
                    ChangeForeColor(Color.White);

                    this.MouseEnter += new EventHandler(Mouse_Enter_1);
                    this.MouseLeave += new EventHandler(Mouse_Leave_1);
                    lblDelivered.MouseEnter += new EventHandler(Mouse_Enter_1);
                    lblDelivered.MouseLeave += new EventHandler(Mouse_Leave_1);
                    lblSubject.MouseEnter += new EventHandler(Mouse_Enter_1);
                    lblSubject.MouseLeave += new EventHandler(Mouse_Leave_1);
                    flpSubject.MouseEnter += new EventHandler(Mouse_Enter_1);
                    flpSubject.MouseLeave += new EventHandler(Mouse_Leave_1);
                    break;

                case 2:
                    ChangeBackColor(ColorsPalette.GDE_Warning);

                    this.MouseEnter += new EventHandler(Mouse_Enter_2);
                    this.MouseLeave += new EventHandler(Mouse_Leave_2);
                    lblDelivered.MouseEnter += new EventHandler(Mouse_Enter_2);
                    lblDelivered.MouseLeave += new EventHandler(Mouse_Leave_2);
                    lblSubject.MouseEnter += new EventHandler(Mouse_Enter_2);
                    lblSubject.MouseLeave += new EventHandler(Mouse_Leave_2);
                    flpSubject.MouseEnter += new EventHandler(Mouse_Enter_2);
                    flpSubject.MouseLeave += new EventHandler(Mouse_Leave_2);
                    break;

                case 3:
                    ChangeBackColor(ColorsPalette.GDE_Danger);

                    this.MouseEnter += new EventHandler(Mouse_Enter_3);
                    this.MouseLeave += new EventHandler(Mouse_Leave_3);
                    lblDelivered.MouseEnter += new EventHandler(Mouse_Enter_3);
                    lblDelivered.MouseLeave += new EventHandler(Mouse_Leave_3);
                    lblSubject.MouseEnter += new EventHandler(Mouse_Enter_3);
                    lblSubject.MouseLeave += new EventHandler(Mouse_Leave_3);
                    flpSubject.MouseEnter += new EventHandler(Mouse_Enter_3);
                    flpSubject.MouseLeave += new EventHandler(Mouse_Leave_3);
                    break;
            }

            this.AdminMessage = adminMessage;
        }

        private void ChangeForeColor(Color newColor)
        {
            lblDelivered.ForeColor = newColor;
            lblSubject.ForeColor = newColor;
            lblDelete.ForeColor = newColor;
        }

        private void ChangeBackColor(Color newColor)
        {
            this.BackColor = newColor;
            flpSubject.BackColor = newColor;
            lblDelete.BackColor = newColor;
        }

        private void cmpAdminMessageSubject_Click(object sender, EventArgs e)
        {
            FRM_AdminMessages.SelectedAdminMessage = this.AdminMessage;

            OnChildClick(this, new EventArgs());
        }

        private void flpSubject_Click(object sender, EventArgs e)
        {
            FRM_AdminMessages.SelectedAdminMessage = this.AdminMessage;

            OnChildClick(this, new EventArgs());
        }

        private void lblSubject_Click(object sender, EventArgs e)
        {
            FRM_AdminMessages.SelectedAdminMessage = this.AdminMessage;

            OnChildClick(this, new EventArgs());
        }

        private void lblDelivered_Click(object sender, EventArgs e)
        {
            FRM_AdminMessages.SelectedAdminMessage = this.AdminMessage;

            OnChildClick(this, new EventArgs());
        }

        private void pnlDelete_Click(object sender, EventArgs e)
        {
            FRM_AdminMessages.SelectedAdminMessage = this.AdminMessage;

            OnChildDelete(this, new EventArgs());
        }

        //Mouse hover all events, select one
        //Dark
        private void Mouse_Enter_0(object sender, EventArgs e)
        {
            ChangeBackColor(ColorsPalette.GDE_Dark_Hover);
        }
        private void Mouse_Leave_0(object sender, EventArgs e)
        {
            ChangeBackColor(ColorsPalette.GDE_Dark);
        }

        //Info
        private void Mouse_Enter_1(object sender, EventArgs e)
        {
            ChangeBackColor(ColorsPalette.GDE_Info_Hover);
        }
        private void Mouse_Leave_1(object sender, EventArgs e)
        {
            ChangeBackColor(ColorsPalette.GDE_Info);
        }

        //Warning
        private void Mouse_Enter_2(object sender, EventArgs e)
        {
            ChangeBackColor(ColorsPalette.GDE_Warning_Hover);
        }
        private void Mouse_Leave_2(object sender, EventArgs e)
        {
            ChangeBackColor(ColorsPalette.GDE_Warning);
        }

        //Danger
        private void Mouse_Enter_3(object sender, EventArgs e)
        {
            ChangeBackColor(ColorsPalette.GDE_Danger_Hover);
        }
        private void Mouse_Leave_3(object sender, EventArgs e)
        {
            ChangeBackColor(ColorsPalette.GDE_Danger);
        }
    }
}
