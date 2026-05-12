using System.ComponentModel.DataAnnotations;

namespace PTPMQL_MVC.Models.Entities
{
    public class ImportReceipt
    {
        [Key]
        public int ImportId { get; set; }

        [Required(ErrorMessage = "Ngày nhập không được để trống")]
        public DateTime ImportDate { get; set; }

        [Required(ErrorMessage = "Phải chọn nhà cung cấp")]
        public int SupplierId { get; set; }

        // Navigation
        public Supplier? Supplier { get; set; }
        public ICollection<ImportDetail>? ImportDetails { get; set; }
    }
}