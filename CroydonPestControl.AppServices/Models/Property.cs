using CroydonPestControl.Core.Models;
using CroydonPestControl.Infrastructure.Models;
using System;
using System.Collections.Generic;

namespace CroydonPestControl.AppServices.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public IEnumerable<Inspection> Inspections { get; set; }
    }
}
