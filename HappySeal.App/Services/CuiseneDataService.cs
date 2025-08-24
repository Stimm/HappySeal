using HappySeal.Shared.Domain;
using System.Text.Json;

namespace HappySeal.App.Services
{
    public class CuiseneDataService : ICuiseneDataService
    {
        private readonly HttpClient _httpClient;

        public CuiseneDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Cuisene>> GetAllCuisenes()
        {
            
            var result = await JsonSerializer.DeserializeAsync<IEnumerable<Cuisene>>
                (await _httpClient.GetStreamAsync($"api/Cuisene"), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return result;
        }
    }
}
