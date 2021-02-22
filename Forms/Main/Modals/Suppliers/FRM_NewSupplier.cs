using GC.Library.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GC.Library.Translators;
using GC.Library.Database;
using GC.Library.Objects.SubObjects.Product;
using GC.Library;

namespace GC.Forms.Main.Modals.Suppliers
{
    public partial class FRM_NewSupplier : Bases.FRM_Default
    {
        List<Supplier> AddedSuppliers = new List<Supplier>();

        int ListViewIndex = -1;

        public FRM_NewSupplier()
        {
            InitializeComponent();

            this.ReadyForm();

            this.ReplaceCloseEvent(new EventHandler(CloseForm));
        }

        private void CloseForm(object sender, EventArgs e)
        {
            GC.GlobalModals.FRM_Confirmation confirmation = null;
            if (AddedSuppliers.Count() == 0) confirmation = new GC.GlobalModals.FRM_Confirmation("Deseja realmente cancelar?", 1);
            else if (AddedSuppliers.Count() > 0) confirmation = new GC.GlobalModals.FRM_Confirmation("Você tem " + AddedSuppliers.Count() + " fornecedores não salvo(s)! Deseja realmente cancelar?", 1);
            confirmation.ShowDialog();
            if (confirmation.Result)
            {
                Close();
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            bool hasWord = false;
            string temp = txtPhone_number.Text.Trim();

            if(temp.Length != 0)
            {
                foreach (char word in temp)
                {
                    if (word != '0' && word != '1' && word != '2' && word != '3' && word != '4' && word != '5' && word != '6' && word != '7' && word != '8' && word != '9')
                    {
                        hasWord = true;
                    }
                }
                if (hasWord || temp.Length < 1 || temp.Length > 15)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Número de telefone/celular inválido! Você deve inserir apenas números.", 2);
                    messOk.Show();
                    return;
                }
            }           

            bool success = true;

            // Handling with the 0 and "". Wich are null values ---------------------------------------------
            string name = FieldsToObject.ToString(txtName.Text);
            string description = FieldsToObject.ToString(txtDesc.Text);
            string email = FieldsToObject.ToString(txtEmail.Text);
            string phone_number = FieldsToObject.ToString(txtPhone_number.Text);
            string cpf_cnpj = FieldsToObject.ToString(txtCpfCnpj.Text);
            // -------------------------------------------------------------------------------

            Supplier newSupplier = new Supplier(0, name, description, email, phone_number, cpf_cnpj);
            
            foreach (Supplier item in GlobalVariables.Suppliers)
            {
                if (newSupplier.Name == item.Name)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Já existe um fornecedor salvo com o esse mesmo nome! Por favor, verifique e insira outro.", 1);
                    messOk.Show();

                    success = false;
                    break;
                }
            }
            if (success)
            {
                foreach (Supplier item in AddedSuppliers)
                {
                    if (newSupplier.Name == item.Name)
                    {
                        GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Um dos fornecedores cadastrados agora por você já possui esse mesmo nome! Por favor, verifique e insira outro.", 1);
                        messOk.Show();

                        success = false;
                        break;
                    }
                }
            }
            if (success)
            {
                AddedSuppliers.Add(newSupplier);
                ListViewItem lvi = lvlAddedSuppliers.Items.Add(newSupplier.Name);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(newSupplier.Description)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(newSupplier.Email)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(newSupplier.PhoneNumber)));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToStringListView(newSupplier.CpfCnpj)));

                if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);

                txtName.Text = String.Empty;
                txtDesc.Text = String.Empty;
                txtEmail.Text = String.Empty;
                txtPhone_number.Text = String.Empty;
                txtCpfCnpj.Text = String.Empty;
            }
            EnableOrDisableFinishButton();
        }

        private void EnableOrDisableFinishButton()
        {
            if (AddedSuppliers.Count() > 0) btnAdd.Enabled = true;
            else btnAdd.Enabled = false;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
            ml.Show();

            int addedCount = AddedSuppliers.Count();
            
            MySqlNonQuery.CreateSuppliers(AddedSuppliers);

            MySqlNonQuery.IncrementUserRegisteredSuppliers(AddedSuppliers.Count);

            foreach (Supplier item in AddedSuppliers)
            {
                int id = Convert.ToInt32(MySqlReader.ReadOnlyOneColumn("supplier", "idsupplier", new string[] { "name", "id_user" }, new string[] { item.Name, GlobalVariables.User.Id.ToString() }, new string[] { "AND" }, new bool[] { false, false }));

                item.Id = id;
            }

            foreach (Supplier item in AddedSuppliers)
            {
                GlobalVariables.Suppliers.Add(item);
            }

            ml.CustomClose();

            Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text.TrimStart();
            name = name.TrimEnd();
            if (name.Length > 3)
            {
                btnCreate.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = false;
            }
        }

        private void lvlAddedSuppliers_DoubleClick(object sender, EventArgs e)
        {
            ListViewIndex = lvlAddedSuppliers.SelectedIndices[0];
            if (ListViewIndex >= 0)
            {
                AddedSuppliers.RemoveAt(ListViewIndex);
                lvlAddedSuppliers.Items.RemoveAt(ListViewIndex);
            }
            ListViewIndex = -1;
            EnableOrDisableFinishButton();
        }
    }
}
