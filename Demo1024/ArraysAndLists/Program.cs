using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays
            // declaration
            int[] a1 = new int[5]; // primitive array declaration

            // initialization and traversal
            for (int i = 0; i < a1.Length ; i++)
            {
                a1[i] = i * 10 + 1; // assigning values to the array
            }

            // another way to initialize array
            int[] a2 = { 1, 2, 3, 4, 5 }; 

            // traversal
            foreach (int element in a1)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            Console.WriteLine("Lists");


            // lists
            // declaration
            List<int> l = new List<int>();

            // initialization
            l.Add(1); // Add() adds at the end of the list
            l.Add(2);
            l.Add(3);

            // element access
            l[1] = 22;

            // some other methods
            l.Insert(2, 99); // inserting 99 at new index 2 of the list
            l.Remove(1); // removing index 1
            l.Sort();

            // traversal
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
                                  

            Console.WriteLine();
        }
    }
}
