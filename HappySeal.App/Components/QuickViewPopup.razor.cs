using HappySeal.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace HappySeal.App.Components
{
    public partial class QuickViewPopup
    {
        
        private MenuItem? _menuItem { get; set; }

        [Parameter]
        public MenuItem? MenuItem { get; set; }

        protected override void OnParametersSet()
        {
            _menuItem = MenuItem;
        }

        public void Close()
        {
            _menuItem = null;
        }
    }
}
