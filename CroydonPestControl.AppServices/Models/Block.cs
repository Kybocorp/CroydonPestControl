using System;

namespace CroydonPestControl.AppServices.Models
{
    public class Block
    {
        public int BlockId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
        public int Properties { get; set; }
        public int PropertiesComplete { get; set; }
        public int StatusId { get; set; }
    }
}
