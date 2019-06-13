using System;

namespace _1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int tes, tt, tC=0, tR=0, tS=0;
            char ani;
            string[] vet;
            double pC, pR, pS;

            tes = int.Parse(Console.ReadLine());

            for (int i = 0; i < tes; i++)
            {
                vet = Console.ReadLine().Split(' ');
                ani = char.Parse(vet[1]);
                if (ani == 'C')
                {
                    tC += int.Parse(vet[0]);
                }
                else if (ani == 'R')
                {
                    tR += int.Parse(vet[0]);
                }
                else
                {
                    tS += int.Parse(vet[0]);
                }
            }
            tt = tC + tR + tS;
            pC = (double) tC / tt * 100;
            pR = (double) tR / tt * 100;
            pS = (double) tS / tt * 100;
            Console.WriteLine("Total: " + tt +" cobaias");
            Console.WriteLine("Total de coelhos: " + tC);
            Console.WriteLine("Total de ratos: " + tR);
            Console.WriteLine("Total de sapos: " + tS);
            Console.WriteLine("Percentual de coelhos: " + pC.ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + pR.ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + pS.ToString("F2") + " %");
        }
    }
}
