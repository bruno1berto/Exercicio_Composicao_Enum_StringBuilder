using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio_Pedidos.Entities;
using Exercicio_Pedidos.Entities.Enums;

namespace Exercicio_Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client data: ");
            Console.WriteLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthdate);

            Console.WriteLine();
            Console.WriteLine("Enter Order data: ");
            Console.WriteLine();

            Console.Write("Status: ");
            OrderStatus orderstatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int qtdItems = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, orderstatus, client);

            for (int i = 1; i <= qtdItems; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter #" + i + " item data: ");
                Console.WriteLine();
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qty = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(qty, productPrice, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

            Console.ReadLine();
        }
    }
}
