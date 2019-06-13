using System;

namespace URI1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont, pos, num;
            pos = cont = 0;

            do
            {
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    pos++;
                }
                cont++;
            } while (cont < 5);
            Console.WriteLine(pos + " valores pares");
        }
    }
}
