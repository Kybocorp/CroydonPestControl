using CroydonPestControl.AppServices.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CroydonPestControl.AppServices.Interfaces
{
    public interface IBlockCycleAppService
    {
        Task<bool> AddBlockCycleAsync(string requestXml);
        Task<IEnumerable<BlockCycle>> GetBlockCyclesAsync();
        Task UpdateBlockCycleAsync(BlockCycle blockCycle);
    }
}
