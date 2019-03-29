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
            for (I=1, J=60; J >= 0; I += 3, J -= 5) Console.WriteLine("I={0} J={1}", I, J);
        }
    }
}
