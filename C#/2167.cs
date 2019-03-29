using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri2167
{
    class Program
    {
        static void Main(string[] args)
        {
            Program uri = new Program();

            int number = Convert.ToInt16(Console.ReadLine());
            
            string rpms = Console.ReadLine();

            int queda = uri.procurarQueda(rpms);

            Console.WriteLine(queda);

        }

        int procurarQueda(string input)
        {
            string[] numeros = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 1; i < numeros.Length; i++)
            {
                if(Convert.ToInt16(numeros[i]) < Convert.ToInt16(numeros[i - 1]))
                {
                    return i + 1;
                }
            }

            return 0;
        }
    }
}