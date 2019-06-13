using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;
            double soma = 0.0;
            int i = 0;

            while (i < 2)
            {
                nota = double.Parse(Console.ReadLine());
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                    
                }
                else
                {
                    soma += nota;
                    i++;

                }

            }

            Console.WriteLine("media = " + (soma/2).ToString("F2"));

            Console.ReadLine();
        }
    }
}
