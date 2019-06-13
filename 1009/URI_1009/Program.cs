using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            double fixo, vendas, sal;
            string nome = Console.ReadLine();

            fixo = double.Parse(Console.ReadLine());
            vendas = double.Parse(Console.ReadLine());

            sal = fixo + vendas * 0.15;

            Console.WriteLine("TOTAL = R$ " + sal.ToString("F2"));

            Console.ReadLine();
        }
    }
}
