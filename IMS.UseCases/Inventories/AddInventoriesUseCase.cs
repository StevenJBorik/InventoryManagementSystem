using System;
using System.Threading.Tasks;
using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces; 

namespace IMS.UseCases.Inventories
{
    public class AddInventoriesUseCase : IAddInventoriesUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public AddInventoriesUseCase(IInventor yRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }
        public async Task ExecuteAsync(Inventory inventory)
        {
            if (!await this.inventoryRepository.ExistsAsync(inventory))
                await this.inventoryRepository.AddInventoryAsync(inventory);
        }
    }
}
