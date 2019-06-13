using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_1061
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet1;
            string[] vet2;
            int diaInicio, diaFim, hrInicio, hrFim, minInicio, minFim, segInicio, segFim;
            int totalSeg, dias, horas, mins, segs;
            int rDias, rHrs;

            vet1 = Console.ReadLine().Split(' ');
            vet2 = Console.ReadLine().Split(':');

            diaInicio = int.Parse(vet1[1]);
            hrInicio = int.Parse(vet2[0]);
            minInicio = int.Parse(vet2[1]);
            segInicio = int.Parse(vet2[2]);

            vet1 = Console.ReadLine().Split(' ');
            vet2 = Console.ReadLine().Split(':');

            diaFim = int.Parse(vet1[1]);
            hrFim = int.Parse(vet2[0]);
            minFim = int.Parse(vet2[1]);
            segFim = int.Parse(vet2[2]);

            totalSeg = 86400 - hrInicio * 3600 - minInicio * 60 - segInicio;
            totalSeg = totalSeg + hrFim * 3600 + minFim * 60 + segFim;
            totalSeg = totalSeg + ((diaFim) - (diaInicio + 1)) * 86400;

            dias = totalSeg / 86400;
            rDias = totalSeg % 86400;
            horas = rDias / 3600;
            rHrs = rDias % 3600;
            mins = rHrs / 60;
            segs = rHrs % 60;

            Console.WriteLine(dias + " dia(s)");
            Console.WriteLine(horas + " horas(s)");
            Console.WriteLine(mins + " minuto(s)");
            Console.WriteLine(segs + " segundo(s)");


            Console.ReadLine();
        }
    }
}
