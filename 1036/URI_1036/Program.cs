using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double r1, r2;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);

            if ((Math.Pow(b, 2.0) - 4 * a * c) < 0 || a == 0){
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                r1 = ((-b) + Math.Sqrt(Math.Pow(b, 2.0) - (4 * a * c))) / (2 * a);
                r2 = ((-b) - Math.Sqrt(Math.Pow(b, 2.0) - (4 * a * c))) / (2 * a);

                Console.WriteLine("R1 = " + r1.ToString("F5"));
                Console.WriteLine("R2 = " + r2.ToString("F5"));
            }
            Console.ReadLine();
        }
    }
}
