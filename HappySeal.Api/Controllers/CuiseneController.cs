using HappySeal.Api.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HappySeal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuiseneController : Controller
    {
        private ICuiseneRepo _cuiseneRepo;

        public CuiseneController(ICuiseneRepo cuiseneRepo)
        {
            this._cuiseneRepo = cuiseneRepo;
        }

        [HttpGet]
        public IActionResult GetAllCuisenes()
        {
            return Ok(_cuiseneRepo.GetAllCuisenes());
        }
    }
}
