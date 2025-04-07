namespace Task_21_08
{
    internal class Program
    {
        /* напишите метод, 
         * который на вход получается массив параметров (строк)
         * и возвращает толькоуникальныестроки. */
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, int>
        {
            {"first", 1},
            {"second", 2},
            {"third", 3},
            {"fourth", 2}
        };
            var valueToFind = 2;
            var key = FindKeyByValue(dictionary, valueToFind);

            if (key != null)
            {
                Console.WriteLine($"Ключ, соответствующий значению {valueToFind}: {key}");
            }
            else
            {
                Console.WriteLine($"Значение {valueToFind} не найдено в словаре.");
            }
        }
        public static string FindKeyByValue(Dictionary<string, int> dictionary, int value)
        {
            foreach (var pair in dictionary)
            {
                if (pair.Value.Equals(value))
                {
                    return pair.Key; 
                }
            }
            return null; 
        }
    }
}