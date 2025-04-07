using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_09
{
    class Ticket
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public bool HasLuggage { get; set; }
        public bool IsLight { get; set; } 
        public Ticket(int id, decimal price, bool hasLuggage, bool isLight)
        {
            Id = id;
            Price = price;
            HasLuggage = hasLuggage;
            IsLight = isLight;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Price: {Price}, HasLuggage: {HasLuggage}, IsLight: {IsLight}";
        }
    }
}