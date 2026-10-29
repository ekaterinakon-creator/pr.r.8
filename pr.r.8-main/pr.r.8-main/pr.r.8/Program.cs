//***********************************************************************
//* Практическая работа № 8                                             *
//* Выполнила: Кондратюк Е.С., группа 2ИСП                              *
//* Задание: Высокоуровневые языки програмирования                      *
//***********************************************************************
using System;
namespace pr.r._8
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
                    int n, i = 1;
                    double result = 0, sumSin = 0;
                    Console.Write("Введите натуральное число: ");
                    do
                    {
                        n = Convert.ToInt32(Console.ReadLine());
                        if (n <= 0)
                        {
                            throw new ArgumentException("Это не натуральное число!");
                        }
                    }
                    while (n <= 0);
                    do
                    {
                        sumSin += Math.Sin(i); // суммируем синусы
                        result += 1 / sumSin; // прибавляем к result 1 деленную на сумму синусов
                        i++; // увеличиваем i на 1 
                    }
                    while (i <= n);
                    Console.Write($"result = {Math.Round(result, 4)}");
                    bool rightChoice = false; // флаг: ввел ли пользователь корректное значение
                    do
                    {
                        try
                        {
                            Console.Write("\nХотите выполнить программу еще раз? (0 - да, 1 - нет): ");
                            int choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice) // проверка выбранного значения
                            {
                                case 0:
                                    rightChoice = true;
                                    break; // программа запустится заново
                                case 1:
                                    return; // выход из программы
                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("Ошибка: Вы ввели другое число!");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    break;
                            }
                        }
                        catch (FormatException fex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Возникла ошибка: " + fex.Message);
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    while (!rightChoice);
                }
                catch (FormatException fex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Возникла ошибка: " + fex.Message + " Введите ещё раз.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadKey();
                }
                catch (OverflowException oex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Возникла ошибка: " + oex.Message + " Введите ещё раз.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadKey();
                }
                catch (ArgumentOutOfRangeException aoorex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Возникла ошибка: " + aoorex.Message + " Введите ещё раз.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadKey();
                }
                catch (Exception ex) // обработка исключений
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Возникла ошибка: " + ex.Message + " Введите ещё раз.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadKey();
                }
            }
            while (true);
        }
    }
}