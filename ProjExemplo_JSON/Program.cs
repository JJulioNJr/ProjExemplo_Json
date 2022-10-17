using Refit;
using System;
using System.Threading.Tasks;

namespace ProjExemplo_JSON {
    internal class Program {
        static async Task Main(string[] args) {
           
            try {
                var cepCliente = RestService.For<ICepApiServices>("http://viacep.com.br");
                Console.Write("Digite o seu Cep: ");
                String cepInformado = Console.ReadLine().ToString();
                
                Console.WriteLine("\nConsultando Informações do Cep: " +cepInformado);
                var address =await cepCliente.GetAdressAsync(cepInformado);
                Console.WriteLine(address.ToString());
                
                Console.ReadKey();

            } catch (Exception ex) {
                Console.WriteLine("\nErro nos Regsitros Criados..."+ex.Message);
            }
        }
    }
}
