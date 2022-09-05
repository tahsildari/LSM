using AutoMapper;
using LSM.Dto;
using LSM.Services.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LSM.Controllers
{
    [ApiController]
    [Route("groups")]
    public class GroupController : Controller
    {
        private readonly ISearchService<GroupDto> searchService;

        public GroupController(ISearchService<GroupDto> searchService)
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
