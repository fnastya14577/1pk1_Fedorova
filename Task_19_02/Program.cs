namespace Task_19_02
{
    internal class Program
    {
        /* Напишите программу, которая запрашивает у пользователя произвольный текст, 
         * содержащий предложения (есть знаки препинания). программу после анализа выводит текст, 
         * разделенный на части:
         a)	По пробелам (отдельные слова построчно)
         b)	По предложениям (отдельные предложения построчно)
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный текст:");
            string inputText = Console.ReadLine();

            string[] words = inputText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Текст, разделённый на отдельные слова:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            char[] delimiters = { ' ', '.', ',', ';', ':', '!', '?' };
            string[] phrases = inputText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Текст, разделённый на отдельные предложения:");
            foreach (var phrase in phrases)
            {
                Console.WriteLine(phrase);
            }
        }
    }
}
