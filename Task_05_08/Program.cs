namespace Task_05_08
{
    internal class Program
    {
        /*Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл. 
         * Создать новый массив, который будет произведением двух предыдущих 
         * (перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в 
         * результирующий массив) 
         * Вывести результирующий массив
         */
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //Создание и заполнение массивов
            int[,] array1 = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array1[i, j] = rnd.Next(1, 10);
                }
            }

            int[,] array2 = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array2[i, j] = rnd.Next(1, 10);
                }
            }
            //Вывод массива
            Console.WriteLine("Результирующий массив: ");
            int[,] array3 = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array3[i, j] = array1[i, j] * array2[i, j];

                    Console.Write(array3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}