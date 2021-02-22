using System;
using System.Drawing;
using GC.Library.Database;
using GC.Library.Entities;
using GC.Library;

namespace GC.Forms.Main.Modals.Costumers
{
    public partial class FRM_EditDebt : Bases.FRM_Default
    {
        double EditedDebt = 1;

        private Costumer costumer = null;

        internal FRM_EditDebt(Costumer costumer)
        {
            InitializeComponent();

            this.ReadyForm();

            lblName.Text = costumer.Name;
            lblSignal.ForeColor = Color.FromName("DarkGreen");
            nudEditedDebt.BackColor = Color.FromArgb(153, 255, 153);

            if (costumer.Debt == -1)
            {
                lblCurrentDebt.Text += "R$ 0,00";
            }
            else
            {
                lblCurrentDebt.Font = new Font(lblCurrentDebt.Font, FontStyle.Bold);
                lblCurrentDebt.ForeColor = Color.Crimson;
                lblCurrentDebt.Text += "R$ " + costumer.Debt.ToString("n2");
            }

            this.costumer = costumer;
        }

        private void UpdateStats()
        {
            if(this.EditedDebt <= 0)
            {
                this.EditedDebt = 0.05;
            }
            nudEditedDebt.Value = Convert.ToDecimal(this.EditedDebt);
        }

        private void RbtUp_CheckedChanged(object sender, EventArgs e)
        {
            lblSignal.Text = "+";
            lblSignal.ForeColor = Color.FromName("DarkGreen");
            nudEditedDebt.BackColor = Color.FromArgb(153, 255, 153);
        }

        private void RbtDown_CheckedChanged(object sender, EventArgs e)
        {
            lblSignal.Text = "-";
            lblSignal.ForeColor = Color.FromName("DarkRed");
            nudEditedDebt.BackColor = Color.FromArgb(255, 102, 102);
        }

        private void BtnP10_Click(object sender, EventArgs e)
        {
            this.EditedDebt += 1;
            UpdateStats();
        }

        private void BtnP100_Click(object sender, EventArgs e)
        {
            this.EditedDebt += 10;
            UpdateStats();
        }

        private void BtnP1000_Click(object sender, EventArgs e)
        {
            this.EditedDebt += 100;
            UpdateStats();
        }

        private void BtnP0_05_Click(object sender, EventArgs e)
        {
            this.EditedDebt += 0.05;
            UpdateStats();
        }

        private void BtnP0_10_Click(object sender, EventArgs e)
        {
            this.EditedDebt += 0.10;
            UpdateStats();
        }

        private void BtnM10_Click(object sender, EventArgs e)
        {
            this.EditedDebt -= 1;
            UpdateStats();
        }

        private void BtnM100_Click(object sender, EventArgs e)
        {
            this.EditedDebt -= 10;
            UpdateStats();
        }

        private void BtnM1000_Click(object sender, EventArgs e)
        {
            this.EditedDebt -= 100;
            UpdateStats();
        }

        private void BtnM0_05_Click(object sender, EventArgs e)
        {
            this.EditedDebt -= 0.05;
            UpdateStats();
        }

        private void BtnM0_10_Click(object sender, EventArgs e)
        {
            this.EditedDebt -= 0.10;
            UpdateStats();
        }

        private void BtnMakeZero_Click(object sender, EventArgs e)
        {
            int rounded = (int)Math.Floor(Convert.ToDecimal(this.EditedDebt));
            if ((this.EditedDebt - rounded) <= 0) this.EditedDebt = 0.05;
            else this.EditedDebt -= rounded;
            UpdateStats();
        }

        private void NudEditedDebt_ValueChanged(object sender, EventArgs e)
        {
            this.EditedDebt = Convert.ToDouble(nudEditedDebt.Value);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if ((rbtDown.Checked && this.EditedDebt > this.costumer.Debt && this.costumer.Debt == -1) ||
                (rbtDown.Checked && this.EditedDebt > this.costumer.Debt && this.costumer.Debt == 0))
            {
                GlobalModals.FRM_MessageAndOK.BuildAndShow("Você não pode retirar algo que não existe! O cliente não está devendo.", 1);

                return;
            }
            else if (rbtDown.Checked && this.EditedDebt > this.costumer.Debt)
            {
                GlobalModals.FRM_MessageAndOK.BuildAndShow("Você não pode retirar mais do que o cliente está devendo! Se ele está devendo " + Library.Translators.ObjectToDetailLabel.ToMoneyLabel(this.costumer.Debt) + " então você pode retirar no máximo " + Library.Translators.ObjectToDetailLabel.ToMoneyLabel(this.costumer.Debt) + ".", 1);

                return;
            }

            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
            ml.Show();

            double actualDebt = costumer.Debt, finalDebt = 0;
            if(actualDebt == -1)
            {
                actualDebt = 0;
            }

            if (rbtDown.Checked)
            {
                finalDebt = actualDebt - this.EditedDebt;
            }
            else
            {
                finalDebt = actualDebt + this.EditedDebt;
            }

            if (finalDebt < 0) finalDebt = 0;

            

            if (finalDebt == 0) finalDebt = -1;

            int index = GlobalVariables.Costumers.IndexOf(costumer);
            GlobalVariables.Costumers[index].Debt = finalDebt;

            costumer.Debt = finalDebt;
            MySqlNonQuery.UpdateCostumerDebt(costumer);

            ml.CustomClose();

            Close();
        }
    }
}
