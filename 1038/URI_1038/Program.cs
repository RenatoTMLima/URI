using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, qtde;
            double preco, total;
            string[] vet = Console.ReadLine().Split(' ');

            preco = 0.0;

            cod = int.Parse(vet[0]);
            qtde = int.Parse(vet[1]);

            switch (cod)
            {
                case 1:
                    preco = 4.0;
                    break;
                case 2:
                    preco = 4.5;
                    break;
                case 3:
                    preco = 5.0;
                    break;
                case 4:
                    preco = 2.0;
                    break;
                case 5:
                    preco = 1.5;
                    break;
            }

            total = (double) preco * qtde;

            Console.WriteLine("Total: R$ " + total.ToString("F2"));
            
            Console.ReadLine();
        }
    }
}
