using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day1
{
   
    
        class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }

            public string Add(string a, string b)
            {
                return a + b;
            }
        }



        class Program6
        {
            public static void Main()
            {
                Calculator calculator = new Calculator();

                int result1 = calculator.Add(5, 3);
                Console.WriteLine("Result int: " + result1);

                double result2 = calculator.Add(2.5, 3.7);
                Console.WriteLine("Result double: " + result2);

                string result3 = calculator.Add("Hello, ", "World!");
                Console.WriteLine("Result string: " + result3);
            }
        }
    
}
