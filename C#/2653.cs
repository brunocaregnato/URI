using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class URI {

    static void Main(string[] args)
      {
            string line;
            List<string> lista = new List<string>();
            while ((line = System.Console.ReadLine()) != null)
            {
                        if (!lista.Contains(line))
                        {
                            lista.Add(line);
                        }
            }
            Console.WriteLine(lista.Count);
        }
}