using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GC.Library.Database;
using GC.Library.Objects;
using GC.Library.Translators;
using GC.Library;

namespace GC.Forms.Main.Controls
{
    public partial class USC_Jobs : UserControl
    {
        internal event EventHandler JobAlteredDeleted;

        Modals.Jobs.FRM_SearchOptionsJobs FrmSO = new Modals.Jobs.FRM_SearchOptionsJobs();

        int ListViewIndex = -1;

        public USC_Jobs()
        {
            InitializeComponent();

            if (!Library.Errors.Care.AntiInvalidInstance)
            {
                UpdateStats();
            }
        }

        internal void UpdateStats()
        {
            lblJobsCount.Text = "Total de Serviços Cadastrados: " + GlobalVariables.FragileData.RegisteredJobs.ToString() + "/" + GlobalVariables.FragileData.MaxJobs.ToString();
            lvlJobs.Items.Clear();
            AddAllJobsToListView();
        }

        private void AddAllJobsToListView()
        {
            foreach (Job item in GlobalVariables.Jobs)
            {
                JobToListView(item);
            }
        }

        private void JobToListView(Job job)
        {
            ListViewItem lvi = lvlJobs.Items.Add(job.Name);
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(job.Description)));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(job.Price)));

            if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);
        }

        private void BtnNewJobs_Click(object sender, EventArgs e)
        {         
            if (GlobalVariables.FragileData.RegisteredJobs >= GlobalVariables.FragileData.MaxJobs)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Infelizmente você já atingiu o seu limite de " + GlobalVariables.FragileData.MaxJobs.ToString() + " serviços cadastrados. Você não poderá cadastrar mais serviços. Contate a administração e mude seu plano para continuar a cadastrar seus serviços.", 1);
                messOk.Show();

                return;
            }

            Modals.Jobs.FRM_NewJob newJob = new Modals.Jobs.FRM_NewJob();
            newJob.ShowDialog();

            UpdateStats();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (this.ListViewIndex >= 0)
            {
                string name = lvlJobs.Items[this.ListViewIndex].Text;

                var filtered = GlobalVariables.Jobs.Where(x => x.Name == name).Select(x => x);

                Job toBeUpdated = null;
                foreach (Job item in filtered)
                {
                    toBeUpdated = item;
                }

                Modals.Jobs.FRM_AlterJob alterJob = new Modals.Jobs.FRM_AlterJob(toBeUpdated);
                alterJob.ShowDialog();

                if (alterJob.Alterations) this.JobAlteredDeleted(this, new EventArgs());
            }

            this.ListViewIndex = -1;

            btnAlter.Enabled = false;
            btnDelete.Enabled = false;

            UpdateStats();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {    
            GlobalModals.FRM_Confirmation confirmation = new GlobalModals.FRM_Confirmation("Este serviço será excluído permanentemente e todos os pedidos e garantias que usam este serviço ficarão sem ele (Porém o valor final dos pedidos continuarão originais). Tem certeza que deseja continuar ?", 1);

            //Loading window
            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();

            confirmation.ShowDialog();
            if (confirmation.Result)
            {
                if (this.ListViewIndex >= 0)
                {
                    ml.Show();

                    string name = lvlJobs.Items[this.ListViewIndex].Text;
                    var filtered = GlobalVariables.Jobs.Where(x => x.Name == name).Select(x => x);
                    Job toBeDeleted = null;

                    foreach (Job item in filtered)
                    {
                        toBeDeleted = item;
                    }

                    //Now yeah, makes the delete
                    
                    MySqlNonQuery.DeleteJobById(toBeDeleted.Id);

                    MySqlNonQuery.IncrementUserRegisteredJobs(-1);

                    GlobalVariables.Jobs.Remove(toBeDeleted);
                    lvlJobs.Items.RemoveAt(this.ListViewIndex);
                }

                UpdateStats();

                this.JobAlteredDeleted(this, new EventArgs());

                ml.CustomClose();
            }

            this.ListViewIndex = -1;
            btnDelete.Enabled = false;
            btnAlter.Enabled = false;
        }

        private void LvlJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvlJobs.SelectedItems.Count != 0)
            {
                this.ListViewIndex = lvlJobs.SelectedIndices[0];
                if (this.ListViewIndex >= 0)
                {
                    btnDelete.Enabled = true;
                    btnAlter.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                    btnAlter.Enabled = false;
                }
            }
        }

        private void BtnSearchOptions_Click(object sender, EventArgs e)
        {
            this.FrmSO.ShowDialog();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lvlJobs.Items.Clear();
                List<Job> JobsFound = new List<Job>();
                if (txtSearch.Text.Length <= 0)
                {
                    AddAllJobsToListView();
                }
                else
                {
                    if (this.FrmSO.ckbName.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Jobs.Where(x => x.Name != null && x.Name.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Job item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Job subItem in JobsFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) JobsFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbDesc.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Jobs.Where(x => x.Description != null && x.Description.ToLower().Contains(txtSearch.Text.ToLower())).Select(x => x);
                        foreach (Job item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Job subItem in JobsFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) JobsFound.Add(item);
                        }
                    }
                    if (this.FrmSO.ckbPrice.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Jobs.Where(x => x.Price > 0 && x.Price.ToString("n2").Contains(txtSearch.Text)).Select(x => x);
                        foreach (Job item in filtered)
                        {
                            itemAlreadyExists = false;
                            foreach (Job subItem in JobsFound)
                            {
                                if (item.IsEqualTo(subItem))
                                {
                                    itemAlreadyExists = true;
                                    break;
                                }
                            }
                            if (!itemAlreadyExists) JobsFound.Add(item);
                        }
                    }
                    if (JobsFound.Count() <= 0)
                    {
                        ListViewItem lvi = lvlJobs.Items.Add("Nenhum resultado...");
                    }
                    else
                    {
                        foreach (Job item in JobsFound)
                        {
                            JobToListView(item);
                        }
                    }
                }
            }
        }
    }
}
