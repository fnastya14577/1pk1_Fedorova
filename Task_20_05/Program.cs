namespace Task_20_05
{
    internal class Program
    {
        /* Напишите программу, имитирующую систему авторизации 
           с использованием перечисления AccessLevel:
         • Guest (только чтение)
         • User (чтение + комментарии)
         • Moderator (удаление контента)
         • Admin (полный доступ)
           Создайте метод, который проверяет, может ли пользователь выполнить действие. 
           На основе уровня доступа выводите сообщение. */
        static void Main(string[] args)
        {
            AccessLevel userAccessLevel = AccessLevel.User;

            PerformAction(userAccessLevel, "Чтение поста");
            PerformAction(userAccessLevel, "Комментирование поста");
            PerformAction(userAccessLevel, "Удаление поста");
            PerformAction(userAccessLevel, "Полный доступ к системе");
        }

        public static void PerformAction(AccessLevel accessLevel, string action)
        {
            switch (action)
            {
                case "Чтение поста":
                    if (accessLevel >= AccessLevel.Guest)
                    {
                        Console.WriteLine("Доступ разрешен: вы можете прочитать пост.");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Недостаточно прав.");
                    }
                    break;

                case "Комментирование поста":
                    if (accessLevel >= AccessLevel.User)
                    {
                        Console.WriteLine("Доступ разрешен: вы можете комментировать пост.");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Недостаточно прав.");
                    }
                    break;

                case "Удаление поста":
                    if (accessLevel >= AccessLevel.Moderator)
                    {
                        Console.WriteLine("Доступ разрешен: пост успешно удален.");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Недостаточно прав для удаления поста.");
                    }
                    break;

                case "Полный доступ к системе":
                    if (accessLevel == AccessLevel.Admin)
                    {
                        Console.WriteLine("Доступ разрешен: у вас есть полный доступ к системе.");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Недостаточно прав для полного доступа. ");
                    }
                    break;

                default:
                    Console.WriteLine("Ошибка: Неизвестное действие.");
                    break;
            }
        }
    }
}
