namespace Task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год своего рождения");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц рождния");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите день рождения");
            int day = int.Parse(Console.ReadLine());

            DateTime birthdate = new DateTime(year, month, day);
            DateTime currentday = DateTime.Now;

            int age = currentday.Year - birthdate.Year;

            if (currentday < birthdate.AddYears(age))
            {
                age--;
            }
            if (age >=18)
            {
                Console.WriteLine("Вы совершеннолетний");
            }
            else
            {
                Console.WriteLine("Вы несовершеннолетний");
            }
        }
    }
}
