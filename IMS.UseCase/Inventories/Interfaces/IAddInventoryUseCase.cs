using IMS.CoreBusiness;

namespace IMS.UseCase.Inventories
{
    public interface IAddInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}