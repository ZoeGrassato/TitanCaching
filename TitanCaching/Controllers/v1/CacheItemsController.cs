using Microsoft.AspNetCore.Mvc;
using TitanCaching.Models;

namespace TitanCaching.Controllers.v1
{
    [Route("api/v1/cache-items")]
    [ApiController]
    public class CacheItemsController : ControllerBase
    {
        [HttpGet]
        public IActionResult ReadAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Read(string id)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(CacheItemTransferObj cacheItem)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Add(CacheItemTransferObj cacheItem)
        {
            return Ok();
        }
    }
}
