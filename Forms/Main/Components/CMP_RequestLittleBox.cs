using System;
using System.Drawing;
using System.Windows.Forms;
using GC.Library;
using GC.Library.Entities;
using GC.Library.Objects;
using GC.Library.Translators;

namespace GC.Forms.Main.Components
{
    public partial class CMP_RequestLittleBox : UserControl
    {
        internal event MouseEventHandler OnChildRequestClick;
        Request Request;

        internal CMP_RequestLittleBox(Request request)
        {
            InitializeComponent();

            lblNumber.Text = request.Number;
            lblCostumer.Text += Costumer.GetCostumerName(request.Id_Costumer);
            lblStarted.Text += request.StartedIn.ToString("dd/MM/yyyy HH:mm:ss");
            lblValue.Text += ObjectToDetailLabel.ToMoneyLabel(request.Value);

            if (!GlobalVariables.Requests.Exists(x => x.Id == request.Id))
            {
                pnlHasInDb.BackgroundImage = Properties.Resources.icon_not_on_cloud;
                pnlHasInDb.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                ToolTip1.SetToolTip(pnlHasInDb, String.Empty);
            }
            
            if (request.IsDelivery)
            {
                pnlIsDelivery.BackgroundImage = Properties.Resources.icon_entrega_30x30;
            }
            else
            {
                ToolTip1.SetToolTip(pnlIsDelivery, String.Empty);
            }

            if (request.ExpiresIn.ToString("yyyy-MM-dd") == "0001-01-01")
            {
                lblExpires.Text += "Sem validade.";
            }
            else
            {
                lblExpires.Text += request.ExpiresIn.ToString("dd/MM/yyyy HH:mm:ss");
            }

            if(request.Observations == null || request.Observations == "")
            {
                lblObservations.Text += "Não possuí.";
            }
            else
            {
                if(request.Observations.Length > 84)
                {
                    lblObservations.Text += request.Observations.Substring(0, 84) + "...";
                }
                else
                {
                    lblObservations.Text += request.Observations;
                }                
            }

            if (request.Status == 'P')
            {
                this.BackColor = Color.FromArgb(33, 149, 170);
                lblCostumer.BackColor = Color.FromArgb(33, 149, 170);
                lblExpires.BackColor = Color.FromArgb(33, 149, 170);
                lblNumber.BackColor = Color.FromArgb(33, 149, 170);
                lblStarted.BackColor = Color.FromArgb(33, 149, 170);
                lblValue.BackColor = Color.FromArgb(33, 149, 170);
                pnlIsDelivery.BackColor = Color.FromArgb(33, 149, 170);
                pnlHasInDb.BackColor = Color.FromArgb(33, 149, 170);
                flowLayoutPanel1.BackColor = Color.FromArgb(33, 149, 170);
            }
            else if(request.Status == 'C')
            {
                this.BackColor = Color.FromArgb(194, 43, 70);
                lblCostumer.BackColor = Color.FromArgb(194, 43, 70);
                lblExpires.BackColor = Color.FromArgb(194, 43, 70);
                lblNumber.BackColor = Color.FromArgb(194, 43, 70);
                lblStarted.BackColor = Color.FromArgb(194, 43, 70);
                lblValue.BackColor = Color.FromArgb(194, 43, 70);
                pnlIsDelivery.BackColor = Color.FromArgb(194, 43, 70);
                pnlHasInDb.BackColor = Color.FromArgb(194, 43, 70);
                flowLayoutPanel1.BackColor = Color.FromArgb(194, 43, 70);
            }
            else if(request.Status == 'F')
            {
                this.BackColor = Color.FromArgb(70, 159, 120);
                lblCostumer.BackColor = Color.FromArgb(70, 159, 120);
                lblExpires.BackColor = Color.FromArgb(70, 159, 120);
                lblNumber.BackColor = Color.FromArgb(70, 159, 120);
                lblStarted.BackColor = Color.FromArgb(70, 159, 120);
                lblValue.BackColor = Color.FromArgb(70, 159, 120);
                pnlIsDelivery.BackColor = Color.FromArgb(70, 159, 120);
                pnlHasInDb.BackColor = Color.FromArgb(70, 159, 120);
                flowLayoutPanel1.BackColor = Color.FromArgb(70, 159, 120);
            }
            else
            {
                this.BackColor = Color.FromArgb(230, 181, 34);
                lblCostumer.BackColor = Color.FromArgb(230, 181, 34);
                lblExpires.BackColor = Color.FromArgb(230, 181, 34);
                lblNumber.BackColor = Color.FromArgb(230, 181, 34);
                lblStarted.BackColor = Color.FromArgb(230, 181, 34);
                lblValue.BackColor = Color.FromArgb(230, 181, 34);
                pnlIsDelivery.BackColor = Color.FromArgb(230, 181, 34);
                pnlHasInDb.BackColor = Color.FromArgb(230, 181, 34);
                flowLayoutPanel1.BackColor = Color.FromArgb(230, 181, 34);
            }

            this.Request = request;
        }        

        private void CmpRequestLittleBox_MouseClick(object sender, MouseEventArgs e)
        {
            Main.Controls.USC_Requests.SelectedRequest = this.Request;
            Main.Controls.USC_Requests.mousePosition = CMP_RequestLittleBox.MousePosition;

            OnChildRequestClick(this, e);
        }

        private void PnlIsDelivery_MouseClick(object sender, MouseEventArgs e)
        {
            CmpRequestLittleBox_MouseClick(this, e);
        }

        private void LblNumber_MouseClick(object sender, MouseEventArgs e)
        {
            CmpRequestLittleBox_MouseClick(this, e);
        }

        private void LblStarted_MouseClick(object sender, MouseEventArgs e)
        {
            CmpRequestLittleBox_MouseClick(this, e);
        }

        private void LblValue_MouseClick(object sender, MouseEventArgs e)
        {
            CmpRequestLittleBox_MouseClick(this, e);
        }

        private void LblCostumer_MouseClick(object sender, MouseEventArgs e)
        {
            CmpRequestLittleBox_MouseClick(this, e);
        }

        private void LblExpires_MouseClick(object sender, MouseEventArgs e)
        {
            CmpRequestLittleBox_MouseClick(this, e);
        }

        private void LblObservations_MouseClick(object sender, MouseEventArgs e)
        {
            CmpRequestLittleBox_MouseClick(this, e);
        }

        private void PnlHasInDb_MouseClick(object sender, MouseEventArgs e)
        {
            CmpRequestLittleBox_MouseClick(this, e);
        }

        private void FlowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            CmpRequestLittleBox_MouseClick(this, e);
        }
    }
}
