using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Data;
using PlatformService.Dtos;

namespace PlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController(IPlatformRepo repository, IMapper mapper) : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
        {
            Console.WriteLine("--> Getting Platforms...");

            var platforms = repository.GetAllPlatforms();

            return Ok(mapper.Map<IEnumerable<PlatformReadDto>>(platforms));
        }
    }
}
