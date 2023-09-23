using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Day4
{
    internal class Box2
    {
        public int Height;
        public int Length;
        public int Width;

        public Box2(int a)//constructor
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
    internal class Woodenbox : Box2
    {
        public int Area;
        public Woodenbox() : base(1)
        {
            Console.WriteLine("wooden Box constructor");

        }//child value is expecting the parent to have parameterless constructor
         //base used access parent constuctor
        public Woodenbox(int x) : base(x)
        {

        }
        public Woodenbox(int x, int y) : base(x)
        {

        }
        public void Move()
        {
            Console.WriteLine("wooden Box Shifted");
        }

    }
    internal class Boxtester
    {
        public static void Testtwo()
        {
            Woodenbox box2 = new Woodenbox();

            box2.Height = 100;
            box2.Width = 50;
            box2.Length = 200;
            box2.Open();
            box2.Close();
            string output = box2.ToString();
            Console.WriteLine(output);


        }

    }
}
