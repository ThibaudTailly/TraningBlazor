using DomaineLayer.Model;
using System.Net.Http.Headers;

namespace TrainingApiBlizzard.Service
{
    public class AuthHandler : DelegatingHandler
    {
        private readonly ITokenProvider _accessTokenProvider;

        public AuthHandler(ITokenProvider accessTokenProvider)
        {
            _accessTokenProvider = accessTokenProvider;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var accessToken = await _accessTokenProvider.GetAccessToken();

            if (!string.IsNullOrEmpty(accessToken))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }

}
