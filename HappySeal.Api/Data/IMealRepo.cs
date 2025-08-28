using HappySeal.Shared.Domain;

namespace HappySeal.Api.Data
{
    public interface IMealRepo
    {
        IEnumerable<Meal> GetAllMeals();
        Meal GetMealById(int id);
        void UpdateMeal(Meal meal);
        Meal CreateMeal(Meal meal);
        void DeleteMeal(int id);
    }
}
