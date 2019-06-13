using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maior, meio, menor;
            string[] vet1 = Console.ReadLine().Split(' ');

            a = int.Parse(vet1[0]);
            b = int.Parse(vet1[1]);
            c = int.Parse(vet1[2]);

            menor = maior = meio = 0;

            if (a<b && a < c)
            {
                menor = a;
                if (b < c)
                {
                    meio = b;
                    maior = c;
                }
                else
                {
                    meio = c;
                    maior = b;
                }
            }
            else if (b < a && b < c)
            {
                menor = b;
                if (a < c)
                {
                    meio = a;
                    maior = c;
                }
                else
                {
                    meio = c;
                    maior = a;
                }
            }
            else if (c < a && c < b)
            {
                menor = c;
                if (a < b)
                {
                    meio = a;
                    maior = b;
                }
                else
                {
                    meio = b;
                    maior = a;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior + "\n");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
