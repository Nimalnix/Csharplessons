using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day1
{
    internal class substringsInStrings
    {
        public static void Substring()
        {
            Console.WriteLine("Enter the string:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter the substring:");
            string searchString = Console.ReadLine();

            int index = inputString.IndexOf(searchString);

            if (index != -1)
            {
                Console.WriteLine("The substring" + searchString + "was found at index" + index + "in the string.");
            }
            else
            {
                      Console.WriteLine("The substring" + searchString + " was not found in the string");    
            }
        }
    }
}
