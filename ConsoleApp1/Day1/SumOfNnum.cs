using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1.Day1
{
    internal class SumOfNnum
    {

      
       public static void Bill()
        {
            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 1)
            {
                Console.WriteLine("Please enter a positive integer for n.");
                return;
            }

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter number " + i + ": ");
                int number = int.Parse(Console.ReadLine());
                sum =sum+ number;
            }

            Console.WriteLine("The sum of " + n + " numbers is: " + sum);
        }
    }



}

