using MVCEFAPP.Models;
using Microsoft.EntityFrameworkCore;



namespace MVCEFAPP.Models
{
    public class HospitalDbContext:DbContext
    {

        public DbSet<Doctor> Docters { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder Options)
        {
            String connString = @"server=200411LTP2749\SQLEXPRESS;database = testdb;integrated security=true;Encrypt=false";
            Options.UseSqlServer(connString);
        }

    }
}

