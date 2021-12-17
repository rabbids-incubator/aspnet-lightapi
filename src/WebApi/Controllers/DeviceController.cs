using Microsoft.AspNetCore.Mvc;
using RabbidsIncubator.LightApi.Application.Controllers;
using RabbidsIncubator.LightApi.Domain.Models;
using RabbidsIncubator.LightApi.Domain.Repositories;

namespace RabbidsIncubator.LightApi.WebApi.Controllers
{
    [ApiController]
    [Route("devices")]
    public class DeviceController : CrudControllerBase
    {
        private readonly IDeviceRepository _deviceRepository;

        private readonly ILogger _logger;

        public DeviceController(ILogger<DeviceController> logger, IDeviceRepository deviceRepository)
        {
            _logger = logger;
            _deviceRepository = deviceRepository;
        }

        [HttpGet(Name = "GetDevices")]
        public async Task<List<DeviceModel>> Get()
        {
            var items = await _deviceRepository.FindAllAsync();
            _logger.LogDebug($"Number of items found: {items.Count}");
            return items;
        }
    }
}
