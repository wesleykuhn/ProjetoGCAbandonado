using GC.Library.Objects;
using GC.Library.Translators;
using System;
using System.Net.Mail;
using GC.Library.Generators;
using GC.Library.Objects.SubObjects.Request;
using GC.Library.Entities;

namespace GC.Library.Web
{
    internal static class Email
    {
        // FIELDS
        const string administrationEmail = "gc-administracao@kuhnper.com.br";

        // -------------------------------------------------------------
        // GENERICS ----------------------------------------------------
        // -------------------------------------------------------------
        private static SmtpClient GetSmtpClient()
        {
            SmtpClient client = new SmtpClient("mail.kuhnper.com.br", 587);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("noreply@kuhnper.com.br", WKCrypto.W710("01322370123705207023763323701237052070230630237002370520702316352370723705297023463223702237052970232370521874940448162623705218749404481606237052187494044816162370521874940448169606302370223705267023063023700237052970230631237012370520702316332370123705297023163023700237052070230633237052370527702346302370323705277023363223701237052970230633237052370527702386342370323705217023063023701237052270230633237092370520702316332370123705297023063123701237052070231635237072370529702336372370923705207023"));
            client.EnableSsl = true;
            client.Credentials = credentials;
            return client;
        }        

        private static MailMessage CreateMailMessage(string to, string subject, string body)
        {
            MailMessage mail = new MailMessage("noreply@kuhnper.com.br", to);
            mail.Subject = subject;
            mail.Body = body;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            return mail;
        }

        private static void SendEmail(string to, string subject, string body)
        {
            SmtpClient client = GetSmtpClient();

            MailMessage mail = CreateMailMessage(to, subject, body);

            client.Send(mail);
        }
        // <--------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------
        // CODES AND PASSWORD EMAILS ---------------------------------------------------
        // -----------------------------------------------------------------------------
        internal static string NewEmailCode(string to, string name)
        {
            string code = Code.NumbersAndWords(6);

            SmtpClient client = GetSmtpClient();
            MailMessage mail = CreateMailMessage(to, "(E-mail Automático) Gestor de Comércio > Alteração de E-mail > Código De Alteração.", @"<div style='border-radius: 20px; background-color: #e6e6e6;font-family: Verdana; text-align: center; padding: 30px 10px 30px 10px;'><p style='font-size: 22px; font-weight:500;'>Olá " + name + "! Este é o código para a alteração do e-mail da sua conta no Gestor de Comércio:</p><div style='border-radius: 20px; background-color: #444444; margin: 0% 15%;'><h2 style='font-size: 40px; color: #42b883; padding: 10px 0px;'>" + code + "</h2></div><br></br><p style='font-size: 12px; font-weight:500;'>*Ignore essa mensagem caso você desconheça este e-mail.*</p></div>");

            client.Send(mail);
            return code;
        }

        internal static string NewAccountCode(string to, string name)
        {       
            string code = Code.NumbersAndWords(6);

            SmtpClient client = GetSmtpClient();
            MailMessage mail = CreateMailMessage(to, "(E-mail Automático) Gestor de Comércio > Criação de Conta > Código De Ativação.", @"<div style='border-radius: 20px; background-color: #e6e6e6;font-family: Verdana; text-align: center; padding: 30px 10px 30px 10px;'><p style='font-size: 22px; font-weight:500;'>Olá " + name + "! Este é o código para ativação da sua conta no Gestor de Comércio:</p><div style='border-radius: 20px; background-color: #444444; margin: 0% 15%;'><h2 style='font-size: 40px; color: #42b883; padding: 10px 0px;'>" + code + "</h2></div><br></br><p style='font-size: 12px; font-weight:500;'>*Ignore essa mensagem caso você desconheça este e-mail.*</p></div>");               
            
            client.Send(mail);
            return code;
        }

