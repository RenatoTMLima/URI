using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int dst = int.Parse(Console.ReadLine()); //distancia
            int min;

            min = dst * 2;

            Console.WriteLine(min + " minutos");

            Console.ReadLine();
        }
    }
}
