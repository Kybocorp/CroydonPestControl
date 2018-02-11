using System;
using System.Collections.Generic;

namespace CroydonPestControl.Infrastructure.Models
{
    public class AddBlockCycleRequest
    {
        public DateTime StartDate { get; set; }
        public IEnumerable<AddBlockToBlockCycleRequest> Blocks { get; set; }
    }
}