        internal static string ForgotPasswordCode(string to, string name)
        {
            string code = Code.Numbers(6);

            SmtpClient client = GetSmtpClient();
            MailMessage mail = CreateMailMessage(to, "(E-mail Automático) Gestor de Comércio > Conta > Requisição de troca de senha.", @"<div style='border-radius: 20px; background-color: #e6e6e6;font-family: Verdana; text-align: center; padding: 30px 10px 30px 10px;'><p style='font-size: 22px; font-weight:500;'>Olá " + name + ", recentemente foi solicitada a troca da sua senha no GC. O código para prosseguir com a alteração da senha é:</p><div style='border-radius: 20px; background-color: #444444; margin: 0% 10%;'><h2 style='font-size: 34px; color: rgb(0,123,255); padding: 10px 0px;'>" + code + "</h2></div><br></br><p style='font-size: 12px; font-weight:500;'>*Caso você não tenha solicitado a troca de sua senha, entre em contato com a administração no e-mail: gc-administracao@kuhnper.com.br.*</p></div>");
            
            client.Send(mail);
            return code;
        }

        internal static string NewPassword(string to, string name)
        {
            string newPassword = Code.Numbers(8);

            SmtpClient client = GetSmtpClient();
            MailMessage mail = CreateMailMessage(to, "(E-mail Automático) Gestor de Comércio > Conta > Nova Senha", @"<div style='border-radius: 20px; background-color: #e6e6e6;font-family: Verdana; text-align: center; padding: 30px 10px 30px 10px;'><p style='font-size: 22px; font-weight:500;'>Olá " + name + ", recentemente foi solicitada a troca da sua senha no GC. Sua nova senha é:</p><div style='border-radius: 20px; background-color: #444444; margin: 0% 10%;'><h2 style='font-size: 34px; color: rgb(0,123,255); padding: 10px 0px;'>" + newPassword + "</h2></div><br></br><p style='font-size: 12px; font-weight:500;'>*Caso você não tenha solicitado a troca de sua senha, entre em contato com a administração no e-mail: gc-administracao@kuhnper.com.br.*</p></div>");
           
            client.Send(mail);
            return newPassword;
        }
        // <------------------------------------------------------------------------------------

        // --------------------------------------------------------------------------------------
        // DETAILS EMAILS -----------------------------------------------------------------------
        // --------------------------------------------------------------------------------------
        internal static void WarrantyDetails(string to, Warranty warranty)
        {
            //Getting commercial information
            string commercialName;
            string cnpj = @"<p>CNPJ da empresa/pessoa: Não informado/possui.</p>";

            if (GlobalVariables.User.Cnpj == null || GlobalVariables.User.Cnpj == "")
            {
                commercialName = GlobalVariables.User.Name;
            }
            else
            {
                commercialName = GlobalVariables.CompanyInformation.Nome;
            }

            if (GlobalVariables.CompanyInformation != null && GlobalVariables.CompanyInformation.Cnpj != "")
            {
                cnpj = @"<p>CNPJ da empresa/pessoa: " + GlobalVariables.CompanyInformation.Cnpj + @".</p>";
            }

            string costumerAddress, costumerName;
            Costumer costumer = Costumer.CloneCostumer(warranty.Id_Costumer);
            if(costumer == null)
            {
                costumerAddress = "Não informado";
                costumerName = "Cliente excluído!";
            }
            else
            {
                costumerAddress = costumer.GetAddress();
                costumerName = costumer.Name + ".";
            }

            TimeSpan duration = warranty.ExpiresIn.Subtract(DateTime.Now);

            string warrantyItem;
            if (!warranty.Type)
            {
                Product product = Product.CloneProduct(warranty.Id_Item);
                if(product == null)
                {
                    warrantyItem = "<p>Produto garantido: Produto excluído!</p>";
                }
                else
                {
                    warrantyItem = "<p>Produto garantido: " + product.Code + " - " + product.Description + @".</p>";
                }
            }
            else
            {
                Job job = Job.CloneJob(warranty.Id_Item);
                if (job == null)
                {
                    warrantyItem = "<p>Serviço garantido: Serviço excluído!</p>";
                }
                else
                {
                    warrantyItem = "<p>Serviço garantido: " + job.Name + " - " + job.Description + @".</p>";
                }
            }

            string observations = "Nenhuma observação.";
            if (warranty.Observations != null && warranty.Observations.Length > 0) observations = warranty.Observations;

            string costuName = Costumer.GetCostumerName(warranty.Id_Costumer);
            if (costuName == "Excluído") costuName = "prezado(a) cliente";

            string subject = "(E-mail Automático) Gestor de Comércio > Detalhes da Garantia Nº" + warranty.Number;

            // body
            string body = 
                @"<div style='border-radius:20px; background-color:#e6e6e6;font-family:Verdana;text-align:center;padding:30px 10px 30px 10px'>
                    <p style='font-size:15px'>Olá " + costuName + @"! Abaixo estão os detalhes de sua garantia no(a) " + commercialName + @":</p>
                    <div style='border-radius:20px;background-color:white;margin:0% 10%;font-size:12px;padding:5px 0px'>"
                        + cnpj +
                        @"<br>
                        <p>Número da garantia: " + warranty.Number + @".</p>
                        <p>Criada em: " + warranty.StartedIn.ToString("dd/MM/yyyy") + " às " + warranty.StartedIn.ToString("HH:mm:ss") + @".</p>
                        <p>Cliente: " + costumerName + @"</p>
                        <p>Endereço do cliente: " + costumerAddress + @".</p>
                        <p>Vencimento da garantia: " + warranty.ExpiresIn.ToString("dd/MM/yyyy") + " às " + warranty.ExpiresIn.ToString("HH:mm:ss") + @".</p>
                        <p>Duração total da garantia: " + duration.Days + @" dias.</p>"
                        + warrantyItem +
                        @"<p>Observações: " + observations + @"</p>" +
                  @"</div>
                </div>";
            // <---- end body

            SendEmail(to, subject, body);
        }

