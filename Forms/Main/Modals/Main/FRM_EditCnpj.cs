using System;
using GC.Library.Translators;
using System.Windows.Forms;
using GC.Library.Objects;
using GC.Library.Checkers;
using GC.Library;
using GC.Library.Database;

namespace GC.Forms.Main.Modals.Main
{
    public partial class FRM_EditCnpj : Bases.FRM_Default
    {
        public FRM_EditCnpj()
        {
            InitializeComponent();

            this.ReadyForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MessageAndOK messOk;

            if (!Variables.StringHasNumbersOnly(txtCnpj.Text))
            {
                messOk = new GlobalModals.FRM_MessageAndOK("CNPJ inválido! Por favor, verifique o CNPJ digitado e tente novamente.", 1);
                messOk.Show();

                return;
            }
            else
            {
                CompanyInformation ci = new CompanyInformation(txtCnpj.Text);

                GlobalModals.FRM_Confirmation conf = new GlobalModals.FRM_Confirmation("Por favor, confirme se " +
                    "os seguintes dados são do seu CNPJ mesmo:\nRazão social: " + ci.Nome + "\nNome fantasia: " +
                    ci.Fantasia + "\nLogradouro: " + ci.Logradouro + "\n\nOs dados estão corretos?", 6);
                conf.Show();
                if (!conf.Result)
                {
                    messOk = new GlobalModals.FRM_MessageAndOK("Então, por favor, verifique o CNPJ digitado e tente novamente.", 6);
                    messOk.Show();

                    return;
                }
                else
                {
                    GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
                    ml.Show();

                    GlobalVariables.User.Cnpj = txtCnpj.Text;

                    GlobalVariables.CompanyInformation = ci;

                    
                    MySqlNonQuery.UpdateUser("cnpj", txtCnpj.Text);

                    ml.CustomClose();

                    messOk = new GlobalModals.FRM_MessageAndOK("CNPJ editado com sucesso!", 4);
                    messOk.Show();

                    this.Close();
                }
            }
        }

        private void btnRemoveCnpj_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MessageAndOK messOk;

            if (GlobalVariables.User.Cnpj == null || GlobalVariables.User.Cnpj == "")
            {
                messOk = new GlobalModals.FRM_MessageAndOK("Não existe nenhum CNPJ na sua conta! Não há " +
                    "o que ser removido.", 1);
                messOk.Show();
            }
            else
            {
                GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
                ml.Show();

                GlobalVariables.User.Cnpj = null;

                GlobalVariables.CompanyInformation = null;

                
                MySqlNonQuery.UpdateUser("cnpj", null);

                ml.CustomClose();

                messOk = new GlobalModals.FRM_MessageAndOK("CNPJ removido com sucesso da sua conta!", 6);
                messOk.Show();
            }

            this.Close();
        }
    }
}
