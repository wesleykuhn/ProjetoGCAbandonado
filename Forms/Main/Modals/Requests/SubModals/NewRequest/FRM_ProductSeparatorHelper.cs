using GC.Library.Objects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GC.Library.Translators;
using GC.Library.Style;
using System.Drawing;
using GC.Library.Objects.SubObjects.Product;

namespace GC.Forms.Main.Modals.Requests.SubModals.NewRequest
{
    public partial class FRM_ProductSeparatorHelper : Bases.FRM_Default
    {
        internal FRM_ProductSeparatorHelper(List<Lot> lots)
        {
            InitializeComponent();

            this.ReadyForm();

            foreach (Lot item in lots)
            {
                Product product = Product.CloneProduct(item.Id_Product);

                ListViewItem lvi = lvlProducts.Items.Add(product.Code);
                lvi.SubItems.Add(product.Description);
                lvi.SubItems.Add(ObjectToListView.ToDoubleListView_ThreeOrZeroDecimals(item.Quantity));
                lvi.SubItems.Add(ObjectToListView.ToStringListView(item.Number));
                lvi.SubItems.Add(ObjectToListView.ToStringListView(product.Position));

                if (lvi.Index % 2 != 0)
                {
                    lvi.BackColor = Color.FromArgb(0, 200, 200, 200);
                }
            }
        }

        private void LvlProducts_Click(object sender, EventArgs e)
        {
            if(lvlProducts.SelectedItems.Count > 0)
            {
                if(lvlProducts.Items[lvlProducts.SelectedIndices[0]].BackColor == ColorsPalette.GDE_Green)
                {
                    lvlProducts.Items[lvlProducts.SelectedIndices[0]].BackColor = Color.White;
                }
                else
                {
                    lvlProducts.Items[lvlProducts.SelectedIndices[0]].BackColor = ColorsPalette.GDE_Green;
                }
            }
        }
    }
}
