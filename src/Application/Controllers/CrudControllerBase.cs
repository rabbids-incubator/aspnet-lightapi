using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RabbidsIncubator.LightApi.Domain.Repositories;

namespace RabbidsIncubator.LightApi.Application.Controllers
{
    public abstract class CrudControllerBase<T> : ControllerBase
    {
        protected readonly ILogger _logger;

        protected readonly ICrudRepository<T> _crudRepository;

        protected CrudControllerBase(ILogger<CrudControllerBase<T>> logger, ICrudRepository<T> crudRepository)
        {
            _logger = logger;
            _crudRepository = crudRepository;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<List<T>>> Get()
        {
            var models = await _crudRepository.FindAllAsync();
            _logger.LogDebug($"Number of items found: {models.Count}");
            return models;
        }
    }
}
