using HappySeal.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace HappySeal.App.Services
{
    public class IngredientDataService : IIngredientDataService
    {
        [Inject]
        private HttpClient _httpClient { get; set; }

        public IngredientDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Ingredient>> GetAllIngredients()
        {
            return await JsonSerializer.DeserializeAsync<List<Ingredient>>
                (await _httpClient.GetStreamAsync($"api/ingredient"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
