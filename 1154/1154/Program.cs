using System;

namespace _1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, cont = 0, soma = 0;
            id = int.Parse(Console.ReadLine());

            while (id > -1)
            {
                cont++;
                soma += id;
                id = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(((double)soma/cont).ToString("F2"));
        }
    }
}
