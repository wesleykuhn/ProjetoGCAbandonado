using System;

namespace GC.Forms.Main.Modals.Requests
{
    public partial class FRM_SearchOptionsRequest : Bases.FRM_Default
    {
        public FRM_SearchOptionsRequest()
        {
            InitializeComponent();

            this.ReadyForm();

            this.ReplaceCloseByHide();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ckbNumber.Checked = true;
            ckbStart.Checked = false;
            ckbValue.Checked = false;
            ckbCostumer.Checked = true;
            ckbExpire.Checked = true;
            ckbObservations.Checked = true;
            cbkIsDelivery.Checked = false;
        }
    }
}
