using HappySeal.Shared.Domain;

namespace HappySeal.Api.Data
{
    public interface IComponentRepo
    {
        void UpdateComponentRepo(Component component);

        Component GetComponentById(int id);

        void DeleteComponent(int id);
    }
}
