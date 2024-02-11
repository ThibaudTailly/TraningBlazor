 namespace DomaineLayer.Model;

public interface ITokenProvider
{
    Task<string> GetAccessToken();
}
