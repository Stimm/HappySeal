using HappySeal.App.Services;
using HappySeal.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace HappySeal.App.Pages
{
    public partial class MealEddit
    {
        [Inject]
        IMealDataService MealDataService { get; set; }
        [Inject]
        ICuiseneDataService CuiseneDataService { get; set; }


        [Parameter]
        public string MealId { get; set; }
        public Meal Meal { get; set; } = new Meal();
        public List<Cuisene> Cuisenes { get; set; } = new List<Cuisene>();
        public List<Component> Components { get; set; } = new List<Component>();
        protected async override Task OnInitializedAsync()
        {
            Meal = await MealDataService.GetMealById(int.Parse(MealId));
            Cuisenes = (await CuiseneDataService.GetAllCuisenes()).ToList();
            Components = Meal.Recipe.Components;
        }

        protected async Task HandleValidSubmit()
        {
            if(Meal.MealId == 0)
            {
                //Create new meal
            }
            else
            {
                await MealDataService.UpdateMeal(Meal);
                Meal = await MealDataService.GetMealById(int.Parse(MealId));
                Components = Meal.Recipe.Components;
            }
        }

        protected async Task HandleInvalidSubmit()
        {

        }

        private void AddNewComponent()
        {
            Components.Add(new Component());
        }
    }
}
