namespace Task_02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начало диапазона температуры: ");
            double startTemp = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите конец диапазона температуры: ");
            double endTemp = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите шаг изменения температуры: ");
            double step = double.Parse(Console.ReadLine());

            for (double i = startTemp; i <= endTemp; i += step)
            {
                double tempF = i * 1.8 + 32;
                Console.WriteLine($"Температура в Цельсиях: {i}; Температура в Фаренгейтах: {tempF}");
            }
        }
    }
}