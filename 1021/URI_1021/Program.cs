using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double dinheiro = double.Parse(Console.ReadLine());
            int cem, cinq, vinte, dez, cinco, dois, um;
            int restoCem, restoCinq, restoVinte, restoDez, restoCinco, restoDois;

            int n, md;
            int cent50, cent25, cent10, cent5, cent1;
            int rCent50, rCent25, rCent10;

            n = (int)dinheiro;
            md = (int) ( dinheiro * 100) - (n * 100);
            

            cem = n / 100;
            restoCem = n % 100;

            cinq = restoCem / 50;
            restoCinq = restoCem % 50;

            vinte = restoCinq / 20;
            restoVinte = restoCinq % 20;

            dez = restoVinte / 10;
            restoDez = restoVinte % 10;

            cinco = restoDez / 5;
            restoCinco = restoDez % 5;

            dois = restoCinco / 2;
            restoDois = restoCinco % 2;
            um = restoDois;

            cent50 = md / 50;
            rCent50 = md % 50;

            cent25 = rCent50 / 25;
            rCent25 = rCent50 % 25;

            cent10 = rCent25 / 10;
            rCent10 = rCent25 % 10;

            cent5 = rCent10 / 5;
            cent1 = rCent10 % 5;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(cem + " nota(s) de R$ 100,00");
            Console.WriteLine(cinq + " nota(s) de R$ 50,00");
            Console.WriteLine(vinte + " nota(s) de R$ 20,00");
            Console.WriteLine(dez + " nota(s) de R$ 10,00");
            Console.WriteLine(cinco + " nota(s) de R$ 5,00");
            Console.WriteLine(dois + " nota(s) de R$ 2,00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(um + " moeda(s) de R$ 1,00");
            Console.WriteLine(cent50 + " moeda(s) de R$ 0,50");
            Console.WriteLine(cent25 + " moeda(s) de R$ 0,25");
            Console.WriteLine(cent10 + " moeda(s) de R$ 0,10");
            Console.WriteLine(cent5 + " moeda(s) de R$ 0,05");
            Console.WriteLine(cent1 + " moeda(s) de R$ 0,01");

            Console.ReadLine();
        }
    }
}
