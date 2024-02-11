using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using DataLayer;
using DataLayer.Service.Interface;
using DataLayer.DbModel;
using DataLayer.Model;

namespace DataLayer.Service
{
    public class DiabloService : IDiabloService
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<BlizzardSetting> _configuration;


        public DiabloService(IHttpClientFactory httpClient, IOptions<BlizzardSetting> configuration)
        {
            _httpClient = httpClient.CreateClient("DiabloClient");
            _configuration = configuration;
        }

        public async Task<DiabloActs?> GetActAsync()
        {
            string urlDiablo = $"{_httpClient.BaseAddress} {_configuration.Value.GetActUrl}";
            var response = await _httpClient.GetStringAsync(urlDiablo);
            DiabloActs? diabloActs = JsonConvert.DeserializeObject<DiabloActs>(response);

            return diabloActs;
        }
        //Fonction Get 
    }
}
