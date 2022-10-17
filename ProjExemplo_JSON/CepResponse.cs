using Newtonsoft.Json;
using System;
using System.Net;

namespace ProjExemplo_JSON
{
    public class CepResponse{

        [JsonProperty("cep")]
        public String Cep { get; set; }
        [JsonProperty("logradouro")]
        public String Logradouro { get; set; }
        [JsonProperty("complemento")]
        public String Complemento { get; set; }
        [JsonProperty("bairro")]
        public String Bairro { get; set; }
        [JsonProperty("localidade")]
        public String Localidade { get; set; }
        [JsonProperty("uf")]
        public String UF { get; set; }
        [JsonProperty("ibge")]
        public  String Ibge { get; set; }
        [JsonProperty("gia")]
        public String Gia { get; set; }
        [JsonProperty("ddd")]
        public String  Ddd { get; set; }
        [JsonProperty("siafi")]
        public String  Siafi  { get; set; }

        public override string ToString() {
            return $"ID:{this.Cep}\nLogradouro: {this.Logradouro}\nComplemento: {this.Complemento}\nBairro: {this.Bairro}" +
            $"Localidade: {this.Localidade}\nUf: {this.UF}\nIbge: {this.Ibge}\nGia: {this.Gia}\nDdd: {this.Ddd}\nSiafi: {this.Siafi}"; 
        }
    }

}
