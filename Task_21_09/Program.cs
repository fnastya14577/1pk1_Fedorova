namespace Task_21_09
{
    internal class Program
    {
        /* Создайте класс билета (Ticket). сгенерируйте список из 30 билетов. произведите:
           • поиск билета с максимальной суммой,
           • билета с минимальной суммой,
           • выведите список билетов с багажом
           • выведите список люготных билетов. */
        static void Main(string[] args)
        {
            var tickets = GenerateTickets(30);

            var maxTicket = tickets.OrderByDescending(t => t.Price).FirstOrDefault();
            var minTicket = tickets.OrderBy(t => t.Price).FirstOrDefault();

            Console.WriteLine("Билет с максимальной суммой: " + maxTicket);
            Console.WriteLine("Билет с минимальной суммой: " + minTicket);

            var ticketsWithLuggage = tickets.Where(t => t.HasLuggage).ToList();
            Console.WriteLine("\nБилеты с багажом:");
            foreach (var ticket in ticketsWithLuggage)
            {
                Console.WriteLine(ticket);
            }

            var lightTickets = tickets.Where(t => t.IsLight).ToList();
            Console.WriteLine("\nЛегкие билеты:");
            foreach (var ticket in lightTickets)
            {
                Console.WriteLine(ticket);
            }
        }

        private static List<Ticket> GenerateTickets(int count)
        {
            var random = new Random();
            var tickets = new List<Ticket>();

            for (int i = 1; i <= count; i++)
            {
                decimal price = (decimal)(random.Next(100, 1000)) / 10; 
                bool hasLuggage = random.Next(2) == 0; 
                bool isLight = !hasLuggage; 

                tickets.Add(new Ticket(i, price, hasLuggage, isLight));
            }

            return tickets;
        }
    }
}