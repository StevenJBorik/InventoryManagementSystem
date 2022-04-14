using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);

        Task<bool> ExistsAsync(Inventory inventory);
        Task AddInventoryAsync(Inventory inventory); 
    }
}
