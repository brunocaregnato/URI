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
            int I, J;
            for (I = 1; I <= 9; I += 2)
            {
                for (J = 7; J >= 5; J--) Console.WriteLine("I={0} J={1}", I, J);
            }
        }
    }
}
