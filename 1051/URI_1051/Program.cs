using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal = double.Parse(Console.ReadLine());
            double total = 0.0;

            if(sal <= 2000.0)
            {
                Console.WriteLine("Isento");
            }
            else if (sal > 4500.0)
            {
                total = 80 + 270 + (sal - 4500.0) * 0.28;
                Console.WriteLine("R$ " + total.ToString("F2"));
            }
            else if(sal > 3000.0)
            {
                total = 80 + (sal - 3000) * 0.18;
                Console.WriteLine("R$ " + total.ToString("F2"));
            }
            else if(sal > 2000.0)
            {
                total = (sal - 2000) * 0.8;
                Console.WriteLine("R$ " + total.ToString("F2"));
            }

            

            Console.ReadLine();
        }
    }
}
