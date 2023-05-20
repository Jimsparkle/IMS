using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusiness
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        [Required]
        public string InventoryName { get; set; } = string.Empty;
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must >0")]
        public int Quantity { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Quantity must >0")]
        public double Price { get; set; }
    }
}