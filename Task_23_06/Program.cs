namespace Task_23_06
{
    internal class Program
    {
        /* Напишите программу со следующими функциями:
           1. Выведите информации о всех дисках в системе
           2. Выведите содержимое каталога C:\Users (названия папок)
           3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
           a) Создание вложенного каталога “temp”
           b) Вывод информации о текущем каталоге (имя, родитель и тд)
           c) Вывод информации о вложенном каталоге
           4. Переместите каталог “temp” по пути “D:\work\newTemp”
           a) Реализуйте вывод информационного сообщения об успешном (или нет)
           перемещении
           5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет)
           удалении. */
        static void Main(string[] args)
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                Console.WriteLine($"Диск: {drive.Name} - {drive.DriveType}");
            }

            string usersPath = @"C:\Users";
            if (Directory.Exists(usersPath))
            {
                Console.WriteLine("\nСодержимое каталога C:\\Users:");
                var directories = Directory.GetDirectories(usersPath);
                foreach (var dir in directories)
                {
                    Console.WriteLine(dir);
                }
            }

            string workPath = @"D:\work";
            Console.WriteLine($"\nПапка '{workPath}' успешно создана.");

            string tempPath = @"C:\temp"; 
            string newTempPath = @"D:\newTemp";
            if (Directory.Exists(tempPath))
            {
                Directory.Move(tempPath, newTempPath);
                Console.WriteLine($"\nКаталог 'temp' перемещен в '{newTempPath}' успешно.");
            }
            else
            {
                Console.WriteLine($"\nКаталог '{tempPath}' не найден.");
            }

            string workTempPath = @"D:\work\temp";
            if (Directory.Exists(workTempPath))
            {
                Directory.Delete(workTempPath, true);
                Console.WriteLine($"\nКаталог '{workTempPath}' успешно удален.");
            }
            else
            {
                Console.WriteLine($"\nКаталог '{workTempPath}' не найден для удаления.");
            }
        }
    }
}