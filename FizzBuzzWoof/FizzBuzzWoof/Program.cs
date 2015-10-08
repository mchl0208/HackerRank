using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzWoof
{
    class Program
    {
        static void Main(string[] args)
        {
            //var N = Int16.Parse(Console.ReadLine());
            //solution(N);
            //int[] N = { 1, 5, 3, 3, 7 }; // true
            int[] N = { 1, 3, 5, 3, 4 }; // false
            var result = solution(N);

            Console.Read();
        }

        public static bool solution(int[] A)
        {

            var changes = 0;
            int[] ordered = (int[])A.Clone();
            Array.Sort(ordered, (i1, i2) => i1.CompareTo(i2));
            var unDuplicates = A.Distinct().ToArray();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != ordered[i])
                    changes++;
            }

            return (changes - (A.Length - unDuplicates.Length) <= 1);
        }

        static void solution(int N)
        {
            for (var i = 1; i <= N; i++)
            {
                var output = "";

                if (i % 3.0 == 0) output += "fizz";
                if (i % 5.0 == 0) output += "buzz";
                if (i % 7.0 == 0) output += "woof";

                output = output == "" ? i.ToString() : output;

                Console.WriteLine(output);
            }
        }
    }


}
