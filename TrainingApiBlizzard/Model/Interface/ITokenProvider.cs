namespace TrainingApiBlizzard.Model.Interface
{
    public interface ITokenProvider
    {
        Task<string> GetAccessToken();
    }
}
