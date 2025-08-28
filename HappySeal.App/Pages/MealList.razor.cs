using HappySeal.App.Services;
using HappySeal.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace HappySeal.App.Pages
{
    public partial class MealList
    {
        [Inject]
        IMealDataService MealDataService{ get; set; }
        public List<Meal> Meals { get; set; } = new List<Meal>();

        protected async override Task OnInitializedAsync()
        {
            Meals = await MealDataService.GetAllMeals();
        }

        private async void RemoveMeal(Meal meal)
        {
            var result = await MealDataService.DeleteMeal(meal.MealId);

            Meals.Remove(meal);
            InvokeAsync(StateHasChanged);
        }
    }
}
