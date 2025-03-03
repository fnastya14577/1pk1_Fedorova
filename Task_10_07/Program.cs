namespace Task_10_07
{
    internal class Program
    {
        /*Создайте метод с помощью которого можно сгенерировать и вернуть символьный 
         * двумерныймассив(состоящийиз символов русского алфавита) и выведите на консоль данный массив 
         * с помощью другого метода(которыйпринимает данный массив в качестве параметра)*/

        static void Main(string[] args)
        {
            int rows = 5; // Количество строк
            int coll = 5; // Количество столбцов
            char[,] charArray = GenerateRussianCharArray(rows, coll);
            PrintCharArray(charArray);
        }
        static char[,] GenerateRussianCharArray(int rows, int coll)
        {
            char[,] array = new char[rows, coll];
            Random random = new Random();
            char startChar = 'А'; 
            int alphabetLength = 33; // Количество букв в русском алфавите

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    array[i, j] = (char)(startChar + random.Next(0, alphabetLength));
                }
            }
            return array;
        }
        static void PrintCharArray(char[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t"); // Вывод с табуляцией
                }
                Console.WriteLine(); // Переход на новую строку после каждой строки массива
            }
        }
    }
}
