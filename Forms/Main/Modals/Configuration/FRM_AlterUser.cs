using GC.Library;
using System;
using GC.Library.Translators;
using System.Linq;
using GC.Library.Errors;
using System.Drawing;

namespace GC.Forms.Main.Modals.Configuration
{
    public partial class FRM_AlterUser : Bases.FRM_Default
    {
        private byte stage = 1;
        private string emailCode = null;

        public FRM_AlterUser()
        {
            InitializeComponent();

            this.ReadyForm();

            this.UpdateCnpjLabel();
            this.UpdateEmailLabel();
            this.UpdatePhoneNumberLabel();
            this.UpdatePasswordStrengh();
        }

        private void UpdatePasswordStrengh()
        {
            byte strengh = 0;

            // CONTAINS WORDS
            foreach (char word in Library.Informations.Chars.WordsLowerCase)
            {
                if (WKCrypto.W710(GlobalVariables.User.GetPassword()).Contains(word))
                {
                    strengh++;
                    break;
                }
            }

            // CONTAINS NUMBERS
            foreach (char number in Library.Informations.Chars.Numbers)
            {
                if (WKCrypto.W710(GlobalVariables.User.GetPassword()).Contains(number))
                {
                    strengh++;
                    break;
                }
            }

            // CONTAINS WORDS UPPER
            foreach (char wordUpper in Library.Informations.Chars.WordsUpperCase)
            {
                if (WKCrypto.W710(GlobalVariables.User.GetPassword()).Contains(wordUpper))
                {
                    strengh++;
                    break;
                }
            }

            // CONTAINS SYMBOLS
            foreach (char symbol in Library.Informations.Chars.Symbols)
            {
                if (WKCrypto.W710(GlobalVariables.User.GetPassword()).Contains(symbol))
                {
                    strengh++;
                    break;
                }
            }

            switch (strengh)
            {
                case 1:
                    LBL_CurrentPasswordStrengh.Text = "Muito Fráca!";
                    LBL_CurrentPasswordStrengh.ForeColor = Color.Crimson;
                    break;

                case 2:
                    LBL_CurrentPasswordStrengh.Text = "Fraca.";
                    LBL_CurrentPasswordStrengh.ForeColor = Color.Orange;
                    break;

                case 3:
                    LBL_CurrentPasswordStrengh.Text = "Média.";
                    LBL_CurrentPasswordStrengh.ForeColor = Color.Green;
                    break;

                default:
                    LBL_CurrentPasswordStrengh.Text = "Forte!";
                    LBL_CurrentPasswordStrengh.ForeColor = Library.Style.ColorsPalette.GDE_Info;
                    break;
            }

            LBL_AlterPassword.Left = LBL_CurrentPasswordStrengh.Left + LBL_CurrentPasswordStrengh.Width + 4;
        }

        private void UpdatePhoneNumberLabel()
        {
            LBL_PhoneNumber.Text = "Celular/Telefone: " + GlobalVariables.User.PhoneNumber;
            LBL_AlterPhoneNumber.Left = LBL_PhoneNumber.Left + LBL_PhoneNumber.Width + 4;
        }

        private void UpdateEmailLabel()
        {
            LBL_Email.Text = "E-mail: " + GlobalVariables.User.Email;
            LBL_AlterEmail.Left = LBL_Email.Left + LBL_Email.Width + 4;
        }

        private void UpdateCnpjLabel()
        {
            if (GlobalVariables.User.Cnpj == null || GlobalVariables.User.Cnpj == "")
            {
                LBL_Cnpj.Text = "CNPJ: Ainda não definido.";
            }
            else
            {
                LBL_Cnpj.Text = "CNPJ: " + GlobalVariables.CompanyInformation.Cnpj;
            }

            LBL_AlterCnpj.Left = LBL_Cnpj.Left + LBL_Cnpj.Width + 4;
        }

        // E-mail -------------------------------------------------------->
        private void LBL_AlterEmail_Click(object sender, EventArgs e)
        {
            LBL_NewEmailCodeLabel.Hide();
            TXT_NewEmailCode.Hide();

            PNL_BackgroundEmail.BringToFront();
        }

