using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Day2
{
    internal class Box
    {
        public static int height;
        public  int width;
        public const String type = "wooden";//const value cannot be changed after assigning
        //public const String type;//const must be declared other wise it is error
        public int Getheight()
        {
            return height;  //SINCE METHOD IS NON STATIC IF IT RETRUN STATIC VALUE IT IS POSSIBLE
        }
    }
    internal class TestBox
    {
        public static void TestOne()
        {
            Box.height = 100;//Static member of the class can be created without object reference
                             // Box.width = 200;
                               Box FirstBox = new Box();//Two diff object created from same class
            Box SecondBox = new Box();//Two diff object created from same class
            FirstBox.width = 1234;
            SecondBox.width = 9876;

            Console.WriteLine( $"First Box={FirstBox.width},{FirstBox.Getheight}");

            Console.WriteLine($"Second Box={SecondBox.width},{Box.height}");

            Console.WriteLine( Box.type);
          //Box.type="glass";//this is invalid const cannot be changed after assignment
        }
    }

}
