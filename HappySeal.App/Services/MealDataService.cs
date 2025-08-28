using HappySeal.Shared.Domain;
using System.Text;
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

        public Task UpdateMeal(Meal meal)
        {
            var mealJson = new StringContent(JsonSerializer.Serialize(meal), Encoding.UTF8, "application/json");

            return _httpClient.PutAsync("api/meal", mealJson);
        }

        public async Task<Meal> CreateMeal(Meal meal)
        {
            //var otherMeal = await JsonSerializer.DeserializeAsync<Meal>
            //    (await _httpClient.GetStreamAsync($"api/Meal/{1}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            //otherMeal.Discription = string.Empty;

            var mealJson = (new StringContent(JsonSerializer.Serialize(meal), Encoding.UTF8,
                "application/json"));

            var response = await _httpClient.PostAsync($"api/meal", mealJson);
            response.EnsureSuccessStatusCode();

            var responseStream = await response.Content.ReadAsStreamAsync();

            var createdMeal = await JsonSerializer.DeserializeAsync<Meal>(responseStream, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // This option handles JSON properties being case-insensitive
            });
            return createdMeal;
        }

        public async Task<List<Meal>> GetAllMeals()
        {
            return await JsonSerializer.DeserializeAsync<List<Meal>>
                (await _httpClient.GetStreamAsync($"api/meal"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<HttpResponseMessage>? DeleteMeal(int id)
        {
            var result = await _httpClient.DeleteAsync($"api/meal/{id}");
            
            return result;
        }
    }
}
