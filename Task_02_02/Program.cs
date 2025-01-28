        namespace Task_02_02
    {
    internal class Program
    {
        //Найти значение выражения при a = 8, b = 14, с = π/4
        static void Main(string[] args)
        {
                int a = 8;
                int b = 14;
                double c = Math.PI / 4;

                double step1 = Math.Pow(b + Math.Pow(a - 1, 1.0 / 3.0), 1.0 / 4.0);
                double step2 = Math.Abs(a - b) * (Math.Pow(Math.Sin(c), 2) + Math.Tan(c));
                double step3 = step1 / step2;

                Console.WriteLine(step3);
            }
        }
    }