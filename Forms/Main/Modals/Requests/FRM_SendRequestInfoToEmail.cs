using GC.Library.Entities;
using GC.Library.Errors;
using GC.Library.Objects;
using GC.Library.Web;
using System;

namespace GC.Forms.Main.Modals.Requests
{
    public partial class FRM_SendRequestInfoToEmail : Bases.FRM_Default
    {
        Request Request;

        int IdCostumer = -1;
        string RequestNumber;

        internal FRM_SendRequestInfoToEmail(Request request)
        {
            InitializeComponent();

            this.ReadyForm();

            Costumer costumer = Costumer.CloneCostumer(request.Id_Costumer);
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

            btnSend.Click += new EventHandler(SendRequestDetails);

            this.Request = request;
        }

        /// <summary>
        /// This builder is used when you wanna inform the costumer that the request is finished.
        /// </summary>
        /// <param name="IdCostumer">Id of the costumer.</param>
        /// <param name="requestNumber">Number of the request.</param>
        internal FRM_SendRequestInfoToEmail(int IdCostumer, string requestNumber)
        {
            InitializeComponent();            

            Costumer costumer = Costumer.CloneCostumer(IdCostumer);
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

            btnSend.Click += new EventHandler(SendDoneInfo);

            this.IdCostumer = IdCostumer;
            this.RequestNumber = requestNumber;
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

        private void SendRequestDetails(object sender, EventArgs e)
        {
            GlobalModals.FRM_MessageAndOK messOk;

            string to;
            if (rbtCostumer.Checked)
            {
                to = rbtCostumer.Text.Substring(36);
            }
            else
            {
                if(txtEmail.Text.Length < 5)
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
                Email.RequestDetails(to, this.Request);

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

        private void SendDoneInfo(object sender, EventArgs e)
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
                Email.RequestFinishedEmail(to, this.IdCostumer, this.RequestNumber);

                mpb.CustomClose();

                messOk = new GlobalModals.FRM_MessageAndOK("Sucesso! E-mail enviado! OBS: Não esqueça de verificar a caixa de spam e o lixo eletrônico caso não encontre o e-mail.", 4);
                messOk.Show();
            }
            catch (Exception ex)
            {
                Care.AppendOnErrorLogFile(ex.Message);

                mpb.CustomClose();

                messOk = new GlobalModals.FRM_MessageAndOK("Aconteceu um erro ao tentar enviar o e-mail! Por favor, tente novamente mais tarde.", 2);
                messOk.Show();
            }

            this.Close();
        }
    }
}
