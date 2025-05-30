using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02.Publications
{
    internal class Cat
    {
        public string breed;
        public string name; 
        public string age; 
        public string color; 
        bool isMother = true; 
        bool childFree = true; 
        public void CatInfo()
        {
            Console.WriteLine($"\n\nКошка под кличкой {name}: ее порода - {breed}, ее шерсть имеет {color} цвет, и ей {age}");
        }
        public void IsMother()
        {
            if (isMother)
                Console.WriteLine($"У кошки {name} есть котята");
            else
                Console.WriteLine("У кошки нет котят");
        }
        public void IsChildFree()
        {
            if (childFree)
                Console.WriteLine($"У кошки {name} нет котят");
            else
                Console.WriteLine("У кошки есть котята");
        }
    }
}