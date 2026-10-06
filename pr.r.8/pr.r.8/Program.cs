//***********************************************************************
//* Практическая работа № 8                                             *
//* Выполнила: Кондратюк Е.С., группа 2ИСП                              *
//* Задание: Высокоуровневые языки програмирования                      *
//***********************************************************************
using System;
namespace pr.r._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Title = "Практическая работа №8";
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Здравствуйте!");
                    int N, i = 1;
                    double Y = 0, sumsin = 0;
                    Console.WriteLine("Введите натуральное число");
                    N = Convert.ToInt32(Console.ReadLine());
                    do
                    {
                        sumsin += Math.Sin(i); // суммируем синусы
                        Y += 1 / sumsin; // прибавляем к Y 1 деленную на сумму синусов
                        i++; // увеличиваем i на 1
                    }
                    while (i <= N);
                    Console.WriteLine($"Y = {Y}");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
                try
                { throw new Exception("Нажмите любую кнопку, чтобы попробовать еще раз."); }
                catch (Exception ex)
                {
                    Console.WriteLine(" " + ex.Message);
                    Console.ReadKey();
                }
            }
            while (true);
        }
    }
}

