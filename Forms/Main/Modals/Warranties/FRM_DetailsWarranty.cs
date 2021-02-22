using GC.Library;
using GC.Library.Entities;
using GC.Library.Objects;
using GC.Library.Translators;
using System;

namespace GC.Forms.Main.Modals.Warranties
{
    public partial class FRM_DetailsWarranty : Bases.FRM_Default
    {
        private Warranty warranty;

        public FRM_DetailsWarranty(Warranty warranty)
        {
            InitializeComponent();

            this.ReadyForm();

            LBL_WarrantyNumber.Text += warranty.Number;

            if (!warranty.Type)
            {
                //LBL PRODUCT
                Product product = Product.CloneProduct(warranty.Id_Item);
                LBL_CodeOrName.Text += product.Code;
                LBL_ProdOrJobDescription.Text += product.Description;                
            }
            else
            {
                Job job = Job.CloneJob(warranty.Id_Item);
                LBL_ProdOrJobTitle.Text = "SERVIÇO";
                LBL_CodeOrName.Text = "Nome: " + job.Name;
                LBL_ProdOrJobDescription.Text += job.Description;
            }

            // LBL DURATION
            LBL_StartedIn.Text += warranty.StartedIn.ToString("dd/MM/yyyy HH:mm:ss");
            LBL_Expiration.Text += warranty.ExpiresIn.ToString("dd/MM/yyyy HH:mm:ss");

            TimeSpan duration = warranty.ExpiresIn.Subtract(DateTime.Now);
            LBL_TotalDuration.Text = "Duração Total: " + duration.Days + " dias.";

            // COSTUMER PLN
            //Costumer
            Costumer costumer = null;

            if (warranty.Id_Costumer == -1 || !GlobalVariables.Costumers.Exists(x => x.Id == warranty.Id_Costumer))
            {
                lblName.Text = "Este cliente foi excluído!";
                lblPhone.Hide();
                pnlWhatsapp.Hide();
                lblEmail.Hide();
                lblAddress.Hide();
                lblComplement.Hide();
                lblCep.Hide();
                lblReference.Hide();
                lblDistrict.Hide();
                lblCity.Hide();
                lblState.Hide();
                lblCountry.Hide();

                pnlCostumerIcon.BackgroundImage = Properties.Resources.icon_lixeira_30x30;
            }
            else
            {
                int index = GlobalVariables.Costumers.FindIndex(x => x.Id == warranty.Id_Costumer);
                costumer = GlobalVariables.Costumers[index];

                lblName.Text = costumer.Name;
                lblPhone.Text += costumer.PhoneNumber;
                pnlWhatsapp.Left = lblPhone.Left + lblPhone.Width + 5;
                if (costumer.IsPhoneWhatsapp)
                {
                    pnlWhatsapp.Visible = true;
                }

                if (costumer.Email == null || costumer.Email == "")
                {
                    lblEmail.Text = "E-mail não informado";
                }
                else
                {
                    lblEmail.Text += costumer.Email;
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
                lblCity.Text += ObjectToDetailLabel.ToLabelMasculino(costumer.City);
                lblState.Text += ObjectToDetailLabel.ToLabelMasculino(costumer.State);
                lblCountry.Text += ObjectToDetailLabel.ToLabelMasculino(costumer.Country);
            }

            lblObservations.Text = warranty.Observations;

            this.warranty = warranty;
        }

        private void BTN_GeneratePDF_Click(object sender, EventArgs e)
        {
            GC.Library.Outputs.Pdf.WarrantyToPdf(this.warranty);

            Library.Files.Open.WarrantyPdf(this.warranty);
        }

        private void BTN_SendEmail_Click(object sender, EventArgs e)
        {
            FRM_WarrantyEmail email = new FRM_WarrantyEmail(this.warranty);
            email.ShowDialog();
        }

        private void FRM_DetailsWarranty_Resize(object sender, EventArgs e)
        {
            lblConstCostumer.Left = (lblConstCostumer.Parent.Width - lblConstCostumer.Width) / 2;

            lblConstObserv.Left = (lblConstObserv.Parent.Width - lblConstObserv.Width) / 2;
        }
    }
}
