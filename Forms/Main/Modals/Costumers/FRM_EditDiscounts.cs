using System;
using GC.Library.Database;
using System.Windows.Forms;
using GC.Library.Entities;
using GC.Library;

namespace GC.Forms.Main.Modals.Costumers
{
    public partial class FRM_EditDiscounts : Bases.FRM_Default
    {
        int NewDiscountCounter = 0;
        double NewDiscountAccumulated = 0;

        private Costumer costumer = null;

        internal FRM_EditDiscounts(Costumer costumer)
        {
            InitializeComponent();

            this.ReadyForm();

            this.costumer = costumer;

            lblName.Text = this.costumer.Name;

            if(this.costumer.DiscountCounter == -1)
            {
                lblCurrentDiscountCounter.Text += "0";
                nudDiscountCounter.Value = 0;
            }
            else
            {
                lblCurrentDiscountCounter.Text += this.costumer.DiscountCounter;
                nudDiscountCounter.Value = this.costumer.DiscountCounter;
            }
            
            if(this.costumer.DiscountAccumulated == -1)
            {
                lblCurrentDiscountAccumulated.Text += "R$ 0,00";
                nudDiscountAccumulated.Value = 0;
            }
            else
            {
                lblCurrentDiscountAccumulated.Text += "R$ " + this.costumer.DiscountAccumulated.ToString("n2");
                nudDiscountAccumulated.Value = Convert.ToDecimal(this.costumer.DiscountAccumulated);
            }            
        }

        private void NudDiscountCounter_ValueChanged(object sender, EventArgs e)
        {
            if (nudDiscountCounter.Value < 0) nudDiscountCounter.Value = 0;
            this.NewDiscountCounter = Convert.ToInt32(nudDiscountCounter.Value);
        }

        private void NudDiscountAccumulated_ValueChanged_1(object sender, EventArgs e)
        {
            if (nudDiscountAccumulated.Value < 0) nudDiscountAccumulated.Value = 0;
            this.NewDiscountAccumulated = Convert.ToDouble(nudDiscountAccumulated.Value);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
            ml.Show();            

            int index = GlobalVariables.Costumers.IndexOf(this.costumer);

            if(this.NewDiscountCounter == 0)
            {
                GlobalVariables.Costumers[index].DiscountCounter = -1;
            }
            else
            {
                GlobalVariables.Costumers[index].DiscountCounter = this.NewDiscountCounter;
            }

            if(this.NewDiscountAccumulated == 0)
            {
                GlobalVariables.Costumers[index].DiscountAccumulated = -1;
            }
            else
            {
                GlobalVariables.Costumers[index].DiscountAccumulated = this.NewDiscountAccumulated;
            }         
            
            MySqlNonQuery.UpdateCostumerDiscounts(this.costumer);

            ml.CustomClose();

            Close();
        }
    }
}
