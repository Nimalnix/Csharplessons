using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FirstMvcApp.Models
{
    public class movie
    {
        [Key]//validation / analaterators(field of class are decerated)



        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Range(1, 20000)]
        public int Id { get; set; }
        [StringLength(25)]
        [Required]
        [MinLength(1)]
        public string Title { get; set; }
        [StringLength(25)]
        [Required]
        [MinLength(1)]
        public string language { get; set; }
        [StringLength(25)]
        [Required]
        [MinLength(1)]
        public string Hero { get; set; }
        [StringLength(25)]
        [Required]
        [MinLength(1)]
        public string Director { get; set; }
        [StringLength(25)]
        [Required]
        [MinLength(1)]
        public string MusicDirector { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int Cost { get; set; }




        public int Collection { get; set; }
        [StringLength(25)]
        [Required]
        [MinLength(1)]
        public string Review { get; set; }

    }
}

