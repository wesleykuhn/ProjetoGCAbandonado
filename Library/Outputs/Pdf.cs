using System;
using System.IO;
using GC.Library.Entities;
using GC.Library.Objects;
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)
using GC.Library.Translators;
using GC.Library.Objects.SubObjects.Request;

namespace GC.Library.Outputs
{
    internal class Pdf
    {
        private Document Document { get; set; }
        private PdfWriter PdfWriter { get; set; }

        private Pdf(string path)
        {
            this.Document = new Document(PageSize.A4);
            this.Document.SetMargins(40, 40, 40, 80);
            this.Document.AddCreationDate();

            this.PdfWriter = PdfWriter.GetInstance(Document, new FileStream(path, FileMode.Create));
        }
        /*
        private void AddLogo()
        {
            //System.Drawing.Image gc = System.Drawing.Image.FromHbitmap(Properties.Resources.icon_gc_logo_50x50.GetHbitmap(System.Drawing.Color.White));
            //System.Drawing.Image kp = System.Drawing.Image.FromHbitmap(Properties.Resources.icon_kuhnper_logo_50x50.GetHbitmap(System.Drawing.Color.White));

            //Image gcImg = Image.GetInstance(gc, System.Drawing.Imaging.ImageFormat.Png);
            //Image kpImg = Image.GetInstance(kp, System.Drawing.Imaging.ImageFormat.Png);

            //kpImg.SetAbsolutePosition((PageSize.A4.Width / 2) - 55, PageSize.A4.Height - 70);
            //gcImg.SetAbsolutePosition((PageSize.A4.Width / 2) + 5, PageSize.A4.Height - 70);

            //this.Document.Add(gcImg);
            //this.Document.Add(kpImg);

            //this.BreakLine();
            //this.BreakLine();
        }*/

        private void AddTitle(string text)
        {
            Paragraph ph = new Paragraph(text, new Font(Font.FontFamily.TIMES_ROMAN, 14, 1));
            this.Document.Add(ph);
        }

        private void AddParagraph(string text)
        {
            Paragraph ph = new Paragraph(text, new Font(Font.FontFamily.TIMES_ROMAN, 10, 0));
            this.Document.Add(ph);
        }

        private void AddParagraphBold(string text)
        {
            Paragraph ph = new Paragraph(text, new Font(Font.FontFamily.TIMES_ROMAN, 10, 1));
            this.Document.Add(ph);
        }        

        private void BreakLine()
        {      
            Paragraph ph = new Paragraph(" ", new Font(Font.FontFamily.TIMES_ROMAN, 10, 0));
            this.Document.Add(ph);
        }

