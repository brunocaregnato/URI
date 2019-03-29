using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = int.Parse(Console.ReadLine());
            double coelho=0, sapo=0, rato=0, animais=0;

            while (total>0)
            {
                string[] read = Console.ReadLine().Split(' ');
                int nmr = int.Parse(read[0]);
                string animal = Convert.ToString(read[1]);

                if (animal.Equals("C")) coelho += nmr;
                else if (animal.Equals("S")) sapo += nmr;
                else if (animal.Equals("R")) rato += nmr;
                animais += nmr;
                total--;                
            }

            Console.WriteLine(string.Format("Total: {0} cobaias", animais));
            Console.WriteLine(string.Format("Total de coelhos: {0}",coelho));
            Console.WriteLine(string.Format("Total de ratos: {0}",rato));
            Console.WriteLine(string.Format("Total de sapos: {0}",sapo));
            Console.WriteLine(string.Format("Percentual de coelhos: {0} %", string.Format("{0:n2}", coelho / animais * 100)));
            Console.WriteLine(string.Format("Percentual de ratos: {0} %", string.Format("{0:n2}", rato / animais * 100)));
            Console.WriteLine(string.Format("Percentual de sapos: {0} %", string.Format("{0:n2}", sapo / animais * 100)));
        }
    }
}
