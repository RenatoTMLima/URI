﻿using System;

namespace _1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} {i*i} {i*i*i}");
                Console.WriteLine($"{i} {i * i+1} {i * i * i+1}");
            }
        }
    }
}