        internal static void RequestDetails(string to, Request request)
        {
            //Getting commercial information
            string commercialName;
            string cnpj = @"<p>CNPJ da empresa/pessoa: Não informado/possui.</p>";

            if(GlobalVariables.User.Cnpj == null || GlobalVariables.User.Cnpj == "")
            {
                commercialName = GlobalVariables.User.Name;
            }
            else
            {
                commercialName = GlobalVariables.CompanyInformation.Nome;                
            }

            if(GlobalVariables.CompanyInformation != null && GlobalVariables.CompanyInformation.Cnpj != "")
            {
                cnpj = @"<p>CNPJ da empresa/pessoa: " + GlobalVariables.CompanyInformation.Cnpj + @".</p>";
            }

            // Other informations of request
            string Discount, Addition, Observations, expiration, paymentType, isDelivery = "Não";
            
            if(request.Discount > 0)
            {
                Discount = request.Discount.ToString("n2");
            }
            else
            {
                Discount = "Não possui";
            }

            if (request.Addition > 0)
            {
                Addition = request.Addition.ToString("n2");
            }
            else
            {
                Addition = "Não possui";
            }

            if (request.Observations != null && request.Observations != "")
            {
                Observations = request.Observations;
            }
            else
            {
                Observations = "Nenhuma";
            }

            if (Checkers.Structs.IsDateTimeNull(request.ExpiresIn))
            {
                expiration = "Não possui vencimento";
            }
            else
            {
                expiration = request.ExpiresIn.ToString("dd/MM/yyyy") + " às " + request.ExpiresIn.ToString("HH:mm:ss");
            }

            switch (request.PaymentType)
            {
                case 0:
                    paymentType = "Dinheiro";
                    break;

                case 1:
                    paymentType = "Cartão de Débito";
                    break;

                case 2:
                    paymentType = "Cartão de Crédito";
                    break;

                case 3:
                    paymentType = "Cheque";
                    break;

                case 4:
                    paymentType = "Boleto";
                    break;

                case 5:
                    paymentType = "Débito Recorrente";
                    break;

                default:
                    paymentType = "Fiado";
                    break;
            }

            if (request.IsDelivery)
            {
                isDelivery = "Sim";
            }

            // List of products HTML ---------------------------------------------------------------------------------------->
            string productsList = @"<p>Produtos inclusos no pedido: ";

            if(request.Products.Count > 0)
            {
                productsList += @"</p>
                                <table style='border-collapse:collapse;width:90%;margin-left:5%;margin-bottom:15px'>
                                    <tbody>
                                        <tr>
                                            <th style='border:2px solid #313131;text-align:left;padding:4px'>Descrição</th>
                                            <th style='border:2px solid #313131;text-align:left;padding:4px'>Preço(R$)</th>
                                            <th style='border:2px solid #313131;text-align:left;padding:4px'>Quantidade</th>
                                            <th style='border:2px solid #313131;text-align:left;padding:4px'>Subtotal</th>
                                        </tr>";

                foreach (Request_Products reqProd in request.Products)
                {
                    Product product = Product.CloneProduct(reqProd.Id_Product);

                    if(product == null)
                    {
                        productsList += @"<tr>
                                        <td style='border:1px solid #313131;text-align:left;padding:4px'>" + "Produto excluído!" + @"</td>
                                        <td style='border:1px solid #313131;text-align:left;padding:4px'>" + reqProd.Price.ToString("n2") + @"</td>
                                        <td style='border:1px solid #313131;text-align:left;padding:4px'>" + reqProd.Quantity.ToString() + @"</td>
                                        <td style='border:1px solid #313131;text-align:left;padding:4px'>" + (reqProd.Price * reqProd.Quantity).ToString("n2") + @"</td>
                                    </tr>";
                    }
                    else
                    {
                        productsList += @"<tr>
                                        <td style='border:1px solid #313131;text-align:left;padding:4px'>" + product.Description + @"</td>
                                        <td style='border:1px solid #313131;text-align:left;padding:4px'>" + reqProd.Price.ToString("n2") + @"</td>
                                        <td style='border:1px solid #313131;text-align:left;padding:4px'>" + reqProd.Quantity.ToString() + @"</td>
                                        <td style='border:1px solid #313131;text-align:left;padding:4px'>" + (reqProd.Price * reqProd.Quantity).ToString("n2") + @"</td>
                                    </tr>";
                    }                    
                }

                productsList += @" </tbody></table>";
            }
            else
            {
                productsList += @"Nenhum produto!</p>";
            }
            // <------------------------------------------------------------------------------------------------------------------------

            // List of jobs HTML ---------------------------------------------------------------------------------------->
            string jobsList = @"<p>Serviços inclusos no pedido: ";

            if (request.Jobs.Count > 0)
            {
                jobsList += @"</p>
                                <table style='border-collapse:collapse;width:90%;margin-left:5%;margin-bottom:15px'>
                                    <tbody>
                                        <tr>
                                            <th style='border:2px solid #313131;text-align:left;padding:4px'>Serviço</th>
                                            <th style='border:2px solid #313131;text-align:left;padding:4px'>Descrição</th>
                                            <th style='border:2px solid #313131;text-align:left;padding:4px'>Valor(R$)</th>
                                        </tr>";

                foreach (Request_Jobs reqJob in request.Jobs)
                {
                    Job job = Job.CloneJob(reqJob.Id_Job);
                    if(job == null)
                    {
                        jobsList += @"<tr>
                                        <td style='border:1px solid #313131;text-align:left;padding:4px'>" + "Serviço excluído!" + @"</td>
                                        <td style='border:1px solid #313131;text-align:left;padding:4px'>" + " " + @"</td>
                                        <td style='border:1px solid #313131;text-align:left;padding:4px'>" + reqJob.Price.ToString("n2") + @"</td>
                                    </tr>";
                    }
                    else
                    {
                        jobsList += @"<tr>
                                        <td style='border:1px solid #313131;text-align:left;padding:4px'>" + job.Name + @"</td>
                                        <td style='border:1px solid #313131;text-align:left;padding:4px'>" + job.Description + @"</td>
                                        <td style='border:1px solid #313131;text-align:left;padding:4px'>" + reqJob.Price.ToString("n2") + @"</td>
                                    </tr>";
                    }                    
                }

                jobsList += @" </tbody></table>";
            }
            else
            {
                jobsList += @"Nenhum serviço!</p>";
            }

            string costumerName = Costumer.GetCostumerName(request.Id_Costumer);
            if (costumerName == "Excluído") costumerName = "prezado(a) cliente";

            string subject = "(E-mail Automático) Gestor de Comércio > Detalhes do Pedido " + request.Number;

            string body = 
                @"<div style='border-radius:20px; background-color:#e6e6e6;font-family:Verdana;text-align:center;padding:30px 10px 30px 10px'>
                    <p style='font-size:15px'>Olá " + costumerName + @"! Abaixo estão os detalhes do seu pedido no(a) " + commercialName + @":</p>
                    <div style='border-radius:20px;background-color:white;margin:0% 10%;font-size:12px;padding:5px 0px'>"
                        + cnpj +
                        @"<br>
                        <p>Número do pedido: " + request.Number +@".</p>
                        <p>Valor do pedido: " + request.Value.ToString("n2") +@".</p>
                        <p>Data do pedido: " + request.StartedIn.ToString("dd/MM/yyyy") + " às " + request.StartedIn.ToString("HH:mm:ss") + @".</p>
                        <p>Desconto: " + Discount +@".</p>
                        <p>Acréscimo: " + Addition +@".</p>
                        <p>Observações: " + Observations +@"</p>
                        <p>Vencimento do pedido: " + expiration + @".</p>
                        <p>Tipo de pagamento: " + paymentType +@".</p>
                        <p>Deverá ser entregue? " + isDelivery +@".</p>
                    </div>
                    <div style='border-radius:20px;background-color:white;margin:10px 5%;font-size:12px;padding:5px 0px;width:90%'>"
                         + productsList + 
                    @"</div>
                    <div style='border-radius:20px;background-color:white;margin:10px 5%;font-size:12px;padding:5px 0px;width:90%'>"
                        + jobsList + 
                    @"</div>
                    <br>
                    <p style='font-size:12px;font-weight:500'>*Atenção: Este e-mail é gerado automaticamente e é apenas informativo! Não tem nenhum objetivo fiscal. Para qualquer finalidade fiscal entre em contato com a empresa/pessoa citada a cima.*</p>
                </div>";

            SendEmail(to, subject, body);
        }
        // <--------------------------------------------------------------------------------------------------

