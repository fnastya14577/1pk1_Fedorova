namespace Task_05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(10, 100);
                }
            }

            Console.WriteLine("\nИсходная матрица: ");
            PrintMatrix(matrix);

            int minElement = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < minElement)
                    {
                        minElement = matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"\nМинимальный элемент матрицы: {minElement}");

            int[,] multipledMatrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    multipledMatrix[i, j] = matrix[i, j] * minElement;
                }
            }

            int[] flatArray = new int[n * n];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    flatArray[index++] = multipledMatrix[i, j];
                }
            }

            Array.Sort(flatArray);
            Array.Reverse(flatArray);

            int[] maxFive = flatArray[..5];

            Console.WriteLine("\nМатрица, умноженная на минимальный элемент: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Array.Exists(maxFive, element => element == multipledMatrix[i, j]))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write(multipledMatrix[i, j] + "\t");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}