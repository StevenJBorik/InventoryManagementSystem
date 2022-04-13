using System.Collections.Generic;
using System.Threading.Tasks;
using IMS.CoreBusiness;

namespace IMS.UseCases.Inventories
{
    public interface IViewInventoriesUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}