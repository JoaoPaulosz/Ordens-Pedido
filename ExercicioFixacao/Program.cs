using System;
using System.Globalization;
using ExercicioFixacao.Entities;
using ExercicioFixacao.Entities.Enums;
namespace ExercicioFixacao {
    class Program {
        static void Main(string[] args) {
            Order order = new Order();
            DateTime moment = DateTime.Now;
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data");
            Console.Write("Status: ");
            OrderStatus status = OrderStatus.Parse<OrderStatus>(Console.ReadLine());
            Client client = new Client(name, email, birthDate);
            order = new Order(moment, status, client);


            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string nameProd = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product prod = new Product(nameProd, price);
                OrderItem item = new OrderItem(quantity,price, prod);
                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("Order Sumary:");
            Console.WriteLine(order);
            }

        }
    }
