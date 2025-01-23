namespace Task_03_04
{
    internal class Program
    {
        /*условиезадачи*/
        static void Main(string[] args)
        {
            /*решение задачи*/
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