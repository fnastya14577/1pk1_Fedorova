namespace Task_04_08
{
    internal class Program
    {
        //Дан массив, содержащий последовательность 50 случайных чисел.Найти количество пар элементов, значения которых равны.
        static void Main(string[] args)
        {
            int[] numbers = new int[50];
            Random random = new Random();

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = random.Next(0, 49);
                Console.Write(numbers[index] + " ");
            }
            //нахождение пар чисел 
            int countOfPairs = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] ==  numbers[i - 1])
                {
      
                    countOfPairs++;
                }
            }
            Console.WriteLine($"Количество пар: {countOfPairs}");
        }
    }
}

        
    

