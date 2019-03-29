using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri2633
{

   class Program
    {
        static void Main(string[] args)
        {
            string linha;
            while ((linha = Console.ReadLine()) != null)
            {
                string entrada = "", saida = "";
                Dictionary<int, string> churras = new Dictionary<int, string>();

                int n = int.Parse(linha);
                for (int i = 0; i < n; i++)
                {
                    entrada = Console.ReadLine();
                    string valor = entrada.Substring(0, entrada.IndexOf(" "));
                    int chave = int.Parse(entrada.Substring(entrada.IndexOf(" ") + 1));
                    churras.Add(chave, valor);
                }
                SortedDictionary<int, string> treeMap = new SortedDictionary<int, string>(churras);//ordena

                foreach (string x in treeMap.Values) saida += x + " ";

                saida = saida.Substring(0, saida.Length - 1);
                Console.WriteLine(saida);
            }
        }
    }
}
