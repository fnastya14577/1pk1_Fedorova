namespace Task_11_01
{
    internal class Program
    {
        /*Передача по значению: Напишите метод, который принимает два целых числа и меняет их
         местами. Проверьте, изменились ли значения переменных вне метода*/
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            Console.WriteLine($"До вызова метода: x = { x}, y = { y}");
            Swap(x, y);
            Console.WriteLine($"После вызова метода: x = {x}, y = {y}");           
        }
        static void Swap(int a, int b)
        { 
        int temp = a;
            a = b;
            b = temp;
        }
    }
}
