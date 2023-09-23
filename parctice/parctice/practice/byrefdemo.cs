using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parctice.practice
{
    internal class byrefdemo
    {
        public static void ByRefmethod(int v1,ref int v2)
        {
            Console.WriteLine("TestM1==> x={0},y={1}", v1,v2);
            v1 = v1 + 100;
            v2 = v2 * 2000;
            Console.WriteLine("TestM2==> x={0},y={1}",v1,v2);
        }

        public static void TestByRefMethod()
        {
            int x = 5;
            int y=10;
            Console.WriteLine( "TestM1==> x={0},y={1}",x,y);
            ByRefmethod(x,ref y);
            Console.WriteLine( "TestM2==> x={0},y={1}",x,y);

        }
    }
}
