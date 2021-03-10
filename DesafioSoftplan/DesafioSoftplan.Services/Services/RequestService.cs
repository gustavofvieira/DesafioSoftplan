using DesafioSoftplan.Domain.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using System.Net.Http;
using System.Threading.Tasks;

namespace DesafioSoftplan.Services.Services
{
    public class RequestService : IRequestService
    {
        // GET: ConsomeCarros
        string uri = "https://localhost:44303/taxaJuros";
        public async Task<double> Index()
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
    }
}
