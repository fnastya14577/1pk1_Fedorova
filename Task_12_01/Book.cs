using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo.Publications
{
    internal class Book
    {
        public string title;
        public string autor; 
        bool isReading = false; 

        public void GetInfo()
        {
            Console.WriteLine($"{autor} : {title}");
        }
        public void GetBoot()
        {
            if (isReading)
                Console.WriteLine($"книга {title} в данный момент выдана другому читателю");
            else
            {
                isReading = true;
                Console.WriteLine("книга выдана на неделю");
            }
        }
        public void ReturnBook()
        {
            if (!isReading)
                Console.WriteLine($"\nКнига {title} свободна");
            else
            {
                isReading = false;
                Console.WriteLine("Книга не возвращена");
            }
        }
    }
}