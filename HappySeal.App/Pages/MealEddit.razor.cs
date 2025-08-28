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
        public Meal? Meal { get; set; } = new Meal();
        public List<Cuisene> Cuisenes { get; set; } = new List<Cuisene>();
        public List<Component> Components { get; set; } = new List<Component>();
        protected async override Task OnInitializedAsync()
        {
            Cuisenes = (await CuiseneDataService.GetAllCuisenes()).ToList();

            if (MealId != null)
            {
                Meal = await MealDataService.GetMealById(int.Parse(MealId));
                Components = Meal.Recipe.Components;
            }
            else
            {
                Meal.Cuisene = new Cuisene();
                Meal.CuiseneId = Cuisenes[0].CuiseneId;
                Meal.Recipe = new Recipe();
                Meal.Recipe.Components = Components;

            }
        }

        protected async Task HandleValidSubmit()
        {
            if(Meal.MealId == 0)
            {                
                Meal = await MealDataService.CreateMeal(Meal);
            }
            else
            {
                await MealDataService.UpdateMeal(Meal);
                Meal = await MealDataService.GetMealById(int.Parse(MealId));
                
            }
            Components = Meal.Recipe.Components;
        }

        protected async Task HandleInvalidSubmit()
        {

        }

        private void AddNewComponent()
        {
            Components.Add(new Component() {Ingredient = new Ingredient() });
        }
    }
}
