using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7.Day7
{
    internal class empdictonarydemo
    {
        public static void EmpDictionaryDemo()
        { //int =key,emp=value
            Dictionary<int, Emp> empMap = new Dictionary<int, Emp>();
            
            for (int i = 1; i <= 10; i++)
            {
                Emp e = new Emp()

                {
                    ID = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i
                };
              
                empMap.Add(e.ID,e);
                
            }
            Emp e1 = new Emp() { ID = 12345, Name = "Venkat", Salary = 1000000 };
            empMap.Add(15, e1);
            empMap.Add(16, e1);
           
            

            Console.WriteLine("Count " + empMap.Count);
            Console.WriteLine("ContainsKey(5) " + empMap.ContainsKey(5));
            Console.WriteLine("ContainsKey(15) " + empMap.ContainsKey(15));
        }
        class Emp
        {
            public int ID;
            public string Name;
            public double Salary;
        }
    }
}
