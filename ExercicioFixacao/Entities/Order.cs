using System;
using System.Collections.Generic;
using System.Text;
using ExercicioFixacao.Entities.Enums;
using System.Globalization;

namespace ExercicioFixacao.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() {

        }

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Items.Remove(item);
        }

        public double Total() {
            double sum = 0;
            foreach(OrderItem item in Items) {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order Moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Items: ");
            foreach (OrderItem item in Items) {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();

        }
    }
}
