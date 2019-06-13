using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; //kms rodados
            double y, cons; //combustível gasto

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            cons = (double)x / y;

            Console.WriteLine(cons.ToString("F3") + " km/l");

            Console.ReadLine();
        }
    }
}
