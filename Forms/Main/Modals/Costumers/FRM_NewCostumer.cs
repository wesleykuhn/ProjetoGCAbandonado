using GC.Library;
using GC.Library.Database;
using GC.Library.Entities;
using GC.Library.Objects;
using GC.Library.Translators;
using GC.Library.Web;
using Renci.SshNet.Security;
using System;
using System.Linq;

namespace GC.Forms.Main.Modals.Costumers
{
    public partial class FRM_NewCostumer : Bases.FRM_Default
    {
        public FRM_NewCostumer()
        {
            InitializeComponent();

            this.ReadyForm();
        }

        private void btnFinish_Click(object sender, EventArgs e)
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
            if(temp.Length < 3)
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

            bool success = true;

            // Handling with the 0 and "". Wich are null values ---------------------------------------------
            string name = FieldsToObject.ToString(txtName.Text);
            string email = FieldsToObject.ToString(txtEmail.Text);
            string phone_number = FieldsToObject.ToString(txtPhoneNumber.Text);
            bool is_phone_whastapp = ckbWhatspp.Checked;
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

            Costumer newCostumer = new Costumer(0, name, email, phone_number, is_phone_whastapp, sex, street, number, complement, reference, district, city, state, country, cep, 0, 0, 0);

            foreach (Costumer item in GlobalVariables.Costumers)
            {
                if (newCostumer.IsEqualTo(item))
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Já existe um cliente salvo com o esse mesmo nome, sexo, telefone e endereço! Por favor, verifique e insira outros.", 1);
                    messOk.Show();

                    success = false;

                    ml.CustomClose();

                    break;
                }
            }

            if (success)
            {
                
                MySqlNonQuery.CreateCostumer(newCostumer);

                MySqlNonQuery.IncrementUserRegisteredCostumers(1);

                int id = Convert.ToInt32(MySqlReader.ReadOnlyOneColumn("costumer", "idcostumer", new string[] { "name", "phone_number", "street", "number", "id_user" }, new string[] { newCostumer.Name, newCostumer.PhoneNumber, newCostumer.Street, newCostumer.Number, GlobalVariables.User.Id.ToString() }, new string[] { "AND", "AND", "AND", "AND" }, new bool[] { false, false, false, false, false }));

                newCostumer.Id = id;

                GlobalVariables.Costumers.Add(newCostumer);

                ml.CustomClose();

                Close();
            }            
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
            if(txtCep.Text.Length < 8)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("O CEP digitado é muito curto! Por favor, verifique e tente novamente.", 1);
                messOk.Show();

                return;
            }
            else
            {
                Cep cep = new Cep(txtCep.Text);
                
                if(cep.Logradouro == null)
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

        private void txtCep_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter) this.BTN_SearchCep_Click(this, new EventArgs());
        }
    }
}
