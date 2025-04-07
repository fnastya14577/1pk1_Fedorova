namespace Task_21_10
{
    internal class Program
    {
        /* Написать метод, 
         * который объединяет два словаря. 
         * Если ключ присутствует в обоих словарях, суммироватьихзначения. */
        static void Main(string[] args)
        {
            var dict1 = new Dictionary<string, int>
        {
            { "apple", 3 },
            { "banana", 2 },
            { "orange", 5 }
        };

            var dict2 = new Dictionary<string, int>
        {
            { "banana", 4 },
            { "pear", 1 },
            { "apple", 2 }
        };

            var mergedDict = MergeDictionaries(dict1, dict2);

            foreach (var kvp in mergedDict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        public static Dictionary<string, int> MergeDictionaries(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        {
            var result = new Dictionary<string, int>(dict1); // Копируем первый словарь

            foreach (var kvp in dict2)
            {
                if (result.ContainsKey(kvp.Key))
                {
                    result[kvp.Key] += kvp.Value;
                }
                else
                {
                    result[kvp.Key] = kvp.Value;
                }
            }

            return result;
        }
    }
}