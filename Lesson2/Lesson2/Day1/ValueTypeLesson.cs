/*Console.WriteLine ("Hello, World!");
byte b1 = 12;
Console.WriteLine( b1);
Console.WriteLine( byte.MinValue);
Console.WriteLine( byte.MaxValue);
Console.WriteLine( sbyte.MinValue);
Console.WriteLine( sbyte.MaxValue);
Console.WriteLine( short.MinValue);
Console.WriteLine( short.MaxValue);
Console.WriteLine( int.MaxValue);
Console.WriteLine( int.MinValue);
Console.WriteLine(long.MinValue);
Console.WriteLine(long.MaxValue);
Console.WriteLine(double.MinValue);
float f1 = 52.679f;
    
double d1 = 1234567890.09876543d;
Console.WriteLine( d1);
char c1 = 'A';
Console.WriteLine( c1);
int x = c1;
Console.WriteLine( x);
Console.WriteLine( c1);

TestMethod();

static void TestMethod()
{
    Console.WriteLine( "test");
}*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Day1
{
    internal class ValueTypeLesson
    {
        public static void TestValueTypes()
        {
            char c1 = 'A';
            Console.WriteLine(c1);
            int x = c1;
            Console.WriteLine(x);
            Console.WriteLine(c1);

        }
        

       public static void TestMethod()
        {
            Console.WriteLine("test");
        }

    }
}
