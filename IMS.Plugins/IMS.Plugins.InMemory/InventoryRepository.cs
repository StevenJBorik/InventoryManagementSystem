using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory { InventoryId = 1, InventoryName = "Bike Seat", Quantity = 100,  Price = 30 },
                new Inventory { InventoryId = 2, InventoryName = "Bike Body", Quantity = 50,  Price = 100 },
                new Inventory { InventoryId = 3, InventoryName = "Bike Wheels", Quantity = 40,  Price = 50 },
                 new Inventory { InventoryId = 4, InventoryName = "Bike Pumps", Quantity = 60,  Price = 20 },

            }; 
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

            return _inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase)); 
        }
    }
}
