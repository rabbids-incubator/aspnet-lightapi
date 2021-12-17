using Microsoft.AspNetCore.Mvc;
using RabbidsIncubator.LightApi.Application.Controllers;
using RabbidsIncubator.LightApi.Domain.Models;
using RabbidsIncubator.LightApi.Domain.Repositories;

namespace RabbidsIncubator.LightApi.WebApi.Controllers
{
    [ApiController]
    [Route("vlans")]
    public class VirtualLanController : CrudControllerBase
    {
        private readonly IVirtualLanRepository _virtualLanRepository;

        private readonly ILogger _logger;

        public VirtualLanController(ILogger<VirtualLanController> logger, IVirtualLanRepository virtualLanRepository)
        {
            _logger = logger;
            _virtualLanRepository = virtualLanRepository;
        }

        [HttpGet(Name = "GetVirtualLans")]
        public async Task<List<DeviceModel>> Get()
        {
            var items = await _virtualLanRepository.FindAllAsync();
            _logger.LogDebug($"Number of items found: {items.Count}");
            return items;
        }
    }
}
