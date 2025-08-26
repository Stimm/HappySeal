using HappySeal.Shared.Domain;

namespace HappySeal.App.Services
{
    public interface IComponentDataService
    {
        Task UpdateComponent(Component component);
        Task<HttpResponseMessage> DeleteComponent(int id);
    }
}
