using TrainingApiBlizzard.Model;

namespace TrainingApiBlizzard.Service.Interface
{
    public interface IDiabloService
    {
        Task<DiabloActs?> GetActAsync();
    }
}
