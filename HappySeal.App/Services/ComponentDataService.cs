using HappySeal.Shared.Domain;
using System.Text;
using System.Text.Json;

namespace HappySeal.App.Services
{
    public class ComponentDataService : IComponentDataService
    {
        private readonly HttpClient _httpClient;

        public ComponentDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task UpdateComponent(Component component)
        {
            var componentJson = new StringContent(JsonSerializer.Serialize(component), Encoding.UTF8, "application/json");
            return _httpClient.PutAsync("api/component", componentJson);
        }
    }
}
