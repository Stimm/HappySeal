using HappySeal.Shared.Domain;

namespace HappySeal.Api.Data
{
    public class IngredientRepo : IIngredientRepo
    {
        private readonly AppDBContext _appDBContext;

        public IngredientRepo(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public IEnumerable<Ingredient> GetAllIngredients()
        {
            return _appDBContext.Ingredients;
        }
    }
}
