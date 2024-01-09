using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day1
{
    internal class InsertElement
    {
        
        static void Main()
        {
            int[] originalArray = { 1, 2, 3, 4, 5 };
            int elementToInsert = 99;
            int positionToInsert = 2; 
            int[] newArray = new int[originalArray.Length + 1];
               for (int i = 0, j = 0; i < newArray.Length; i++)
            {
                if (i == positionToInsert)
                {
                    newArray[i] = elementToInsert;
                }
                else
                {
                    newArray[i] = originalArray[j];
                    j++;
                }
            }

            Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
            Console.WriteLine("Element to Insert: " + elementToInsert);
            Console.WriteLine("Position to Insert: " + positionToInsert);
            Console.WriteLine("Updated Array: " + string.Join(", ", newArray));
        }
    }

}

