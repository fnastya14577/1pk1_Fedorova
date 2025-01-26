namespace Task_03_06
{
    internal class Program
    {
        //Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, с шагом h = 0,5.
        public static void Main(string[] args)
        {
            double startX = -4;
            double endX = 4;
            double step = 0.5;

            Console.WriteLine("Таблица значений функции y = |x|");
            Console.WriteLine("-----------------------");
            Console.WriteLine("  x   |   y  ");
            Console.WriteLine("-----------------------");

            for (double x = startX; x <= endX; x += step)
            {
                double y = Math.Abs(x);
                Console.WriteLine($"{x,5:F1} | {y,5:F1}");
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("\nНажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}