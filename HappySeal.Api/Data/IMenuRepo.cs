using HappySeal.Shared.Domain;

namespace HappySeal.Api.Data
{
    public interface IMenuRepo
    {
        IEnumerable<Menu> GetAllMenus();
        Menu GetMenuById(int id);
    }
}