        private void AddCreationDate()
        {
            this.BreakLine();
            this.BreakLine();
            this.BreakLine();

            Paragraph ph = new Paragraph("Emissão deste documento: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), new Font(Font.FontFamily.TIMES_ROMAN, 8, 0));
            ph.Alignment = Element.ALIGN_RIGHT;
            this.Document.Add(ph);
        }

        internal static void RequestToPdf(Request request)
        {
            Pdf pdf = new Pdf(Informations.Directories.PdfRequests + request.Number + ".pdf");
            pdf.Document.AddTitle("Detalhes do pedido");

            pdf.Document.Open();

            pdf.AddTitle("Detalhes do Pedido");

            pdf.BreakLine();

            pdf.AddParagraph("Número do pedido: " + request.Number + ".");

            pdf.AddParagraph("Data do pedido: " + request.StartedIn.ToString("dd/MM/yyyy HH:mm:ss") + ".");

            pdf.AddParagraph("Valor total: " + ObjectToDetailLabel.ToMoneyLabel(request.Value) + ".");

            Costumer costumer = Costumer.CloneCostumer(request.Id_Costumer);
            if (costumer == null)
            {
                pdf.AddParagraph("Cliente: Cliente excluído!");
            }
            else
            {
                pdf.AddParagraph("Cliente: " + costumer.Name + ".");
                pdf.AddParagraph("Endereço do cliente: " + costumer.GetAddress() + " - " + costumer.District + " - " + costumer.City + ".");
            }

            if (Checkers.Structs.IsDateTimeNull(request.ExpiresIn)) pdf.AddParagraph("Tem vencimento? Não.");
            else pdf.AddParagraph("Tem vencimento? Sim, vence em " + request.ExpiresIn.ToString("dd/MM/yyyy HH:mm:ss") + ".");

            pdf.AddParagraph("Descontos: " + ObjectToDetailLabel.ToMoneyLabel(request.Discount) + ".");

            pdf.AddParagraph("Acréscimos: " + ObjectToDetailLabel.ToMoneyLabel(request.Addition) + ".");         

            pdf.AddParagraph("Tipo de pagamento: " + request.PaymentTypeToString() + ".");

            pdf.AddParagraph("Situação do pedido: " + Request.GetStatusString(request) + ".");

            if(request.Observations == null || request.Observations == "") pdf.AddParagraph("Observações: Sem observações.");
            else pdf.AddParagraph("Observações: " + request.Observations + ".");

            if (request.IsDelivery) pdf.AddParagraph("É uma entrega? Não.");
            else pdf.AddParagraph("É uma entrega? Sim.");
            
            if(request.Occurrences == null || request.Occurrences == "") pdf.AddParagraph("Ocorrências: Sem ocorrências.");
            else pdf.AddParagraph("Ocorrências: " + request.Occurrences + ".");            

            pdf.BreakLine();
            pdf.BreakLine();

            // REQUEST PRODUCTS --------------------------------->
            pdf.AddTitle("Produtos");

            pdf.BreakLine();

            pdf.AddParagraphBold("Código ............. Descrição ........................................... Preço(R$) .... Quantidade(unid./kg) .... Subtotal(R$)");

            foreach (Request_Products por in request.Products)
            {
                // BUIDLING ---------------------------->
                string code, description, price, qtt, subtotal, line = "";

                Product product = Product.CloneProduct(por.Id_Product);
                if (product == null)
                {
                    code = "Produto Excluído!";
                    description = " ";
                }
                else
                {
                    code = product.Code;
                    description = product.Description;
                }

                price = por.Price.ToString("n2");
                subtotal = (por.Price * por.Quantity).ToString("n2");

                if (Checkers.Variables.IsValueDouble(por.Quantity)) qtt = ObjectToDetailLabel.ToKilogramLabel(por.Quantity);
                else qtt = por.Quantity.ToString() + " un.";

                // 16 + 1       50 + 1        12 + 1        17    
                line = code + " ";
                for (int i = 0; i < 17 - code.Length; i++)
                {
                    line += ".";
                }

                line += " " + description + " ";
                for (int i = 0; i < 51 - description.Length; i++)
                {
                    line += ".";
                }

                line += " " + price + " ";
                for (int i = 0; i < 13 - price.Length; i++)
                {
                    line += ".";
                }

                line += " " + qtt + " ";
                for (int i = 0; i < 17 - qtt.Length; i++)
                {
                    line += ".";
                }

                line += " " + subtotal;
                // <-----------------------------------

                // ASSEMBLY ---------------------------->
                pdf.AddParagraph(line);
                // <------------------------------------
            }
            // <--------------------------------------------------

            pdf.BreakLine();
            pdf.BreakLine();

            // REQUEST JOBS --------------------------------->
            pdf.AddTitle("Serviços");

            pdf.BreakLine();

            pdf.AddParagraphBold("Serviço .................................. Descrição ....................................................... Preço(R$)");

            foreach (Request_Jobs jor in request.Jobs)
            {
                // BUIDLING ---------------------------->
                string name, description, price, line = "";

                Job job = Job.CloneJob(jor.Id_Job);
                if (job == null)
                {
                    name = "Serviço Excluído!";
                    description = " ";
                }
                else
                {
                    name = job.Name;
                    description = job.Description;
                }

                price = jor.Price.ToString("n2");

                line = name + " ";
                for (int i = 0; i < 34 - name.Length; i++)
                {
                    line += ".";
                }

                line += " " + description + " ";
                for (int i = 0; i < 58 - description.Length; i++)
                {
                    line += ".";
                }

                line += " " + price + " ";
                for (int i = 0; i < 13 - price.Length; i++)
                {
                    line += ".";
                }
                // <-----------------------------------

                // ASSEMBLY ---------------------------->
                pdf.AddParagraph(line);
                // <------------------------------------
            }
            // <--------------------------------------------------

            pdf.BreakLine();
            pdf.BreakLine();

            if (GlobalVariables.User.Cnpj == null || GlobalVariables.User.Cnpj == "")
            {
                pdf.AddTitle("Dados do Vendedor/Prestador");

                pdf.BreakLine();

                pdf.AddParagraph("Nome: " + GlobalVariables.User.Name + ".");

                pdf.AddParagraph("E-mail: " + GlobalVariables.User.Email + ".");

                pdf.AddParagraph("Telefone/Celular: " + GlobalVariables.User.PhoneNumber + ".");
            }
            else
            {
                pdf.AddTitle("Dados da Empresa/Comércio");

                pdf.BreakLine();

                pdf.AddParagraph("CNPJ: " + GlobalVariables.CompanyInformation.Cnpj + ".");

                pdf.AddParagraph("Razão social: " + GlobalVariables.CompanyInformation.Nome + ".");

                pdf.AddParagraph("Logradouro: " + GlobalVariables.CompanyInformation.Logradouro + ".");

                pdf.AddParagraph("Número: " + GlobalVariables.CompanyInformation.Numero + ".");
            }

            pdf.AddCreationDate();

            pdf.Document.Close();
        }

        // STATIC METHODS
        internal static void WarrantyToPdf(Warranty warranty)
        {
            Pdf pdf = new Pdf(Informations.Directories.PdfWarranties + warranty.Number + ".pdf");
            pdf.Document.AddTitle("Detalhes da garantia " + warranty.Number);

            pdf.Document.Open();

            pdf.AddTitle("Detalhes da Garantia");

            pdf.BreakLine();

            pdf.AddParagraph("Número da garantia: " + warranty.Number + ".");

            pdf.AddParagraph("Garantia criada em " + warranty.StartedIn.ToString("dd/MM/yyyy HH:mm:ss") + ".");

            Costumer costumer = Costumer.CloneCostumer(warranty.Id_Costumer);
            if(costumer == null)
            {
                pdf.AddParagraph("Cliente: Cliente excluído!");
            }
            else
            {
                pdf.AddParagraph("Cliente: " + costumer.Name + ".");
                pdf.AddParagraph("Endereço do cliente: " + costumer.GetAddress() + " - " + costumer.District + " - " + costumer.City + ".");
            }            

            if (!warranty.Type)
            {
                Product product = Product.CloneProduct(warranty.Id_Item);
                if(product == null) pdf.AddParagraph("Produto: Produto excluído!");
                else pdf.AddParagraph("Produto: " + product.Code + " - " + product.Description + ".");
            }
            else
            {
                Job job = Job.CloneJob(warranty.Id_Item);
                if(job == null) pdf.AddParagraph("Serviço: Serviço excluído!");
                else pdf.AddParagraph("Serviço: " + job.Name + " - " + job.Description + ".");
            }
            
            pdf.AddParagraph("Garantia válida até " + warranty.ExpiresIn.ToString("dd/MM/yyyy HH:mm:ss") + ".");

            TimeSpan duration = warranty.ExpiresIn.Subtract(DateTime.Now);
            pdf.AddParagraph("Duração total: " + duration.Days + " dias.");

            string observation = "Nenhuma observação.";
            if (warranty.Observations != null && warranty.Observations.Length > 0) observation = warranty.Observations;
            pdf.AddParagraph("Observações: " + observation);

            pdf.BreakLine();
            pdf.BreakLine();

            if (GlobalVariables.User.Cnpj == null || GlobalVariables.User.Cnpj == "")
            {
                pdf.AddTitle("Dados do Vendedor/Prestador");

                pdf.BreakLine();

                pdf.AddParagraph("Nome: " + GlobalVariables.User.Name + ".");

                pdf.AddParagraph("E-mail: " + GlobalVariables.User.Email + ".");

                pdf.AddParagraph("Telefone/Celular: " + GlobalVariables.User.PhoneNumber + ".");
            }
            else
            {
                pdf.AddTitle("Dados da Empresa/Comércio");

                pdf.BreakLine();

                pdf.AddParagraph("CNPJ: " + GlobalVariables.CompanyInformation.Cnpj + ".");

                pdf.AddParagraph("Razão social: " + GlobalVariables.CompanyInformation.Nome + ".");

                pdf.AddParagraph("Logradouro: " + GlobalVariables.CompanyInformation.Logradouro + ".");

                pdf.AddParagraph("Número: " + GlobalVariables.CompanyInformation.Numero + ".");
            }

            pdf.AddCreationDate();

            pdf.Document.Close();
        }
    }
}
