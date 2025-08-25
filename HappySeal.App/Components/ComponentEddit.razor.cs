using HappySeal.App.Services;
using HappySeal.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace HappySeal.App.Components
{
    public partial class ComponentEddit
    {
        [Inject]
        IIngredientDataService IngredientDataService { get; set; }

        [Parameter]
        public List<Component> Components { get; set; } = new List<Component>();

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        protected async override Task OnInitializedAsync()
        {
            Ingredients = await IngredientDataService.GetAllIngredients();
        }
    }
}
