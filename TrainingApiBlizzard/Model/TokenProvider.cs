using TrainingApiBlizzard.Model.Interface;

namespace TrainingApiBlizzard.Model
{
    public class TokenProvider : ITokenProvider
    {
        private readonly HttpClient _httpClient;

        public TokenProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> GetAccessToken()
        {
            var clientId = "0902f3db20294b9bac76fbe25c905264";
            var clientSecret = "BrPuG1B4x1AiE3H592cJKTUWoqhN4bz1";

            var tokenUrl = "https://oauth.battle.net/token";
            var parameters = new Dictionary<string, string>
            {
            { "grant_type", "client_credentials" },
            { "client_id", clientId },
            { "client_secret", clientSecret }
            };

            var response = await _httpClient.PostAsync(tokenUrl, new FormUrlEncodedContent(parameters));
            response.EnsureSuccessStatusCode();

            var tokenResponse = await response.Content.ReadFromJsonAsync<TokenResponse>();

            return tokenResponse.access_token;
        }
    }
}
