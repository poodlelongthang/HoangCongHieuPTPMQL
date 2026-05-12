using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTPMQL_MVC.Models.Entities
{
    public class ExportDetail
    {
        [Key]
        public int ExportDetailId { get; set; }

        [Required]
        public int ExportId { get; set; }

        [Required]
        public int DeviceId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải > 0")]
        public int Quantity { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Đơn giá phải > 0")]
        public decimal UnitPrice { get; set; }

        // Không lưu DB → tính động
        [NotMapped]
        public decimal TotalPrice => Quantity * UnitPrice;

        // Navigation
        public ExportReceipt? ExportReceipt { get; set; }
        public Device? Device { get; set; }
    }
}