        private void BTN_AlterEmail_Click(object sender, EventArgs e)
        {
            if(this.stage == 1)
            {
                GlobalModals.FRM_MessageAndOK messOk;

                if (TXT_NewEmail.Text.Length < 5 || !TXT_NewEmail.Text.Contains('@') || !TXT_NewEmail.Text.Contains('.'))
                {
                    messOk = new GlobalModals.FRM_MessageAndOK("O E-mail inserido não é valido. Por favor, verifique e tente novamente!", 1);
                    messOk.Show();

                    return;
                }

                if (WKCrypto.W710(GlobalVariables.User.GetPassword()) != TXT_NewEmailPassword.Text)
                {
                    messOk = new GlobalModals.FRM_MessageAndOK("A senha de usuário digitada não está correta! Por favor, verifique e tente novamente!", 1);
                    messOk.Show();

                    return;
                }

                GlobalModals.FRM_MessageAndProgressBar mp = new GlobalModals.FRM_MessageAndProgressBar("Um e-mail contendo um código de 6 dígitos está sendo enviado para " + TXT_NewEmail.Text + "! Por favor, aguarde...", 4);

                mp.Show();

                try
                {
                    this.emailCode = Library.Web.Email.NewEmailCode(TXT_NewEmail.Text, GlobalVariables.User.Name);
                }
                catch (Exception ex)
                {
                    messOk = new GlobalModals.FRM_MessageAndOK("Ocorreu um erro ao tentar enviar o e-mail, verifique se seu computador tem acesso a internet ou se você digitou o e-mail corretamente.", 2);

                    mp.CustomClose();

                    messOk.Show();

                    Care.AppendOnErrorLogFile(ex.Message + " - " + ex.Source);

                    return;
                }

                mp.CustomClose();

                messOk = new GlobalModals.FRM_MessageAndOK("E-mail enviado com sucesso! Por favor, verifique na sua caixa de entrada se você recebeu o código. Não esqueça de verificar a Caixa de Spam e o Lixo Eletrônico.", 5);
                messOk.Show();

                BTN_AlterEmail.Text = "Alterar";

                TXT_NewEmail.Enabled = false;
                TXT_NewEmailPassword.Enabled = false;

                LBL_NewEmailCodeLabel.Show();
                TXT_NewEmailCode.Show();

                this.stage = 2;
            }
            else if(this.stage == 2)
            {
                GlobalModals.FRM_MessageAndOK messOk;

                if(TXT_NewEmailCode.Text != this.emailCode)
                {
                    messOk = new GlobalModals.FRM_MessageAndOK("O código digitado não está correto! Por favor, verifique e tente novamente!", 1);
                    messOk.Show();

                    return;
                }
                else
                {
                    Library.Database.MySqlNonQuery.UpdateUser("email", TXT_NewEmail.Text);

                    GlobalVariables.User.Email = TXT_NewEmail.Text;

                    messOk = new GlobalModals.FRM_MessageAndOK("Sucesso! Seu E-mail alterado!", 4);
                    messOk.Show();

                    this.Close();
                }                
            }            
        }
        // <---------------------------------------------------------------

        // CPF CNPJ ------------------------------------------------------->
        private void LBL_AlterCnpj_Click(object sender, EventArgs e)
        {
            Modals.Main.FRM_EditCnpj editCnpj = new Modals.Main.FRM_EditCnpj();
            editCnpj.ShowDialog();

            this.UpdateCnpjLabel();
        }
        // <---------------------------------------------------------------------------------

