namespace Task_12_01
{
    internal class Program
    {
        /*в этом же проекте реализуйте класс Newspaper (газета) со следующими данными:
         * дата издания, название газеты, заголовок главной полосы, количество страниц, цена
         * функционал класса.
         */
        static void Main(string[] args)
        {
            Book book1 = new Book();
            var book2 = new Book();
            var book3 = new Book() { title = "Автостопом по галактике", autor = "Дуглас Адамс" };
            Book book4 = new Book() { title = "Хоббит", autor = "Джон Толкин" };

            book1.autor = "Рей Бредберри";
            book1.title = "Марсианские хроники";
            book1.GetInfo();    //Рей Бредберри : Марсианские хроники

            book2.autor = "Джона Роулинг";
            book2.title = "Гарри Поттер и философский камень";
            book2.GetInfo();    //Джона Роулинг : Гарри Поттер и философский камень

            book2.GetBoot(); 

            book2.GetBoot(); 

            book1.ReturnBook(); 

            var journal1 = new Journal() { name = "Техника и вооружение", countPages = "102 стр.", orientation = "военный", price = "930 рублей", date = "2025 г." };
            var journal2 = new Journal() { name = "Мурзилка", date = "2008 г.", price = "640 рублей", orientation = "детский", countPages = "52 стр." };

            journal1.JournalInfo(); 
            journal1.Buy(); 
            journal2.JournalInfo(); 
            journal2.NotBuy(); 

            var newspaper1 = new Newspaper() { name = "Известия", orientation = "Новостная", price = "25 рублей", publisher = "АО Редация газеты Известия" };
            var newspaper2 = new Newspaper() { name = "Московский комсомолец", orientation = "Социально-политическая", price = "30 рублей", publisher = "Московский издательский дом" };

            newspaper1.NewsInfo(); 
            newspaper1.IsHave(); // проверка на наличие газеты
            newspaper2.NewsInfo(); // информация о второгой газете
            newspaper2.IsNotHave(); 
        }
    }
}
