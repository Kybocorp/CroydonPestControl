﻿using AutoMapper;
using CroydonPestControl.API.Controllers.Models;
using CroydonPestControl.API.Models;
using CroydonPestControl.AppServices.Interfaces;
using CroydonPestControl.AppServices.Models;
using CroydonPestControl.Core.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CroydonPestControl.API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class BlockCycleController : Controller
    {
        private readonly IBlockCycleAppService _blockCycleAppService;
        private readonly IXmlHelper _xmlHelper;
        private readonly ILogger<InspectionController> _logger;
        private readonly IMapper _mapper;

        public BlockCycleController(IBlockCycleAppService blockCycleAppService, IXmlHelper xmlHelper, ILogger<InspectionController> logger, IMapper mapper)
        {
            _blockCycleAppService = blockCycleAppService;
            _xmlHelper = xmlHelper;
            _logger = logger;
            _mapper = mapper;
        }

        /// <summary>
        /// Get All BlockCycles
        /// </summary>
        /// <returns>List of BlockCycles</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            _logger.LogInformation("Calling Get from BlockCycleController");
            var response = await _blockCycleAppService.GetBlockCyclesAsync();
            if (response == null) return NotFound();
            return Ok(response);
        }
        /// <summary>
        /// Add BlockCycle
        /// </summary>
        /// <returns>The Newly BlockCycle Id created</returns>
        [HttpPost]
        public async Task<IActionResult> Add([FromBody]AddBlockCycleRequest request)
        {
            _logger.LogInformation("Calling Add from BlockCycleController with request : {@0}", request);
            if (!ModelState.IsValid) return BadRequest();
            var requestXml = _xmlHelper.ConvertToXml(request);
            if (!await _blockCycleAppService.AddBlockCycleAsync(requestXml)) return NotFound();
            return Ok();
        }

        /// <summary>
        /// Update BlockCycle
        /// </summary>
        /// <returns></returns>
        //[HttpPut]
        //public async Task<IActionResult> UpdateBlockCycle([FromBody]BlockCycle request)
        //{
        //    _logger.LogInformation("Calling UpdateBlockCycle from BlockCycleController with request : {@0}", request);
        //    if (!ModelState.IsValid) return BadRequest();
        //    await _blockCycleAppService.UpdateBlockCycleAsync(request);
        //    return Ok();
        //}

    }
}
