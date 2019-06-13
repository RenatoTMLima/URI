using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1050
{
    class Program
    {
        static void Main(string[] args)
        {
            int ddd = int.Parse(Console.ReadLine());
            string dest;

            dest = "";

            switch (ddd)
            {
                case 61:
                    dest = "Brasilia";
                    break;
                case 71:
                    dest = "Salvador";
                    break;
                case 11:
                    dest = "Sao Paulo";
                    break;
                case 21:
                    dest = "Rio de Janeiro";
                    break;
                case 32:
                    dest = "Juiz de Fora";
                    break;
                case 19:
                    dest = "Campinas";
                    break;
                case 27:
                    dest = "Vitoria";
                    break;
                case 31:
                    dest = "Belo Horizonte";
                    break;
                default:
                    dest = "DDD nao cadastrado";
                    break;

            }

            Console.WriteLine(dest);

            Console.ReadLine();
        }
    }
}
