using HappySeal.App.Models;
using HappySeal.Shared.Domain;

namespace HappySeal.App.Pages
{
    public partial class MenuOverView
    {
        public Menu Menu{ get; set; }
        public MenuItem? _SelectedMenuItem { get; set; }

        protected override void OnInitialized()
        {
            Menu = MockDataService.Menu;
        }
    }
}
