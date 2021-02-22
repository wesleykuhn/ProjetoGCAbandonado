using System;
using System.Windows.Forms;
using GC.Library.Database;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace GC
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, "Global\\" + Library.Collectors.AppGuid.Get()))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("O programa já está aberto!");

                    Environment.Exit(0);
                }
                
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                GlobalModals.FRM_MiniLoad startLoader = new GlobalModals.FRM_MiniLoad();

                KuhnperBase.Library.Informations.Connection.SetConnectionString("434064633646328761640843646356463287616488406463064632826164384164630646328361640843646356463287616488406463064632826164084064632646328561647845646346463289616488406463064632826164646328890142629759936463288901426297590364632889014262975903184364631646328961648848646336463283616418456463764632896164484064633646328761640840646306463280616408406463064632896164084264631646328061640840646306463280616418456463764632896164884064630646328261641843646316463289616408416463164632806164184564637646328961643847646396463280616418436463164632896164784564634646328961648840646306463282616408406463264632886164484864630646328361645348646316463287616408426463164632806164084064630646328061640842646316463280616478456463464632896164084264631646328061644840646336463287616408436463564632876164084064632646328561641840646306463280616408436463564632876164484064633646328761643842646316463289616408436463564632876164884464633646328161646463288901426297590364632889014262975963084064633646328661640840646306463289616408416463164632806164584864631646328761647845646346463289616464632889014262975913084064632646328861647343646316463280616498416463064632806164584864631646328761640840646326463285616418406463064632806164084364635646328761644840646336463287616438426463164632896164084364635646328761648844646336463281616464632889014262975903646328890142629759630840646336463286616408476463664632816164784364631646328061647845646346463289616438426463164632896164984164630646328061640841646316463280616408406463264632886164034764636646328161641840646306463280616458486463164632876164084064632646328561640347646366463281616478436463164632806164784564634646328961643842646316463289616498416463064632806164084164631646328061640840646336463285616403416463164632806164184564637646328961644840646336463287616408406463064632806164784364631646328061643847646396463280616408436463564632876164884064630646328261644840646336463287616448426463264632896164184064630646328061640843646356463287616448406463364632876164384264631646328961640843646356463287616488446463364632816164084064631646328261640843646396463280616418436463164632896164084164631646328061641845646376463289616438476463964632806164084064632646328661646463288901426297591364632889014262975903646328890142629759236463288901426297599364632889014262975933646328890142629759930840646326463288616403416463164632806164184564637646328961640845646316463288616408456463164632886164084364635646328761640841646316463280616408406463064632806164984164630646328061641845646376463289616408456463164632886164484864630646328361640340646306463280616498416463064632806164384764639646328061640843646356463287616418456463764632896164784364631646328061640840646306463280616408406463264632856164646328890142629759236463288901426297598364632889014262975983646328890142629759036463288901426297590308406463264632886164");

                GC.Library.Folders.StartupCheckIn.CheckFoldersBeforeLoad();

                startLoader.Show();

                bool result = MySqlNonQuery.TestConnection(false);
                if (!result)
                {
                    result = MySqlNonQuery.TestConnection(false);
                }

                if (result)
                {
                    // AUTO UPDATE ((UPDATER))
                    // Check for updater updates (Kuhnper Updater)
                    KuhnperBase.Library.Updates.Updater.CheckForUpdates();                    

                    // Program self-updater partial system
                    string currentProgramVersion = MySqlReader.CheckForProgramUpdate();
                    if (currentProgramVersion != null)
                    {
                        KuhnperUpdater.LocalLibrary.KuhnperUpdaterParameter kup = new KuhnperUpdater.LocalLibrary.KuhnperUpdaterParameter("Gestor de Comércio", "GC", "gc", System.Windows.Forms.Application.ProductVersion, currentProgramVersion);

                        string serializedKup = kup.SerializeThis();

                        System.IO.File.WriteAllText(@"./kup.txt", serializedKup);

                        startLoader.CustomClose();

                        System.Diagnostics.Process.Start("KuhnperUpdater.exe");

                        Environment.Exit(0);
                    }
                    else startLoader.CustomClose();

                    Application.Run(new Forms.Login.FRM_Login());
                }
                else
                {
                    startLoader.CustomClose();

                    bool success = false;

                    KuhnperBase.Forms.Messages.FRM_CancelableLoading cl = new KuhnperBase.Forms.Messages.FRM_CancelableLoading("Seu computador está sem conexão com a internet nesse momento! Aguarde enquanto o programa tenta conectar novamente...\n\n[Tentativa 1 de 10]", KuhnperBase.Library.Style.KuhnperColors.BootstrapRed, KuhnperBase.Forms.Messages.FRM_CancelableLoading.FormSounds.Error);

                    cl.CancelButtonClicked += new EventHandler(ForceProgramExit);

                    cl.Show();

                    for (int i = 0; i < 10; i++)
                    {
                        Thread.Sleep(30000);

                        cl.ChangeMessage("Seu computador está sem conexão com a internet nesse momento! Aguarde enquanto o programa tenta conectar novamente...\n\n[Tentativa " + (i + 1).ToString() + " de 10]");

                        if (MySqlNonQuery.TestConnection(false))
                        {
                            success = true;

                            break;
                        }
                    }

                    cl.ForceClose();

                    if (success) Application.Run(new Forms.Login.FRM_Login());
                }
            }            
        }

        private static void ForceProgramExit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
