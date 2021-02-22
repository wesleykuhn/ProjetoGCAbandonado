using GC.Library;
using GC.Library.Database;
using GC.Library.Web;
using System;
using System.Windows.Forms;

namespace GC.Forms.Main.Modals.Configuration
{
    public partial class FRM_AccountTypeChange : Bases.FRM_Default
    {
        public FRM_AccountTypeChange()
        {
            InitializeComponent();

            this.ReadyForm();

            switch (GlobalVariables.User.AccountType)
            {
                case 'P':
                    rbtP.Enabled = false;
                    break;
                case 'M':
                    rbtM.Enabled = false;
                    break;
                case 'G':
                    rbtG.Enabled = false;
                    break;
            }
        }

        private void lkbDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.Visited = true;

            System.Diagnostics.Process.Start("https://www.kuhnper.com.br/gc/planos");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MessageAndOK messOk;

            if(!rbtP.Checked && !rbtM.Checked && !rbtG.Checked)
            {
                messOk = new GlobalModals.FRM_MessageAndOK("Você precisa selecionar um novo tipo de plano para sua conta!", 1);
                messOk.Show();

                return;
            }

            string newType = "PEQUENO";
            if (rbtM.Checked) newType = "MÉDIO";
            else if (rbtG.Checked) newType = "GRANDE";

            GlobalModals.FRM_Confirmation conf = new GlobalModals.FRM_Confirmation("Atenção! Após solicitada a troca do plano você só poderá mudar novamente depois de 2 meses. Tem certeza que deseja solicitar a mudança para o plano " + newType + "?", 6);
            conf.Show();
            if (!conf.Result) return;
            else
            {
                char type = 'P';
                if (rbtM.Checked) type = 'M';
                else if (rbtG.Checked) type = 'G';

                GlobalModals.FRM_MessageAndProgressBar mpb = new GlobalModals.FRM_MessageAndProgressBar("Aguarde, enviando solicitação...", 6);
                mpb.Show();
                try
                {
                    Email.ChangeAccountTypeRequestEmail(type);
                   
                    MySqlNonQuery.UpdateUserMetadata("last_account_type_change", Library.Translators.ObjectToSQL.ToDateTimeSql(DateTime.Now));

                    mpb.CustomClose();

                    messOk = new GlobalModals.FRM_MessageAndOK("Sucesso! Solicitação enviada!", 4);
                    messOk.Show();
                }
                catch (Exception ex)
                {
                    Library.Errors.Care.AppendOnErrorLogFile(ex.Message);

                    mpb.CustomClose();

                    messOk = new GlobalModals.FRM_MessageAndOK("Aconteceu um erro ao tentar enviar a solicitação! Por favor, tente novamente mais tarde.", 2);
                    messOk.Show();
                }

                this.Close();
            }
        }
    }
}
