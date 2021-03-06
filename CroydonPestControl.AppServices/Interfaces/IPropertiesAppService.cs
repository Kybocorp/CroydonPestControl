﻿using CroydonPestControl.AppServices.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CroydonPestControl.AppServices.Interfaces
{
    public interface IPropertiesAppService
    {
        Task<IEnumerable<PropertiesViewModel>> GetPropertiesByBlockIdAsync(int blockId,int blockCycleId);
        Task<IEnumerable<InspectionViewModel>> GetInspectionsByPropertyIdAsync(int propertyId);
        Task UpdateBlockCyclePropertyAsync(PropertiesViewModel request);
        Task<IEnumerable<DateTime>> GetPropertyNextInspectionDatesAsync(int blockCycleId, int propertyId);
    }
}
