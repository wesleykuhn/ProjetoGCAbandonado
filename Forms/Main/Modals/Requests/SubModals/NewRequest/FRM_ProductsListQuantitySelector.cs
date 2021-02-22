using GC.Library.Style;
using GC.Library.Objects;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GC.Forms.Main.Modals.Requests.SubModals.NewRequest
{
    public partial class FRM_ProductsListQuantitySelector : Bases.FRM_Default
    {
        internal bool Success = false;
        internal double Quantity;

        internal Product Product;

        internal FRM_ProductsListQuantitySelector(Product product, bool isAlterRequest)
        {
            InitializeComponent();

            this.ReadyForm();

            this.UnableClose();
            this.UnableMinimize();

            this.HideTitle();

            if (product.Description.Length > 24)
            {
                lblDescription.Text = product.Description.Substring(0, 24) + "...";
            }
            else
            {
                lblDescription.Text = product.Description;
            }

            lblCode.Text += product.Code;

            lblCode.ForeColor = ColorsPalette.GDE_Info;
            lblDescription.ForeColor = ColorsPalette.GDE_Info;

            lblCode.Left = (panel1.Width - lblCode.Width) / 2;
            lblDescription.Left = (panel1.Width - lblDescription.Width) / 2;

            if (isAlterRequest)
            {
                this.Text = "GC - Pedidos > Alteração De Pedido > Selecionando Produtos > Selecionando Quantidade";
            }

            this.Product = product;

            LabelTrainAnimation();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.Quantity = Convert.ToDouble(nudQuantity.Value);
            this.Success = true;
            this.Close();
        }

        private void RbtWeight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtWeight.Checked)
            {
                if(this.Product.Price == -1 || this.Product.Weight == -1)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Para ultilizar a função de calculo do produto por peso você precisa definir o preço e o peso deste produto! Vá no menu de produtos e defina o preço e peso deste produto.", 1);
                    messOk.Show();
                    this.Close();
                }

                lblKind.Text = "Peso:";

                nudQuantity.DecimalPlaces = 3;
                nudQuantity.Value = Convert.ToDecimal(1.000);
                nudQuantity.Minimum = Convert.ToDecimal(0.001);
            }
        }

        private void RbtUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtUnit.Checked)
            {
                lblKind.Text = "Quantidade:";

                nudQuantity.Value = 1;
                nudQuantity.DecimalPlaces = 0;
                nudQuantity.Minimum = 1;
            }
        }

        private void LabelTrainAnimation()
        {
            Task task = new Task(new Action(() =>
            {
                //Back panel
                Panel titlePanel = new Panel();
                titlePanel.Name = "titlePanel";
                titlePanel.Height = 16;
                titlePanel.Width = this.Width - 74;
                titlePanel.Left = 12;
                titlePanel.Top = 9;
                titlePanel.AutoScroll = false;

                //Title label
                Label title = new Label();
                title.Name = "lblTitle";
                title.AutoSize = true;
                title.Text = this.Text;
                title.Font = Library.Style.Labels.FormTitle;
                title.ForeColor = Color.GhostWhite;
                title.Left = 0;
                title.Top = 0;

                //Combination
                titlePanel.Controls.Add(title);
                int titleIndex = titlePanel.Controls.GetChildIndex(title);
                int panelIndex;

                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => {
                        this.Controls.Add(titlePanel);                        
                    }));
                }
                else
                {
                    try
                    {
                        this.Controls.Add(titlePanel);
                    }
                    catch (InvalidOperationException)
                    {
                        this.Invoke(new Action(() => {
                            this.Controls.Add(titlePanel);
                        }));
                    }
                }

                panelIndex = this.Controls.GetChildIndex(titlePanel);

                int length = title.Width - titlePanel.Width;
                int initialLeft = title.Left;
                int newLeft;

                System.Threading.Tasks.Task task2;

                //The animation
                while (true)
                {
                    for (int i = 0; i < length; i++)
                    {
                        task2 = Task.Delay(75);
                        task2.Wait();

                        if (this.Controls[panelIndex].Controls[titleIndex].InvokeRequired)
                        {
                            newLeft = this.Controls[panelIndex].Controls[titleIndex].Left - 1;
                            this.Controls[panelIndex].Controls[titleIndex].Invoke(new Action(() => this.Controls[panelIndex].Controls[titleIndex].Left = newLeft));
                        }
                        else
                        {
                            newLeft = this.Controls[panelIndex].Controls[titleIndex].Left - 1;
                            this.Controls[panelIndex].Controls[titleIndex].Left = newLeft;
                        }
                    }

                    //The reset
                    task2 = Task.Delay(2000);
                    task2.Wait();

                    if (this.Controls[panelIndex].Controls[titleIndex].InvokeRequired)
                    {
                        this.Controls[panelIndex].Controls[titleIndex].Invoke(new Action(() => this.Controls[panelIndex].Controls[titleIndex].Left = initialLeft));
                    }
                    else
                    {
                        try
                        {
                            this.Controls[panelIndex].Controls[titleIndex].Left = initialLeft;
                        }
                        catch (InvalidOperationException)
                        {
                            this.Controls[panelIndex].Controls[titleIndex].Invoke(new Action(() => this.Controls[panelIndex].Controls[titleIndex].Left = initialLeft));
                        }                        
                    }
                }
            }));

            task.Start();
        }

        private void FrmModal_NewRequestProductsListQuantitySelector_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BtnAdd_Click(this, new EventArgs());
            else if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void NudQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BtnAdd_Click(this, new EventArgs());
            else if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void BtnAdd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
