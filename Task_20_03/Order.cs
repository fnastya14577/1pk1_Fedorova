using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_03
{
    internal class Order
    {
        public OrderStatus Status { get; set; }

        public Order()
        {
            Status = OrderStatus.New;
        }
        public void ChangeStatus()
        {
            if (Status != OrderStatus.Cancelled && Status != OrderStatus.Delivered)
            {
                Status++;
                Console.WriteLine($"статус заказа изменен на {Status}");
            }
            else
            
                Console.WriteLine("Невозможно изменить статус заказа");
            
        }

        public void CancelOrder()
        {
            if (Status != OrderStatus.Cancelled && Status != OrderStatus.Delivered)
            {
                Status = OrderStatus.Cancelled;
                Console.WriteLine("Заказ отменен");
            }
            else { Console.WriteLine("Невозможно изменить статус заказа"); }
        }
    }
}