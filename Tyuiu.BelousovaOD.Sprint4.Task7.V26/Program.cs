﻿using Tyuiu.BelousovaOD.Sprint4.Task7.V26.Lib;
namespace Tyuiu.BelousovaOD.Sprint4.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #4                                                            *");
            Console.WriteLine("* Задание #7 Вариант #26                                               *");
            Console.WriteLine("************************************************************************");

            int n = 5;
            int m = 3;         
            int[,] mtrx = new int[n, m];
            int index = 0;
            string value = "351268459614723";

            


            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[index]}\t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            int res = ds.Calculate(n, m, value);

            Console.WriteLine($"Ответ = {res} ");
            Console.ReadKey();

        }
    }
}
