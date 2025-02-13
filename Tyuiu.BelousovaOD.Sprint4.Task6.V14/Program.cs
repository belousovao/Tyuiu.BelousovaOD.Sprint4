﻿using Tyuiu.BelousovaOD.Sprint4.Task6.V14.Lib;
namespace Tyuiu.BelousovaOD.Sprint4.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Белоусова О. Д. | СМАРТб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Белоусова Ольга Дмитриевна | СМАРТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных                                             *");
            Console.WriteLine("* ['Январь', 'Февраль', 'Март', 'Апрель', 'Май', 'Июнь', 'Июль'],         *");
            Console.WriteLine("* используя класс Array, выведите элементы массива,                       *");
            Console.WriteLine("* длина которых больше 3 символов.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var months = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= months.Length - 1; i++)
            {
                Console.WriteLine(months[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] res = ds.Calculate(months);
            Console.WriteLine("Элементы массива, длина которых больше 3 символов: ");
            for (int i = 0; i <= res.Length - 1; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
