using System;

namespace Uri1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(string.Format("{0} x {1} = {2}",i,n,i*n));
            }
        }
    }
}
