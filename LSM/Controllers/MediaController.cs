using AutoMapper;
using LSM.Dto;
using LSM.Services.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LSM.Controllers
{
    [ApiController]
    [Route("media")]
    public class MediaController : Controller
    {
        private readonly ISearchService<MediaDto> searchService;

        public MediaController(ISearchService<MediaDto> searchService)
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
