namespace Task_19_01
{
    internal class Program
    {
        /* Напишите программу, в которой пользователь вводит произвольный текст в консоли, 
         * после чего программа запрашивает подстроку для поиска. 
         * Если подстрока найдена - то программа запрашивает текст для того чтобы заменить 
         * на него эту подстроку (столько раз, сколько раз подстрока встречена в тексте). */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите производный текст: ");
            string inputText = Console.ReadLine();

            Console.WriteLine("Введите подстроку для поиска:");
            string searchSubstring = Console.ReadLine();

            if (inputText.Contains(searchSubstring))
            {
                Console.WriteLine("Введите текст для замены:");
                string replaceSubstring = Console.ReadLine();

                int count = 0;
                int startIndex = 0;

                while ((startIndex = inputText.IndexOf(searchSubstring, startIndex)) != -1)
                {
                    count++;
                    startIndex += searchSubstring.Length;
                }

                string resultText = inputText.Replace(searchSubstring, replaceSubstring);
                Console.WriteLine($"Результат: {resultText}");
                Console.WriteLine($"Подстрока встречена в тексте: {count} раз(а).");
            }
            else
            {
                Console.WriteLine("Подстрока не найдена в тексте.");
            }
        }
    }
}
