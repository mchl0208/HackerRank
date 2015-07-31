using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopianTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] T = { };
            int.TryParse(Console.ReadLine(), out N);
            Array.Resize(ref T, N);

            while (N-- != 0) int.TryParse(Console.ReadLine(), out T[N]);

            //Sm = (2^(m - 2[m/2]))*(2^([m/2]+1)-1)
            for (int X = T.Length; X != 0; X--)
            {
                Console.WriteLine(Math.Pow(2, T[X-1] - (2 * (T[X-1] / 2))) * (Math.Pow(2, ((T[X-1] / 2) + 1)) - 1));
            } 
        }
    }
}
