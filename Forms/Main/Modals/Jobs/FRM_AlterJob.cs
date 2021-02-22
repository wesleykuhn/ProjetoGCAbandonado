using System;
using System.Windows.Forms;
using GC.Library.Translators;
using GC.Library.Objects;
using GC.Library.Database;
using GC.Library;

namespace GC.Forms.Main.Modals.Jobs
{
    public partial class FRM_AlterJob : Bases.FRM_Default
    {
        internal bool Alterations = false;

        Job oldJob;

        internal FRM_AlterJob(Job oldJob)
        {
            InitializeComponent();

            this.ReadyForm();

            txtName.Text = oldJob.Name;
            txtDesc.Text = ObjectToListView.ToStringListView(oldJob.Description);

            if(oldJob.Price == -1)
            {
                nudPrice.Value = 0;
            }
            else
            {
                nudPrice.Value = Convert.ToDecimal(oldJob.Price);
            }

            this.oldJob = oldJob;
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text.TrimStart();
            name = name.TrimEnd();
            if (name.Length < 1) btnAlter.Enabled = false;
            else btnAlter.Enabled = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
            ml.Show();

            //Taking the supplier out from the global list to be updated
            int index = GlobalVariables.Jobs.IndexOf(oldJob);
            GlobalVariables.Jobs[index] = null;

            // Handling with the 0 and "". Wich are null values ---------------------------------------------
            string aux = txtName.Text.TrimStart();
            aux = aux.TrimEnd();
            string name = aux;

            aux = txtDesc.Text.TrimStart();
            aux = aux.TrimEnd();
            string description = aux;

            double price = FieldsToObject.ToDouble(Convert.ToDouble(nudPrice.Value));
            // -------------------------------------------------------------------------------

            Job newJob = new Job(oldJob.Id, name, description, price);
            foreach (Job item in GlobalVariables.Jobs)
            {
                if(item != null)
                {
                    if (newJob.Name == item.Name)
                    {
                        GlobalVariables.Jobs[index] = oldJob;

                        GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Já existe um serviço salvo com o esse mesmo nome! Por favor, insira outro nome.", 1);
                        messOk.Show();

                        ml.CustomClose();

                        return;
                    }
                }                
            }

            
            MySqlNonQuery.UpdateJob(newJob);

            GlobalVariables.Jobs[index] = newJob;

            this.Alterations = true;

            ml.CustomClose();

            Close();
        }
    }
}
