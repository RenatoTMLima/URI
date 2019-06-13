using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = 0;
            if (b < a)
            {
                c = a;
                a = b;
                b = c;
            }
            c = 0;
            for(int i = a+1; i < b; i++)
            {
                if (i % 2 != 0)
                {
                    c += i;
                    
                }
            }

            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
