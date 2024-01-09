using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day1
{
    internal class SwapTwoNumByValue
    {
        public static void Swap(int x, int y)
        {
            x = x + y;
            y = x - y; 
            x = x - y; 
            Console.WriteLine("x="+x);
            Console.WriteLine("y="+y);
        }
        public static void qwerty()
        {
            Console.WriteLine( "Enter the first value:");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second value:");
            int b = int.Parse(Console.ReadLine());

            Swap(a, b);
            
            
        }
    }
}
