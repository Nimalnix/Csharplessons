using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day1
{
    internal class SwapTwoNum
    {
        public static void Hi()
        {
            Console.WriteLine( "Enter the FirstValue");
            int UserInputA=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the SecondValue");
            int UserInputB= int.Parse(Console.ReadLine());

            Console.WriteLine( $"{UserInputA} {UserInputB}");

            Console.WriteLine( "AfterSwap");

            int Number = UserInputA;
            UserInputA = UserInputB;
           
            UserInputB = Number;

            Console.WriteLine($"{UserInputA} {UserInputB}");

            
        }
        
    }
}
