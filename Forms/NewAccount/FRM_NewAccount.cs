using System;
using System.Windows.Forms;
using GC.Library.Collectors;
using GC.Library.Database;
using GC.Library.Entities;
using GC.Library.Errors;
using GC.Library.Web;

namespace GC.Forms.NewAccount
{
    public partial class FRM_NewAccount : Bases.FRM_Default
    {
        GlobalModals.FRM_MessageAndOK MessOk;

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        public FRM_NewAccount()
        {
            InitializeComponent();

            this.ReadyForm();

            lblHelperText.Text = "";
            btnFinishCreation.Enabled = false;
            btnCreateNewAccount.Enabled = false;            
        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        //Variables block -------------------------------------------------------------
        //Temporary variables to help the account creation
        private string userName;
        private string userEmail;
        private string userPassword;
        private string userPhoneNumber;
        private string emailCode;

        //Array that make all the 5 validations
        private bool[] validator = new bool[] { false, false, false, false, false };

        //Other Methods/Functions block------------------------------------------------
        private void canWeEnableCreateButton()
        {
            if(validator[0] == true && validator[1] == true && validator[2] == true && validator[3] == true && validator[4] == true)
            {
                btnCreateNewAccount.Enabled = true;
            }
            else
            {
                btnCreateNewAccount.Enabled = false;
            }
        }

        //Helper label events block----------------------------------------------------
        private void txtUserName_ShowInformation(object sender, EventArgs e)
        {
            lblHelperText.Text = "Insira seu nome completo com acentos, caso tenha.";
        }

        private void txtUserEmail_ShowInformation(object sender, EventArgs e)
        {
            lblHelperText.Text = "Insira um e-mail válido. Esse e-mail será usado para que eu possa entrar em contato com você e para que você consiga entrar e usar o programa. Verifique se o e-mail foi digitado corretamente, para que eu consiga criar sua conta.";
        }

        private void txtUserPassword_ShowInformation(object sender, EventArgs e)
        {
            lblHelperText.Text = "Insira uma senha que contenha entre 6 à 14 caracteres. DICA: Uma senha com letras maiúsculas, minúsculas e números é bem mais difícil de ser roubada!";
        }

        private void txtUserPasswordCOnfirmation_ShowInformation(object sender, EventArgs e)
        {
            lblHelperText.Text = "Insira novamente a senha que você digitou acima.";
        }

        private void txtUserPhoneNumber_ShowInformation(object sender, EventArgs e)
        {
            lblHelperText.Text = "Insira o número do seu telefone celular. Preciso dessa informação para caso " +
                "eu não consiga entrar em contato com você via e-mail. O celular deve ser digitado no seguinte " +
                "formato: DDD + Número. Por exemplo: 19912345678.";
        }

        //Almost last step to finish the account creation -------------------------------------------
        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MessageAndProgressBar mp;

            // EMAIL CHECK IF ALREADY EXISTS ------------------------------------------------------------------->
            mp = new GlobalModals.FRM_MessageAndProgressBar("Verificando se o e-mail digitado já exite...", 6);
            mp.Show();

            bool result = EmailAlreadyExists();

            mp.CustomClose();

            if (result)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("O e-mail digitado já está cadastrado! Por favor, tente recuperar a senha desse e-mail ou digite outro.", 1);
                messOk.Show();
                pnlUserEmailIcon.BackgroundImage = Properties.Resources.icon_fechar3_22x20;
                return;
            }
            // <------------------------------------------------------------------------------------------------

            userName = txtUserName.Text;
            userEmail = txtUserEmail.Text;
            userPassword = txtUserPassword.Text;
            userPhoneNumber = txtUserPhoneNumber.Text;

            mp = new GlobalModals.FRM_MessageAndProgressBar("Um e-mail contendo um código de 6 dígitos está sendo enviado para " + userEmail + "! Por favor, aguarde...", 4);

            mp.Show();

            try
            {
                emailCode = Email.NewAccountCode(userEmail, userName);
            }
            catch(Exception ex)
            {
                this.MessOk = new GlobalModals.FRM_MessageAndOK("Ocorreu um erro ao tentar enviar o e-mail, verifique se seu computador tem acesso a internet ou se você digitou o e-mail corretamente.", 2);
                mp.CustomClose();
                this.MessOk.Show();
                Care.AppendOnErrorLogFile(ex.Message + " - " + ex.Source);
                return;
            }

            mp.CustomClose();

            this.MessOk = new GlobalModals.FRM_MessageAndOK("E-mail enviado com sucesso! Por favor, verifique na sua caixa de entrada se você recebeu o código. Não esqueça de verificar a Caixa de Spam e o Lixo Eletrônico.", 5);
            this.MessOk.Show();

