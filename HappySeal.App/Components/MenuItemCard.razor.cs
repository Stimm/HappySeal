using HappySeal.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace HappySeal.App.Components
{
    public partial class MenuItemCard
    {
        [Parameter]
        public MenuItem MenuItem { get; set; } = default!;

        [Parameter]
        public EventCallback<MenuItem> MenuItemQuickView { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public void NavagaitToMealDetails(Meal selectedMeal)
        {
            NavigationManager.NavigateTo($"/mealdetails/{selectedMeal.MealId}");
        }

    }
}
