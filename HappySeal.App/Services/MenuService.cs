using HappySeal.Shared.Domain;
using System.Text.Json;

namespace HappySeal.App.Services
{
    public class MenuService : IMenuService
    {
        private HttpClient _httpClient { get; set; }

        public MenuService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Menu> GetMenuById(int id)
        {
            var result =  await JsonSerializer.DeserializeAsync<Menu>
                (await _httpClient.GetStreamAsync($"api/Menu/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            return result;
        }
    }
}
