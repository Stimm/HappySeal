using HappySeal.Shared.Domain;
using System.Text.Json;

namespace HappySeal.App.Services
{
    public class MealDataService : IMealDataService
    {
        private HttpClient _httpClient { get; set; }

        public MealDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Meal> GetMealById(int id)
        {
            return await JsonSerializer.DeserializeAsync<Meal>
                (await _httpClient.GetStreamAsync($"api/Meal/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
