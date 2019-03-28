using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, j;
            n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                j = int.Parse(Console.ReadLine());
                if (j == 0) Console.WriteLine("NULL");
                else if (j % 2 == 0)
                {
                    if (j > 0) Console.WriteLine("EVEN POSITIVE");
                    else Console.WriteLine("EVEN NEGATIVE");
                }
                else
                {
                    if (j > 0) Console.WriteLine("ODD POSITIVE");
                    else Console.WriteLine("ODD NEGATIVE");
                }
            }
        }
    }
}
