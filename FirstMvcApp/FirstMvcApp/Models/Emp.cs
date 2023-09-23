using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace FirstMvcApp.Models
{
    public class Emp
    {

        [Key]//validation / analaterators(field of class are decerated)



        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(25, ErrorMessage = "Name must not have more than 25 chars")]



        [MinLength(3, ErrorMessage = "name must have at least 3 chars")]



        [Required(ErrorMessage = "Title is Required")]
        public string Name { get; set; } = string.Empty;
        [Range(10000, 50000)]
        public Decimal Salary { get; set; }



        [StringLength(20, ErrorMessage = "r must not have more than 25 chars")]



        [MinLength(3, ErrorMessage = "royalty must have at least 3 chars")]



        [Required(ErrorMessage = "Title is Required")]
        public string City { get; set; } = string.Empty;



    }
}




