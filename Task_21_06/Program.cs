namespace Task_21_06
{
    internal class Program
    {
        /* Написать метод, который удаляет повторяющиеся элементы из списка, 
         * сохраняя порядок. */
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 3, 5, 1, 6 };
            List<int> uniqueNumbers = RemoveDuplicates(numbers);

            Console.WriteLine("Список с уникальными элементами:");
            foreach (var number in uniqueNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public static List<T> RemoveDuplicates<T>(List<T> inputList)
        {
            HashSet<T> seen = new HashSet<T>();
            List<T> resultList = new List<T>();

            foreach (var item in inputList)
            {
                if (seen.Add(item))
                {
                    resultList.Add(item);
                }
            }
            return resultList;
        }
    }
}