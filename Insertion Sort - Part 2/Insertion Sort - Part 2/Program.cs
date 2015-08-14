using System;
using System.Linq;

namespace Insertion_Sort___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Convert.ToInt32(Console.ReadLine());
            var a = Console.ReadLine();
            var ar = a.Split(' ').Select(nu => Convert.ToInt32(nu)).ToArray();

            insertionSort(ar);
        }

        static void insertionSort(int[] ar)
        {
            for (int i = 1; i < ar.Length; i++)
            {
                var x = ar[i];
                var j = i;

                while (j > 0 && ar[j-1] > x)
                {
                    ar[j] = ar[j - 1];
                    j--;
                }
                ar[j] = x;
                Console.WriteLine(string.Join(" ", ar));
            }
        }
    }
}
