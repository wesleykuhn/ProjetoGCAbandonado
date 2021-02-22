using GC.Library;
using GC.Library.Objects;
using GC.Library.Translators;
using System;
using System.Collections.Generic;
using GC.Library.Database;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

namespace GC.Forms.Main.Modals.Jobs
{
    public partial class FRM_NewJob : Bases.FRM_Default
    {
        List<Job> AddedJobs = new List<Job>();
        int ListViewIndex = -1;

        public FRM_NewJob()
        {
            InitializeComponent();

            this.ReadyForm();

            this.ReplaceCloseEvent(new EventHandler(CloseForm));
        }

        private void CloseForm(object sender, EventArgs e)
        {
            GC.GlobalModals.FRM_Confirmation confirmation = null;
            if (AddedJobs.Count() == 0) confirmation = new GC.GlobalModals.FRM_Confirmation("Deseja realmente cancelar?", 1);
            else if (AddedJobs.Count() > 0) confirmation = new GC.GlobalModals.FRM_Confirmation("Você tem " + AddedJobs.Count() + " serviços não salvo(s)! Deseja realmente cancelar?", 1);
            confirmation.ShowDialog();
            if (confirmation.Result)
            {
                Close();
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text.TrimStart();
            name = name.TrimEnd();
            if (name.Length > 1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
            ml.Show();

            int addedCount = AddedJobs.Count();

            
            MySqlNonQuery.CreateJobs(AddedJobs);

            MySqlNonQuery.IncrementUserRegisteredJobs(AddedJobs.Count);

            foreach (Job item in AddedJobs)
            {
                int id = Convert.ToInt32(MySqlReader.ReadOnlyOneColumn("job", "idjob", new string[] { "name", "id_user" }, new string[] { item.Name, GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }));

                item.Id = id;
            }

            foreach (Job item in AddedJobs)
            {
                GlobalVariables.Jobs.Add(item);
            }

            ml.CustomClose();

            Close();
        }

        private void BtnAddJob_Click(object sender, EventArgs e)
        {
            bool success = true;

            if(nudPrice.Value <= 0)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Você não pode deixar o preço zerado! Por favor, mude-o e tente novamente.", 1);
                messOk.Show();

                return;
            }

            // Handling with the 0 and "". Wich are null values ---------------------------------------------
            string name = FieldsToObject.ToString(txtName.Text);
            string description = FieldsToObject.ToString(txtDesc.Text);
            double price = FieldsToObject.ToDouble(Convert.ToDouble(nudPrice.Value));
            // -------------------------------------------------------------------------------

            Job newJob = new Job(0, name, description, price);

            foreach (Job item in GlobalVariables.Jobs)
            {
                if (newJob.Name == item.Name)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Já existe um serviço salvo com o esse mesmo nome! Por favor, verifique e insira outro nome.", 1);
                    messOk.Show();

                    success = false;
                    break;
                }
            }
            if (success)
            {
                foreach (Job item in AddedJobs)
                {
                    if (newJob.Name == item.Name)
                    {
                        GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Um dos serviço(s) cadastrado(s) agora pouco por você já possui esse mesmo nome! Por favor, verifique e insira outro nome.", 1);
                        messOk.Show();

                        success = false;
                        break;
                    }
                }
            }
            if (success)
            {
                AddedJobs.Add(newJob);
                ListViewItem lvi = lvlAddedJobs.Items.Add(newJob.Name);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(newJob.Description)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView_TwoDecimals(newJob.Price)));

                if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);

                txtName.Text = String.Empty;
                txtDesc.Text = String.Empty;
                nudPrice.Value = Convert.ToDecimal(0.01);
            }
            EnableOrDisableFinishButton();
        }

        private void EnableOrDisableFinishButton()
        {
            if (AddedJobs.Count() > 0) btnAdd.Enabled = true;
            else btnAdd.Enabled = false;
        }

        private void LvlAddedJobs_DoubleClick(object sender, EventArgs e)
        {
            this.ListViewIndex = lvlAddedJobs.SelectedIndices[0];
            if (this.ListViewIndex >= 0)
            {
                AddedJobs.RemoveAt(this.ListViewIndex);
                lvlAddedJobs.Items.RemoveAt(this.ListViewIndex);
            }
            this.ListViewIndex = -1;
            EnableOrDisableFinishButton();
        }
    }
}
