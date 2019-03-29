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
            while (true)
            {
                int senha = int.Parse(Console.ReadLine());
                if (senha == 2002) break;
                Console.WriteLine("Senha Invalida"); 

            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
