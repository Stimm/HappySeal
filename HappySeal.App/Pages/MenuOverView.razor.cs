using HappySeal.App.Models;
using HappySeal.App.Services;
using HappySeal.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace HappySeal.App.Pages
{
    public partial class MenuOverView
    {
        [Inject]
        public IMenuService? MenuService { get; set; }

        public Menu Menu{ get; set; } = default!;
        public MenuItem? _selectedMenuItem { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Menu = await MenuService.GetMenuById(1);
        }

        public void ShowQuickViewPopUp(MenuItem selectedMenuItem)
        {
            _selectedMenuItem = selectedMenuItem;
        }
    }
}
