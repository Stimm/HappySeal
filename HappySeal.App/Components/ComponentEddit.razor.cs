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
        public List<Component> Components { get; set; } 

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        protected async override Task OnInitializedAsync()
        {
            Ingredients = await IngredientDataService.GetAllIngredients();
            if (Components[0].ComponentId == 0)
            {
                Components[0].IngredientId = Ingredients[0].IngredientId;
            }
        }

        protected async Task HandleValidSubmit(Component component)
        {
            if (component.ComponentId != 0)
            {
                await ComponentDataService.UpdateComponent(component);
            }
        }

        public async Task RemoveComponent(Component component)
        {
            if(component.ComponentId != 0)
            {
                var result = ComponentDataService.DeleteComponent(component.ComponentId);
            }
            Components.Remove(component);
        }
    }
}
