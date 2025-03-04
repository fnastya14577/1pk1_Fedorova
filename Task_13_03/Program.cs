using System.Xml.Linq;

namespace Task_13_03
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }

        public class Car
        {
            public string Number { get; set; }
            public string CarBrand { get; set; }
            public string Color { get; set; }
            public double Speed { get; set; }

            public Car(string number, string carBrand, string color, double speed)
            {
                Number = number;
                CarBrand = carBrand;
                Color = color;
                Speed = speed;
            }
            public void Accelerate(int increase)
            {
                Speed += increase;
                Console.WriteLine($"Автомобиль {CarBrand} разогнался до {Speed} км/ч.");

            }
            // Метод для торможения автомобиля
            public void Brake(int maxSpeed)
            {
                if (Speed > maxSpeed)
                {
                    Console.WriteLine($"Превышение скорости! {CarBrand} останавливается.");
                    Speed = 0;
                }
                else
                {
                    Console.WriteLine($"{CarBrand} замедляется.");
                }
            }
        }
            public static void Main()
            {
                Car car1 = new CarBrand("A123АС", "Toyota", "Зеленый");
                car1.Accelerate(100); 
                car1.Brake(60);      

                Car car2 = new CarBrand("A153АС", "Toyota", "Красный");
                car1.Accelerate(70);
                car1.Brake(40);
            }
     }
}