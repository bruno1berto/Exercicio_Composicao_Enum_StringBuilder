using System;
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

            Client c1 = new Client(name, email, birthdate);

            Console.WriteLine();
            Console.WriteLine("Enter Order data: ");
            Console.WriteLine();

            Console.Write("Status: ");
            string orderstatus = Console.ReadLine();
            Console.Write("How many items to this order? ");
            int qtdItems = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, OrderStatus. orderstatus, c1);
        }
    }
}
