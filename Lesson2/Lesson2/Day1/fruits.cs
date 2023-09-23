using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Day1
{
    internal class friut
    {
        public static void fruit()
        {



            for (int i = 1; i <= 100; i++)
            {
                if(i%3 == 0)
                {
                    Console.WriteLine( "apple"+i);
                }
                if(i%5 == 0)
                {
                    Console.WriteLine( "orange"+i);

                }
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine( "grapes" + i);
                }

            }

        }
    }
}