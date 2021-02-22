using System;
using System.Linq;
using GC.Library.Objects;
using GC.Library.Translators;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using GC.Library;

namespace GC.Forms.Main.Modals.Requests.SubModals.NewRequest
{
    public partial class FRM_JobsList : Bases.FRM_Default
    {

        Jobs.FRM_SearchOptionsJobs FrmSO = new Jobs.FRM_SearchOptionsJobs();

        internal List<Job> SelectedJobs = new List<Job>();

        internal FRM_JobsList(List<Job> alreadySelectedJobs)
        {
            InitializeComponent();

            this.ReadyForm();

            this.ReplaceCloseEvent(new EventHandler(CloseForm));

            UpdateStats();

            if (alreadySelectedJobs.Count != 0)
            {
                this.SelectedJobs = alreadySelectedJobs;

                lvlJobs.ItemChecked -= LvlJobs_ItemChecked;

                if (lvlJobs.Items.Count != 0)
                {
                    for (int i = 0; i < lvlJobs.Items.Count; i++)
                    {
                        if (Job.AListContains(SelectedJobs, lvlJobs.Items[i].Text))
                        {
                            lvlJobs.Items[i].Checked = true;
                        }
                    }
                }

                lvlJobs.ItemChecked += LvlJobs_ItemChecked;
            }            
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.SelectedJobs.Clear();

            this.Close();
        }

        internal void UpdateStats()
        {
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

        private void LvlJobs_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < lvlJobs.Items.Count; i++)
            {
                if (lvlJobs.Items[i].Checked)
                {
                    if (!Job.AListContains(SelectedJobs, lvlJobs.Items[i].Text))
                    {
                        SelectedJobs.Add(Job.CloneJob(lvlJobs.Items[i].Text));
                    }
                }
                else
                {
                    if (Job.AListContains(SelectedJobs, lvlJobs.Items[i].Text))
                    {
                        SelectedJobs.Remove(Job.CloneJob(lvlJobs.Items[i].Text));
                    }
                }
            }

            lblSelectedCount.Text = SelectedJobs.Count.ToString();
        }

        private void BtnSearchOptions_Click(object sender, EventArgs e)
        {
            FrmSO.ShowDialog();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lvlJobs.ItemChecked -= LvlJobs_ItemChecked;

                lvlJobs.Items.Clear();
                List<Job> JobsFound = new List<Job>();
                if (txtSearch.Text.Length <= 0)
                {
                    AddAllJobsToListView();
                }
                else
                {
                    if (FrmSO.ckbName.Checked)
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
                    if (FrmSO.ckbDesc.Checked)
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
                    if (FrmSO.ckbPrice.Checked)
                    {
                        bool itemAlreadyExists;
                        var filtered = GlobalVariables.Jobs.Where(x => x.Price > 0 && x.Price.ToString().Contains(txtSearch.Text)).Select(x => x);
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

                if (JobsFound.Count != 0)
                {
                    for (int i = 0; i < lvlJobs.Items.Count; i++)
                    {
                        if (Job.AListContains(SelectedJobs, lvlJobs.Items[i].Text))
                        {
                            lvlJobs.Items[i].Checked = true;
                        }
                    }
                }

                lvlJobs.ItemChecked += LvlJobs_ItemChecked;
            }
        }
    }
}
