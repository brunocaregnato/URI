using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri1172
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
                if (vet[i] <= 0) vet[i] = 1;
            }

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(string.Format("X[{0}] = {1}", i, vet[i]));
            }
        }
    }
}
