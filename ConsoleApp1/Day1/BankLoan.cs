using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1.Day1
{

    class Program1
    {
        public static void Main()
        {
            Console.WriteLine("Enter your Bank");
            Console.WriteLine("1-SBI,2-ICIC,3-Axis");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    SBI();
                    break;
                case 2:
                    ICIC();
                    break;
                case 3:
                    Axis();
                    break;
                default:
                    Console.WriteLine("Enter The Bank");
                    break;



            }
        }
        public static void SBI()
        {
            float sbiInterestRate = 8.0f;
            Console.WriteLine("Enter the Priciple amount :");
            float Amount = float.Parse(Console.ReadLine());
            if (Amount == 0)
            {
                Console.WriteLine("Enter the Amount");


            }
            else if (Amount > 0)
            {
                float sbiInterest = (Amount * sbiInterestRate) / 100;
                Console.WriteLine("Total Amount After 8% Intrest is" + sbiInterest);

            }
        }

        public static void ICIC()
        {
            float IcicInterestRate = 7.0f;
            Console.WriteLine("Enter the Priciple amount :");
            float Amount = float.Parse(Console.ReadLine());
            if (Amount == 0)
            {
                Console.WriteLine("Enter the Amount");


            }
            else if (Amount > 0)
            {
                float sbiInterest = (Amount * IcicInterestRate) / 100;
                Console.WriteLine("Total Amount After 8% Intrest is" + IcicInterestRate);

            }


        }
        public static void Axis()
        {
            float AxisInterestRate = 6.0f;
            Console.WriteLine("Enter the Priciple amount :");
            float Amount = float.Parse(Console.ReadLine());
            if (Amount == 0)
            {
                Console.WriteLine("Enter the Amount");


            }
            else if (Amount > 0)
            {
                float sbiInterest = (Amount * AxisInterestRate) / 100;
                Console.WriteLine("Total Amount After 8% Intrest is" + AxisInterestRate);

            }


        }



    }


}





