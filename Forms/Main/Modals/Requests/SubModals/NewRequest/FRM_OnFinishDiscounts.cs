using System;
using System.Linq;
using System.Windows.Forms;
using GC.Library;
using GC.Library.Database;
using GC.Library.Entities;
using GC.Library.Objects;
using GC.Library.Translators;

namespace GC.Forms.Main.Modals.Requests.SubModals.NewRequest
{
    public partial class FRM_OnFinishDiscounts : Bases.FRM_Default
    {
        internal string Occurrences = "";
        int NewCounter, OldCounter;
        double NewAccumulated, OldAccumulated, RequestValue;

        Costumer Costumer;

        internal FRM_OnFinishDiscounts(int OldCounter, double OldAccumulated, double RequestValue, Costumer costumer)
        {
            InitializeComponent();

            this.ReadyForm();

            lblActualCounter.Text += ObjectToDetailLabel.ToIntLabel(OldCounter);
            lblActualAccumulated.Text += ObjectToDetailLabel.ToMoneyLabel(OldAccumulated);
            lblActualCounter.Left = (pnlCounterBack.Width - lblActualCounter.Width) / 2;
            lblActualAccumulated.Left = (pnlAccumulatedBack.Width - lblActualAccumulated.Width) / 2;

            lblNewCounter.Text += ObjectToDetailLabel.ToIntLabel(OldCounter);
            lblNewAccumulated.Text += ObjectToDetailLabel.ToMoneyLabel(OldAccumulated);
            lblNewCounter.Left = (pnlCounterBack.Width - lblNewCounter.Width) / 2;
            lblNewAccumulated.Left = (pnlAccumulatedBack.Width - lblNewAccumulated.Width) / 2;

            if(OldCounter == -1)
            {
                this.OldCounter = 0;
                this.NewCounter = 0;
            }
            else
            {
                this.OldCounter = OldCounter;
                this.NewCounter = OldCounter;
            }

            if(OldAccumulated == -1)
            {
                this.OldAccumulated = 0;
                this.NewAccumulated = 0;
            }
            else
            {
                this.OldAccumulated = OldAccumulated;
                this.NewAccumulated = OldAccumulated;
            }           
            
            this.RequestValue = RequestValue;
            this.Costumer = costumer;
        }

        private void UpdateNewCounter()
        {
            lblNewCounter.Text = "Novo compras/pedidos anotados:  " + this.NewCounter.ToString();
            lblNewCounter.Left = (pnlCounterBack.Width - lblNewCounter.Width) / 2;
        }

        private void UpdateNewAccumulated()
        {
            lblNewAccumulated.Text = "Novo desconto acumulado: " + ObjectToDetailLabel.ToMoneyLabel(this.NewAccumulated);
            lblNewAccumulated.Left = (pnlAccumulatedBack.Width - lblNewAccumulated.Width) / 2;
        }

