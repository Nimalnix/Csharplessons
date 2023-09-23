using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7.Day7
{
    internal class Hash

    {


        public static void HashtableDemo()



        {



            Hashtable ht = new Hashtable();



            Console.WriteLine("Count " + ht.Count);



            Console.WriteLine("IsFixedSize " + ht.IsFixedSize);



            ht.Add("id", 123);



            ht.Add("name", "Gates");



            Console.WriteLine("Count " + ht.Count);



            ht.Add("sal", 15000);



            ht.Add("r1", new Random().Next());



            ht.Add("IsDirector", false);



            ht.Add("Address", null);



            // ht.Add("name", "Bill");// Runtime Error duplicate key



            Console.WriteLine("Count " + ht.Count);



            Console.WriteLine(ht["sal"]);



            Console.WriteLine("ContainsKey(r1) " + ht.ContainsKey("sal"));



            Console.WriteLine("ContainsKey(name) " + ht.ContainsKey("name"));





            foreach (object k in ht.Keys)
            {


                Console.WriteLine(k + "--" + ht[k]);



            }
        }


        public static void EmpHTDemo()
        {
            Hashtable empTable = new Hashtable();
            for (int i = 1; i <= 10; i++)
            {
                Emp e = new Emp()
                {
                    ID = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i
                };
                empTable.Add(e.ID, e);

            }



            Console.WriteLine("Count " + empTable.Count);
            Console.WriteLine("ContainsKey(5) " + empTable.ContainsKey(5));
            Console.WriteLine("ContainsKey(15) " + empTable.ContainsKey(15));
        }
       class Emp
        {
            public int ID;
            public string Name; 
            public int Salary;   
        }

    }
}
