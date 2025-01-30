namespace ConsoleApp1
{
    internal class Program
    {
        //Дано целое число N (> 0), являющееся некоторой степенью числа 2: N = 2K. Найти целое число K — показатель этой степени.
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N(>0):");
            double n=double.Parse(Console.ReadLine());

            double k = Math.Log(n,2);
            Console.WriteLine(k);
           
        }
    }
}
