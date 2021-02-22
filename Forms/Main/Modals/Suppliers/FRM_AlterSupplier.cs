using System;
using GC.Library.Translators;
using GC.Library.Database;
using GC.Library.Objects.SubObjects.Product;
using GC.Library;

namespace GC.Forms.Main.Modals.Suppliers
{
    public partial class FRM_AlterSupplier : Bases.FRM_Default
    {
        internal bool Alterations = false;

        private Supplier oldSupplier;

        internal FRM_AlterSupplier(Supplier OldSupplier)
        {
            InitializeComponent();

            this.ReadyForm();

            txtName.Text = OldSupplier.Name;
            txtDesc.Text = ObjectToListView.ToStringListView(OldSupplier.Description);
            txtEmail.Text = ObjectToListView.ToStringListView(OldSupplier.Email);
            txtPhone_number.Text = ObjectToListView.ToStringListView(OldSupplier.PhoneNumber);
            txtCpfCnpj.Text = ObjectToListView.ToStringListView(OldSupplier.CpfCnpj);
            this.oldSupplier = OldSupplier;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
            ml.Show();

            bool hasWord = false;
            string temp = txtPhone_number.Text.Trim();
            foreach (char word in temp)
            {
                if (word != '0' && word != '1' && word != '2' && word != '3' && word != '4' && word != '5' && word != '6' && word != '7' && word != '8' && word != '9')
                {
                    hasWord = true;
                }
            }
            if (hasWord || temp.Length > 15)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Número de telefone/celular inválido! Você deve colocar todos os 10 ou 11 números do telefone ou celular. Ex: 1934343434 ou 19912345678.", 2);
                messOk.Show();

                ml.CustomClose();

                return;
            }

            //Taking the supplier out from the global list to be updated
            int index = GlobalVariables.Suppliers.IndexOf(oldSupplier);
            GlobalVariables.Suppliers[index] = null;

            // Handling with the 0 and "". Wich are null values ---------------------------------------------
            string aux = txtName.Text.TrimStart();
            aux = aux.TrimEnd();
            string name = aux;

            aux = txtDesc.Text.TrimStart();
            aux = aux.TrimEnd();
            string description = aux;

            aux = txtEmail.Text.TrimStart();
            aux = aux.TrimEnd();
            string email = FieldsToObject.ToString(aux);

            aux = txtPhone_number.Text.TrimStart();
            aux = aux.TrimEnd();
            string phone_number = FieldsToObject.ToString(aux);

            aux = txtCpfCnpj.Text.TrimStart();
            aux = aux.TrimEnd();
            string cpf_cnpj = FieldsToObject.ToString(aux);
            // -------------------------------------------------------------------------------

            Supplier newSupplier = new Supplier(oldSupplier.Id, name, description, email, phone_number, cpf_cnpj);            
            foreach (Supplier item in GlobalVariables.Suppliers)
            {
                if(item != null)
                {
                    if (newSupplier.Name == item.Name)
                    {
                        GlobalVariables.Suppliers[index] = oldSupplier;

                        GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Já existe um fornecedor salvo com o esse mesmo nome! Por favor, verifique e insira outro.", 1);
                        messOk.Show();

                        ml.CustomClose();

                        return;
                    }
                }                
            }

            
            MySqlNonQuery.UpdateSupplier(newSupplier);

            GlobalVariables.Suppliers[index] = newSupplier;

            this.Alterations = true;

            ml.CustomClose();

            Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text.TrimStart();
            name = name.TrimEnd();
            if (name.Length < 3) btnAlter.Enabled = false;
            else btnAlter.Enabled = true;
        }
    }
}
