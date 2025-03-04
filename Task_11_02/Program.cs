namespace Task_11_02
{
    internal class Program
    {
        /*Напишите метод, который принимает два целых числа по ссылке и
          меняет их местами. Проверьте, изменились ли значения переменных вне метода*/
        static void Main(string[] args)
        {
            int x = 2;
            int y = 5;

            Console.WriteLine($"До вызова метода: x = {x}, y = {y}");
            //далее передаем переменные по ссылке 
            Swap(ref x, ref y); 
            Console.WriteLine($"После вызова метода: x = {x}, y = {y}");
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp; // Меняем местами 'a' и 'b'
        }
    }
}
    

