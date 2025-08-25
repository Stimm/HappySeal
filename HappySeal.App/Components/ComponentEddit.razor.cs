using HappySeal.App.Services;
using HappySeal.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace HappySeal.App.Components
{
    public partial class ComponentEddit
    {
        [Inject]
        IIngredientDataService IngredientDataService { get; set; }
        [Inject]
        IComponentDataService ComponentDataService { get; set; }

        [Parameter]
        public List<Component> Components { get; set; } = new List<Component>();

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        protected async override Task OnInitializedAsync()
        {
            Ingredients = await IngredientDataService.GetAllIngredients();
        }

        protected async Task HandleValidSubmit(Component component)
        {
            if (component.ComponentId== 0)
            {
                //Create new meal
            }
            else
            {
                await ComponentDataService.UpdateComponent(component);
            }
        }
    }
}
