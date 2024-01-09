using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day1
{
    internal class SearchElementInArray
    {
        public static void Search()
        {
            Console.WriteLine( "Enter the number :");
              int n=int.Parse( Console.ReadLine() );
            int[] originalArray = new int[n];
            Console.WriteLine( "Enter the elements:");
            for(int i = 0; i < n; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                originalArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the element to search: ");
            int searchElement = int.Parse(Console.ReadLine());

            bool falg = false;

            for(int i = 0;i<originalArray.Length;i++)
            {
                if (originalArray[i] == searchElement)
                {
                    falg = true;
                    Console.WriteLine( "Element "+searchElement+" found at the index "+i);
                    break;
                }
               
            }
            if(!falg)
            {
                Console.WriteLine( "Element"+searchElement+"not found in the array");
            }

        }
    }
}
