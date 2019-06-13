using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maiorAB;
            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;
            maiorAB = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine(maiorAB + " eh o maior");

            Console.ReadLine();
        }
    }
}
