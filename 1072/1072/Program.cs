using System;

namespace _1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x, dentro = 0, fora = 0;

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if(x>=10 && x <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}
