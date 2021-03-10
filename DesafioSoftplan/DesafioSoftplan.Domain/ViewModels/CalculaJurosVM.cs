using DesafioSoftplan.Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSoftplan.Domain.ViewModels
{
    public class CalculaJurosVM
    {
        /*
         Body -> raw -> Json
        {
           "ValorInical": 100,
            "Meses": 5
         }
         
         */

        string uri = "https://localhost:44303/taxaJuros";

        public double ValorInical { get; set; }
        public int Meses { get; set; }


        public double CalculaJuros(CalculaJurosVM calculaJurosVM)
        {
            var juros = Math.Round(Math.Pow(calculaJurosVM.ValorInical * (1 + ConsultaTaxaJuros().Result), calculaJurosVM.Meses) / Math.Pow(10, 8), 2); 
            return juros;
        }

        public async Task<double> ConsultaTaxaJuros()
        {
            try
            {
                double taxa;
                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(uri))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var Json = await response.Content.ReadAsStringAsync();
                            taxa = JsonConvert.DeserializeObject<double>(Json);
                            return taxa;
                        }
                    }
                }
                return 0;

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        private double BadRequest(string message)
        {
            throw new NotImplementedException();
        }
    }
}
