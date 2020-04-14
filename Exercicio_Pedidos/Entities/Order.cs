using System;
using System.Collections.Generic;
using Exercicio_Pedidos.Entities;
using Exercicio_Pedidos.Entities.Enums;

namespace Exercicio_Pedidos
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public  Client Client{ get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public Order(DateTime moment, OrderStatus status, Client client, List<OrderItem> orderItems) : this(moment, status, client)
        {
            OrderItems = orderItems;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }

        public double Total(List<OrderItem> orderItems)
        {
            double total = 0;
            foreach (OrderItem oi in orderItems)
            {
                total += oi.SubTotal();
            }
            return total;
        }
    }
}
