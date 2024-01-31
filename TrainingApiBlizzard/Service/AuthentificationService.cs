using TrainingApiBlizzard.Model;

namespace TrainingApiBlizzard.Service
{
    public class AuthentificationService
    {
        private readonly HttpClient _httpClient;


        public AuthentificationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<string?> GetAccessTokenAsync()
        {
            var clientId = "29dd723dc3104df695a1e9e87b42cdfa";
            var clientSecret = "j3RHFz0GVsWr22B6LsIJHWbfSdd9kBtF";

            var tokenUrl = "https://oauth.battle.net/token";
            var parameters = new Dictionary<string, string>
            {
                {"grant_type","client_credentials"},
                {"client_id",clientId },
                {"client_secret", clientSecret }
            };

            // endroit ou receptionner le token de reponse
            //var reponse 
            var stringTokenReponse = await _httpClient.PostAsync(tokenUrl, new FormUrlEncodedContent(parameters));
            
            var reponse = await stringTokenReponse.Content.ReadFromJsonAsync<TokenResponse>();

            return reponse?.access_token;

        }
    }
}
