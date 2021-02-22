using GC.Library.Translators;
using System;
using GC.Library.Database;
using System.Windows.Forms;
using GC.Library.Entities;
using GC.Library;
using GC.Library.Objects;
using System.Linq;

namespace GC.Forms.Main.Modals.Costumers
{
    public partial class FRM_AlterCostumer : Bases.FRM_Default
    {
        internal bool Alterations = false;

        private Costumer oldCostumer;

        internal FRM_AlterCostumer(Costumer OldCostumer)
        {
            InitializeComponent();

            this.ReadyForm();

            txtName.Text = OldCostumer.Name;
            txtEmail.Text = OldCostumer.Email;
            txtPhoneNumber.Text = OldCostumer.PhoneNumber;
            ckbWhatspp.Checked = OldCostumer.IsPhoneWhatsapp;

            if(OldCostumer.Sex == 'M')
            {
                rbtMan.Checked = true;
            }
            else
            {
                rbtWoman.Checked = true;
            }

            txtStreet.Text = OldCostumer.Street;
            txtNumber.Text = OldCostumer.Number;
            txtComplement.Text = OldCostumer.Complement;
            txtReference.Text = OldCostumer.Reference;
            txtDistrict.Text = OldCostumer.District;
            txtCity.Text = OldCostumer.City;
            txtState.Text = OldCostumer.State;
            txtCountry.Text = OldCostumer.Country;
            txtCep.Text = OldCostumer.Cep;

            this.oldCostumer = OldCostumer;
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
            ml.Show();

            bool hasWord = false;
            string temp = txtPhoneNumber.Text.Trim();
            foreach (char word in temp)
            {
                if (word != '0' && word != '1' && word != '2' && word != '3' && word != '4' && word != '5' && word != '6' && word != '7' && word != '8' && word != '9')
                {
                    hasWord = true;
                }
            }
            if (hasWord || temp.Length < 4 || temp.Length > 15)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Número de telefone/celular inválido! Você deve colocar apenas números e no mínimo 4 números.", 2);
                messOk.Show();

                ml.CustomClose();

                return;
            }

            temp = txtName.Text.TrimStart();
            temp.TrimEnd();
            if (temp.Length < 3)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Nome de cliente muito curto! Ele deve ter no mínimo 3 letras e no máximo 50 letras.", 2);
                messOk.Show();

                ml.CustomClose();

                return;
            }

            temp = txtStreet.Text.TrimStart();
            temp.TrimEnd();
            if (temp.Length < 1)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("O campo endereço não pode ficar vazio! Coloque nele a rua da residência do cliente.", 2);
                messOk.Show();

                ml.CustomClose();

                return;
            }

            temp = txtNumber.Text.TrimStart();
            temp.TrimEnd();
            if (temp.Length < 1)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("O campo Nº não pode ficar vazio! Coloque nele o número da residência do cliente.", 2);
                messOk.Show();

                ml.CustomClose();

                return;
            }

            //Taking the product out from the global list to be updated
            int index = GlobalVariables.Costumers.IndexOf(oldCostumer);
            GlobalVariables.Costumers[index] = null;

            // Handling with the 0 and "". Wich are null values ---------------------------------------------
            string name = FieldsToObject.ToString(txtName.Text);
            string email = FieldsToObject.ToString(txtEmail.Text);
            string phone_number = FieldsToObject.ToString(txtPhoneNumber.Text);
            bool is_phone_whatsapp = ckbWhatspp.Checked;

            char sex = 'M';
            if (rbtWoman.Checked) sex = 'F';

            string street = FieldsToObject.ToString(txtStreet.Text);
            string number = FieldsToObject.ToString(txtNumber.Text);
            string complement = FieldsToObject.ToString(txtComplement.Text);
            string reference = FieldsToObject.ToString(txtReference.Text);
            string district = FieldsToObject.ToString(txtDistrict.Text);
            string city = FieldsToObject.ToString(txtCity.Text);
            string state = FieldsToObject.ToString(txtState.Text);
            string country = FieldsToObject.ToString(txtCountry.Text);
            string cep = FieldsToObject.ToString(txtCep.Text);
            // -------------------------------------------------------------------------------

            Costumer newCostumer = new Costumer(oldCostumer.Id, name, email, phone_number, is_phone_whatsapp, sex, street, number, complement, reference, district, city, state, country, cep, oldCostumer.DiscountCounter, oldCostumer.DiscountAccumulated, oldCostumer.Debt);
            foreach (Costumer item in GlobalVariables.Costumers)
            {
                if (item != null)
                {
                    if (newCostumer.Name == item.Name && newCostumer.PhoneNumber == item.PhoneNumber && newCostumer.Street == item.Street && newCostumer.Number == item.Number)
                    {
                        GlobalVariables.Costumers[index] = oldCostumer;

                        GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Já existe um cliente salvo com o esse mesmo nome, telefone, endereço e número! Por favor, verifique e insira outros.", 1);
                        messOk.Show();

                        ml.CustomClose();

                        return;
                    }
                }
            }

            
            MySqlNonQuery.UpdateCostumer(newCostumer);

            GlobalVariables.Costumers[index] = newCostumer;

            this.Alterations = true;

            ml.CustomClose();

            Close();
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (txtCep.Text.Contains("-"))
            {
                GlobalModals.FRM_MessageAndOK errorMsg = new GlobalModals.FRM_MessageAndOK("Insira apenas números! Sem acentos.", 1);
                errorMsg.Show();

                return;
            }

            foreach (char word in Library.Informations.Chars.WordsLowerCase)
            {
                if (txtCep.Text.ToLower().Contains(word))
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Insira apenas números!", 1);
                    messOk.Show();

                    return;
                }
            }
        }

        private void BTN_SearchCep_Click(object sender, EventArgs e)
        {
            if (txtCep.Text.Length < 8)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("O CEP digitado é muito curto! Por favor, verifique e tente novamente.", 1);
                messOk.Show();

                return;
            }
            else
            {
                Cep cep = new Cep(txtCep.Text);

                if (cep.Logradouro == null)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("O CEP digitado não é válido! Por favor, verifique e tente novamente!", 1);
                    messOk.Show();

                    return;
                }
                else
                {
                    txtStreet.Text = cep.Logradouro;
                    txtComplement.Text = cep.Complemento;
                    txtDistrict.Text = cep.Bairro;
                    txtCity.Text = cep.Localidade;
                    txtState.Text = cep.Uf;
                }
            }
        }

        private void txtCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter) this.BTN_SearchCep_Click(this, new EventArgs());
        }
    }
}
