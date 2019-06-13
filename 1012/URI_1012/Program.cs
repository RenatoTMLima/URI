using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double tri, cir, tra, qua, ret;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);

            tri = a * c / 2.0;
            cir = (3.14159) * Math.Pow(c, 2.0);
            tra = (a + b) * c / 2.0;
            qua = Math.Pow(b, 2.0);
            ret = a * b;

            Console.WriteLine("TRIANGULO: " + tri.ToString("F3"));
            Console.WriteLine("CIRCULO: " + cir.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + tra.ToString("F3"));
            Console.WriteLine("QUADRADO: " + qua.ToString("F3"));
            Console.WriteLine("RETANGULO: " + ret.ToString("F3"));


            Console.ReadLine();
        }
    }
}
