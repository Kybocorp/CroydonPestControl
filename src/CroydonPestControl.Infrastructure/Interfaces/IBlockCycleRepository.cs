using CroydonPestControl.Infrastructure.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace CroydonPestControl.Infrastructure.Interfaces
{
    public interface IBlockCycleRepository
    {
        Task<bool> AddBlockCycleAsync(string requestXml);
        Task<IEnumerable<BlockCycle>> GetBlockCyclesAsync();
        Task<IEnumerable<Block>> GetBlocksByBlockCycleIdAsync(int blockCycleId);
        Task<IEnumerable<UnassignedBlockViewModel>> GetUnassignedBlocksByBlockCycleIdAsync(int blockCycleId);
        Task<Block> AddBlockToBlockCycleAsync(AddBlockToBlockCycleRequest request);
        Task<IEnumerable<PropertiesViewModel>> GetPropertiesByBlockIdAsync(int blockId,int blockCycleId);
        Task UpdateBlockCycleAsync(BlockCycle blockCycle);
        Task UpdateBlockCyclePropertyAsync(PropertiesViewModel updateBlockCyclePropertyRequest);
        Task<IEnumerable<DateTime>> GetPropertyNextInspectionDatesAsync();
    }
}
