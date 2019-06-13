using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int anos, meses, dias, restoAno, restoMes;

            anos = d / 365;
            restoAno = d % 365;
            meses = restoAno / 30;
            dias = restoAno % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");

            Console.ReadLine();
        }
    }
}
