using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6.Day6
{
    internal class emp

    {
        private readonly double Id;
        public string Name;
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public emp() { }
        public emp(double v1)
        {
            Id = v1;
        }
        public double GetID()
        {
            return Id;
        }

        public static void EmpArray()
        {
            emp[] elist = new emp[10];
            for (int i = 0; i < 10; i++)
            {
                emp e1 = new emp(i);
                e1.FirstName = "Emp" + i;
                elist[i] = e1;
            }



            Console.WriteLine("No of Employees " + elist.Length);
            for (int i = 0; i < 10; i++)
            {
                emp e1 = elist[i];
                Console.WriteLine("ID=" + e1.GetID() + " Name=" + e1.FirstName);
            }
        }
    }
}
