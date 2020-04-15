
using System.Text;

namespace Exercicio_Pedidos.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }
        public OrderItem(int quantity, double price, Product product) : this (quantity, price)
        {
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name);
            sb.Append(", R$ ");
            sb.Append(Product.Price);
            sb.Append(", Quantity: ");
            sb.Append(Quantity);
            sb.Append(", SubTotal: R$ ");
            sb.Append(SubTotal());

            return sb.ToString();
        }
    }
}
