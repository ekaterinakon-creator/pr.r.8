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
                    Console.Title = "Практическая работа №8"; // Заголовок
                    Console.BackgroundColor = ConsoleColor.Gray; // установка цвета фона
                    Console.ForegroundColor = ConsoleColor.Green; // установка цвета шрифта
                    Console.Clear(); // очистка мусора
                    Console.WriteLine("Здравствуйте!"); // приветствие
                    int N, i = 1; // обьявление переменных, где N - кол-во слагаемых
                    double Y = 0, sumsin = 0; // обьявление переменной и инициализация
                    Console.WriteLine("Введите натуральное число"); // вывод просьбы 
                    N = Convert.ToInt32(Console.ReadLine()); // считывание ввода пользователя и преобразование в целочисленный тип
                    do
                    {
                        sumsin += Math.Sin(i); // суммируем синусы
                        Y += 1 / sumsin; // прибавляем к Y 1 деленную на сумму синусов
                        i++; // увеличиваем i на 1
                    }
                    while (i <= N); // проверка условия
                    Console.WriteLine($"Y = {Y} ");  // вывод результата
                    Console.WriteLine("Нажмите любую кнопку, чтобы попробовать еще раз.");
                    Console.ReadKey(); // задержка консоли
                }
                catch (Exception ex) // обработка исключений
                {
                    Console.ForegroundColor = ConsoleColor.Red; // установка цвета шрифта
                    Console.WriteLine("Ошибка: " + ex.Message); // вывод ошибки
                    Console.WriteLine("Нажмите любую кнопку, чтобы попробовать еще раз.");
                    Console.ReadKey(); // задержка консоли
                }
            }
            while (true);
        }
    }
}

