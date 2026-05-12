using System.ComponentModel.DataAnnotations;
namespace PTPMQL_MVC.Models.Entities
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [Required(ErrorMessage = "Tên nhà cung cấp không được để trống")]
        [StringLength(100)]
        public string SupplierName { get; set; } = default!;
        // Navigation property
        public ICollection<Device>? Devices { get; set; }
        public ICollection<ImportReceipt>? ImportReceipts { get; set; }
    }
}
