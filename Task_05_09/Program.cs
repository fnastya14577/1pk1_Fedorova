namespace Task_05_09
{
    internal class Program
    {
        /* Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли 
         * данная матрица Z-матрицей (это матрица, где все недиагональные элементы меньше нуля) 
         * Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали. 
         * Если не выполняется, то вывести сообщение что данная матрица не является Z-матрицей 
         */
        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] array = new int[n, n]; 
            Console.WriteLine("Введите элементы матрицы: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            bool diagonal = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    if (array[i, j] >= 0)
                    {
                        diagonal = false;
                        break;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (diagonal && i == j) Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(array[i, j] + " ");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
            if (diagonal) Console.WriteLine("Матрица является Z-матрицей.");

            else Console.WriteLine("Матрица не является Z-матрицей.");
        }
    }
}