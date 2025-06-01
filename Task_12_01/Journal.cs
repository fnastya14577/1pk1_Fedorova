using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo.Publications
{
    internal class Journal
    {
        public string date; 
        public string orientation; 
        public string name; 
        public string countPages; 
        public string price; 
        bool isBuy = true;
        bool isNotBuy = true;

        public void Buy()
        {
            if (isBuy)
                Console.WriteLine($"Журнал {name} продан");
        }

        public void NotBuy()
        {
            if (isNotBuy)
                Console.WriteLine($"Журнал {name} не продан");
        }
        public void JournalInfo()
        {
            Console.WriteLine($"\n\nЖурнал под названием {name} был написан в {date}, " +
                $"его предметно-тематическая направленность: {orientation}, количество страниц: {countPages}, и стоит он {price}");
        }
    }
}