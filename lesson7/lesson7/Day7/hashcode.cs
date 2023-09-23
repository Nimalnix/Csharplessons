using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7.Day7
{
    internal class hashcode
    {
        public static void TestTwo()
        {
            Emp empOne = new Emp();
            empOne.ID = 1001;empOne.Name = "sam";
            Emp empTwo = new Emp();
            empTwo.ID = 1002; empTwo.Name = "sam";
            Emp empThree = new Emp();
            empThree.ID = 1003; empThree.Name = "sam";
            bool flag = (empOne.Equals(empTwo));
            Console.WriteLine(flag);
            flag = empOne.Equals(empThree);
            Console.WriteLine(flag);
            Console.WriteLine(empOne.GetHashCode());
            Console.WriteLine(empTwo.GetHashCode());
            Console.WriteLine(empThree.GetHashCode());



        }
        class Emp
        {
            public int ID;
            public string Name;
            public double Salary;
        }
    }

}
