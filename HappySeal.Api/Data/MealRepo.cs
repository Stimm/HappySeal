using HappySeal.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HappySeal.Api.Data
{
    public class MealRepo : IMealRepo
    {
        private readonly AppDBContext _appDBContext;

        public MealRepo(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public Meal CreateMeal(Meal meal)
        {
            var components = meal.Recipe.Components;

            var newMeal = meal;
            newMeal.Cuisene = _appDBContext.Cuisenes.Where(c => c.CuiseneId == newMeal.CuiseneId).FirstOrDefault();

            var newRecipe = new Recipe();

            var newComponentList = new List<Component>();
            foreach(var component in components)
            {
                var newComponent = new Component();
                newComponent.amount = component.amount;
                newComponent.IngredientId = component.IngredientId;
                newComponent.Measurement = component.Measurement;
                newComponent.Ingredient = _appDBContext.Ingredients.Where(i => i.IngredientId == component.IngredientId).FirstOrDefault();
                newComponentList.Add(newComponent);
            }
            newRecipe.Components = newComponentList;
            newMeal.Recipe = newRecipe;

            _appDBContext.Meals.Add(newMeal);
            
            newMeal.Recipe.MealId = newMeal.MealId;
            _appDBContext.Recipes.Add(newRecipe);

            foreach (var component in newComponentList)
            {
                component.RecipeId = newRecipe.RecipeId;
                _appDBContext.Components.Add(component);
            }
            _appDBContext.SaveChanges();

            return newMeal;
        }

        public void DeleteMeal(int id)
        {
            var recipeToDelete = _appDBContext.Recipes.Where(r => r.MealId == id).FirstOrDefault();
            var componentsToDelete = _appDBContext.Components.Where(c => c.RecipeId == recipeToDelete.RecipeId);
            var mealToDelete = _appDBContext.Meals.Where(m => m.MealId == id).FirstOrDefault();

            _appDBContext.Remove(recipeToDelete);
            _appDBContext.RemoveRange(componentsToDelete);
            _appDBContext.Remove(mealToDelete);
            _appDBContext.SaveChanges();
        }

        public IEnumerable<Meal> GetAllMeals()
        {
            return _appDBContext.Meals;
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

        public void UpdateMeal(Meal meal)
        {
            var _mealToUpdate = _appDBContext.Meals.FirstOrDefault(m => m.MealId == meal.MealId);

            _appDBContext.Meals.Entry(_mealToUpdate).CurrentValues.SetValues(meal);

            List<Component> ListOfNewComponents = meal.Recipe.Components.Where(c => c.ComponentId == 0).ToList();

            foreach (var component in ListOfNewComponents)
            {
                component.RecipeId = meal.Recipe.RecipeId;
                component.Ingredient = _appDBContext.Ingredients.Where(i => i.IngredientId == component.IngredientId).FirstOrDefault();
                _appDBContext.Components.Add(component);
            }

            _appDBContext.SaveChanges();
        }
    }
}
