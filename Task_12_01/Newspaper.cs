using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo.Publications
{
    internal class Newspaper
    {
        public string name; 
        public string publisher; 
        public string orientation; 
        public string price; 
        bool isHave = true; 
        bool isNotHave = true; 
        public void NewsInfo()
        {
            Console.WriteLine($"\n\nГазета {name}, под издательством {publisher}, ее направленность: {orientation}, и стоит она {price}");
        }
        public void IsHave()
        {
            if (isHave)
                Console.WriteLine($"Газеты {name} есть в наличии");
            else
                Console.WriteLine($"Газеты {name} закончились");
        }
        public void IsNotHave()
        {
            if (isNotHave)
                Console.WriteLine($"Газеты {name} закончились");
            else
                Console.WriteLine($"Газеты {name} есть в наличии");
        }
    }
}