        private void cbxCounter_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCounter.Checked)
            {                
                rbtCounterIncrease.Enabled = true;
                rbtCounterDecrease.Enabled = true;
                rbtCounterReset.Enabled = true;
            }
            else
            {
                if (rbtCounterIncrease.Checked) rbtCounterIncrease.Checked  = false;
                if (rbtCounterDecrease.Checked) rbtCounterDecrease.Checked = false;
                if (rbtCounterReset.Checked) rbtCounterReset.Checked = false;

                rbtCounterIncrease.Enabled = false;
                rbtCounterDecrease.Enabled = false;
                rbtCounterReset.Enabled = false;

                this.NewCounter = this.OldCounter;
                UpdateNewCounter();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAccumulated.Checked)
            {
                rbtAccumulatedManual.Enabled = true;
                rbtAccumulatedPercent.Enabled = true;
                rbtAccumulatedReset.Enabled = true;
            }
            else
            {
                if (rbtAccumulatedManual.Checked) rbtAccumulatedManual.Checked = false;
                if (rbtAccumulatedPercent.Checked) rbtAccumulatedPercent.Checked = false;
                if (rbtAccumulatedReset.Checked) rbtAccumulatedReset.Checked = false;

                rbtAccumulatedManual.Enabled = false;
                rbtAccumulatedPercent.Enabled = false;
                rbtAccumulatedReset.Enabled = false;
            }
        }

        private void rbtAccumulatedManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAccumulatedManual.Checked)
            {
                nudAccumulatedManual.Enabled = true;
                nudAccumulatedManual.Value = Convert.ToDecimal(1);
                this.NewAccumulated = this.OldAccumulated + Convert.ToDouble(nudAccumulatedManual.Value);
                UpdateNewAccumulated();
            }
            else
            {
                this.NewAccumulated = this.OldAccumulated;
                nudAccumulatedManual.Enabled = false;
                UpdateNewAccumulated();
            }
        }

        private void nudAccumulatedManual_ValueChanged(object sender, EventArgs e)
        {
            this.NewAccumulated = this.OldAccumulated + Convert.ToDouble(nudAccumulatedManual.Value);
            UpdateNewAccumulated();
        }

        private void rbtAccumulatedPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAccumulatedPercent.Checked)
            {
                nudAccumulatedPercent.Enabled = true;
                nudAccumulatedPercent.Value = Convert.ToDecimal(1);
                double percent = Convert.ToDouble(nudAccumulatedPercent.Value);
                this.NewAccumulated = this.OldAccumulated + (percent * this.RequestValue / 100);
                UpdateNewAccumulated();
            }
            else
            {
                this.NewAccumulated = this.OldAccumulated;
                nudAccumulatedPercent.Enabled = false;
                UpdateNewAccumulated();
            }
        }

        private void nudAccumulatedPercent_ValueChanged(object sender, EventArgs e)
        {
            double percent = Convert.ToDouble(nudAccumulatedPercent.Value);
            this.NewAccumulated = this.OldAccumulated + (percent * this.RequestValue / 100);
            UpdateNewAccumulated();
        }

        private void rbtAccumulatedReset_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAccumulatedReset.Checked)
            {
                this.NewAccumulated = 0;
                UpdateNewAccumulated();
            }
            else
            {
                this.NewAccumulated = this.OldAccumulated;
                UpdateNewAccumulated();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string Occurrences = "";
            bool useJump = false;
            if (this.OldAccumulated != this.NewAccumulated)
            {
                if (this.NewAccumulated > 0)
                {
                    double diference = 0;
                    if (this.OldAccumulated > this.NewAccumulated)
                    {
                        diference = this.OldAccumulated - this.NewAccumulated;
                    }
                    else
                    {
                        diference = this.NewAccumulated - this.OldAccumulated;
                    }
                    Occurrences += "-Foi adicionado um desconto acumulado" +
                        " de " + ObjectToDetailLabel.ToMoneyLabel(diference) + " para o cliente " +
                        "deste pedido na data " + DateTime.Now.ToString("dd/MM/yyyy") + " às " +
                        "" + DateTime.Now.ToString("HH:mm:ss") + ". " +
                        "Novo desconto acumulado do cliente: " + ObjectToDetailLabel.ToMoneyLabel(this.NewAccumulated) + ".";
                }
                else
                {
                    Occurrences += "O desconto acumulado do cliente deste pedido foi zerado na data " +
                        "" + DateTime.Now.ToString("dd/MM/yyyy") + " às " + DateTime.Now.ToString("HH:mm:ss") + ".";
                }
                useJump = true;
            }
            if (this.OldCounter != this.NewCounter)
            {
                if (useJump)
                {
                    Occurrences += "\n\n";
                }

                if (this.NewCounter > this.OldCounter)
                {
                    Occurrences += "-O contador de desconto do cliente deste pedido foi " +
                        "aumentado em 1 em " + DateTime.Now.ToString("dd/MM/yyyy") + " às " +
                        "" + DateTime.Now.ToString("HH:mm:ss") + ". Nova contagem: " + this.NewCounter.ToString() + ".";
                }
                else if (this.NewCounter == 0)
                {
                    Occurrences += "-O contador de desconto do cliente deste pedido foi " +
                        "zerado em " + DateTime.Now.ToString("dd/MM/yyyy") + " às " +
                        "" + DateTime.Now.ToString("HH:mm:ss") + ".";
                }
                else
                {
                    Occurrences += "-O contador de desconto do cliente deste pedido foi " +
                        "diminuído em 1 em " + DateTime.Now.ToString("dd/MM/yyyy") + " às " +
                        "" + DateTime.Now.ToString("HH:mm:ss") + ". Nova contagem: " + this.NewCounter.ToString() + ".";
                }
            }

            this.Costumer.DiscountCounter = this.NewCounter;
            this.Costumer.DiscountAccumulated = this.NewAccumulated;

            
            MySqlNonQuery.UpdateCostumerDiscounts(this.Costumer);

            var filtered = GlobalVariables.Costumers.Where(x => x.Id == this.Costumer.Id).Select(x => x);
            foreach (Costumer item in filtered)
            {
                int index = GlobalVariables.Costumers.IndexOf(item);
                GlobalVariables.Costumers[index].DiscountAccumulated = this.NewCounter;
                GlobalVariables.Costumers[index].DiscountAccumulated = this.NewAccumulated;
            }

            this.Occurrences = Occurrences;

            this.Close();
        }

        private void rbtCounterIncrease_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCounterIncrease.Checked)
            {
                this.NewCounter++;
                UpdateNewCounter();
            }
            else
            {
                this.NewCounter = this.OldCounter;
            }
        }

        private void rbtCounterDecrease_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCounterDecrease.Checked)
            {
                if(this.OldCounter == 0)
                {
                    this.NewCounter = this.OldCounter;
                }
                else
                {
                    this.NewCounter--;
                }
                
                UpdateNewCounter();
            }
            else
            {
                this.NewCounter = this.OldCounter;
            }            
        }

        private void rbtCounterReset_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCounterReset.Checked)
            {
                this.NewCounter = 0;
                UpdateNewCounter();
            }
            else
            {
                this.NewCounter = this.OldCounter;
            }
        }
    }
}
