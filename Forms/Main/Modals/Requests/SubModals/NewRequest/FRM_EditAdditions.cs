using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GC.Forms.Main.Modals.Requests.SubModals.NewRequest
{
    public partial class FRM_EditAdditions : Bases.FRM_Default
    {
        internal List<double> Values = new List<double>();
        internal List<double> Percents = new List<double>();        

        public FRM_EditAdditions(List<double> values, List<double> percents)
        {
            InitializeComponent();

            this.ReadyForm();

            if (values.Count > 0)
            {
                foreach (double item in values)
                {
                    ListViewItem lvi = lvlValues.Items.Add(item.ToString("n2"));
                }
            }
            if(percents.Count > 0)
            {
                foreach (double item in percents)
                {
                    ListViewItem lvi = lvlPercents.Items.Add(item.ToString());
                }
            }

            this.Percents = percents;
            this.Values = values;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (nudValue.Value == 0) return;

            if (rbtValue.Checked)
            {
                double aux = Convert.ToDouble(nudValue.Value);
                this.Values.Add(aux);
                ListViewItem lvi = lvlValues.Items.Add(aux.ToString("n2"));
            }
            else
            {
                double aux = Convert.ToDouble(nudValue.Value);
                this.Percents.Add(aux);
                ListViewItem lvi = lvlPercents.Items.Add(aux.ToString());
            }
        }

        private void LvlValues_DoubleClick(object sender, EventArgs e)
        {
            if (lvlValues.SelectedItems.Count == 0) return;

            this.Values.Remove(Double.Parse(lvlValues.Items[lvlValues.SelectedIndices[0]].Text));

            lvlValues.Items.Clear();
            foreach (double item in this.Values)
            {
                ListViewItem lvi = lvlValues.Items.Add(item.ToString("n2"));
            }
        }

        private void LvlPercents_DoubleClick(object sender, EventArgs e)
        {
            if (lvlPercents.SelectedItems.Count == 0) return;

            this.Percents.Remove(Double.Parse(lvlPercents.Items[lvlPercents.SelectedIndices[0]].Text));

            lvlPercents.Items.Clear();
            foreach (double item in this.Percents)
            {
                ListViewItem lvi = lvlPercents.Items.Add(item.ToString());
            }
        }

        private void NudValue_ValueChanged(object sender, EventArgs e)
        {
            if(nudValue.Value == 0)
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void RbtValue_CheckedChanged(object sender, EventArgs e)
        {
            lblNudAux.Text = "R$";

            nudValue.DecimalPlaces = 2;
        }

        private void RbtPercent_CheckedChanged(object sender, EventArgs e)
        {
            lblNudAux.Text = "%";

            nudValue.DecimalPlaces = 5;
        }
    }
}
