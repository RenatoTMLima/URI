using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios
{
    class URI_1010
    {
        static void Main(string[] args)
        {
            string[] vet;
            int qtd;
            double preco, vlr;

            vet = Console.ReadLine().Split(' ');
            qtd = int.Parse(vet[1]);
            preco = double.Parse(vet[2]);

            vlr = qtd * preco;

            vet = Console.ReadLine().Split(' ');
            qtd = int.Parse(vet[1]);
            preco = double.Parse(vet[2]);

            vlr = vlr + (qtd * preco);

            Console.WriteLine("VALOR A PAGAR: R$ " + vlr.ToString("F2"));

            Console.ReadLine();
        }
    }
}
