using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1.Day1
{
    internal class factors
    {
        public static void Gus()
        {
            Console.WriteLine( "Enter a Number:");
            int Number=int.Parse( Console.ReadLine() );

            Console.WriteLine("The Factors of " + Number + " is:");

            for(int i = 1; i <=Number; i++)
            {
                if(Number%i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }


    }
}
