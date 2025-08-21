using HappySeal.Shared.Domain;

namespace HappySeal.Api.Data
{
    public class MealRepo : IMealRepo
    {
        private readonly AppDBContext _appDBContext;

        public MealRepo(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public Meal GetMealById(int id)
        {
            var results = _appDBContext.Meals.Where(m => m.MealId == id).FirstOrDefault();

            results.Cuisene = _appDBContext.Cuisenes.Where(c => c.CuiseneId == results.CuiseneId).FirstOrDefault();
            results.Recipe = _appDBContext.Recipes.Where(r => r.MealId == results.MealId).FirstOrDefault();
            results.Recipe.Components = _appDBContext.Components.Where(co => co.RecipeId == results.Recipe.RecipeId).ToList();

            foreach (var component in results.Recipe.Components)
            {
                component.Ingredient = _appDBContext.Ingredients.Where(i => i.IngredientId == component.IngredientId).FirstOrDefault();
            }

            return results;
        }
    }
}
