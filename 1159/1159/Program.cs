using System;

namespace _1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma, num, i;
            num = int.Parse(Console.ReadLine());
            while (num!=0)
            {
                soma = 0;
                i = 1;
                while (i<6)
                {
                    if (num%2==0)
                    {
                        soma += num;
                        num += 2;
                        i++;
                    }
                    else
                    {
                        num++;
                    }
                }
                Console.WriteLine(soma);
                num = int.Parse(Console.ReadLine());
            }
        }
    }
}
