using GC.Library;
using GC.Library.Errors;
using System.Diagnostics;
using System.Windows.Forms;

namespace GC.Forms.Main.Controls
{
    public partial class USC_Home : UserControl
    {
        private byte oneTimeNav = 1;

        public USC_Home()
        {
            InitializeComponent();

            if (!Care.AntiInvalidInstance)
            {
                if(GlobalVariables.Announce == null)
                {
                    wbsNews.Hide();

                    this.BackColor = System.Drawing.SystemColors.Control;
                }
                else
                {
                    System.Threading.Tasks.Task.Run(() => UpdateWebNews());

                    while (wbsNews.ReadyState != WebBrowserReadyState.Complete)
                    {
                        Application.DoEvents();
                    }                    
                }                
            }
        }

        private void UpdateWebNews()
        {
            Care.HandleInvokeMethod(ref wbsNews, new System.Action(() => {
                wbsNews.DocumentText = GlobalVariables.Announce.Body;
            }));            
        }

        private void lkbAccountTypes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.Visited = true;

            System.Diagnostics.Process.Start("https://www.kuhnper.com.br/gc/planos");
        }

        private void lkbTutorials_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.Visited = true;

            System.Diagnostics.Process.Start("https://www.kuhnper.com.br/gc/tutoriais");
        }

        private void lkbUpdates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.Visited = true;

            System.Diagnostics.Process.Start("https://www.kuhnper.com.br/gc/atualizacoes");
        }

        private void wbsNews_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (this.oneTimeNav == 0)
            {
                Process.Start(e.Url.ToString().Replace("about:", ""));

                e.Cancel = true;
            }
            else this.oneTimeNav--;
        }
    }
}
