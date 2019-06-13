using System;

namespace _1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fat = 1;

            for (int i = n; i >0; i--)
            {
                fat *= i;
            }
            Console.WriteLine(fat);
        }
    }
}
