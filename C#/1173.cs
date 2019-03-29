using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri1173
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];

            int i = int.Parse(Console.ReadLine());
            vet[0] = i;

            for (i = 1; i < 10; i++)
            {
                vet[i] = vet[i - 1] * 2;
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(string.Format("N[{0}] = {1}", i, vet[i]));
            }
        }
    }
}
