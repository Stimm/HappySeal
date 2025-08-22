using HappySeal.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace HappySeal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealController : Controller
    {
        private IMealRepo _mealRepo;

        public MealController(IMealRepo mealRepo)
        {
            _mealRepo = mealRepo;
        }


        [HttpGet("{id}")]
        public IActionResult GetMealById(int id)
        {
            return Ok(_mealRepo.GetMealById(id));
        }
    }
}
