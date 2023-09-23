using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace MVCEFAPP.Models
{
    public class RepositoryDoctor
    {
        public static List<Doctor> GetDoctors()
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var list = ctx.Docters.ToList();
            return list;
        }
        public static Doctor GetDoctorById(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var doctor = ctx.Docters.Find(id);
            return doctor;
            
        }

        public static void AddNewDoctor(Doctor doctor)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Docters.Add(doctor);
            ctx.SaveChanges();
        }

        
        public static void ModifyDocter(Doctor doctor)
        {
            HospitalDbContext ctx= new HospitalDbContext();
            ctx.Entry(doctor). State=EntityState.Modified;
            ctx.SaveChanges();  
        }
        public static void RemoveDocter(int id)
        {
            HospitalDbContext ctx=new HospitalDbContext();
            Doctor doctor = ctx.Docters.Find(id);
            ctx.Docters.Remove(doctor);
            ctx.SaveChanges();
        }
    }
}
