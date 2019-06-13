using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, p1, p2, dist;
            string[] vet = Console.ReadLine().Split(' ');
            x1 = double.Parse(vet[0]);
            p1 = double.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet[0]);
            p2 = double.Parse(vet[1]);

            dist = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(p2 - p1, 2.0));

            Console.WriteLine(dist.ToString("F4"));

            Console.ReadLine();
        }
    }
}
