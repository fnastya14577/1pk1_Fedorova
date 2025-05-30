using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    internal class Pet
    {
        public string Name { get; set; } // кличка
        public string Type { get; set; } // вид животного
        public int Age { get; set; } // возраст
        public int Weight { get; set; } // вес
        public bool Health { get; set; }// отметка о состоянии здоровья

        public Pet()
        {
            Name = "nameless";
            Type = "unknown";
            Age = 0;
            Weight = 0;
            Health = true;
        }
        public Pet(string name, string type, int age, int weight, bool health)
        {
            Name = name;
            Type = type;
            Age = age;
            Weight = weight;
            Health = health;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Кличка: {Name}");
            Console.WriteLine($"Вид животного: {Type}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Вес: {Weight} кг");
            Console.WriteLine($"Состояние здоровья: {(Health ? "здоров" : "нездоров")}");
        }
        public void ChangeWeight(int newWeight)
        {
            Weight = newWeight;
            Console.WriteLine($"Новый вес: {Weight} кг");
        }
        public void ChangeHealth(bool healthStatus)
        {
            Health = healthStatus;
            Console.WriteLine($"Текущий статус здоровья обновлен: {(Health ? "здоров" : "нездоров")}");
        }

    }
}