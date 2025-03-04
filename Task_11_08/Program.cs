namespace Task_11_08
{
    internal class Program
    {
        /*Напишите метод, который принимает переменное количество
          чисел и возвращает их сумму и максимальное значение через выходные параметры (out).*/
        static void Main(string[] args)
        {
            // Вызов метода с переменным количеством аргументов
            SumAndMax(out double max, out double sum, 1, 2, 3, 4, 5);
            Console.WriteLine($"Сумма: {sum}, Максимальное значение: {max}");
        }
        static void SumAndMax(out double max, out double sum, params int[] numbers)
        {
            sum = 0;
            max = int.MinValue; // Инициализация максимального значения

            foreach (var number in numbers)
            {
                sum += number;
                if (number > max)
                {
                    max = number; // Обновление максимального значения
                }
            }
        }
    }
}