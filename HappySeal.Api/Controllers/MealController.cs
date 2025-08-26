using HappySeal.Api.Data;
using HappySeal.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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

        [HttpPut]
        public IActionResult UpdateMeal([FromBody] Meal meal)
        {
            if(meal == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var mealToUpdate = _mealRepo.GetMealById(meal.MealId);
            if(mealToUpdate == null)
            {
                return BadRequest();
            }

            _mealRepo.UpdateMeal(meal);
            return NoContent();
        }
    }
}
