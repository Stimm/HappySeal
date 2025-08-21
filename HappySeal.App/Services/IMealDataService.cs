using HappySeal.Shared.Domain;

namespace HappySeal.App.Services
{
    public interface IMealDataService
    {
        Task<Meal> GetMealById(int id);
    }
}
