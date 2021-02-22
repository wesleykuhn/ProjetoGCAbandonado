using System;

namespace GC.Forms.Main.Modals.Suppliers
{
    public partial class FRM_SearchOptionsSuppliers : Bases.FRM_Default
    {
        public FRM_SearchOptionsSuppliers()
        {
            InitializeComponent();

            this.ReadyForm();

            this.ReplaceCloseByHide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ckbName.Checked = true;
            ckbDesc.Checked = true;
            ckbEmail.Checked = true;
            ckbPhone_number.Checked = true;
            ckbCpfCnpj.Checked = false;
        }
    }
}
