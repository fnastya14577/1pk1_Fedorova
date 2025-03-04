namespace Task_11_03
{
    internal class Program
    {
        /*Напишите метод, который принимает строку и возвращает через
          выходной параметр количество гласных и согласных букв в этой строке*/
        static void Main(string[] args)
        {
            string input = "Пример строки для анализа";
            CountLetters(input, out int Count1, out int Count2);

            Console.WriteLine($"Гласные: {Count1}, Согласные: {Count2}");
        }

        static void CountLetters(string input, out int vowels, out int consonants)
        {
            vowels = 0;
            consonants = 0;
            string vowelsList = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (vowelsList.Contains(c))
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }
        }
    }
}
    

