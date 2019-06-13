using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cem, cinq, vinte, dez, cinco, dois, um;
            int restoCem, restoCinq, restoVinte, restoDez, restoCinco, restoDois;

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

            Console.WriteLine(n);
            Console.WriteLine(cem + " nota(s) de R$ 100,00");
            Console.WriteLine(cinq + " nota(s) de R$ 50,00");
            Console.WriteLine(vinte + " nota(s) de R$ 20,00");
            Console.WriteLine(dez + " nota(s) de R$ 10,00");
            Console.WriteLine(cinco + " nota(s) de R$ 5,00");
            Console.WriteLine(dois + " nota(s) de R$ 2,00");
            Console.WriteLine(um + " nota(s) de R$ 1,00");


            Console.ReadLine();
        }
    }
}
