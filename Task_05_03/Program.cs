namespace Task_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются ли матрицы равными, если
            да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
            элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны. */

            char[,] matrix1 = //вводим массив 1
            {
                    { 'f', 'h', 'h'},
                    { 'w', 'g', 'k'},
                    { 'a', 'f', 'j'}
                };
            char[,] matrix2 = //вводим массив 2
            {
                     { 'f', 'c', 'h'},
                     { 'm', 'g', 'z'},
                     { 'a', 'o', 'd'}
                };
            bool alive = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        alive = false;
                        break;
                    }
                }
            }
            if (alive)
            {
                Console.WriteLine("Матрицы равны");
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matrix1[i, j] == matrix2[i, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(matrix1[i, j] + " ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(matrix1[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matrix1[i, j] == matrix2[i, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(matrix2[i, j] + " ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(matrix2[i, j] + " ");
                        }
                    }
                   Console.WriteLine();
                }
            }
        }
    }
}