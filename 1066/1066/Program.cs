using System;

namespace _1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0, impar = 0, pos = 0, neg = 0, num;

            for (int i = 0; i < 5; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num%2==0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
                if (num > 0)
                {
                    pos++;
                }else if(num<0)
                {
                    neg++;
                }
            }

            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(pos + " valor(es) positivo(s)");
            Console.WriteLine(neg + " valor(es) negativo(s)");
        }
    }
}
