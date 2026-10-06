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
                catch (ArgumentOutOfRangeException aoorex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Возникла ошибка: " + aoorex.Message);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (FormatException fex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Возникла ошибка: " + fex.Message);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (Exception ex) // обработка исключений
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Возникла ошибка: " + ex.Message);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            
            }
            while (true);
        }
    }
}

