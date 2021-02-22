using System;

namespace GC.Forms.Main.Modals.Products
{
    public partial class FRM_SearchOptions : Bases.FRM_Default
    {
        public FRM_SearchOptions()
        {
            InitializeComponent();

            this.ReadyForm();

            this.ReplaceCloseByHide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ckbDesc.Checked = true;
            ckbCode.Checked = true;
            ckbPackQuant.Checked = false;
            ckbPos.Checked = false;
            ckbPrice.Checked = false;
            ckbWeight.Checked = false;
        }
    }
}
