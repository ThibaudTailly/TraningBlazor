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
            var clientSecret = "jOAu1r5lmE0Tg1H4MXj5uRBs7ZrkJ7pw";

            var tokenUrl = "https://oauth.battle.net/token";
            var parameters = new Dictionary<string, string>
            {
                {"grand_type","client_credentials"},
                {"client_id",clientId },
                {"client_secret", clientSecret }
            };

            // endroit ou receptionner le token de reponse
            //var reponse 
            var stringTokenReponse ="";
            return stringTokenReponse;

        }
    }
}
