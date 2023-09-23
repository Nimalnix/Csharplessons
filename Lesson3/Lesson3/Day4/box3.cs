using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Day4
{
    class box3
    {
		internal class Box
		{
			public int Height;
			public int Width;
			public int length;
			public Box(string name)
			{
				Console.WriteLine("box obj");
			}
			public void open()
			{
				Console.WriteLine("box open");
			}
			public void close()
			{
				Console.WriteLine("box is closed");
			}
			public override string ToString()
			{


				return $"Height:{Height}, Width:{Width},length={length}";
			}
		}







		internal class WoodenBox : Box
		{
			public int Area;
			public WoodenBox() : base("harish")//constructor child class expecting parameter less constructor
			{
				Console.WriteLine("woodenbox is constructor");
			}
			public WoodenBox(string name) : base("hh")//base is used to access the parent constructor with parameter
			{
				Console.WriteLine("woodenbox is constructor");
			}
			public WoodenBox(string name, string name1) : base("dd")//constructor
			{
				Console.WriteLine("woodenbox is constructor");
			}
			public void move()
			{

				Console.WriteLine("wooden box shifted");
			}
		}
		internal class BoxTester
		{
			internal static void TestOne()
			{
				Box box = new Box("hh");
				box.Height = 10;
				box.Width = 10;
				box.length = 10;
				box.open();
				box.close();

				string output = box.ToString();
				Console.WriteLine(output);
				//box.Area=300;
		//box.Move();//child class can have modification but parent class cant
			}


			public static void TestTwo()
			{
				WoodenBox box = new WoodenBox();
				box.Height = 100;
				box.Width = 18;
				box.length = 200;
				box.open();
				box.close();
				box.move();
				string output = box.ToString();
				Console.WriteLine(output);
			}
			public override string ToString()
			{


				return "Tom and Jerry";
			}

			public static void TestThree()
			{
				Box box = new WoodenBox();
				box.Height = 250;
				box.Width = 50;
				box.length = 270;
				box.open();
				box.close();
				
				string output = box.ToString();
				Console.WriteLine(output);
				//box.Area=300;
				//box.Move();//child clas modification cannot be added to parent class
			}
		}
	}
}
