using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCEFAPP.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }





        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must have atleast 3 character and max of 20 characters")]
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }





        [Required]
        [Column(TypeName = "numeric(18,0)")]
        public long PhoneNumber { get; set; }
    }
}
