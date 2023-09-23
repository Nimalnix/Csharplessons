using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Lesson2.Day2.Person;

namespace Lesson2.Day2
{
    internal class book
    {
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string TableOfContent { get; set; } = String.Empty;

        // public string Author { get; set; } = String.Empty;
        public string Authorname { get; set; } = String.Empty;

        public string Country { get; set; } = String.Empty;
        public string EmailId { get; set; } = String.Empty;



        public override string ToString()
        {
            return $"Title:{Title}\n" +
            $" Description:{Description}\n" +
            $"TableOfContent:{TableOfContent}\n" +
            $"Authorname:{Authorname}\n" +
                    $" EmailId:{EmailId}\n" +
                    $"country:{Country}\n";
        }
    }

    internal class Testperson
    {
        public static void TestOne()
        {
            book firstPerson = new book();
            firstPerson.Title = "ps2";
            firstPerson.Description = "Novel";
            firstPerson.TableOfContent = "Index";
            firstPerson.Authorname = "kalki";
            firstPerson.Country = "India";
            firstPerson.EmailId = "kalki@gamil.com";
            ;
            string value = firstPerson.ToString();
            Console.WriteLine(value);

        }
    }
}





