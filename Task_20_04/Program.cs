namespace Task_20_04
{
    internal class Program
    {
        /* Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
           • Car
           • Bike
           • Bus
           • Truck
           • Motorcycle
          Храните список транспортных средств (можно просто List<VehicleType>). 
          Добавьте метод для подсчёта транспорта определённого типа. 
          Реализуйте поиск по типу и вывод информации. */
        static void Main(string[] args)
        {
            VehicleInventory inventory = new VehicleInventory();

            inventory.AddVehicle(VehicleType.Car, "Toyota Camry");
            inventory.AddVehicle(VehicleType.Bike, "Giant");
            inventory.AddVehicle(VehicleType.Bus, "Mercedes");
            inventory.AddVehicle(VehicleType.Truck, "Volvo FH");
            inventory.AddVehicle(VehicleType.Motorcycle, "Yamaha R1");
            inventory.AddVehicle(VehicleType.Car, "Honda Accord");

            inventory.DisplayAllVehicles();

            int carCount = inventory.CountVehiclesByType(VehicleType.Car);
            Console.WriteLine($"\nКоличество автомобилей: {carCount}");
        }
    }
}