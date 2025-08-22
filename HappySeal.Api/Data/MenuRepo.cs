using HappySeal.Shared.Domain;

namespace HappySeal.Api.Data
{
    public class MenuRepo : IMenuRepo
    {
        private readonly AppDBContext _appDBContext;
        public MenuRepo(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public IEnumerable<Menu> GetAllMenus()
        {
            return _appDBContext.Menu;
        }

        public Menu GetMenuById(int id)
        {
            var result = _appDBContext.Menu.Where(m => m.MenuId == id).FirstOrDefault();
            result.MenueItems = _appDBContext.MenuItems.Where(mi => mi.MenuId == id).ToList();

            foreach(var menuItem in result.MenueItems){
                menuItem.Meal = _appDBContext.Meals.Where(me => me.MealId == menuItem.MealId).FirstOrDefault();
                menuItem.Meal.Cuisene = _appDBContext.Cuisenes.Where(c => c.CuiseneId == menuItem.Meal.CuiseneId).FirstOrDefault();
                menuItem.Meal.Recipe = _appDBContext.Recipes.Where(r => r.MealId == menuItem.Meal.MealId).FirstOrDefault();
                menuItem.Meal.Recipe.Components = _appDBContext.Components.Where(co => co.RecipeId == menuItem.Meal.Recipe.RecipeId).ToList();

                foreach (var component in menuItem.Meal.Recipe.Components)
                {
                    component.Ingredient = _appDBContext.Ingredients.Where(i => i.IngredientId == component.IngredientId).FirstOrDefault();
                }
            }

            return result;
        }
    }
}
