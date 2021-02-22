using GC.Library;
using GC.Library.Checkers;
using GC.Library.Objects;
using GC.Library.Objects.SubObjects.Product;
using GC.Library.Translators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GC.Forms.Main.Modals.Products
{
    public partial class FRM_EditLot : Bases.FRM_Default
    {
        internal Lot Lot;

        internal FRM_EditLot(Lot lot)
        {
            InitializeComponent();

            this.ReadyForm();

            this.ReplaceCloseEvent(new EventHandler(CloseForm));

            txtNumber.Text = ObjectToListView.ToStringListView(lot.Number);

            if (!Structs.IsDateTimeNull(lot.ExpiresIn))
            {
                cbxExpiresIn.Checked = true;
                dtpExpiresIn.Value = lot.ExpiresIn;
            }            

            if ((lot.Quantity % 1) != 0)
            {
                rbtWeight.Checked = true;
            }
            nudValue.Value = Convert.ToDecimal(lot.Quantity);

            this.Lot = lot;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Lot = null;

            this.Close();
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
            if (FieldsToObject.ToString(txtNumber.Text) == null && cbxExpiresIn.Checked)
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Você não pode colocar uma data de validade num lote sem identificação! Por favor, insira um código, ou desmaque o campo 'Tem data de validade' ou então cancele a edição deste lote.", 1);
                messOk.Show();
                return;
            }

            bool useExpirationDate = false;

            int counter = GlobalVariables.Lots.Count(x => x.Id_Product == this.Lot.Id_Product);            
            if(counter > 1)
            {
                List<Lot> otherLots = GlobalVariables.Lots.Where(x => x.Id_Product == this.Lot.Id_Product).Select(x => x).ToList();
                foreach (Lot item in otherLots)
                {
                    if (!Structs.IsDateTimeNull(item.ExpiresIn))
                    {
                        useExpirationDate = true;
                    }
                }

                if (useExpirationDate && !cbxExpiresIn.Checked)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Você tem outros lotes, do mesmo produto que este lote o qual você está editando, que tem data de validade! Você não poderá deixar este lote sem data de validade. Caso queira mudar, você deverá excluir todos os lotes e começar a adicionar os novos lotes sem data de validade.", 1);
                    messOk.Show();
                    return;
                }
                if (!useExpirationDate && cbxExpiresIn.Checked)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Você tem outros lotes, do mesmo produto que este lote o qual você está editando, que não tem data de validade! Você não poderá colocar uma data de validade neste lote. Caso queira mudar, você deverá excluir todos os lotes e começar a adicionar os novos lotes com data de validade.", 1);
                    messOk.Show();
                    return;
                }
            }            

            if(cbxExpiresIn.Checked)
            {
                this.Lot = new Lot(this.Lot.Id, FieldsToObject.ToString(txtNumber.Text), Convert.ToDouble(nudValue.Value), this.Lot.Entry, dtpExpiresIn.Value, this.Lot.Id_Product);
            }
            else
            {
                this.Lot = new Lot(this.Lot.Id, FieldsToObject.ToString(txtNumber.Text), Convert.ToDouble(nudValue.Value), this.Lot.Entry, new DateTime(1, 1, 1, 0, 0, 0), this.Lot.Id_Product);
            }            

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
