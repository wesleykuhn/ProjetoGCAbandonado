using GC.Library.Objects;
using System;
using System.Data;
using System.Linq;
using GC.Library.Database;
using GC.Library.Translators;
using GC.Library.Objects.SubObjects.Product;
using GC.Library;

namespace GC.Forms.Main.Modals.Products
{
    public partial class FRM_AlterProduct : Bases.FRM_Default
    {
        internal bool Alterations = false;

        private Product oldProduct;

        internal FRM_AlterProduct(Product OldProduct)
        {
            InitializeComponent();

            this.ReadyForm();

            txtCode.Text = OldProduct.Code;
            txtDesc.Text = OldProduct.Description;

            if(OldProduct.Price == -1)
            {
                nudPrice.Value = 0;
            }
            else
            {
                nudPrice.Value = Convert.ToDecimal(OldProduct.Price);
            }

            if(OldProduct.Position == null)
            {
                txtPos.Text = "";
            }
            else
            {
                txtPos.Text = OldProduct.Position;
            }

            if(OldProduct.PackQuantity == -1)
            {
                nudPackQuant.Value = 0;
            }
            else
            {
                nudPackQuant.Value = Convert.ToDecimal(OldProduct.PackQuantity);
            }

            if(OldProduct.Weight == -1)
            {
                nudWeight.Value = 0;
            }
            else
            {
                nudWeight.Value = Convert.ToDecimal(OldProduct.Weight);
            }

            if (OldProduct.IdealStock == -1)
            {
                nudIdeal_stock.Value = 0;
            }
            else
            {
                nudIdeal_stock.Value = Convert.ToDecimal(OldProduct.IdealStock);
            }

            // SUPPLIER CHOOSING ------------------------------>
            cbxSupplier.Items.Add("Nenhum");
            foreach (Supplier item in GlobalVariables.Suppliers)
            {
                cbxSupplier.Items.Add(item.Name);
            }

            int index = GlobalVariables.Suppliers.FindIndex(x => x.Id == OldProduct.Id_Supplier);
            if (index == -1) cbxSupplier.SelectedIndex = 0;
            else cbxSupplier.SelectedIndex = index + 1;
            //--------------------------------------------------

            this.oldProduct = OldProduct;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (nudPrice.Value <= 0)
            {
                GC.GlobalModals.FRM_MessageAndOK messOk = new GC.GlobalModals.FRM_MessageAndOK("Você não pode deixar o produto sem preço!", 1);
                messOk.Show();
                return;
            }

            GlobalModals.FRM_MiniLoad ml = new GlobalModals.FRM_MiniLoad();
            ml.Show();

            //Taking the product out from the global list to be updated
            int index = GlobalVariables.Products.IndexOf(oldProduct);
            GlobalVariables.Products[index] = null;

            // Handling with the 0 and "". Wich are null values ---------------------------------------------
            string position = FieldsToObject.ToString(txtPos.Text), desc = FieldsToObject.ToString(txtDesc.Text);
            double ideal_stock = FieldsToObject.ToDouble(Convert.ToDouble(nudIdeal_stock.Value)), price = FieldsToObject.ToDouble(Convert.ToDouble(nudPrice.Value)), weight = FieldsToObject.ToDouble(Convert.ToDouble(nudWeight.Value));
            int pack_qtt = FieldsToObject.ToInt(Convert.ToInt32(nudPackQuant.Value));
            // -------------------------------------------------------------------------------

            Product newProduct = new Product(oldProduct.Id, "NoCode", desc, ideal_stock, price, position, pack_qtt, weight, Supplier.GetSupplierId(cbxSupplier.SelectedItem.ToString()));
            if (ckbAutoCode.Checked)
            {
                int counter = 1;
                bool alreadyExists = false, breaker = false;
                while (!breaker)
                {
                    alreadyExists = false;
                    foreach (Product item in GlobalVariables.Products)
                    {
                        if (item.Code == counter.ToString())
                        {
                            alreadyExists = true;
                            break;
                        }
                    }                    
                    if (alreadyExists) counter++;
                    else breaker = true;
                }
                newProduct.Code = counter.ToString();
            }
            else
            {
                string aux = txtCode.Text.TrimStart();
                aux = aux.TrimEnd();
                newProduct.Code = aux;
            }
            //---------------------------------------------------------------

            foreach (Product item in GlobalVariables.Products)
            {
                if(item != null)
                {
                    if (newProduct.Code == item.Code && newProduct.Description == item.Description)
                    {
                        GlobalVariables.Products[index] = oldProduct;

                        GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Já existe um produto salvo com o esse mesmo código e descrição! Por favor, insira outro(s).", 1);
                        messOk.Show();

                        ml.CustomClose();

                        return;
                    }
                }                
            }            

            
            MySqlNonQuery.UpdateProduct(newProduct);

            GlobalVariables.Products[index] = newProduct;

            this.Alterations = true;

            ml.CustomClose();

            Close();
        }

        private void ckbAutoCode_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAutoCode.Checked)
            {
                txtCode.Enabled = false;
            }
            else
            {
                txtCode.Enabled = true;
            }
            txtCode_TextChanged(ckbAutoCode, new EventArgs());
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            string code = txtCode.Text.TrimStart(), desc = txtDesc.Text.TrimStart();
            code = code.TrimEnd();
            desc = desc.TrimEnd();
            if (code.Length > 0 && desc.Length > 0)
            {
                btnAlter.Enabled = true;
            }
            else if (ckbAutoCode.Checked && desc.Length > 0)
            {
                btnAlter.Enabled = true;
            }
            else
            {
                btnAlter.Enabled = false;
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            txtCode_TextChanged(txtDesc, new EventArgs());
        }
    }
}
