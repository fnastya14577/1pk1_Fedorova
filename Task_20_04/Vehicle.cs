using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_04
{
    public enum VehicleType
    {
        Car,        
        Bike,       
        Bus,        
        Truck,      
        Motorcycle   
    }

    public class Vehicle
    {
        public VehicleType Type { get; private set; }
        public string Model { get; private set; }

        public Vehicle(VehicleType type, string model)
        {
            Type = type;
            Model = model;
        }

        public override string ToString() => $"Тип: {Type}, Модель: {Model}";
    }

    public class VehicleInventory
    {
        private List<Vehicle> _vehicles;

        public VehicleInventory()
        {
            _vehicles = new List<Vehicle>();
        }

        public void AddVehicle(VehicleType type, string model)
        {
            _vehicles.Add(new Vehicle(type, model));
            Console.WriteLine($"Добавлено: {type}, Модель: {model}");
        }

        public int CountVehiclesByType(VehicleType type)
        {
            return _vehicles.Count(v => v.Type == type);
        }

        public void DisplayAllVehicles()
        {
            Console.WriteLine("Список всех транспортных средств:");
            foreach (var vehicle in _vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
