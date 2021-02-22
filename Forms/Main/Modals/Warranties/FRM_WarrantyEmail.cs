using GC.Library.Entities;
using GC.Library.Errors;
using GC.Library.Objects;
using GC.Library.Web;
using System;

namespace GC.Forms.Main.Modals.Warranties
{
    public partial class FRM_WarrantyEmail : Bases.FRM_Default
    {
        private readonly Warranty warranty;

        public FRM_WarrantyEmail(Warranty warranty)
        {
            InitializeComponent();

            this.ReadyForm();

            Costumer costumer = Costumer.CloneCostumer(warranty.Id_Costumer);
            if(costumer == null)
            {
                rbtCostumer.Text = "Cliente excluído!";
                rbtCostumer.Enabled = false;

                rbtOther.Checked = true;
            }
            else
            {
                if (costumer.Email != null && costumer.Email != "")
                {
                    rbtCostumer.Text += costumer.Email;
                    rbtCostumer.Checked = true;
                }
                else
                {
                    rbtCostumer.Text = "Cliente sem e-mail cadastrado!";
                    rbtCostumer.Enabled = false;

                    rbtOther.Checked = true;
                }
            }            

            this.warranty = warranty;
        }

        private void rbtOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtOther.Checked)
            {
                txtEmail.Enabled = true;
                txtEmail.Focus();
            }
            else
            {
                txtEmail.Enabled = false;
            }
        }

        private void BTN_Send_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MessageAndOK messOk;

            string to;
            if (rbtCostumer.Checked)
            {
                to = rbtCostumer.Text.Substring(36);
            }
            else
            {
                if (txtEmail.Text.Length < 5)
                {
                    messOk = new GlobalModals.FRM_MessageAndOK("E-mail muito curto! O e-mail precisa ter no mínimo 6 letras!", 1);
                    messOk.Show();

                    return;
                }

                to = txtEmail.Text;
            }

            GlobalModals.FRM_MessageAndProgressBar mpb = new GlobalModals.FRM_MessageAndProgressBar("Aguarde, enviando e-mail...", 6);
            mpb.Show();

            try
            {
                Email.WarrantyDetails(to, this.warranty);

                mpb.CustomClose();

                messOk = new GlobalModals.FRM_MessageAndOK("Sucesso! E-mail enviado! OBS: Não esqueça de verificar a caixa de spam e o lixo eletrônico caso não encontre o e-mail.", 4);
                messOk.Show();
            }
            catch (Exception ex)
            {
                Care.AppendOnErrorLogFile(ex.Message);

                mpb.CustomClose();

                messOk = new GlobalModals.FRM_MessageAndOK("Aconteceu um erro ao tentar enviar o e-mail! Por favor, verifique se digitou corretamente ou tente novamente mais tarde.", 2);
                messOk.Show();
            }

            this.Close();
        }
    }
}
