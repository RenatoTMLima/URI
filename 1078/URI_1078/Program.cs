using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;

            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + n + " = " + (n * i));
            }


            Console.ReadLine();
        }
    }
}
