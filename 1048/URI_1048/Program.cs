using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal = double.Parse(Console.ReadLine());
            double per, ganho, total;

            per = ganho = total = 0;

            if(sal <= 400.0)
            {
                per = 0.15;
            }
            else if (sal <= 800.0)
            {
                per = 0.12;
            }
            else if (sal <= 1200.0)
            {
                per = 0.10;
            }
            else if (sal <= 2000.0)
            {
                per = 0.07;
            }
            else if (sal > 400.0)
            {
                per = 0.04;
            }

            ganho = sal * per;
            total = sal + ganho;
            per = per * 100;

            Console.WriteLine("Novo salario: " + total.ToString("F2"));
            Console.WriteLine("Reajuste ganho: " + ganho.ToString("F2"));
            Console.WriteLine("Em percentual: " + per.ToString("F0") + " %");



            Console.ReadLine();
        }
    }
}