        // PASSWORD ----------------------------------------------------------------------------->
        private void LBL_AlterPassword_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.UserChangedPasswordRecently)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Você já mudou a senha da sua conta hoje! Tente novamente amanhã. :)", 2);
                messOk.Show();

                return;
            }
            else PNL_BackgroundPassword.BringToFront();                      
        }

        private void BTN_AlterPassword_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_Confirmation conf = new GlobalModals.FRM_Confirmation("Deseja confirmar a alteração da senha de sua conta?", 6);
            conf.Show();
            if (!conf.Result)
            {
                return;
            }

            if (TXT_ChangeUserPassOldPass.Text != Library.Translators.WKCrypto.W710(GlobalVariables.User.GetPassword()))
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("A senha antiga que você digitou não está correta!", 1);
                messOk.Show();
                return;
            }

            if (TXT_ChangeUserPassNewPass.Text == Library.Translators.WKCrypto.W710(GlobalVariables.User.GetPassword()))
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("A senha nova é a mesma que a atual! Escolha outra.", 1);
                messOk.Show();
                return;
            }

            if (TXT_ChangeUserPassNewPass.Text.Length < 6)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("A senha nova é muito curta!", 1);
                messOk.Show();
                return;
            }

            if (TXT_ChangeUserPassNewPass.Text != TXT_ChangeUserPassRepNewPass.Text)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Os campos da nova senha não estão iguais! Por favor, verifique.", 1);
                messOk.Show();
                return;
            }

            Library.Database.MySqlNonQuery.UpdateUser("password", Library.Translators.WKCrypto.W530(TXT_ChangeUserPassNewPass.Text));
            GlobalVariables.User.SetPassword(TXT_ChangeUserPassNewPass.Text);

            GlobalModals.FRM_MessageAndOK messOk2 = new GlobalModals.FRM_MessageAndOK("Parabéns! Você alterou sua senha com sucesso!", 5);
            messOk2.Show();

            GlobalVariables.UserChangedPasswordRecently = true;

            this.Close();
        }

        private void TXT_ChangeUserPassNewPass_TextChanged(object sender, EventArgs e)
        {
            if (TXT_ChangeUserPassNewPass.Text.Length < 6)
            {
                BTN_AlterPassword.Enabled = false;
                PNL_UserPasswordIcon.BackgroundImage = Properties.Resources.icon_fechar3_22x20;
            }
            else
            {
                BTN_AlterPassword.Enabled = true;
                PNL_UserPasswordIcon.BackgroundImage = Properties.Resources.icon_right;
            }

            byte strengh = 0;

            // CONTAINS WORDS
            foreach (char word in Library.Informations.Chars.WordsLowerCase)
            {
                if (TXT_ChangeUserPassNewPass.Text.Contains(word))
                {
                    strengh++;
                    break;
                }
            }

            // CONTAINS NUMBERS
            foreach (char number in Library.Informations.Chars.Numbers)
            {
                if (TXT_ChangeUserPassNewPass.Text.Contains(number))
                {
                    strengh++;
                    break;
                }
            }

            // CONTAINS WORDS UPPER
            foreach (char wordUpper in Library.Informations.Chars.WordsUpperCase)
            {
                if (TXT_ChangeUserPassNewPass.Text.Contains(wordUpper))
                {
                    strengh++;
                    break;
                }
            }

            // CONTAINS SYMBOLS
            foreach (char symbol in Library.Informations.Chars.Symbols)
            {
                if (TXT_ChangeUserPassNewPass.Text.Contains(symbol))
                {
                    strengh++;
                    break;
                }
            }

            switch (strengh)
            {
                case 1:
                    LBL_NewPasswordStrengh.Text = "Muito Fráca!";
                    LBL_NewPasswordStrengh.ForeColor = Color.Crimson;
                    break;

                case 2:
                    LBL_NewPasswordStrengh.Text = "Fraca.";
                    LBL_NewPasswordStrengh.ForeColor = Color.Orange;
                    break;

                case 3:
                    LBL_NewPasswordStrengh.Text = "Média.";
                    LBL_NewPasswordStrengh.ForeColor = Color.Green;
                    break;

                default:
                    LBL_NewPasswordStrengh.Text = "Forte!";
                    LBL_NewPasswordStrengh.ForeColor = Library.Style.ColorsPalette.GDE_Info;
                    break;
            }
        }

        private void TXT_ChangeUserPassRepNewPass_TextChanged(object sender, EventArgs e)
        {
            if (TXT_ChangeUserPassNewPass.Text != TXT_ChangeUserPassRepNewPass.Text)
            {
                BTN_AlterPassword.Enabled = false;
                PNL_UserPasswordConfirmationIcon.BackgroundImage = Properties.Resources.icon_fechar3_22x20;
            }
            else
            {
                BTN_AlterPassword.Enabled = true;
                PNL_UserPasswordConfirmationIcon.BackgroundImage = Properties.Resources.icon_right;
            }
        }
        // <------------------------------------------------------------------------------------

        // PHONE NUMBER ---------------------------------------------------------------------->
        private void LBL_AlterPhoneNumber_Click(object sender, EventArgs e)
        {
            PNL_BackgroundPhoneNumber.BringToFront();
        }

        private void txtUserPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            bool hasWord = false;
            foreach (char word in TXT_UserPhoneNumber.Text)
            {
                if (word != '0' && word != '1' && word != '2' && word != '3' && word != '4' && word != '5' && word != '6' && word != '7' && word != '8' && word != '9')
                {
                    hasWord = true;
                }
            }
            if (hasWord || TXT_UserPhoneNumber.Text.Length < 11 || !TXT_UserPhoneNumber.Text.Contains('9') || TXT_UserPhoneNumber.Text.Contains(' '))
            {
                BTN_AlterPhoneNumber.Enabled = false;
                PNL_UserPhoneNumberIcon.BackgroundImage = Properties.Resources.icon_fechar3_22x20;
            }
            else
            {
                BTN_AlterPhoneNumber.Enabled = true;
                PNL_UserPhoneNumberIcon.BackgroundImage = Properties.Resources.icon_right;
            }
        }

        private void BTN_AlterPhoneNumber_Click(object sender, EventArgs e)
        {
            Library.Database.MySqlNonQuery.UpdateUser("phone_number", TXT_UserPhoneNumber.Text);

            GlobalVariables.User.PhoneNumber = TXT_UserPhoneNumber.Text;

            GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Sucesso! Número de celular alterado.", 5);
            messOk.Show();

            this.Close();
        }
    }
}
