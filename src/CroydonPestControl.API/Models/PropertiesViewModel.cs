using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CroydonPestControl.API.Models
{
    public class PropertiesViewModel
    {
        public int PropertyId { get; set; }
        public int BlockCycleId { get; set; }
        public string AmPm { get; set; }
        public string Address { get; set; }
        public string Comments { get; set; }
        public DateTime NextInspectionDate { get; set; }
        public int Inspections { get; set; }
        public int StatusId { get; set; }
        public int LastUpdatedBy { get; set; }
    }
}
