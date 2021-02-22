using System;
using GC.Library;
using GC.Library.Database;
using GC.Library.Entities;

namespace GC.Forms.Main.Modals.Configuration
{
    public partial class FRM_SendFeedback : Bases.FRM_Default
    {
        public FRM_SendFeedback()
        {
            InitializeComponent();

            this.ReadyForm();
        }

        private void rbtSendError_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtSendError.Checked)
            {
                lblInfo.Text = "Por favor, descreva em detalhes o que você estava fazendo, qual era o horário e qual o problema que você encontrou:";
                lblInfo.Left = (pnlBackground.Width - lblInfo.Width) / 2;
                btnReport.Text = "Reportar";
            }
            else
            {
                lblInfo.Text = "Por favor, descreva em detalhes qual a sua sugestão e o que ela poderia trazer de benefício para o programa:";
                lblInfo.Left = (pnlBackground.Width - lblInfo.Width) / 2;
                btnReport.Text = "Sugerir";
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MessageAndOK messOk;

            if (rtbText.Text.Trim().Length < 15 || rtbText.Text.Length < 30)
            {
                messOk = new GlobalModals.FRM_MessageAndOK("Seu texto precisa ter no mínimo 30 caracteres!", 1);
                messOk.Show();
                return;
            }

            string text = "Data de envio: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") +  ". Mensagem: ";
            text += rtbText.Text;

            byte type;
            if (rbtSendError.Checked) type = 1;
            else type = 2;

            
            MySqlNonQuery.CreateFeedback(text, type);

            messOk = new GlobalModals.FRM_MessageAndOK("Seu relatório ou sugestão foi enviado com sucesso! Talvez a administração " +
                "entrará em contato com você para pedir mais informações. Desde já, lhe agradecemos!", 5);
            messOk.Show();

            this.Close();
        }
    }
}
