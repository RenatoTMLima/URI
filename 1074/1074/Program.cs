using System;

namespace _1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x;

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (x % 2 == 0)
                {
                    Console.Write("EVEN ");
                    if (x > 0)
                    {
                        Console.WriteLine("POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("NEGATIVE");
                    }
                }
                else
                {
                    Console.Write("ODD ");
                    if (x > 0)
                    {
                        Console.WriteLine("POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("NEGATIVE");
                    }
                }
            }
        }
    }
}
