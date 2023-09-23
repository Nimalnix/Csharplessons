using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Day2
{
    //int a=19; worng declaration and not before namespace
    internal class Demo1
    {
        //Global declaration
        int x = 10;// Member variable/Class variable
        static int y = 1000;

        public static void FirstMethod()
        {
            // Local variable
            // int x = 20;
            int y = 2000;

            //Console.WriteLine(x);//Non static number can not be accessed
            Console.WriteLine(y);//Local variable

            Console.WriteLine(Demo1.y);//gobal static variable
        }

        public void SecondMethod()
        {
            int x = 100;
            Console.WriteLine(x);
            Console.WriteLine(Demo1.y);
        }

    }
            internal class Demo2
        {

        }
       
        
    
}
namespace Lesson2.Demo
{
    
    internal class Demo1
    {

    }
    internal class Demo2
    {

    }

}
