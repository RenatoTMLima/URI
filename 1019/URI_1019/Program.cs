using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int val, hr, min, seg;

            val = int.Parse(Console.ReadLine());

            hr = val / 3600;
            min = (val - hr * 3600) / 60;
            seg = val - hr * 3600 - min * 60;

            Console.WriteLine(hr + ":" + min + ":" + seg);

            Console.ReadLine();
        }
    }
}
