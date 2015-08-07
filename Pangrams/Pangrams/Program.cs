using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine().ToLower();
            var strinArray = Regex.Replace(x, @"\s+", "").ToCharArray().Distinct();
            int counter = 0;

            foreach (var caracter in strinArray)
            {
                counter += caracter;
            }

            if (counter == 2847) Console.WriteLine("pangram");
            else Console.WriteLine("not pangram");

        }
    }
}
