using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace lesson8.Day8
{
    internal class DoTask
    {
        int x = 0;//global variable are not thread safe //when two are more threads access the gobal variable it becomes overridden 
        public void Run()
        {
            Monitor.Enter(this);
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.Write("Inside DoTask");
            Console.WriteLine("\t Thread ID:" + id);
            // int x = 0;
            try
            {
                for (int icount = 0; icount <= 5; icount++)
                {
                    x += icount;
                    Console.WriteLine("\tId=" + id + ":x=" + x + "icount" + icount);
                    Thread.Sleep(1000);


                }
            }
            finally { Monitor.Exit(this); }
        }
        public static void DemoA()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("mainth id" + id);
            DoTask a1 = new DoTask();
            a1.Run();



        }

        //multiple threads
        public static void DemoB()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("mainth id" + id);
            DoTask a1 = new DoTask();
            Thread t1 = new Thread(a1.Run);//delegates
            t1.Start();
            a1.Run();
            Console.WriteLine("----------------End of Demo---------------");


        }
        //local variables are threadsafe //each thread will get stack of its own

        public static void DemoB2()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("mainth id" + id);
            DoTask a1 = new DoTask();
            Thread t1 = new Thread(a1.Run);//delegates
            Console.WriteLine(t1.ManagedThreadId + "T1 state" + t1.ThreadState);
            t1.Start();
            Console.WriteLine(t1.ManagedThreadId + " state after start" + t1.ThreadState);
            Thread.Sleep(3000);
            Console.WriteLine(t1.ManagedThreadId + "T1 state After Sleep" + t1.ThreadState);
            a1.Run();
            Console.WriteLine("----------------End of Demo---------------");

        }
        public static void DemoC()
        {
            Thread t= Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine( "MainTh ID:"+id);
            DoTask a1 = new DoTask();
            ThreadStart ts = a1.Run;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();
            t1.Join(7000);
            if (t1.IsAlive) t1.Abort();
            t1.Join(7000);
            if (t1.IsAlive) t2.Abort();

            Console.WriteLine("----------------End of Demo---------------");
        }
    }
}