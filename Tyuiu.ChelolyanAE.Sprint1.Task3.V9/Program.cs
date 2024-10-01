using System;
using Tyuiu.ChelolyanAE.Sprint1.Task3.V9.Lib;

namespace Tyuiu.ChelolyanAE.Sprint1.Task3.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds= new DataService();

            Console.Title = "Спринт #1 |Выполнила: Челольян А. Е. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Челольян Анжела Евгеньевна | ИИПБ-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет указанные расчеты и печатает результат на экран               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int minutes;
            Console.WriteLine(" Введите минуты :                                                          ");
            minutes=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Время в часах и минутах = {ds.ConvertMinutesToHours(minutes)}");

            Console.ReadKey();
        }
    }
}
