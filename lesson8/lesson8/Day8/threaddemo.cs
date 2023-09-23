using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8.Day8
{
    internal class threaddemo
    {
        public static void DemoCurrentTH()
        {
            Thread t1=Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine( "ThreadID"+id);
            Console.WriteLine( "IsAlive"+t1.IsAlive);
            Console.WriteLine("priority" + t1.Priority);
            Console.WriteLine("threadstate" + t1.ThreadState);
            Console.WriteLine("currentculture" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            t1.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
            Console.WriteLine("currentculture" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            t1.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
            Console.WriteLine("currentculture" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());


        }
    }
}
