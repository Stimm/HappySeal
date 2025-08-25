using HappySeal.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace HappySeal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : Controller
    {
        private IIngredientRepo _ingredientRepo;

        public IngredientController(IIngredientRepo ingredientRepo)
        {
            _ingredientRepo = ingredientRepo;
        }

        [HttpGet]
        public IActionResult GetAllMenues()
        {
            return Ok(_ingredientRepo.GetAllIngredients());
        }
    }
}
