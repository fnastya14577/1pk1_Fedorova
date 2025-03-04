namespace Task_11_06
{
    internal class Program
    {
        /*Напишите метод, который принимает массив целых чисел и
          изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли оригинальный
          массив вне метода.*/
        static void Main(string[] args)
        {
            int[] Array1 = { 1, 2, 3, 4, 5 };

            // Вывод массива
            Console.WriteLine("Оригинальный массив: " + string.Join(", ", Array1));
            Array2(Array1);

            // Вывод оригинального массива после вызова метода
            Console.WriteLine("Оригинальный массив после вызова метода: " + string.Join(", ", Array1));
        }
        static void Array2(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 1; // Увеличиваем каждый элемент на 1
            }
        }
    }
}
