using HappySeal.Shared.Domain;

namespace HappySeal.Api.Data
{
    public interface IMealRepo
    {
        Meal GetMealById(int id);
        void UpdateMeal(Meal meal);
        Meal CreateMeal(Meal meal);
    }
}
