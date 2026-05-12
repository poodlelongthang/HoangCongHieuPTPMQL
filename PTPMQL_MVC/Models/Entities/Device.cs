using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTPMQL_MVC.Models.Entities
{
    public class Device
    {
        [Key]
        public int DeviceId { get; set; }

        [Required(ErrorMessage = "Tên thiết bị không được để trống")]
        [StringLength(150)]
        public string DeviceName { get; set; } = default!;

        // Giá tham khảo (optional)
        [Range(0, double.MaxValue, ErrorMessage = "Giá phải >= 0")]
        public decimal? Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Tồn kho phải >= 0")]
        public int Stock { get; set; }

        // ====== FK ======

        [Required(ErrorMessage = "Phải chọn loại thiết bị")]
        public int CategoryId { get; set; }
        public DeviceCategory? Category { get; set; }

        [Required(ErrorMessage = "Phải chọn nhà cung cấp")]
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

        // ====== Navigation ======

        public ICollection<ImportDetail>? ImportDetails { get; set; }
        public ICollection<ExportDetail>? ExportDetails { get; set; }
    }
}