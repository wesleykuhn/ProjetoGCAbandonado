using GC.Library.Objects;
using System;
using System.Windows.Forms;
using GC.Library.Translators;
using GC.Library.Database;
using System.Linq;
using System.Collections.Generic;
using GC.Library.Objects.SubObjects.Product;
using GC.Library;
using GC.Library.Checkers;

namespace GC.Forms.Main.Modals.Products
{
    public partial class FRM_AddLot : Bases.FRM_Default
    {
        internal Lot Lot;
        Product Product;

        internal bool Empty = true;

        internal FRM_AddLot(Product Product)
        {
            InitializeComponent();

            this.ReadyForm();

            this.Product = Product;
        }

        private void RbtUnit_CheckedChanged(object sender, EventArgs e)
        {
            nudValue.DecimalPlaces = 0;
            nudValue.Value = 1;
            lblType.Text = "Unid.";
        }

        private void RbtWeight_CheckedChanged(object sender, EventArgs e)
        {
            nudValue.DecimalPlaces = 3;
            nudValue.Value = 1;
            lblType.Text = "kg.";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(FieldsToObject.ToString(txtNumber.Text) == null && cbxExpiresIn.Checked)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Você não pode colocar uma data de validade num Lote sem identificação! Por favor, insira um código, ou desmaque o campo 'Tem data de validade' ou então cancele a criação deste Lote.", 1);
                messOk.Show();
                return;
            }

            bool useExpirationDate = false;

            int counter = GlobalVariables.Lots.Count(x => x.Id_Product == this.Product.Id);
            if (counter > 0)
            {
                List<Lot> otherLots = GlobalVariables.Lots.Where(x => x.Id_Product == this.Product.Id).Select(x => x).ToList();
                foreach (Lot item in otherLots)
                {
                    if (!Structs.IsDateTimeNull(item.ExpiresIn))
                    {
                        useExpirationDate = true;
                    }
                }

                if (useExpirationDate && !cbxExpiresIn.Checked)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Você tem outros Lotes, do mesmo produto que este Lote o qual você está criado, que tem data de validade! Você não poderá deixar este novo Lote sem data de validade. Caso queira mudar, você deverá excluir todos os outros Lotes e começar a adicionar os novos Lotes sem data de validade.", 1);
                    messOk.Show();
                    return;
                }
                if (!useExpirationDate && cbxExpiresIn.Checked)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Você tem outros Lotes, do mesmo produto que este Lote o qual você está criado, que não tem data de validade! Você não poderá colocar uma data de validade neste novo Lote. Caso queira mudar, você deverá excluir todos os outros Lotes e começar a adicionar os novos Lotes com data de validade.", 1);
                    messOk.Show();
                    return;
                }
            }            

            if (cbxExpiresIn.Checked)
            {
                this.Lot = new Lot(-1, FieldsToObject.ToString(txtNumber.Text), Convert.ToDouble(nudValue.Value), DateTime.Now, dtpExpiresIn.Value, this.Product.Id);
            }
            else
            {
                this.Lot = new Lot(-1, FieldsToObject.ToString(txtNumber.Text), Convert.ToDouble(nudValue.Value), DateTime.Now, new DateTime(1, 1, 1, 0, 0, 0), this.Product.Id);
            }

            //Due the C# Datetime format is different of the MySql's DateTime format, I made this fix
            string dateFix = this.Lot.Entry.ToString("yyyy/MM/dd HH:mm:ss");
            this.Lot.Entry = SqlToObject.ToDateTime(dateFix);
            dateFix = this.Lot.ExpiresIn.ToString("yyyy/MM/dd HH:mm:ss");
            this.Lot.ExpiresIn = SqlToObject.ToDateTime(dateFix);
            //---------------------------------------------------------------------------------------

            
            this.Lot.Id = MySqlNonQuery.CreateLot(this.Lot);

            this.Empty = false;

            GlobalVariables.Lots.Add(this.Lot);            

            this.Close();
        }

        private void CbxExpiresIn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxExpiresIn.Checked)
            {
                dtpExpiresIn.Enabled = true;
            }
            else
            {
                dtpExpiresIn.Enabled = false;
            }
        }
    }
}