        // ----------------------------------------------------------------------------------------
        // WARNING AND INFORMATIONS EMAILS --------------------------------------------------------
        // ----------------------------------------------------------------------------------------
        internal static void RequestFinishedEmail(string to, int idCostumer, string requestNumber)
        {
            string commercialName = GlobalVariables.User.Name;
            if (GlobalVariables.User.Cnpj != null && GlobalVariables.User.Cnpj != "") commercialName = GlobalVariables.CompanyInformation.Nome;

            string costumerName = Costumer.GetCostumerName(idCostumer);
            if (costumerName == "Excluído") costumerName = "prezado(a) cliente";

            string subject = "(E-mail Automático) Gestor de Comércio > Pedido " + requestNumber + " Finalizado";

            string body =
                @"<div style='border-radius:20px; border: 2px solid #49b675;font-family:Verdana;text-align:center;padding:30px 10px 30px 10px;'>
                    <p style='font-size:15px'>Boas notícias " + costumerName + @"! Seu pedido número " + requestNumber + @", aberto no(a) " + commercialName + @", acabou de ser finalizado!</p>                   
                    <br>
                    <p style='font-size:12px;font-weight:500'>*Atenção: Este e-mail é gerado automaticamente e é apenas informativo! Não tem nenhum objetivo fiscal. Para qualquer finalidade fiscal entre em contato com a empresa/pessoa citada a cima.*</p>
                </div>";

            SendEmail(to, subject, body);
        }
        // <-------------------------------------------------------------------------------------

