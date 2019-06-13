using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int hr = int.Parse(Console.ReadLine()); //horas gastas na viagem
            int vel = int.Parse(Console.ReadLine()); //velocidade
            double dist, lit;

            dist = (double) hr * vel;
            lit = dist / 12;

            Console.WriteLine(lit.ToString("F3"));

            Console.ReadLine();
        }
    }
}
