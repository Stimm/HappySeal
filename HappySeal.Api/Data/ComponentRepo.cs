using HappySeal.Shared.Domain;

namespace HappySeal.Api.Data
{
    public class ComponentRepo : IComponentRepo
    {
        private AppDBContext _dbContext;

        public ComponentRepo(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Component GetComponentById(int id)
        {
            return _dbContext.Components.FirstOrDefault(c => c.ComponentId == id);
        }

        public void UpdateComponentRepo(Component component)
        {
            var componentToUpdate = _dbContext.Components.FirstOrDefault(c => c.ComponentId == component.ComponentId);
            _dbContext.Components.Entry(componentToUpdate).CurrentValues.SetValues(component);

            _dbContext.SaveChanges();
        }
    }
}
