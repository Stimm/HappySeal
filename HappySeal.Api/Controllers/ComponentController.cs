using HappySeal.Api.Data;
using HappySeal.Shared.Domain;
using Microsoft.AspNetCore.Mvc;

namespace HappySeal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentController : Controller
    {

        private IComponentRepo _componentRepo;

        public ComponentController(IComponentRepo componentRepo)
        {
            _componentRepo = componentRepo;
        }

        [HttpPut]
        public IActionResult UpdateComponent([FromBody] Component component)
        {
            if (component == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var componentToUpdate = _componentRepo.GetComponentById(component.ComponentId);

            if (componentToUpdate == null)
            {
                return BadRequest();
            }

            _componentRepo.UpdateComponentRepo(component);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteComponent(int id)
        {
                var componentToDelete = _componentRepo.GetComponentById(id);

                if(componentToDelete == null)
                {
                    return BadRequest();
                }

            _componentRepo.DeleteComponent(id);

            return Ok();
        }
    }
}
