using CroydonPestControl.AppServices.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CroydonPestControl.AppServices.Interfaces
{
    public interface IBlocksAppService
    {
        Task<IEnumerable<Block>> GetAllBlocksAsync();
        Task<IEnumerable<Block>> GetBlocksByBlockCycleIdAsync(int blockCycleId);
        Task<IEnumerable<UnassignedBlockViewModel>> GetUnassignedBlocksByBlockCycleIdAsync(int blockCycleId);
        Task<Block> AddBlockToBlockCycleAsync(AddBlockToBlockCycleRequest request);
    }
}
