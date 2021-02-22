using System;
using System.Drawing;
using System.Windows.Forms;
using GC.Library.Entities;
using GC.Library.Translators;

namespace GC.Forms.Main.Modals.Costumers
{
    public partial class FRM_DetailsCostumer : Bases.FRM_Default
    {
        internal FRM_DetailsCostumer(Costumer costumer)
        {
            InitializeComponent();

            this.ReadyForm();

            lblName.Text = costumer.Name;

            lblPhone.Text = costumer.PhoneNumber;
            pnlWhatsapp.Location = new Point(lblPhone.Width + 134, 55);
            if (costumer.IsPhoneWhatsapp)
            {
                pnlWhatsapp.Visible = true;
            }

            if(costumer.Email == null || costumer.Email == "")
            {
                lblEmail.Text = "E-mail não informado";
            }
            else
            {
                lblEmail.Text = costumer.Email;
            }            

            if (costumer.Sex == 'M')
            {
                pnlCostumerIcon.BackgroundImage = Properties.Resources.icon_perfil_menpadrao_100x100;
            }
            else
            {
                pnlCostumerIcon.BackgroundImage = Properties.Resources.icon_perfil_woman_100x100;
            }           

            lblAddress.Text += costumer.Street + ", " + costumer.Number;

            lblComplement.Text += ObjectToDetailLabel.ToLabelMasculino(costumer.Complement);
            lblCep.Text += ObjectToDetailLabel.ToLabelMasculino(costumer.Cep);
            lblReference.Text += ObjectToDetailLabel.ToLabelFeminino(costumer.Reference);
            lblDistrict.Text += ObjectToDetailLabel.ToLabelMasculino(costumer.District);
            lblCity.Text += ObjectToDetailLabel.ToLabelFeminino(costumer.City);
            lblState.Text += ObjectToDetailLabel.ToLabelMasculino(costumer.State);
            lblCountry.Text += ObjectToDetailLabel.ToLabelMasculino(costumer.Country);

            if (costumer.Debt == -1)
            {
                lblDebt.Text += "R$ 0,00";
            }
            else
            {
                lblDebt.Font = new Font(lblDebt.Font, FontStyle.Bold);
                lblDebt.Text += "R$ " + costumer.Debt.ToString("n2");
                lblDebt.ForeColor = Color.Crimson;
            }

            lblDiscountCounter.Text += ObjectToDetailLabel.ToIntLabel(costumer.DiscountCounter);
            lblAccumulatedDiscount.Text += ObjectToDetailLabel.ToMoneyLabel(costumer.DiscountAccumulated);
        }
    }
}
