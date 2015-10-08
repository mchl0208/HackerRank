using System;
using System.Linq;

namespace Find_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            int T;
            int[][] N = { };
            int.TryParse(Console.ReadLine(), out T);
            Array.Resize(ref N, T);

            while (T-- != 0)
            {
                N[T] = Console.ReadLine().Split(' ').Select(nu => Convert.ToInt32(nu)).ToArray();
            }

            for (int i = N.Length - 1; i >= 0; i--)
            {
                var mx = 2 * N[i][2] - N[i][0];
                var my = 2 * N[i][3] - N[i][1];
                //printf(“%d %d”,2*a[i].x2 – a[i].x1, 2*a[i].y2 – a[i].y1);

                Console.WriteLine("{0} {1}", mx, my);
            }

            Console.Read();

        }
    }
}
