using HappySeal.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace HappySeal.App.Pages
{
    public partial class MealDetails
    {
        [Parameter]
        public Meal Meal { get; set; }

    }
}
