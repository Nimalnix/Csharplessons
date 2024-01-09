using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day1
{
    internal class RevArray
    {
       public static void revArray()
        {
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] originalArray = new int[n];

            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                originalArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Original Array: " + string.Join(", ", originalArray));

            //Array.Reverse(originalArray);

            ReverseArray(originalArray);

            Console.WriteLine("Reversed Array: " + string.Join(", ", originalArray));

            static void ReverseArray(int[] arr)
            {
                int m = 0;
                int n = arr.Length - 1;

                while (m < n)
                {  
                    int temp = arr[m];
                    arr[m] = arr[n];
                    arr[n] = temp;
                    
                    m++;
                    n--;
                }
            }
        }


    }
}