using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parctice.practice
{
    internal class demo
    {
        class SampleProgram
        {
            public static void main(string[] args)
            {
                int num = 1;
                funcv(num);
                Console.Write(num + ", ");
                funcr(ref num);
                Console.Write(num + ", ");
            }
           public static void funcv(int num)
            {
                num = num + 10; Console.Write(num + ", ");
            }
           public static void funcr(ref int num)
            {
                num = num + 10; Console.Write(num + ", ");
            }
        }
    }
}

