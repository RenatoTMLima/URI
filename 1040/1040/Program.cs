using System;

namespace _1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5=0, media;
            string[] vet = Console.ReadLine().Split(' ');

            n1 = double.Parse(vet[0]);
            n2 = double.Parse(vet[1]);
            n3 = double.Parse(vet[2]);
            n4 = double.Parse(vet[3]);

            media = ((2 * n1) + (3 * n2) + (4 * n3) + n4) / 10;

            Console.WriteLine("Media: " + media.ToString("F1"));
            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                n5 = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + n5.ToString("F1"));
                media = (media + n5) / 2;
                if (media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + media.ToString("F1"));
            }

        }
    }
}
