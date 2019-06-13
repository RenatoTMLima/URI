using System;

namespace _1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int hrI = int.Parse(vet[0]);
            int mnI = int.Parse(vet[1]);
            int hrF = int.Parse(vet[2]);
            int mnF = int.Parse(vet[3]);
            TimeSpan dtI = new TimeSpan(hrI, mnI, 0);
            TimeSpan dtF = new TimeSpan(hrF, mnF, 0);
            TimeSpan addDay = new TimeSpan(1, 0, 0, 0);

            if (dtI >= dtF)
            {
                dtF = dtF.Add(addDay);
            }

            TimeSpan dif = dtF.Subtract(dtI);

            if (dif.TotalHours >= 24)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", dif.Hours, dif.Minutes);
            }
        }
    }
}
