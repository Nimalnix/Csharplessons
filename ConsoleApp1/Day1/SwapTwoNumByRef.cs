using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day1
{
    internal class SwapTwoNumByRef
    {
        public static void Swapnum()
        {
            int v1 = 35;
            int v2 = 55;
            Console.WriteLine($"v1={v1}, v2={v2}");
            Swap(ref v1, ref v2);
            Console.WriteLine("After Swap");
            Console.WriteLine($"v1={v1}, v2={v2}");
        }
        public static void Swap(ref int x, ref int y)
        {
            x = x + y;// 90
            y = x - y; // 90-55=35
            x = x - y; //90-35=55
        }
    }
}
