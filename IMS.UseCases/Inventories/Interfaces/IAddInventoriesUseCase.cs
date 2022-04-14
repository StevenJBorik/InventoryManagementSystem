using System.Threading.Tasks;
using IMS.CoreBusiness;

namespace IMS.UseCases.Inventories
{
    public interface IAddInventoriesUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    } 
}