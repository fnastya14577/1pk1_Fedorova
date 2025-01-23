namespace Task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.8;

            Console.WriteLine("  t        v");

            for (double t = 0; t <= 10; t += 0.5)
            {
                double v = g * t;
                Console.WriteLine($"{t:F1}\t{v:F2}");
            }
        }
    }
}
