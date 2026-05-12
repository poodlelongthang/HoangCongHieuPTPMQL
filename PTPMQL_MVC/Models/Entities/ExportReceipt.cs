using System.ComponentModel.DataAnnotations;

namespace PTPMQL_MVC.Models.Entities
{
    public class ExportReceipt
    {
        [Key]
        public int ExportId { get; set; }

        [Required(ErrorMessage = "Ngày xuất không được để trống")]
        [DataType(DataType.Date)]
        public DateTime ExportDate { get; set; }

        public ICollection<ExportDetail>? ExportDetails { get; set; }
    }
}