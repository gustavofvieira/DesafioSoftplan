using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioSoftplan.Domain.ViewModels
{
    public class CalculaJurosVM
    {
        private readonly string _baseUrlJuros = "taxaJuros";
        public double ValorInical { get; set; }
        public int Meses { get; set; }

        public double ConsultaTaxaJuros()
        {

            return 0.01;
        }
        public double CalculaJuros(CalculaJurosVM calculaJurosVM)
        {
           
            var juros = Math.Round(Math.Pow(calculaJurosVM.ValorInical * (1 + ConsultaTaxaJuros()), calculaJurosVM.Meses) / Math.Pow(10,8), 2);

           // var pw = Math.Pow(juros, calculaJurosVM.Meses);
            return juros;
        }



        private readonly string _baseUrlServidor = "api/servidor";
        private readonly string _baseUrlServidorImagem = "api/servidorImagem";
        private readonly RequestService _requestService;
        public HubProdebService(IAcessInfoHubProdeb accessInfo)
        {
            _requestService = new RequestService(accessInfo);
        }

        public ServidorVM CadastrarImagem(ServidorVM servidorVM)
        {
            return _requestService.MakeRequest<ServidorVM>(_baseUrlServidor + "/cadastrarimagem/", Method.POST, servidorVM);
        }
        public virtual TEntity MakeRequest<TEntity>(string path, Method method, object payload = null, List<Parameter> parameters = null)
        {
            var request = CreateRestRequest(path, method, payload, parameters);

            var client = RequestEngine.CreateClient(_accessInfo);

            var response = RequestEngine.ExecuteRequest<TEntity>(client, request, _accessInfo);

            return response;
        }
    }
}
