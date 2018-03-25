using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CroydonPestControl.AppServices.Interfaces;
using CroydonPestControl.AppServices.Models;
using Microsoft.Extensions.Logging;
using CroydonPestControl.Infrastructure.Interfaces;
using AutoMapper;

namespace CroydonPestControl.AppServices
{
    public class PropertiesAppService : IPropertiesAppService
    {
        private readonly ILogger<PropertiesAppService> _logger;
        private readonly IBlockCycleRepository _blockCycleRepository;
        private readonly IInspectionRepository _inspectionRepository;
        private readonly IMapper _mapper;
        public PropertiesAppService(ILogger<PropertiesAppService> logger,IBlockCycleRepository blockCycleRepository, IInspectionRepository inspectionRepository, IMapper mapper)
        {
            _logger = logger;
            _blockCycleRepository = blockCycleRepository;
            _inspectionRepository = inspectionRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<PropertiesViewModel>> GetPropertiesByBlockIdAsync(int blockId,int blockCycleId)
        {
            return _mapper.Map<IEnumerable<PropertiesViewModel>>(await _blockCycleRepository.GetPropertiesByBlockIdAsync(blockId, blockCycleId));
        }

        public async Task<IEnumerable<InspectionViewModel>> GetInspectionsByPropertyIdAsync(int propertyId)
        {

            return _mapper.Map<IEnumerable<InspectionViewModel>>(await _inspectionRepository.GetInspectionsByPropertyIdAsync(propertyId));
        }

        public async Task UpdateBlockCyclePropertyAsync(PropertiesViewModel request)
        {
            await _blockCycleRepository.UpdateBlockCyclePropertyAsync(_mapper.Map<Infrastructure.Models.PropertiesViewModel>(request));
        }

        public async Task<IEnumerable<DateTime>> GetPropertyNextInspectionDatesAsync()
        {
            return await _blockCycleRepository.GetPropertyNextInspectionDatesAsync();
        }
    }
}
