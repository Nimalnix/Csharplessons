using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day1
{
    internal class LargestOfTwoNum
    {

        public static void HEllo()
        {
            Console.WriteLine("Enter the value Integer A");


            int FirstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value Integer B");
            int SecondValue = int.Parse(Console.ReadLine());

            if (FirstValue > SecondValue)
            {
                Console.WriteLine(FirstValue);
            }
            else if (FirstValue < SecondValue)
            {
                Console.WriteLine(SecondValue);
            }
            else
            {
                Console.WriteLine("Equal");
            }

        }
    }

}

