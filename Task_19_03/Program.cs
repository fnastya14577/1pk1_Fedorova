namespace Task_19_03
{
    internal class Program
    {
        /* Напишите консольное приложение, в котором осуществляется построчный пользовательский ввод 
         * (ввод каждой строки подтверждается нажатием на enter). 
         * Количество введенных строк произвольно, ввод завершается при вводе пустой строки. 
         * После окончания ввода произведите объединение всех ранеее введенных строк в одну с 
         * использованием разделителя «-».
        */
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            string input;

            Console.WriteLine("Введите строку (для завершения ввода оставьте пустую строку и нажмите Enter): ");

            while (true)
            {
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                
                    break;
                
                lines.Add(input);
            }

            string result = string.Join("<>", lines);
            Console.WriteLine($"Результат: {result}");
        }
    }
}