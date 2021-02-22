using GC.Library.Web;
using Newtonsoft.Json.Linq;

namespace GC.Library.Objects
{
    internal class Cep
    {
        internal string Logradouro { get; set; }
        internal string Complemento { get; set; }
        internal string Bairro { get; set; }
        internal string Localidade { get; set; }
        internal string Uf { get; set; }

        public Cep(string cep)
        {
            try
            {
                JObject parsedObject = JObject.Parse(HttpRequest.Get("https://viacep.com.br/ws/" + cep + "/json/"));

                this.Logradouro = parsedObject.Value<string>("logradouro");
                this.Complemento = parsedObject.Value<string>("complemento");
                this.Bairro = parsedObject.Value<string>("bairro");
                this.Localidade = parsedObject.Value<string>("localidade");
                this.Uf = parsedObject.Value<string>("uf");
            }
            catch (System.Exception)
            {
                this.Logradouro = null;
                this.Complemento = null;
                this.Bairro = null;
                this.Localidade = null;
                this.Uf = null;
            }            
        }
    }
}
