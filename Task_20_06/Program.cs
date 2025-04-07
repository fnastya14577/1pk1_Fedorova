namespace Task_20_06
{
    internal class Program
    {
        /* Создайте программу, имитирующую работу светофора, 
           используя перечисление TrafficLightColor:
          • Red
          • Yellow
          • Green
           Реализуйте автоматическое переключение цветов (каждые 3 секунды). 
           При смене цвета выводите его в консоль (можно с задержкой Thread.Sleep). 
           Добавьте возможность ручного переключения. */

        private static TrafficLightColor currentColor = TrafficLightColor.Red;
        private static bool running = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите 'Q' для выхода, или 'C' для ручного переключения цвета.");
            Task.Run(() => AutomaticSwitching());

            while (running)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(intercept: true).Key;
                    if (key == ConsoleKey.Q)
                    {
                        running = false;
                    }
                    else if (key == ConsoleKey.C)
                    {
                        SwitchColor();
                    }
                }
            }

            Console.WriteLine("Программа завершена.");
        }

        private static async Task AutomaticSwitching()
        {
            while (running)
            {
                Console.Clear();
                ShowCurrentColor();
                SwitchColor();
                await Task.Delay(3000); 
            }
        }

        // Переключение цвета 
        private static void SwitchColor()
        {
            currentColor = (TrafficLightColor)(((int)currentColor + 1) % 3);
        }

        private static void ShowCurrentColor()
        {
            Console.WriteLine($"Текущий цвет: {currentColor}");
        }
    }
}