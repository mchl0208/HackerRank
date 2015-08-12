using System;
using System.Linq;

namespace Lonely_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            var a = Console.ReadLine();
            var aint = a.Split(' ').Select(nu => Convert.ToInt32(nu)).ToArray();

            Array.Sort(aint, (i1, i2) => i1.CompareTo(i2));

            if (n == 1)
                Console.WriteLine(aint[0]);
            else
            {
                for (var c = 1; c <= n - 1; c += 2)
                {
                    if (aint[c] - aint[c - 1] != 0)
                    {
                        if (c == 1 || c % 2 != 0)
                            Console.WriteLine(aint[c - 1]);
                        else if (c % 2 == 0)
                            Console.WriteLine(aint[c]);
                        return;
                    }
                }
                Console.WriteLine(aint[n - 1]);
            }
        }
    }
}
