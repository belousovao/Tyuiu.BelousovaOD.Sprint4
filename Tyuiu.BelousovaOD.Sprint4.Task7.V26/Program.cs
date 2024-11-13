using Tyuiu.BelousovaOD.Sprint4.Task7.V26.Lib;
namespace Tyuiu.BelousovaOD.Sprint4.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 │ Выполнил: Белоусова О. Д. │ СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (случайная генерация)                           *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Вынолнил: Белоусова Ольга Дмитриевна │ СМАРТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вывести слова длинной                                                   *");
            Console.WriteLine("* больше 4                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("351268459614723");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
            string array = "351268459614723";
            var res = ds.Calculate(5, 3, array);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
