using AutoMapper;
using LSM.Dto;
using LSM.Services.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LSM.Controllers
{
    [ApiController]
    [Route("buildings")]
    public class BuildingController : Controller
    {
        private readonly ISearchService<BuildingDto> searchService;

        public BuildingController(ISearchService<BuildingDto> searchService)
        {
            this.searchService=searchService;

        }

        [HttpGet]
        public IActionResult Index([FromQuery] string searchBy)
        {
            var result = searchService.Search(searchBy);
            return Ok(result);
        }
    }
}
