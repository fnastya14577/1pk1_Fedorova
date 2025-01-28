namespace Task_03_04
{
    internal class Program
    {
        /*Дано целое число N (> 0), являющееся некоторой степенью числа 2: N = 2K. Найти целое число K — показатель
этой степени.*/
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exit" || input == "")
                {
                    Console.WriteLine($"Количество введенных строк пользователем: {count}");
                    break;
                }

                Console.Clear();
                count++;
            }
        }
    }
}