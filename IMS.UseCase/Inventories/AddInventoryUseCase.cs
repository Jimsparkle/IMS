using IMS.CoreBusiness;
using IMS.UseCase.PluginInterfaces;

namespace IMS.UseCase.Inventories
{
    public class AddInventoryUseCase : IAddInventoryUseCase
    {
        public AddInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        private readonly IInventoryRepository inventoryRepository;

        public async Task ExecuteAsync(Inventory inventory)
        {
            await this.inventoryRepository.AddInventoryAsync(inventory);
        }
    }
}
