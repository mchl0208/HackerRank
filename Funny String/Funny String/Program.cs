using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funny_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int T;
            String[] S = {};
            int.TryParse(Console.ReadLine(), out T);
            Array.Resize(ref S, T);

            while (T--  != 0) S[S.Length - T -1] = Console.ReadLine();

            for (int pos = 0; pos <= S.Length - 1; pos++)
            {
                byte[] s = Encoding.ASCII.GetBytes(S[pos]);
                byte[] r = Encoding.ASCII.GetBytes(S[pos]);
                Array.Reverse(r);

                bool Funny = false;

                for (int i = 1; i < s.Length; i++)
                {
                    if (Math.Abs(s[i] - s[i - 1]) != Math.Abs(r[i - 1] - r[i]))
                    {
                        Funny = false;
                        break;
                    }
                }
                if (Funny) Console.WriteLine("Funny");
                else Console.WriteLine("Not Funny");
            }

            Console.ReadLine();
        }
    }
}
