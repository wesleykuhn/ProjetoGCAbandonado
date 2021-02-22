using GC.Library;
using GC.Library.Database;
using GC.Library.Errors;
using GC.Library.Web;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GC.Forms.Main.Controls
{
    public partial class USC_Configuration : UserControl
    {
        public USC_Configuration()
        {
            InitializeComponent();

            btnApply.TextAlign = ContentAlignment.MiddleCenter;
            btnApply.TextImageRelation = TextImageRelation.Overlay;

            btnChangeAccountType.Anchor = AnchorStyles.None;
            btnChangeAccountType.Anchor = AnchorStyles.Right | AnchorStyles.Top;

            btnRenewAccount.Anchor = AnchorStyles.None;
            btnRenewAccount.Anchor = AnchorStyles.Right | AnchorStyles.Top;

            if (!Library.Errors.Care.AntiInvalidInstance)
            {
                UpdateUI();
                UpdateAccountPaymentUI();

                if (!GlobalVariables.IsWindows10)
                {
                    cbxActiveComputerVoice.Enabled = false;
                    cbxActiveComputerVoice.Text += " (Esta opção só está disponível para o Windows 10!)";
                }
            }
        }

        private void UpdateUI()
        {
            cbxActiveAnimations.Checked = GlobalVariables.Configuration.Enable_animations;
            cbxActiveComputerVoice.Checked = GlobalVariables.Configuration.Enable_windows_voice_alerts;
            cbxActiveWindowAlerts.Checked = GlobalVariables.Configuration.Enable_modal_alerts;            

            nudDaysBeforeExpirimentProduct.Value = Convert.ToDecimal(GlobalVariables.Configuration.Days_before_expiration);
            cbxActiveCriticalStockSystem.Checked = GlobalVariables.Configuration.Enable_critical_stock_system;

            cbxActiveRequestSeparatorHelper.Checked = GlobalVariables.Configuration.Enable_request_products_separation_helper;
            cbxAutoClearCancelledReq.Checked = GlobalVariables.Configuration.Auto_clear_cancelled_req;
        }

        internal void UpdateAccountPaymentUI()
        {
            DateTime dateOfExpiration = Library.Translators.SqlToObject.ToDate(Library.Database.MySqlReader.ReadOnlyOneColumn("user_metadata", "expiration", new string[] { "id_user" }, new string[] { GlobalVariables.User.Id.ToString() }, null, new bool[] { false }));

            switch (GlobalVariables.User.AccountType)
            {
                case 'G':
                    lblAccountType.Text = "GRANDE";
                    break;
                case 'M':
                    lblAccountType.Text = "MÉDIO";
                    break;
                default:
                    lblAccountType.Text = "PEQUENO";
                    break;
            }

            TimeSpan days = dateOfExpiration.Subtract(DateTime.Now);
            int dif = (int)days.TotalDays;

            lblExpiration.Text = "Sua conta vence em " + dif.ToString() + " dias.";
            if (dif <= 9) lblExpiration.ForeColor = Color.Crimson;
        }

        private void UpdateGlobalVariables()
        {
            GlobalVariables.Configuration.Enable_animations = cbxActiveAnimations.Checked;
            GlobalVariables.Configuration.Enable_windows_voice_alerts = cbxActiveComputerVoice.Checked;
            GlobalVariables.Configuration.Enable_modal_alerts = cbxActiveWindowAlerts.Checked;

            GlobalVariables.Configuration.Days_before_expiration = Convert.ToInt32(nudDaysBeforeExpirimentProduct.Value);
            GlobalVariables.Configuration.Enable_critical_stock_system = cbxActiveCriticalStockSystem.Checked;

            GlobalVariables.Configuration.Enable_request_products_separation_helper = cbxActiveRequestSeparatorHelper.Checked;
            GlobalVariables.Configuration.Auto_clear_cancelled_req = cbxAutoClearCancelledReq.Checked;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            UpdateGlobalVariables();

            MySqlNonQuery.UpdateUserConfiguration();

            GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Novas configurações aplicadas com sucesso!", 5);
            messOk.Show();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_Confirmation conf = new GlobalModals.FRM_Confirmation("Atenção! Deseja realmente redefinir todas as opções do programa? Essa operação não poderá ser desfeita depois.", 1);
            conf.Show();
            if (!conf.Result) return;

            GlobalVariables.Configuration.Enable_animations = true;
            GlobalVariables.Configuration.Enable_windows_voice_alerts = true;
            GlobalVariables.Configuration.Enable_modal_alerts = true;

            GlobalVariables.Configuration.Days_before_expiration = 30;
            GlobalVariables.Configuration.Enable_critical_stock_system = true;

            GlobalVariables.Configuration.Enable_request_products_separation_helper = true;
            GlobalVariables.Configuration.Auto_clear_cancelled_req = true;

            UpdateUI();

            MySqlNonQuery.UpdateUserConfiguration();
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            if (!MySqlReader.CheckFeedbackLimit())
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Infelizmente você ainda tem 5 relatórios ou sugestões que ainda estão em aberto. Por isso, você não poderá mais enviar relatórios ou sugestões.", 1);
                messOk.Show();
                return;
            }
            else
            {
                Modals.Configuration.FRM_SendFeedback feedback = new Modals.Configuration.FRM_SendFeedback();
                feedback.ShowDialog();
            }
        }

        private void btnRenewAccount_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_Confirmation conf = new GlobalModals.FRM_Confirmation("Para recarregar sua conta você precisa solicitar um boleto de cobrança. Então, dentro de 48 horas uteis, a administração lhe enviará um link, via mensagem do programa e e-mail, do boleto gerado pelo site www.asaas.com. Após pagar o boleto, sua conta ira ser recarregada com mais 30 dias." +
                "\n\nATENÇÃO: Todos os links de boletos serão enviados apenas por meio do e-mail gc-administracao@kuhnper.com.br! Toda cobrança pelo uso do GC que vier fora deste e-mail deverá ser ignorada." +
                "\n\nDeseja enviar uma solicitação de recarga agora?", 6);
            conf.Show();

            if (conf.Result)
            {
                if (Library.Database.MySqlReader.CheckLastRenewRequest())
                {
                    GlobalModals.FRM_MessageAndOK messOk;

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
                    GlobalModals.FRM_MessageAndOK.BuildAndShow("Você já solicitou a recarga de sua conta nas últimas 24 horas! Por favor, aguarde sua última solicitação completar 24 horas para realizar outra.", 1);
                }                
            }
        }

        private void btnChangeAccountType_Click(object sender, EventArgs e)
        {
            DateTime lastRequestDate = Library.Translators.SqlToObject.ToDateTime(MySqlReader.ReadOnlyOneColumn("user_metadata", "last_account_type_change", new string[] { "id_user" }, new string[] { GlobalVariables.User.Id.ToString() }, null, new bool[] { false }));

            TimeSpan aux = DateTime.Now.Subtract(lastRequestDate);
            int dif = (int)aux.TotalDays;

            if(dif < 60)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Você solicitou uma mudança de plano à menos de 2 meses! Por isso, você não poderá solicitar novamente.", 1);
                messOk.Show();

                return;
            }
            else
            {
                Modals.Configuration.FRM_AccountTypeChange changeAccountType = new Modals.Configuration.FRM_AccountTypeChange();
                changeAccountType.ShowDialog();
            }            
        }

        private void LBL_MyAccountInfo_Click(object sender, EventArgs e)
        {
            Modals.Configuration.FRM_AlterUser alterUser = new Modals.Configuration.FRM_AlterUser();
            alterUser.ShowDialog();
        }
    }
}
