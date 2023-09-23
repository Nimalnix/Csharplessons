using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9.Day9
{
    internal class Charstreams
    {
        //char streams

        public static void Testone()
        {
            Char ch;
            Console.WriteLine("press a key followed by Enter :");
            int x = Console.Read();//only print one charcater
            ch = (Char)x;//get a char
            Console.WriteLine("\n" + x + "your key is:" + ch);
        }

        public static void Testtwo()
        {
            Char ch = ' ';
            Console.WriteLine("press a Key q to exit :");
            while (ch != 'q')
            {
                ch = (Char)Console.Read();//get a char
                Console.WriteLine("your key is:" + ch);
            }
        }
        public static void Testthree()
        {
            Console.Out.WriteLine("enter a sentence");
            String? str = Console.ReadLine();
            Console.Out.WriteLine(" " + str);
        }

        public static void TestNullabletypes()
        {
            int? x = 0;
            x = null;
            if(x.HasValue)
            {
                Console.WriteLine(x.Value);

            }
            else
             Console.WriteLine(x.GetValueOrDefault());
        }
    }
}