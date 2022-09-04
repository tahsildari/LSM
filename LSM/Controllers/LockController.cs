using AutoMapper;
using LSM.Dto;
using LSM.Services.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LSM.Controllers
{
    [ApiController]
    [Route("buildings")]
    public class LockController : Controller
    {
        private readonly ISearchService<LockDto> searchService;

        public LockController(ISearchService<LockDto> searchService)
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
