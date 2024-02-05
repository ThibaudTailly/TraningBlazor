using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using TrainingApiBlizzard.Model;
using TrainingApiBlizzard.Service.Interface;

namespace TrainingApiBlizzard.Service
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
            string urlDiablo =  $"{_httpClient.BaseAddress} {_configuration.Value.GetActUrl}";
            var response =  await _httpClient.GetStringAsync(urlDiablo);
            DiabloActs? diabloActs = JsonConvert.DeserializeObject<DiabloActs>(response);

            return diabloActs;
        } 
    }
}
