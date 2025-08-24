using HappySeal.Shared.Domain;

namespace HappySeal.Api.Data
{
    public class CuiseneRepo : ICuiseneRepo
    {
        private AppDBContext _dbContext;

        public CuiseneRepo(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Cuisene> GetAllCuisenes()
        {
            return _dbContext.Cuisenes.ToList();
        }
    }
}
