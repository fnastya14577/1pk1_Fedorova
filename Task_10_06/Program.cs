using System;

namespace Task_10_06
{
    internal class Program
    {
        /*Создать Метод ArrayGeneration не возвращающий значения
        принимает целое число n
        выводит на консоль сгенерированный массив размерности n*n.*/

        static void Main(string[] args)
        {
            int n = 5; // Задайте размерность массива
            ArrayGeneration(n);
        }
        static void ArrayGeneration(int n)
        {
            int[,] array = new int[n, n];
            Random random = new Random();

            // Заполнение массива случайными числами
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(1, 101); // Генерация случайного числа от 1 до 100
                }
            }

            // Вывод на консоль
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t"); 
                }
                Console.WriteLine(); 
            }
        }
    }
}