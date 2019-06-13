using System;

namespace _1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sair, j;

            for (int i = 0; i < n; i++)
            {
                sair = 0;
                j = 2;
                int num = int.Parse(Console.ReadLine());

                while(sair == 0 && j < num)
                {
                    if(num % j == 0)
                    {
                        sair = 1;
                    }
                    j++;
                }
                
                if (sair == 0)
                {
                    Console.WriteLine(num + " eh primo");
                }
                else
                {
                    Console.WriteLine(num + " nao eh primo");
                }
            }
        }
    }
}
