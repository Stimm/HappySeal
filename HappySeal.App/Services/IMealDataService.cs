using HappySeal.Shared.Domain;
using System.Threading.Tasks;

namespace HappySeal.App.Services
{
    public interface IMealDataService
    {
        Task<List<Meal>> GetAllMeals();
        Task<Meal> GetMealById(int id);
        Task UpdateMeal(Meal meal);
        Task<Meal> CreateMeal(Meal meal);
        Task<HttpResponseMessage> DeleteMeal(int id);
    }
}