        // --------------------------------------------------------------------------------------
        // TO ADMINISTRATION EMAILS -----------------------------------------------------
        // --------------------------------------------------------------------------------------
        internal static void PaymentRequestEmail()
        {
            DateTime dateOfExpiration = Translators.SqlToObject.ToDate(Library.Database.MySqlReader.ReadOnlyOneColumn("user_metadata", "expiration", new string[] { "id_user" }, new string[] { GlobalVariables.User.Id.ToString() }, null, new bool[] { false }));

            string subject = "(E-mail Automático) Gestor de Comércio > " + GlobalVariables.User.Name + " Solicitou Boleto de Pagamento";
            
            string body = 
                @"<div style='font-family: Verdana; text-align: center; border-radius: 10px; background-color: #31a859; color: white; padding: 20px;'>
	                <p>Solicitação de Boleto:</p>
                    <div style='text-align: left; border-radius: 10px; background-color: white; color: black; padding: 10px'>
    	                <p>Id do usuário: " + GlobalVariables.User.Id.ToString() + @"</p>
                        <p>Nome: " + GlobalVariables.User.Name + @"</p>
                        <p>E-mail: " + GlobalVariables.User.Email + @"</p>
                        <p>Celular: " + GlobalVariables.User.PhoneNumber + @"</p>
                        <p>Plano: " + GlobalVariables.User.AccountType.ToString() + @"</p>
                        <p>Conta vence em " + dateOfExpiration.ToString("dd/MM/yyyy HH:mm:ss") + @"</p>
                        <p>Boleto solicitado em " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + @"</p>
                        <p>Entrou no programa em " + GlobalVariables.User.Joined.ToString("dd/MM/yyyy HH:mm:ss") + @"</p>
                    </div>
                </div>";

            SendEmail(administrationEmail, subject, body);
        }

