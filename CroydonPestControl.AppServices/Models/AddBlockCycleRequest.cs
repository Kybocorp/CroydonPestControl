using System;
using System.Collections.Generic;

namespace CroydonPestControl.AppServices.Models
{
    public class AddBlockCycleRequest
    {
        public DateTime StartDate { get; set; }
        public List<AddBlockToBlockCycleRequest> Blocks { get; set; }
    }
}
