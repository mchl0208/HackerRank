using System;
using System.Linq;
using System.Numerics;

namespace Fibonacci_Modified
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenum = new BigInteger();
            var a = Console.ReadLine().Split(' ').Select(nu => Convert.ToInt32(nu)).ToArray();

            BigInteger A = a[0];
            BigInteger B = a[1];

            for (int c = 0; c < a[2] - 2; c++)
            {
                lenum = (A + (B * B));
                A = B;
                B = lenum;
            }

            Console.WriteLine(lenum);
            Console.ReadKey();

        }
    }
}
