using HappySeal.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace HappySeal.App.Components
{
    public partial class MenuItemCard
    {
        [Parameter]
        public MenuItem MenuItem { get; set; } = default!;

    }
}
