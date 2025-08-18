using HappySeal.App.Models;
using HappySeal.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace HappySeal.App.Pages
{
    public partial class MealDetails
    {
        [Parameter]
        public string MealId { get; set; }

        public Meal Meal { get; set; }

        protected override void OnInitialized()
        {
            Meal = MockDataService.GetMealById(MealId);
        }
    }
}
