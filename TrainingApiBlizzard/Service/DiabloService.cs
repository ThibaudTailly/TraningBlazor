using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using TrainingApiBlizzard.Model;

namespace TrainingApiBlizzard.Service
{
    public class DiabloService
    {
        private readonly HttpClient _httpClient;
        private AuthentificationService _authenticationService;

        public DiabloService(HttpClient httpClient, AuthentificationService authenticationService)
        {
            _httpClient = httpClient;
            _authenticationService = authenticationService;
        }

        public async Task<DiabloActs?> GetActAsync()
        {
            string urlDiablo = "https://us.api.blizzard.com/d3/data/act?locale=en_US";
            var Token  = await _authenticationService.GetAccessTokenAsync();
            //Mets le token dans le header.
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            var response =  await _httpClient.GetStringAsync(urlDiablo);
            DiabloActs? diabloActs = JsonConvert.DeserializeObject<DiabloActs>(response);
            
            return diabloActs;

        } 
    }
}
