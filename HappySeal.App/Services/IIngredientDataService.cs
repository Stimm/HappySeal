using HappySeal.Shared.Domain;

namespace HappySeal.App.Services
{
    public interface IIngredientDataService
    {
        Task<List<Ingredient>> GetAllIngredients();
    }
}
