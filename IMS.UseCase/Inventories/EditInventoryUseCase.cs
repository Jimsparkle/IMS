using IMS.CoreBusiness;
using IMS.UseCase.PluginInterfaces;

namespace IMS.UseCase.Inventories
{
    public class EditInventoryUseCase : IEditInventoryUseCase
    {
        private IInventoryRepository inventoryRepository;
        public EditInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task ExecuteAsync(Inventory inventory)
        {
            await this.inventoryRepository.EditInventoryAsync(inventory);
        }
    }
}
