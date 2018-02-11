using CroydonPestControl.AppServices.Interfaces;
using System;
using System.Threading.Tasks;
using CroydonPestControl.AppServices.Models;
using CroydonPestControl.Infrastructure.Interfaces;
using AutoMapper;
using System.Collections.Generic;

namespace CroydonPestControl.AppServices
{
    public class BlockCycleAppService : IBlockCycleAppService
    {
        private readonly IBlockCycleRepository _blockCycleRepository;
        private readonly IMapper _mapper;

        public BlockCycleAppService(IBlockCycleRepository blockCycleRepository, IMapper mapper)
        {
            _blockCycleRepository = blockCycleRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddBlockCycleAsync(string requestXml)
        {
            return await _blockCycleRepository.AddBlockCycleAsync(requestXml);
        }

        public async Task<IEnumerable<BlockCycle>> GetBlockCyclesAsync()
        {
            return _mapper.Map<IEnumerable<BlockCycle>>(await _blockCycleRepository.GetBlockCyclesAsync());
        }

        public async Task UpdateBlockCycleAsync(BlockCycle blockCycle)
        {
            await _blockCycleRepository.UpdateBlockCycleAsync(_mapper.Map<Infrastructure.Models.BlockCycle>(blockCycle));
        }

    }
}
