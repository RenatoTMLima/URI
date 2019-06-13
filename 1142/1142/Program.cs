using System;

namespace _1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cont = 1, i;

            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"{cont} {cont+1} {cont+2} PUM");
                cont += 4;
            }
        }
    }
}
