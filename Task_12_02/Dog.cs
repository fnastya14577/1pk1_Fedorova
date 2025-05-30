using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02.Publications
{
    internal class Dog
    {
        public string breed; 
        public string name; 
        public string age; 
        public string color; 
        bool isVaccine = true; 
        bool isNotVaccine = true;

        public void DogInfo()
        {
            Console.WriteLine($"\n\nСобаке под кличкой {name} {age}, ее порода {breed}, а ее шерстка имеет {color} цвет");
        }
        public void IsVaccine()
        {
            if (isVaccine)
                Console.WriteLine($"Собака {name} имеет все прививки");
            else
                Console.WriteLine($"У собаки {name} нет прививок");
        }
        public void IsNotVaccine()
        {
            if (isNotVaccine)
                Console.WriteLine($"У собаки {name} нет прививок");
            else
                Console.WriteLine("У собаки есть все прививки");
        }
    }
}