        internal static void ChangeAccountTypeRequestEmail(char newType)
        {
            string type;
            switch (newType)
            {
                case 'M':
                    type = "MÉDIO";
                    break;

                case 'G':
                    type = "GRANDE";
                    break;

                default:
                    type = "PEQUENO";
                    break;
            }

            DateTime aux = SqlToObject.ToDateTime(Database.MySqlReader.ReadOnlyOneColumn("user_metadata", "last_account_type_change", new string[] { "id_user" }, new string[] { GlobalVariables.User.Id.ToString() }, null, new bool[] { false }));

            string lastRequest = "Nunca";
            if (!Checkers.Structs.IsDateTimeNull(aux)) lastRequest = aux.ToString("dd/MM/yyyy HH:mm:ss");

            DateTime dateOfExpiration = SqlToObject.ToDate(Library.Database.MySqlReader.ReadOnlyOneColumn("user_metadata", "expiration", new string[] { "id_user" }, new string[] { GlobalVariables.User.Id.ToString() }, null, new bool[] { false }));

            string subject = "(E-mail Automático) Gestor de Comércio > " + GlobalVariables.User.Name + " Solicitou Mudança de Plano";

            string body = 
                @"<div style='font-family: Verdana; text-align: center; border-radius: 10px; background-color: #0e4bef; color: white; padding: 20px;'>
	                <p>Solicitação de Mudança do Plano da Conta:</p>
                    <div style='text-align: left; border-radius: 10px; background-color: white; color: black; padding: 10px'>
    	                <p>Id do usuário: " + GlobalVariables.User.Id.ToString() + @"</p>
                        <p>Nome: " + GlobalVariables.User.Name + @"</p>
                        <p>E-mail: " + GlobalVariables.User.Email + @"</p>
                        <p>Celular: " + GlobalVariables.User.PhoneNumber + @"</p>
                        <p>Plano: " + GlobalVariables.User.AccountType.ToString() + @"</p>
                        <p>Conta vence em " + dateOfExpiration.ToString("dd/MM/yyyy HH:mm:ss") + @"</p>                        
                        <p>Entrou no programa em " + GlobalVariables.User.Joined.ToString("dd/MM/yyyy HH:mm:ss") + @"</p>
                        <br>
                        <p>Última mudança solicitada: " + lastRequest + @"</p>
                        <p>Mudança solicitada em " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + @"</p>
                        <p>Plano solicitado: " + type + @"</p>
                    </div>
                </div>";

            SendEmail(administrationEmail, subject, body);
        }
        // <-----------------------------------------------------------------------------------------
    }
}
