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
        public HttpClient _httpClient { get; set; }
        [Inject]
        public IMenuService? MenuService { get; set; }

        public Menu Menu{ get; set; } = default!;
        public MenuItem? _selectedMenuItem { get; set; }

        protected async override Task OnInitializedAsync()
        {

            Menu = await MenuService.GetMenuById(1);

            //Menu = await _httpClient.GetFromJsonAsync<Menu>("https://localhost:7117/api/Menu");

            //var test = 1;
        }

        public void ShowQuickViewPopUp(MenuItem selectedMenuItem)
        {
            _selectedMenuItem = selectedMenuItem;
        }
    }
}
