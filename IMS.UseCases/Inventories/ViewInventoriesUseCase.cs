using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventories {

    public class ViewInventoriesUseCase: IViewInventoriesUseCase {

        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoriesUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await inventoryRepository.GetInventoriesByNameAsync(name);  
        }
}
    
}
