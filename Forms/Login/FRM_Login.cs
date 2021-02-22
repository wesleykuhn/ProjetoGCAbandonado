using System;
using System.Windows.Forms;
using GC.Library.Database;
using System.Drawing;
using GC.Library.Style;
using System.Runtime.InteropServices;
using GC.Library.Collectors;
using GC.Library.Files;
using GC.Library;
using GC.Library.Auth;
using GC.Library.Objects.SubObjects.Product;
using GC.Library.Objects;
using GC.Library.Sync;
using GC.Library.Web;
using GC.Library.Errors;

namespace GC.Forms.Login
{
    public partial class FRM_Login : Form
    {
        private int macs;

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public FRM_Login()
        {
            this.macs = MySqlReader.MacAddressCounter(MacNumber.GetEnderecoMAC1());

            InitializeComponent();

            //Auto write e-mail system
            Library.Files.LoginData.LastLoginFileBeforeLogin(ref txtEmail, ref txtPassword);
            if(txtEmail.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                cbxAutoLogin.CheckedChanged -= CbxAutoLogin_CheckedChanged;
                cbxAutoLogin.Checked = true;
                cbxAutoLogin.CheckedChanged += CbxAutoLogin_CheckedChanged;
                btnLogin_Click(this, new EventArgs());
            }
            else if(txtEmail.Text.Length > 0)
            {
                txtPassword.Select();
            }

            string[] version = Application.ProductVersion.Split('.');

            lblVersion.Text = "V" + version[0];

            if (version[3] != "0")
            {
                lblVersion.Text += "." + version[1] + "." + version[2] + "." + version[3];
            }
            else if (version[2] != "0")
            {
                lblVersion.Text += "." + version[1] + "." + version[2];
            }
            else if (version[1] != "0")
            {
                lblVersion.Text += "." + version[1];
            }

            lblVersion.Left = this.Width - (lblVersion.Width + 10);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void LblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
            ml.Show();

            //If the same PC already did 3 accounts then we block him, until admin's authorization            
            if (this.macs >= 3)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Infelizmente você não pode criar mais de 3 contas no mesmo computador! Para criar mais contas entre em contato com a administração.", 1);
                messOk.Show();
            }
            else
            {
                if (MacNumber.GetEnderecoMAC1() == "UserWithoutMAC")
                {
                    ml.CustomClose();

                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Erro! Seu dispositivo não está passando os dados corretamente para o programa! Tente " +
                        "criar uma conta por outro dispositivo/computador ou entre em contato com algum suporte técnico.", 2);
                    messOk.Show();
                }
                else if (!MySqlReader.AntiAccountCreationAbulse())
                {
                    ml.CustomClose();

                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Atenção! Você tem uma ou mais conta(s) que não está(ão) paga(s) ou que foi criada apenas a menos " +
                        "de 11 dias atrás! Por isso, você não poderá criar outra conta.", 2);
                    messOk.Show();
                }
                else
                {
                    ml.CustomClose();

                    NewAccount.FRM_NewAccount newAccount = new NewAccount.FRM_NewAccount();
                    newAccount.ShowDialog();
                }                
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            //If Key Enter is hit we do the same function of the click() event
            if(e.KeyCode == Keys.Enter)
            {
                txtEmail.Select();
                btnLogin_Click(btnLogin, new EventArgs());                
            }
        }

        private void CbxAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAutoLogin.Checked)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Atenção! Fique ciente de que ao ativar essa função qualquer pessoa que abrir seu programa, por este computador, poderá usar sua conta.", 6);
                messOk.Show();
                this.Activate();
            }            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //If E-mail's lenght isn't enought we clear the field
            string aux = txtEmail.Text.Trim();
            if(aux.Length < 5 || txtPassword.Text.Length < 6)
            {
                txtEmail.Text = String.Empty;
                txtPassword.Text = String.Empty;
                return;
            }            

            this.Hide();
            aux = txtEmail.Text;

            //Loading Screen form is ready
            LoadingScreen.FRM_LoadingScreen frmLoadingScreen = new LoadingScreen.FRM_LoadingScreen("Validando tentativa de login...");
            frmLoadingScreen.Show();

            switch (Library.Checkers.Structs.IsSystemAndWebDateTimeSync())
            {
                case -1:
                    GlobalModals.FRM_MessageAndOK.BuildAndShow("Houve um erro ao tentar verificar a sincronia do horário de seu computador com o horário da internet! Por favor, tente novamente em alguns minutos. Se o erro persistir entre em contato com a administração.", 2);

                    return;

                case 0:
                    GlobalModals.FRM_MessageAndOK.BuildAndShow("ATENÇÃO! O horário de seu computador não está correto. Por favor, ajuste o horário de seu computador para usar o programa.", 2);

                    return;
            }

            //If there's no name with that e-mail then it doesn't exist
            string typedEmail = MySqlReader.ReadOnlyOneColumn("user", "name", new string[] { "email"}, new string[] { aux }, null, new bool[] { false });
            if (typedEmail.Length < 5)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("E-mail inválido! Não existe nenhuma conta cadastrada com o e-mail digitado.", 1);
                messOk.Show();

                txtEmail.Text = String.Empty;
                txtPassword.Text = String.Empty;
                frmLoadingScreen.CustomClose();
                Show();
                return;
            }

            //Check if the entered e-mail and pass is valid
            bool auth = MySqlReader.IsAuthValid(txtEmail.Text, txtPassword.Text);
            if (!auth)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Senha incorreta! Por favor, verifique se digitou a senha corretamente e tente novamente.", 1);
                messOk.Show();

                frmLoadingScreen.CustomClose();
                txtEmail.Text = String.Empty;
                txtPassword.Text = String.Empty;
                Show();
                return;
            }

            //If is valid then clear fields and make changes on loading screen
            txtPassword.Text = String.Empty;

            //Read the user on database and Instance it
            MySqlReader.ReadUser(aux);

            if(GlobalVariables.User.Id == -1)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Ocorreu um erro fatal ao tentar acessar os dados da sua conta. Por favor, tente novamente mais tarde. Caso você continue recebendo essa mensagem entre em contato com a administração!", 2);
                messOk.Show();
            }

            if (!Library.Database.MySqlReader.CheckPayment())
            {
                frmLoadingScreen.CustomClose();
                
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Seu periodo de testes acabou ou sua conta mensal não foi paga! Por isso, você não poderá usar o programa.", 2);
                messOk.Show();

                GlobalModals.FRM_Confirmation conf = new GlobalModals.FRM_Confirmation("Para recarregar sua conta você precisa solicitar um boleto de cobrança. Então, dentro de 48 horas uteis, a administração lhe enviará um link, via mensagem do programa e e-mail, do boleto gerado pelo site www.asaas.com. Após pagar o boleto, sua conta ira ser recarregada com mais 30 dias." +
                "\n\nATENÇÃO: Todos os links de boletos serão enviados apenas por meio do e-mail gc-administracao@kuhnper.com.br! Toda cobrança pelo uso do GC que vier fora deste e-mail deverá ser ignorada." +
                "\n\nDeseja enviar uma solicitação de recarga agora?", 6);
                conf.Show();

                if (conf.Result)
                {
                    if (Library.Database.MySqlReader.CheckLastRenewRequest())
                    {
                        GlobalModals.FRM_MessageAndProgressBar mpb = new GlobalModals.FRM_MessageAndProgressBar("Aguarde, enviando solicitação...", 6);
                        mpb.Show();

                        try
                        {
                            Email.PaymentRequestEmail();

                            Library.Database.MySqlNonQuery.UpdateLastRenewRequest();

                            mpb.CustomClose();

                            messOk = new GlobalModals.FRM_MessageAndOK("Sucesso! Solicitação enviada!", 4);
                            messOk.Show();
                        }
                        catch (Exception ex)
                        {
                            Care.AppendOnErrorLogFile(ex.Message);

                            mpb.CustomClose();

                            messOk = new GlobalModals.FRM_MessageAndOK("Aconteceu um erro ao tentar enviar a solicitação! Por favor, tente novamente mais tarde.", 2);
                            messOk.Show();
                        }
                    }
                    else
                    {
                        messOk = new GlobalModals.FRM_MessageAndOK("Você já solicitou a recarga de sua conta nas últimas 24 horas! Por favor, aguarde sua última solicitação completar 24 horas para realizar outra.", 1);
                        messOk.Show();
                    }                    
                }
            }
            else
            {
                //Token system to prevent multi-logins
                bool result = Token.TokenAuth();
                if (!result)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("A conta que você tentou entrar já está logada em outro lugar! Caso você ache que sua conta foi violada entre em contato com a administração.", 1);
                    messOk.Show();

                    frmLoadingScreen.CustomClose();
                    txtEmail.Text = String.Empty;
                    txtPassword.Text = String.Empty;
                    this.Show();
                    return;
                }

                //Register the e-mail and the auto login system into last_login file
                LoginData.LastLoginFileAfterLogin(GlobalVariables.User, cbxAutoLogin.Checked);                

                //Makes update in the new token of the user
                MySqlNonQuery.UpdateUser("last_login", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                MySqlNonQuery.UpdateUser("active", "1");

                // PROGRESS BAR 5%
                frmLoadingScreen.IncrementStep(5);
                frmLoadingScreen.ChangeStatusMessage("Carregando suas configurações...");
                MySqlReader.ReadConfiguration();
                GlobalVariables.IsWindows10 = Library.Checkers.OperationalSystem.IsWindows10();
                if (!GlobalVariables.IsWindows10) GlobalVariables.Configuration.Enable_windows_voice_alerts = false;

                // PROGRESS BAR 10%
                frmLoadingScreen.IncrementStep(5);
                frmLoadingScreen.ChangeStatusMessage("Carregando lembretes...");
                MySqlReader.ReadReminders();
                DatabaseToLocalFile.Reminders();
                Reminder.UpdateTodaysReminders();

                // PROGRESS BAR 15%
                frmLoadingScreen.IncrementStep(5);
                frmLoadingScreen.ChangeStatusMessage("Carregando produtos...");
                MySqlReader.ReadProducts();

                // PROGRESS BAR 20%
                frmLoadingScreen.IncrementStep(5);
                frmLoadingScreen.ChangeStatusMessage("Carregando lotes...");
                MySqlReader.ReadLots();
                Lot.JoinSameLots();

                // PROGRESS BAR 25%
                frmLoadingScreen.IncrementStep(5);
                frmLoadingScreen.ChangeStatusMessage("Carregando serviços...");
                MySqlReader.ReadJobs();

                // PROGRESS BAR 30%
                frmLoadingScreen.IncrementStep(5);
                frmLoadingScreen.ChangeStatusMessage("Carregando fornecedores...");
                MySqlReader.ReadSuppliers();

                // PROGRESS BAR 35%
                frmLoadingScreen.IncrementStep(5);
                frmLoadingScreen.ChangeStatusMessage("Carregando clientes...");
                MySqlReader.ReadCostumers();

                // PROGRESS BAR 40%
                frmLoadingScreen.IncrementStep(5);
                frmLoadingScreen.ChangeStatusMessage("Carregando garantias...");
                MySqlReader.ReadWarranties();
                DatabaseToLocalFile.Warranties();

                // PROGRESS BAR 45%
                frmLoadingScreen.IncrementStep(5);
                frmLoadingScreen.ChangeStatusMessage("Carregando pedidos...");
                MySqlReader.ReadRequests();
                DatabaseToLocalFile.Requests();

                // PROGRESS BAR 80%
                frmLoadingScreen.IncrementStep(35);
                frmLoadingScreen.ChangeStatusMessage("Carregando dados de comércio...");
                MySqlReader.ReadSalesRecord();
                MySqlReader.ReadDaysRecords();
                if(GlobalVariables.User.Cnpj != null && GlobalVariables.User.Cnpj != "")
                {
                    GlobalVariables.CompanyInformation = new CompanyInformation(GlobalVariables.User.Cnpj);
                }

                // PROGRESS BAR 85%
                frmLoadingScreen.IncrementStep(5);
                frmLoadingScreen.ChangeStatusMessage("Carregando mensagens e anúncios...");
                MySqlReader.ReadAdminMessages();
                MySqlReader.ReadAnnounce();
                GlobalVariables.AdminMessages.Sort((x, y) => DateTime.Compare(y.DeliveredIn, x.DeliveredIn));

                // PROGRESS BAR 90%
                frmLoadingScreen.IncrementStep(5);
                frmLoadingScreen.ChangeStatusMessage("Executando operação quinzenal...");
                Library.Routines.Fortnight.Start();

                // PROGRESS BAR 100%
                frmLoadingScreen.IncrementStep(10);
                frmLoadingScreen.ChangeStatusMessage("Tudo pronto! Vamos começar!");

                frmLoadingScreen.CustomClose();

                Library.Folders.StartupCheckIn.CheckFoldersAfterLoad();

                //Instance the Main form
                Library.Errors.Care.AntiInvalidInstance = false;
                Forms.Main.FRM_Main mainForm = new Forms.Main.FRM_Main();

                //Runs the main form             
                mainForm.ShowDialog();

                //Clear
                mainForm.Dispose();
                GlobalVariables.ClearAll();

                Library.Routines.AwaysActive.RunRoutine = false;
            }            

            //After closed the main form the login form will reappear
            this.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            Forms.ForgotPassword.FRM_ForgotPassword frmForgPass = new Forms.ForgotPassword.FRM_ForgotPassword();
            frmForgPass.ShowDialog();
        }

        //This event is to show the login windows after the little loading box
        private void frmLogin_Shown(object sender, EventArgs e)
        {
            this.Activate();
        }

        //Style events
        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = ColorsPalette.GDE_Info;
        }

        private void BtnNewAccount_MouseEnter(object sender, EventArgs e)
        {
            btnNewAccount.ForeColor = Color.White;
        }

        private void BtnNewAccount_MouseLeave(object sender, EventArgs e)
        {
            btnNewAccount.ForeColor = ColorsPalette.GDE_Green;
        }

        private void BtnForgotPassword_MouseEnter(object sender, EventArgs e)
        {
            btnForgotPassword.ForeColor = Color.White;
        }

        private void BtnForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            btnForgotPassword.ForeColor = ColorsPalette.GDE_Green;
        }

        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.White;
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Crimson;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Se precisar de ajuda com problemas ao tentar entrar ou recarga de contas, envie um e-mail para gc-administração@kuhnper.com.br.", 6);
            messOk.Show();
        }

        private void pnlMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