            btnCreateNewAccount.Enabled = false;
            txtUserName.Enabled = false;
            txtUserEmail.Enabled = false;
            txtUserPassword.Enabled = false;
            txtUserPasswordConfirmation.Enabled = false;
            txtUserPhoneNumber.Enabled = false;

            pnlStage2.BringToFront();
        }

        //Data validation block -------------------------------------------------------------------
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            string temp = txtUserName.Text.TrimStart();
            temp = temp.TrimEnd();
            if (temp.Length < 7 || temp.Length > 50 || !temp.Contains(" "))
            {
                validator[0] = false;
                pnlUserNameIcon.BackgroundImage = Properties.Resources.icon_fechar3_22x20;
            }
            else if (txtUserName.Text.Contains("0") ||
               temp.Contains("1") ||
               temp.Contains("2") ||
               temp.Contains("3") ||
               temp.Contains("4") ||
               temp.Contains("5") ||
               temp.Contains("6") ||
               temp.Contains("7") ||
               temp.Contains("8") ||
               temp.Contains("9"))
            {
                validator[0] = false;
                pnlUserNameIcon.BackgroundImage = Properties.Resources.icon_fechar3_22x20;
            }
            else
            {
                validator[0] = true;
                pnlUserNameIcon.BackgroundImage = Properties.Resources.icon_right;
            }

            canWeEnableCreateButton();
        }

        private void txtUserEmail_TextChanged(object sender, EventArgs e)
        {
            string temp = txtUserEmail.Text.Trim();
            if (temp.Length < 5 || !temp.Contains("@") || !temp.Contains("."))
            {
                validator[1] = false;
                pnlUserEmailIcon.BackgroundImage = Properties.Resources.icon_fechar3_22x20;
                return;
            }
            else
            {
                validator[1] = true;
                pnlUserEmailIcon.BackgroundImage = Properties.Resources.icon_right;
            }

            canWeEnableCreateButton();
        }

        private bool EmailAlreadyExists()
        {
            bool result = MySqlReader.EmailAlreadyExists(txtUserEmail.Text);
            return result;
        }

        private void txtUserPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            bool hasWord = false;
            foreach (char word in txtUserPhoneNumber.Text)
            {
                if (word != '0' && word != '1' && word != '2' && word != '3' && word != '4' && word != '5' && word != '6' && word != '7' && word != '8' && word != '9')
                {
                    hasWord = true;
                }
            }
            if (hasWord || txtUserPhoneNumber.Text.Length < 11 || !txtUserPhoneNumber.Text.Contains("9") || txtUserPhoneNumber.Text.Contains(" "))
            {
                validator[4] = false;
                pnlUserPhoneNumberIcon.BackgroundImage = Properties.Resources.icon_fechar3_22x20;
            }
            else
            {
                validator[4] = true;
                pnlUserPhoneNumberIcon.BackgroundImage = Properties.Resources.icon_right;
            }

            canWeEnableCreateButton();
        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtUserPassword.Text.Length < 6)
            {
                validator[2] = false;
                pnlUserPasswordIcon.BackgroundImage = Properties.Resources.icon_fechar3_22x20;
            }
            else
            {
                validator[2] = true;
                pnlUserPasswordIcon.BackgroundImage = Properties.Resources.icon_right;              
            }

            canWeEnableCreateButton();
        }

        private void txtUserPasswordConfirmation_TextChanged(object sender, EventArgs e)
        {
            if (txtUserPassword.Text != txtUserPasswordConfirmation.Text)
            {
                validator[3] = false;
                pnlUserPasswordConfirmationIcon.BackgroundImage = Properties.Resources.icon_fechar3_22x20;
            }
            else
            {
                validator[3] = true;
                pnlUserPasswordConfirmationIcon.BackgroundImage = Properties.Resources.icon_right;                
            }

            canWeEnableCreateButton();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            txtCode.Text.Trim();
            txtCode.CharacterCasing = CharacterCasing.Upper;
            if (txtCode.Text.Length == 6) btnFinishCreation.Enabled = true;
            else btnFinishCreation.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinishCreation_Click(object sender, EventArgs e)
        {
            if(txtCode.Text != emailCode)
            {
                this.MessOk = new GlobalModals.FRM_MessageAndOK("Código inválido! Verifique se digitou corretamente.", 2);
                txtCode.Text = String.Empty;
            }
            else
            {
                User user = new User(-1, userName, userEmail, userPassword, userPhoneNumber, null, MacNumber.GetEnderecoMAC1());
                
                MySqlNonQuery.CreateUser(user);

                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Conta criada com sucesso! Agora, vamos começar a usar o programa.", 5);
                messOk.Show();

                Close();
            }
        }
    }
}
