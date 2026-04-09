using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace PTPMQL_MVC.Models.Entities
{
    public class Person
    {
        [Key]
        [Required(ErrorMessage = "Id không được để trống")]
        public string PersonId { get; set;} =default!;
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(50, ErrorMessage = "Tên tối đa 50 ký tự")]
        public string FullName  { get; set;} = null!;
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string Address { get; set;} =default!;
        [Range(1, 120, ErrorMessage = "Tuổi phải từ 1 đến 120")]
        [Required(ErrorMessage = "Tuổi không được để trống")]
        public string Age {get; set;} =default!;
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        [Required(ErrorMessage = "Email không được để trống")]
        public string Email {get; set; } = null!;
        public string FacultyId { get; set; } = default!;
        [ForeignKey("FacultyId")]
        public virtual Faculty? Faculty { get; set; } = default!;
    }

}