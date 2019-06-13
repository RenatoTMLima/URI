using System;

namespace _1145
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);
            int num = 1;

            for (int i = 1; i <= y/x; i++)
            {
                for (int j = 1; j < x ; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine(num);
                num++;
            }
        }
    }
}
