using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEFAPP.Models
{
    public class Appointment
    {
        [Key]
        [Column("appointmentno")]
        public int Id { get; set; }
        [Required]
        public int patientID { get; set; }
        [Required]

        public int DocterID { get; set; }
        [Required]
        public DateTime DateOfAppointment { get; set; }
        [Required]
        public bool status { get; set; }
    }
}
