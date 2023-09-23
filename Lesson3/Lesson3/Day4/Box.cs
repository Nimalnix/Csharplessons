using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Day4
{
    internal class Box
    {
        
   
            public int Height;
            public int Length;
            public int Width;

            public Box()//constructor
            {
                Console.WriteLine("Box Object Created");
            }
            public void Open()
            {
                Console.WriteLine("Box is Open");
            }
            public void Close()
            {
                Console.WriteLine("Box is Closed");
            }
        public override string ToString()
        {
            return $"Height:{Height}, Length:{Length}, Width:{Width}";  
        }

    }
        internal class WoodenBox : Box { }//child class of Box (inhertiance)
        internal class BoxTester
        {
            public static void TestOne()
            {
            Box box = new Box();
            box.Height = 10;
            box.Width = 5;
                 box.Length = 20;
            box.Open();
            box.Close();
          string output=  box.ToString();
            Console.WriteLine( output);
        }
       
    }
    
}

