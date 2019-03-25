using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri1241
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1, x1, y1, r2, x2, y2;
            float distancia;
            string entrada;
            while ((entrada = Console.ReadLine()) != null)
            {
                string[] linha = entrada.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                r1 = int.Parse(linha[0].ToString());
                x1 = int.Parse(linha[1].ToString());
                y1 = int.Parse(linha[2].ToString());
                r2 = int.Parse(linha[3].ToString());
                x2 = int.Parse(linha[4].ToString());
                y2 = int.Parse(linha[5].ToString());
                distancia = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
                if ((r1 - Math.Sqrt(distancia)) >= r2) Console.WriteLine("RICO");
                else Console.WriteLine("MORTO");
            }
        }
    }
}

