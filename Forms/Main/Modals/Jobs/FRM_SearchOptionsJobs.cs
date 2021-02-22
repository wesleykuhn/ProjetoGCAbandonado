using System;

namespace GC.Forms.Main.Modals.Jobs
{
    public partial class FRM_SearchOptionsJobs : Bases.FRM_Default
    {
        public FRM_SearchOptionsJobs()
        {
            InitializeComponent();

            this.ReadyForm();

            this.ReplaceCloseByHide();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ckbName.Checked = true;
            ckbDesc.Checked = true;
            ckbPrice.Checked = true;
        }
    }
}
