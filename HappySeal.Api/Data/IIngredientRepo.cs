using HappySeal.Shared.Domain;

namespace HappySeal.Api.Data
{
    public interface IIngredientRepo
    {
        IEnumerable<Ingredient> GetAllIngredients();
    }
}
