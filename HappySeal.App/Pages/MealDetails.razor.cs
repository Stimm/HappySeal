using HappySeal.App.Services;
using HappySeal.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace HappySeal.App.Pages
{
    public partial class MealDetails
    {
        [Inject]
        public IMealDataService? MealDataService { get; set; }

        [Parameter]
        public string MealId { get; set; }

        public Meal Meal { get; set; } = new Meal();

        protected async override Task OnInitializedAsync()
        {         
            Meal = await MealDataService.GetMealById(int.Parse(MealId));
        }
    }
}
