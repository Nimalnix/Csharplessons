using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Day4
{
    internal abstract class vehicle//it is not complisery to have abstrat class in abstract method
    {//abstart class cannot be subsanched
       //abstart class must be inhertited
        public vehicle()
        {
            Console.WriteLine( "vehicle Constructor");
        }
        public void start()
        {
            Console.WriteLine( "vehicle started");
        }
    }
    //end of class
    internal class Car:vehicle
    {
        public Car()
        {
            Console.WriteLine("car constructed");
        }
    }

    class VehicelTester
    {
        public static void hi()
        {
            //vehicle tetser=new vehicle();
            vehicle tester = new Car();
            tester.start();
        }
    }
   
}
