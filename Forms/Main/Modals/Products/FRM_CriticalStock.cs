using System.Drawing;
using System.Windows.Forms;
using GC.Library;
using GC.Library.Objects;
using GC.Library.Translators;

namespace GC.Forms.Main.Modals.Products
{
    public partial class FRM_CriticalStock : Bases.FRM_Default
    {
        int Counter = 0;

        public FRM_CriticalStock()
        {
            InitializeComponent();

            this.ReadyForm();

            foreach (Product item in GlobalVariables.Products)
            {
                if(Product.GetTotalStockQuantity(item.Id) < item.IdealStock || Product.GetTotalStockQuantity(item.Id) == 0)
                {
                    ListViewItem lvi = lvlCriticalProducts.Items.Add(item.Code);
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.Description));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, Product.GetTotalStockQuantityToString(item.Id)));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(null, ObjectToListView.ToDoubleListView(item.IdealStock)));

                    if (lvi.Index % 2 != 0) lvi.BackColor = Color.FromArgb(0, 200, 200, 200);                  

                    this.Counter++;
                }                
            }

            lblTotalProducts.Text += this.Counter;
        }
    }
}
