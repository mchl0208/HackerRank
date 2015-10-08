using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Puzzle
{
    class Program
    {
        static void Main(String[] args)
        {
            //string fileName = Environment.GetEnvironmentVariable("OUTPUT_PATH");
            TextWriter tw = new StreamWriter(@"C:\salida", true);
            int res;
            int _num;
            _num = Convert.ToInt32(Console.ReadLine());

            res = solvePuzzle(_num);
            tw.WriteLine(res);

            tw.Flush();
            tw.Close();
        }

        static int solvePuzzle(int num)
        {
            Int32[] result = num.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

            var oneHole = result.Count(a => a == 0 || a == 4 || a == 6 | a == 9);
            var twoHole = result.Count(a => a == 8);

            return (twoHole*2) + oneHole;

        }

    }
}
