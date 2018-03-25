using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using CroydonPestControl.AppServices.Interfaces;
using CroydonPestControl.AppServices.Models;
using System.Collections.Generic;

namespace CroydonPestControl.API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class PropertiesController : Controller
    {
        private readonly IPropertiesAppService _propertiesAppService;
        private readonly ILogger<PropertiesController> _logger;
        public PropertiesController(IPropertiesAppService propertiesAppService, ILogger<PropertiesController> logger)
        {
            _propertiesAppService = propertiesAppService;
            _logger = logger;
        }
        /// <summary>
        /// Get All Properties by blockId
        /// </summary>
        /// <returns>list of Property object</returns>
        [HttpGet("{blockId}&{blockCycleId}")]
        public async Task<IActionResult> GetByBlockId(int blockId,int blockCycleId)
        {
            _logger.LogInformation("Calling Get from PropertiesController");
            return Ok(await _propertiesAppService.GetPropertiesByBlockIdAsync(blockId, blockCycleId));
        }

        /// <summary>
        /// Get property next inspection dates
        /// </summary>
        /// <returns>list of dates</returns>
        [HttpGet()]
        public async Task<IActionResult> GetPropertyNextInspectionDates()
        {
            _logger.LogInformation("Calling GetPropertyNextInspectionDatesAsync from InspectionController");
            return Ok(await _propertiesAppService.GetPropertyNextInspectionDatesAsync());
        }

        /// <summary>
        /// Get inspections by propertyId
        /// </summary>
        /// <returns>list of Inspection object</returns>
        [HttpGet("{propertyId}")]
        public async Task<IActionResult> GetInspectionsByPropertyId(int propertyId)
        {
            _logger.LogInformation("Calling GetInspectionsByUserId from InspectionController with UserId : {0}", propertyId);
            return Ok(await _propertiesAppService.GetInspectionsByPropertyIdAsync(propertyId));
        }

        /// <summary>
        /// Updates block cycle properties
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateBlockCycleProperty([FromBody]PropertiesViewModel request)
        {
            _logger.LogInformation("Calling UpdateBlockCycleProperty from PropertiesController with request : {@0}", request);
            if (!ModelState.IsValid) return BadRequest();
            await _propertiesAppService.UpdateBlockCyclePropertyAsync(request);
            return Ok();
        }
    }
}
