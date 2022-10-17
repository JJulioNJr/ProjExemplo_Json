using Refit;
using System;
using System.Threading.Tasks;

namespace ProjExemplo_JSON {
    public interface ICepApiServices {

        [Get("/ws/{cep}/json/")]
        Task<CepResponse> GetAdressAsync(String cep);
    }
}
      
