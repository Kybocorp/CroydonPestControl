﻿using System;

namespace CroydonPestControl.Infrastructure.Models
{
    public class AddBlockToBlockCycleRequest
    {
        public int BlockCycleId { get; set; }
        public int BlockId { get; set; }
        public DateTime StartDate { get; set; }
    }
}