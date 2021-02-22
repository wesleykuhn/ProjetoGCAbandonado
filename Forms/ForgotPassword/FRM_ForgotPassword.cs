using System;
using GC.Library.Database;
using GC.Library.Translators;
using GC.Library.Web;

namespace GC.Forms.ForgotPassword
{
    public partial class FRM_ForgotPassword : Bases.FRM_Default
    {
        private byte Stage = 1;
        private byte Tries = 0;
        private string Code;
        private string UserName;

        public FRM_ForgotPassword()
        {
            InitializeComponent();

            this.ReadyForm();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Length < 4)
            {
                txtEmail.Text = String.Empty;
            }

            GlobalModals.FRM_MessageAndOK messOk;

            switch (this.Stage)
            {
                case 1:
                    if (!MySqlReader.EmailAlreadyExists(txtEmail.Text.Trim()))
                    {
                        messOk = new GlobalModals.FRM_MessageAndOK("O e-mail digitado não existe. Por favor, verifique se digitou corretamente e tente novamente.", 1);
                        messOk.Show();
                        txtEmail.Text = String.Empty;

                        this.Tries++;
                        return;
                    }
                    else
                    {
                        this.UserName = MySqlReader.ReadOnlyOneColumn("user", "name", new string[] { "email" }, new string[] { txtEmail.Text.Trim() }, null, new bool[] { false });

                        this.Stage = 2;
                        pnlStage2.BringToFront();
                    }
                    break;
                case 2:
                    if (!MySqlReader.PhoneNumberExists(txtPhoneNumber.Text.Trim(), txtEmail.Text.Trim()))
                    {
                        messOk = new GlobalModals.FRM_MessageAndOK("O número de celular digitado não é o correto! Por favor, verifique se digitou certo e tente novamente.", 1);
                        messOk.Show();
                        txtPhoneNumber.Text = String.Empty;

                        this.Tries++;
                        return;
                    }
                    else
                    {
                        this.Code = Email.ForgotPasswordCode(txtEmail.Text.Trim(), this.UserName);

                        this.Stage = 3;
                        pnlStage3.BringToFront();

                        messOk = new GlobalModals.FRM_MessageAndOK("Um e-mail contendo um código foi enviado para " + txtEmail.Text.Trim() + "! Por favor, abra sua caixa de entrada e encontre o código para continuar. Não se esqueça de verificar sua Caixa de Spam e o Lixo Eletrônico.", 5);
                        messOk.Show();                        
                    }
                    break;
                case 3:
                    if(this.Code != txtCode.Text)
                    {
                        messOk = new GlobalModals.FRM_MessageAndOK("O código digitado está incorreto! Por favor, verifique se digitou certo e tente novamente.", 1);
                        messOk.Show();
                        txtCode.Text = String.Empty;

                        this.Tries++;
                        return;
                    }
                    else
                    {
                        string newPassword = Email.NewPassword(txtEmail.Text.Trim(), this.UserName);

                        bool result = MySqlNonQuery.UpdateUserByEmail(txtEmail.Text.Trim(), "password", WKCrypto.W530(newPassword));
                        if (!result)
                        {
                            GlobalModals.FRM_MessageAndOK.BuildAndShow("Houve um erro fatal ao tentar atualizar seus dados!", 2);
                        }
                        else
                        {
                            messOk = new GlobalModals.FRM_MessageAndOK("Parabéns " + this.UserName + "! Um e-mail contendo sua nova senha foi enviado para você. Por favor, verifique sua caixa de entrada. " +
                            "Não esqueça de verificar a Caixa de Spam e o Lixo Eletrônico. OBS: Para trocar " +
                            "sua senha por uma do seu gosto, vá no painel 'Configurações' quando você entrar no programa.", 5);
                            messOk.Show();                            
                        }

                        this.Close();
                    }

                    break;                    
            }

            if (this.Tries >= 8)
            {
                messOk = new GlobalModals.FRM_MessageAndOK("Atenção! Você tentou demais trocar a senha de alguma conta. Por segurança o programa será fechado!", 2);
                messOk.Show();

                Environment.Exit(0);
            }             
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
