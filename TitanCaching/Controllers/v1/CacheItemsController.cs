using Microsoft.AspNetCore.Mvc;
using Services.Cache;
using TitanCaching.Mapping;
using TitanCaching.Models;

namespace TitanCaching.Controllers.v1
{
    [Route("api/v1/cache-items")]
    [ApiController]
    public class CacheItemsController : ControllerBase
    {
        private readonly ICacheService _cacheService;
        private readonly CacheItemsMapping _cacheItemsMapping;

        public CacheItemsController(ICacheService cacheService)
        {
            _cacheService = cacheService;
        }

        [HttpGet]
        public IActionResult ReadAll()
        {
            var unmappedItems = _cacheService.GetAll();
            var mappedItems = _cacheItemsMapping.MapFromCacheItems(unmappedItems);
            return Ok(mappedItems);
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
            return Created(string.Empty, new object());
        }

        [HttpDelete]
        public IActionResult Delete(string key)
        {
            return NoContent();
        }
    }
}
