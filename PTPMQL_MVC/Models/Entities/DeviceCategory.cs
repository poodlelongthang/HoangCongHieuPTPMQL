using System.ComponentModel.DataAnnotations;

namespace PTPMQL_MVC.Models.Entities
{
    public class DeviceCategory
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Tên loại không được để trống")]
        [StringLength(100)]
        public string CategoryName { get; set; } = default!;

        // Quan hệ 1 - nhiều
        public ICollection<Device>? Devices { get; set; }
    }
}