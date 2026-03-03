using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTPMQL_MVC.Models.Entities
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public string PersonID { get; set;} =default!;
        public string FullName  { get; set;} =default!;
        public string Address { get; set;} =default!;

    }
}