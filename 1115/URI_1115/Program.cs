using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1115
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string quad;
            string[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while(x != 0 && y != 0)
            {
                if (x > 0)
                {
                    if (y > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    else
                    {
                        Console.WriteLine("quarto");
                    }
                }
                else
                {
                    if (y > 0)
                    {
                        Console.WriteLine("segundo");
                    }
                    else
                    {
                        Console.WriteLine("terceiro");
                    }
                }
                vet = Console.ReadLine().Split(' ');

                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }



            Console.ReadLine();
        }
    }
}
