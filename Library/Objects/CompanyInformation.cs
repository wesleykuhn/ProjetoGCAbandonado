using Newtonsoft.Json.Linq;
using GC.Library.Web;

namespace GC.Library.Objects
{
    internal class CompanyInformation
    {
        internal string Status { get; set; }
        internal string Cnpj { get; set; }
        internal string Tipo { get; set; }
        internal string Abertura { get; set; }
        internal string Nome { get; set; }
        internal string Fantasia { get; set; }
        internal string Logradouro { get; set; }
        internal string Numero { get; set; }
        internal string Complemento { get; set; }
        internal string Cep { get; set; }
        internal string Bairro { get; set; }
        internal string Municipio { get; set; }
        internal string UF { get; set; }
        internal string Email { get; set; }
        internal string Telefone { get; set; }

        internal CompanyInformation(string cnpj)
        {
            JObject parsedObject = JObject.Parse(HttpRequest.Get(@"https://www.receitaws.com.br/v1/cnpj/" + cnpj));

            this.Status = parsedObject.Value<string>("status");
            this.Cnpj = parsedObject.Value<string>("cnpj");
            this.Tipo = parsedObject.Value<string>("tipo");
            this.Abertura = parsedObject.Value<string>("abertura");
            this.Nome = parsedObject.Value<string>("nome");
            this.Fantasia = parsedObject.Value<string>("fantasia");
            this.Logradouro = parsedObject.Value<string>("logradouro");
            this.Numero = parsedObject.Value<string>("numero");
            this.Complemento = parsedObject.Value<string>("complemento");
            this.Cep = parsedObject.Value<string>("cep");
            this.Bairro = parsedObject.Value<string>("bairro");
            this.Municipio = parsedObject.Value<string>("municipio");
            this.UF = parsedObject.Value<string>("uf");
            this.Email = parsedObject.Value<string>("email");
            this.Telefone = parsedObject.Value<string>("telefone");
        }
    }
}
