using GC.Library.Database;
using GC.Library.Objects;
using GC.Library.Translators;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using GC.Library;
using GC.Library.Objects.SubObjects.Product;
using GC.Library.Checkers;

namespace GC.Forms.Main.Modals.Products
{
    public partial class FRM_EditStock : Bases.FRM_Default
    {
        Product Product; 

        internal FRM_EditStock(Product product)
        {
            InitializeComponent();

            this.ReadyForm();

            lblCode.Text += product.Code;
            lblDesc.Text += product.Description;              

            lblCode.Left = (pnlDetailsBack.Width - lblCode.Width) / 2;
            lblDesc.Left = (pnlDetailsBack.Width - lblDesc.Width) / 2;            

            this.Product = product;

            UpdateUI();          
        }

        private void UpdateUI()
        {
            lvlLots.Items.Clear();

            double stock = 0;
            stock = GlobalVariables.Lots.Where(x => x.Id_Product == this.Product.Id).Sum(x => x.Quantity);
            lblStock.Text = "Quantidade no estoque: " + ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals(stock);
            if (Variables.IsValueDouble(stock))
            {
                lblStock.Text += " kg";
            }
            else
            {
                lblStock.Text += " Unidades";
            }

            lblStock.Left = (pnlDetailsBack.Width - lblStock.Width) / 2;

            List<Lot> filtered = GlobalVariables.Lots.Where(x => x.Id_Product == this.Product.Id).Select(x => x).ToList();

            bool hasExpiration = false;
            foreach (Lot item2 in filtered)
            {
                if (!Structs.IsDateTimeNull(item2.ExpiresIn))
                {
                    hasExpiration = true;
                }
                break;
            }

            if (hasExpiration)
            {
                filtered.Sort((x, y) => DateTime.Compare(x.ExpiresIn, y.ExpiresIn));
            }
            else
            {
                filtered.Sort((x, y) => DateTime.Compare(x.Entry, y.Entry));
            }

            foreach (var item in filtered)
            {
                ListViewItem lvi;

                if (item.Number == null || item.Number == "")
                {
                    lvi = lvlLots.Items.Add("Sem identificação");
                }
                else
                {
                    lvi = lvlLots.Items.Add(item.Number);
                }

                lvi.SubItems.Add(ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals(item.Quantity));
                lvi.SubItems.Add(ObjectToListView.ToDateTimeListView(item.Entry));
                if (Structs.IsDateTimeNull(item.ExpiresIn))
                {
                    lvi.SubItems.Add("Sem validade");
                }
                else
                {
                    lvi.SubItems.Add(ObjectToListView.ToDateTimeListView(item.ExpiresIn));
                }                
            }
        }

        private void LvlLots_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvlLots.SelectedItems.Count > 0)
            {
                btnDelete.Enabled = true;
                btnAlter.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnAlter.Enabled = false;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(lvlLots.SelectedItems.Count > 0)
            {
                GlobalModals.FRM_Confirmation conf = new GlobalModals.FRM_Confirmation("Este lote será excluído permanentemente! Deseja realmente continuar?", 1);
                conf.Show();
                if (conf.Result == false) return;

                string number = null;
                if (lvlLots.Items[lvlLots.SelectedIndices[0]].Text != "Sem identificação")
                {
                    number = ListViewToObject.ToString(lvlLots.Items[lvlLots.SelectedIndices[0]].Text);
                }
                
                double quantity = ListViewToObject.ToDouble(lvlLots.Items[lvlLots.SelectedIndices[0]].SubItems[1].Text);
                DateTime entry = DateTime.ParseExact(lvlLots.Items[lvlLots.SelectedIndices[0]].SubItems[2].Text, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                
                int id = Lot.GetLotId(number, quantity, entry);

                
                MySqlNonQuery.DeleteLotById(id);

                Lot toBeDeleted = Lot.CloneLotById(id);
                GlobalVariables.Lots.Remove(toBeDeleted);

                lvlLots.Items.RemoveAt(lvlLots.SelectedIndices[0]);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lvlLots.SelectedItems.Count > 0)
            {              
                string number;
                if (lvlLots.Items[lvlLots.SelectedIndices[0]].Text == "Sem identificação")
                {
                    number = null;
                }
                else
                {
                    number = ListViewToObject.ToString(lvlLots.Items[lvlLots.SelectedIndices[0]].Text);
                }

                double quantity = ListViewToObject.ToDouble(lvlLots.Items[lvlLots.SelectedIndices[0]].SubItems[1].Text);
                DateTime entry = DateTime.ParseExact(lvlLots.Items[lvlLots.SelectedIndices[0]].SubItems[2].Text, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                int id = Lot.GetLotId(number, quantity, entry);

                Lot lot = Lot.CloneLotById(id);
                int index = GlobalVariables.Lots.IndexOf(lot);

                FRM_EditLot editLot = new FRM_EditLot(lot);
                editLot.ShowDialog();

                if (editLot.Lot == null) return;
                else lot = editLot.Lot;

                
                MySqlNonQuery.UpdateLot(lot);
                
                GlobalVariables.Lots[index] = lot;

                UpdateUI();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FRM_AddLot addLot = new FRM_AddLot(this.Product);
            addLot.ShowDialog();

            if (addLot.Empty) return;
            
            UpdateUI();
        }
    }
}
