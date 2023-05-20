using IMS.CoreBusiness;

namespace IMS.UseCase.Inventories
{
    public interface IEditInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}