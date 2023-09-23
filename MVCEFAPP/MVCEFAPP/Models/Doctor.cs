
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace MVCEFAPP.Models
{
    public class Doctor
    {
        [Key]
        [Column("doctorno")]

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [MinLength(3)]
        public string Name { get; set; }    =string.Empty;

        [Required]
        public string Speciality { get; set; } = string.Empty;
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Column(TypeName ="numeric(18,2)")]
      public decimal VistingFee { get; set; }

        [Required]
        [Column(TypeName = "numeric(18,0)")]
        public long PhoneNumber { get; set; }
    }
}
