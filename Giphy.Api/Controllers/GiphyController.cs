using System.Threading.Tasks;
using Giphy.Lib.Services;
using Microsoft.AspNetCore.Mvc;

namespace Giphy.Api.Controllers
{
    [Route("api/giphy")]
    public class GiphyController : Controller
    {
        private readonly IGiphyService _giphyService;
        public GiphyController(IGiphyService service)
        {
            _giphyService = service;
        }

        [HttpGet]
        [Route("random/{searchQuery}")]
        public async Task<IActionResult> GetRandomGif(string searchQuery)
        {
            // TODO create GiphyService
            var result = await _giphyService.GetRandomGif(searchQuery);
            return Ok(result);
        }

    }
}