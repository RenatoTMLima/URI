using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, fim, dur;
            string[] vet = Console.ReadLine().Split(' ');

            inicio = int.Parse(vet[0]);
            fim = int.Parse(vet[1]);
            dur = 0;

            if(inicio < fim)
            {
                dur = fim - inicio;
                Console.WriteLine("O JOGO DUROU " + dur + " HORA(S)");
            }
            else
            {
                dur = 24 - inicio;
                dur = dur + fim;
                if (dur > 24)
                {
                    Console.WriteLine("O JOGO DUROU 24 HORA(S)");
                }
                else
                {
                    Console.WriteLine("O JOGO DUROU " + dur + " HORA(S)");
                }
            }

            Console.ReadLine();
        }
    }
}
