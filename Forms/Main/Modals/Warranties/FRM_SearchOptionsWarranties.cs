using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GC.Forms.Main.Modals.Warranties
{
    public partial class FRM_SearchOptionsWarranties : Bases.FRM_Default
    {
        public FRM_SearchOptionsWarranties()
        {
            InitializeComponent();

            this.ReadyForm();

            this.ReplaceCloseByHide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ckbNumber.Checked = true;
            ckbCostumer.Checked = true;
            rbtTypeAll.Checked = true;
            ckbStartedIn.Checked = false;
            ckbExpiresIn.Checked = true;
        }
    }
}
