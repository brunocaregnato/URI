using System; 

class URI {

    static void Main(string[] args) { 

        string[] numeros = Console.ReadLine().Split(' ');
            int altura=int.Parse(numeros[1]);
            for (int i = 0; i < int.Parse(numeros[0]); i++) {
                string s = Console.ReadLine();
                int idx = s.LastIndexOf(' ');
                string nome =s.Substring(0, idx);
                string alturaGigante=s.Substring(idx + 1);
                if (int.Parse(alturaGigante) > altura) {
                    Console.WriteLine(nome);
                }
            }
    }
}