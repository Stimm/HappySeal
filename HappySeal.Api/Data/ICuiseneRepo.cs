using HappySeal.Shared.Domain;

namespace HappySeal.Api.Data
{
    public interface ICuiseneRepo
    {
        List<Cuisene> GetAllCuisenes();
    }
}
