using HappySeal.Shared.Domain;

namespace HappySeal.App.Services
{
    public interface ICuiseneDataService
    {
        Task<IEnumerable<Cuisene>> GetAllCuisenes();
    }
}
