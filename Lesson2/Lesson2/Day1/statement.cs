using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Day1
{
    internal class statement
    {
        public static void TestOne()
        {
            Console.WriteLine( "Enter the Age");
            String x=Console.ReadLine();  


            int age=int.Parse(x);    
            if(age<18)
            {
                Console.WriteLine("sorry you cant drive");
            }

        else {
                Console.WriteLine("yes you can drive");
                    }

        }
    }
}
