namespace Task_21_07
{
    internal class Program
    {
        /* Написать метод, который находит первый ключ в словаре, 
         * соответствующий заданному значению. 
         * Если значения нет, вернуть null. */
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>
        {
            { "item1", 10 },
            { "item2", 30 },
            { "item3", 40 },
            { "item4", 10 }
        };

            string key = FindKey(dict, 10);
            Console.WriteLine(key ?? "null");

            key = FindKey(dict, 40);
            Console.WriteLine(key ?? "null");
        }
        static string FindKey(Dictionary<string, int> dictionary, int value)
        {
            foreach (var i in dictionary)
            {
                if (i.Value.Equals(value))
                {
                    return i.Key;
                }
            }
            return null;
        }
    }
}
