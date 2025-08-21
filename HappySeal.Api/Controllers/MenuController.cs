using HappySeal.Api.Data;

using Microsoft.AspNetCore.Mvc;

namespace HappySeal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : Controller
    {
        private readonly IMenuRepo _menuRepo;

        public MenuController(IMenuRepo menuRepo)
        {
            _menuRepo = menuRepo;
        }

        [HttpGet]
        public IActionResult GetAllMenues()
        {
            return Ok(_menuRepo.GetAllMenus);
        }

        [HttpGet("{id}")]
        public IActionResult GetMenuById(int id)
        {
            return Ok(_menuRepo.GetMenuById(id));
        }
    }
}
