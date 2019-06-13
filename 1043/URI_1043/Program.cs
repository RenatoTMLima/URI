using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, res;
            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);
            res = 0;

            if (Math.Abs(a-b) < c && c < a+b || Math.Abs(a - c) < b && b < a + c || Math.Abs(b - c) < a && a < c + b)
            {
                res = a + b + c;
                Console.WriteLine("PERIMETRO = " + res.ToString("F1"));
            }
            else
            {
                res = (a + b) * c / 2;
                Console.WriteLine("AREA = " + res.ToString("F1"));
            }

            Console.ReadLine();
        }
    }
}
