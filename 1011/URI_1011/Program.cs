using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, vol;

            r = double.Parse(Console.ReadLine());

            vol = (4.0 / 3.0) * (3.14159) * Math.Pow(r, 3.0);

            Console.WriteLine("VOLUME = " + vol.ToString("F3"));

            Console.ReadLine();
        }
    }
}
