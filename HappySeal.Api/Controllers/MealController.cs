using HappySeal.Api.Data;
using HappySeal.Shared.Domain;
using Microsoft.AspNetCore.Http.HttpResults;
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
        public ActionResult<Meal> GetMealById(int id)
        {
            return Ok(_mealRepo.GetMealById(id));
        }

        [HttpPost]
        public ActionResult<Meal> CreateMeal([FromBody] Meal meal)
        {
            if (meal == null)
                return BadRequest();


            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdMeal = _mealRepo.CreateMeal(meal);
            return CreatedAtAction(nameof(GetMealById), new { id = createdMeal.MealId }, createdMeal); 
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
