using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri1095
{
    class Program
    {
        static void Main(string[] args)
        {
            int I, J, a = 7, b;
            for (I = 1; I <= 9; I += 2)
            {
                for (b = 1, J = a; b <= 3; J--, b++) Console.WriteLine("I={0} J={1}", I, J);
                a += 2;
            }
        }
    }
}
