using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day1
{
    internal class GreatestOfThreeNum
    {
        public static void Sia()
        {
            Console.Write( "Enter the Value of FirstNumber :");
            int FirstNumber=int.Parse( Console.ReadLine() );

            Console.Write("Enter the Value of SecondNumber :");
            int SecondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the Value of ThirdNumber :");
            int ThirdNumber = int.Parse(Console.ReadLine());

           

            if( FirstNumber >= SecondNumber && FirstNumber>=ThirdNumber)
            {
                Console.WriteLine( FirstNumber);
            }
            else if (FirstNumber <= SecondNumber && SecondNumber >= ThirdNumber)
            {
                Console.WriteLine(SecondNumber);
            }
            else { Console.WriteLine(ThirdNumber); }
        }

    }
}
