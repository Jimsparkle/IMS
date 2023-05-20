using IMS.CoreBusiness;

namespace IMS.UseCase.Inventories
{
    public interface IViewInventoryByIdUseCase
    {
        Task<Inventory> ExecuteAsync(int inventoryId);
    }
}