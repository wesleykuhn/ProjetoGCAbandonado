using System;

namespace GC.Forms.Main.Modals.Costumers
{
    public partial class FRM_SearchOptionsCostumers : Bases.FRM_Default
    {
        public FRM_SearchOptionsCostumers()
        {
            InitializeComponent();

            this.ReadyForm();

            this.ReplaceCloseByHide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ckbName.Checked = true;
            ckbEmail.Checked = true;
            ckbPhoneNumber.Checked = true;
            ckbAddress.Checked = true;
            ckbCep.Checked = true;

            ckbState.Checked = false;
            ckbSex.Checked = false;
            ckbReference.Checked = false;
            ckbDistrict.Checked = false;
            ckbCountry.Checked = false;
            ckbComplement.Checked = false;
            ckbCity.Checked = false;
        }
    }
}
