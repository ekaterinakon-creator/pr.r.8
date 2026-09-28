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
            try
            {

                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                int N, i = 1;
                double Y = 0, sum_sin = 0;
                Console.WriteLine("Введите натуральное число");
                N = Convert.ToInt32(Console.ReadLine());
                do
                {
                    sum_sin += Math.Sin(i);
                    Y += 1 / sum_sin;
                    i++;
                }
                while (N > 0);
                Console.WriteLine($"Y = {Y} ");
            }  
            catch (Exception ex) 
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine($"Что-то пошло не так! Ошибка: {ex.Message}.");  
            }
            Console.ReadKey();
    }
}
