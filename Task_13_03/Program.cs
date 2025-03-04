using System.Xml.Linq;

namespace Task_13_03
{
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
        public Car(string number, string carBrand)
        {
            Number = number;
            CarBrand = carBrand;
        }

    }
    
}
