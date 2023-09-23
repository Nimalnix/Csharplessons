using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Day2
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }=String.Empty;//IT GET intilized so that it doesn't throw NULL 
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Title { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string Region { get; set; } = String.Empty;
        public string PostalCode { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;
        public long Phone { get; set; }


        public override string ToString()
        {
            return $"ID:{this.Id},Name:{FirstName} {LastName},\n" +
                $" Address:{Address},city:{City},state:{Region},\n" +
                $" phone:{Phone},country:{Country},zip:{PostalCode}";
        }

        internal class Testperson
        {
            public static void TestOne()
            {
                Person firstPerson= new Person();
                firstPerson.Id = 1;
                firstPerson.FirstName = "harish";
                firstPerson.LastName = "B";
                firstPerson.Address = "maliga apartment";
                firstPerson.City = "lunavala";
                firstPerson.Country = "India";
                firstPerson.Phone = 99999;
                firstPerson.PostalCode = "900 009";
                firstPerson.Region = "tn";
                firstPerson.Title = "Mr";
                string value=firstPerson.ToString();
                Console.WriteLine( value);

            }
        }


    }
}
