using HappySeal.Shared.Domain;

namespace HappySeal.Api.Data
{
    public interface IMealRepo
    {
        Meal GetMealById(int id);
    }
}
