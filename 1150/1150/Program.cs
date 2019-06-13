using System;

namespace _1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int z = int.Parse(Console.ReadLine());

            int cont = 1, soma;

            while(z <= x)
            {
                z = int.Parse(Console.ReadLine());
            }

            soma = x;

            while(soma < z)
            {
                soma += ++x;
                cont++;
            }
            Console.WriteLine(cont);
        }
    }
}
