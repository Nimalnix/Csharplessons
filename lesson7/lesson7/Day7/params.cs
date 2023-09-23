using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7.Day7
{
    internal class @params
    {
        //params - variable length argument
        public static void AddIntParameters(params int[] arguments)
        {
            int add = 0;
            Console.WriteLine("Param Length " + arguments.Length);
            foreach (int argu in arguments)
            {
                add += argu;
            }
            Console.WriteLine(add);
        }
        public static void TestAddIntParams()
        {
            AddIntParameters(1);
            AddIntParameters(1, 2, 3, 4, 5);
        }


        public static void AddStringParameters(params string[] arguments)
        {
            string add = string.Empty;
            Console.WriteLine("Param Length " + arguments.Length);
            foreach (string argu in arguments)
            {
                add += argu;
            }
            Console.WriteLine(add);
        }
        public static void TestAddStringParams()
        {
            AddStringParameters("1");
            AddStringParameters("1", "b", "5", "j");
        }
    }
}



