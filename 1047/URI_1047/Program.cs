using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicioHr, inicioMin, fimHr, fimMin, durHr, durMin, durHr2;
            string[] vet = Console.ReadLine().Split(' ');

            inicioHr = int.Parse(vet[0]) * 60;
            inicioMin = int.Parse(vet[1]);
            fimHr = int.Parse(vet[2]) * 60;
            fimMin = int.Parse(vet[3]);
            durHr = 0;
            durMin = 0;

            if (inicioHr < fimHr)
            {
                durHr = (60 - inicioMin) + fimMin + (fimHr - inicioHr - 60);
                durHr2 = durHr / 60;
                durMin = durHr % 60;
                Console.WriteLine("O JOGO DUROU " + durHr2 + " HORA(S) E " + durMin + " MINUTO(S)");
            }
            else
            {
                durHr = 60 - inicioMin;
                durHr = durHr + (1380 - inicioHr);
                durHr = fimHr + fimMin + durHr;
                durHr2 = durHr / 60;
                durMin = durHr % 60;
                if (durHr >= 24)
                {
                    Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
                }
                else
                {
                    Console.WriteLine("O JOGO DUROU " + durHr2 + " HORA(S) E " + durMin + " MINUTO(S)");
                }
            }


            Console.ReadLine();
        }
    }
}
