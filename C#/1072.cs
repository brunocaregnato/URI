using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            int contIn=0, contOut=0;
            n = int.Parse(Console.ReadLine());

            while(n-- > 0)
            {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) contIn++;
                else contOut++;
            }
            Console.WriteLine(string.Format("{0} in", contIn));
            Console.WriteLine(string.Format("{0} out", contOut));
        }
    }
}
