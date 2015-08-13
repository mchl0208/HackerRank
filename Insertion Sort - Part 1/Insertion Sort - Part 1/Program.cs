using System;
using System.Linq;

namespace Insertion_Sort___Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Convert.ToInt32(Console.ReadLine());
            var a = Console.ReadLine();
            var ar = a.Split(' ').Select(nu => Convert.ToInt32(nu)).ToArray();

            insertionSort(ar, ar[s - 1], ar.Length - 1);
        }

        static void insertionSort(int[] ar, int unsorted, int insertPosition)
        {
            if (insertPosition == 0 || ar[insertPosition - 1] < unsorted)
            {
                ar[insertPosition] = unsorted;
                Console.WriteLine(string.Join(" ", ar));
            }
            else
            {
                ar[insertPosition] = ar[insertPosition - 1];
                Console.WriteLine(string.Join(" ", ar));
                insertionSort(ar, unsorted, --insertPosition);
            }
            
        }
    }
}
