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
                    do
                    {
                        N = Convert.ToInt32(Console.ReadLine());
                        if (N <= 0)
                        {
                            throw new Exception("Это не натуральное число! Введите ещё раз.");
                        }
                    }
                    while (N <= 0);
                    do
                    {
                        sumsin += Math.Sin(i); // суммируем синусы
                        Y += 1 / sumsin; // прибавляем к Y 1 деленную на сумму синусов
                        i++; // увеличиваем i на 1
                    }
                    while (i <= N);
                    Y = Math.Round(Y, 4);
                    Console.WriteLine($"Y = {Y}");
                    bool rightСhoice = false; // флаг: ввел ли пользователь корректное значение
                    while (!rightСhoice)
                    {
                        try
                        {
                            Console.WriteLine("\nХотите выполнить программу еще раз? (0 - да, 1 - нет)");
                            int choice = Convert.ToInt32(Console.ReadLine());

                            switch (choice) // проверка выбранного значения
                            {
                                case 0:
                                    rightСhoice = true;
                                    break; // программа запустится заново
                                case 1:
                                    return; // выход из программы
                                default:

                                    break;
                            }
                        }
                        catch (FormatException fex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Возникла ошибка: " + fex.Message);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.ReadKey();
                        }
                    }
                }
                catch (FormatException fex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Возникла ошибка: " + fex.Message);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadKey();
                }
                catch (ArgumentOutOfRangeException aoorex)
                {
                    Console.WriteLine("Возникла ошибка: " + aoorex.Message);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadKey();
                }
                catch (Exception ex) // обработка исключений
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Возникла ошибка: " + ex.Message);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadKey();
                }
            }
            while (true);
        }
    }
}

