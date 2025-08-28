using HappySeal.Shared.Domain;

namespace HappySeal.App.Services
{
    public interface IMenuService
    {
        Task<Menu> GetMenuById(int id);
        Task<List<Menu>> GetAllMenus();
    }
}
