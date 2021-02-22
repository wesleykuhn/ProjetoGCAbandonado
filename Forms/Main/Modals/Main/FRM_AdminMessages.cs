using GC.Library;
using GC.Library.Checkers;
using GC.Library.Database;
using GC.Library.Objects;
using GC.Library.Style;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GC.Forms.Main.Modals.Main
{
    public partial class FRM_AdminMessages : Bases.FRM_Full
    {
        internal static AdminMessage SelectedAdminMessage = null;

        private byte oneTimeNav = 1;

        public FRM_AdminMessages()
        {
            InitializeComponent();

            this.ReadyForm();

            AssemblyMessagesSidebar();
            AssemblyMessage();            
        }

        // Controls assembly ----------------------------------------------------------->
        private void AssemblyMessagesSidebar()
        {
            spcMessages.Panel1.Controls.Clear();

            foreach (AdminMessage message in GlobalVariables.AdminMessages)
            {               
                Components.CMP_AdminMessageSubject cams = new Components.CMP_AdminMessageSubject(message);
                cams.OnChildClick += new EventHandler(MessageClicked);
                cams.OnChildDelete += new EventHandler(DeleteAdminMessage);
                cams.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                if (spcMessages.Panel1.Controls.Count == 0)
                {
                    spcMessages.Panel1.Controls.Add(cams);                   
                }
                else
                {
                    spcMessages.Panel1.Controls.Add(cams);

                    spcMessages.Panel1.Controls[spcMessages.Panel1.Controls.Count - 1].Top = spcMessages.Panel1.Controls[spcMessages.Panel1.Controls.Count - 2].Location.Y + spcMessages.Panel1.Controls[spcMessages.Panel1.Controls.Count - 2].Height;
                }

                if(this.WindowState != FormWindowState.Maximized)
                {
                    spcMessages.Panel1.Controls[spcMessages.Panel1.Controls.Count - 1].Width -= 50;
                }
                else
                {
                    spcMessages.Panel1.Controls[spcMessages.Panel1.Controls.Count - 1].Width = spcMessages.Panel1.Width;
                }
            }
        }
        // <------------------------------------------------------------------------

        //EVENTS BEGIN -------------------------------------------------------------------->
        private void MessageClicked(object sender, EventArgs e)
        {
            AssemblyMessage();

            if (Structs.IsDateTimeNull(SelectedAdminMessage.ReadIn))
            {
                int index = GlobalVariables.AdminMessages.FindIndex(x => x.Id == SelectedAdminMessage.Id);
                GlobalVariables.AdminMessages[index].ReadIn = DateTime.Now;
                SelectedAdminMessage.ReadIn = DateTime.Now;

                MarkAdminMessageAsRead(SelectedAdminMessage);                
            }                     
        }

        private void AssemblyMessage()
        {
            wbsBody.DocumentText = String.Empty;

            if (GlobalVariables.AdminMessages.Count <= 0)
            {
                Label label = new Label();
                label.Font = Library.Style.Labels.BigLabel;
                label.AutoSize = true;
                label.BackColor = SystemColors.Control;
                label.Text = "Nenhuma...";
                label.Left = 5;
                label.Top = 5;

                spcMessages.Panel1.Controls.Add(label);
                spcMessages.Panel2.Hide();
            }
            else if(SelectedAdminMessage == null)
            {
                flpSubject.Hide();
                wbsBody.Hide();
                pnlInfo.Hide();
            }
            else
            {               
                switch (SelectedAdminMessage.Color)
                {
                    case 0:
                        pnlColor.BackColor = ColorsPalette.GDE_Dark;
                        lblColor.Text = "Prioridade: Normal";
                        break;

                    case 1:
                        pnlColor.BackColor = ColorsPalette.GDE_Info;
                        lblColor.Text = "Prioridade: Pouco Importante";
                        break;

                    case 2:
                        pnlColor.BackColor = ColorsPalette.GDE_Warning;
                        lblColor.Text = "Prioridade: Importante";
                        break;

                    case 3:
                        pnlColor.BackColor = ColorsPalette.GDE_Danger;
                        lblColor.Text = "Prioridade: Urgente";
                        break;
                }

                lblDelivered.Text = "Enviada em " + SelectedAdminMessage.DeliveredIn.ToString("dd/MM/yyyy") + " às " + SelectedAdminMessage.DeliveredIn.ToString("HH:mm:ss");

                lblSubject.Text = SelectedAdminMessage.Subject;

                //flpBody.Top = flpSubject.Location.Y + flpSubject.Height + 6;
                //flpBody.Height = spcMessages.Panel2.Height - (flpSubject.Location.Y + flpSubject.Height + 6 + 10);

                this.oneTimeNav = 1;

                wbsBody.DocumentText = SelectedAdminMessage.Body;

                pnlInfo.Show();
                flpSubject.Show();
                wbsBody.Show();
            }            
        }

        private static async void MarkAdminMessageAsRead(AdminMessage msg)
        {
            await System.Threading.Tasks.Task.Run(() => UpdateReadInOnDb(msg.Id));
        }

        private static void UpdateReadInOnDb(int idAm)
        {
            MySqlNonQuery.MarkAdminMessageAsRead(idAm);
        }

        private void DeleteAdminMessage(object sender, EventArgs e)
        {
            GlobalModals.FRM_Confirmation conf = new GlobalModals.FRM_Confirmation("Atenção! Deseja realmente excluir esta mensagem? Uma vez excluída ela não poderá ser recuperada.", 1);
            conf.Show();
            if (!conf.Result) return;
            

            MySqlNonQuery.DeleteAdminMessage(SelectedAdminMessage.Id);

            int index = GlobalVariables.AdminMessages.FindIndex(x => x.Id == SelectedAdminMessage.Id);
            GlobalVariables.AdminMessages.RemoveAt(index);

            SelectedAdminMessage = null;

            AssemblyMessagesSidebar();
            AssemblyMessage();
        }

        private void wbsBody_Navigating(object sender, WebBrowserNavigatingEventArgs e)
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
