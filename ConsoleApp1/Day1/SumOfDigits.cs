using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day1
{
    internal class SumOfDigits
    {
        public static void SumOfdigits() 
        {
            Console.Write( "Enter the digits you want to sum: ");
            int Number=int.Parse(Console.ReadLine());

            int sum = 0;

            while (Number !=0)
            {
                int LastDigit = Number % 10;//To Get the last digit
                sum += LastDigit;
                Number = Number / 10;//To remove the last digit
            }
            Console.WriteLine( sum);
        }  
    }
}
