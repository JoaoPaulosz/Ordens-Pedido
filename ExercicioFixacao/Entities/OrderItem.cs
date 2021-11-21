using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioFixacao.Entities {
    class OrderItem {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity,double price, Product product) {
            Quantity = quantity;
            Product = product;
            Price = price;
        }

        public double SubTotal() {
            return Quantity * Price;
        }

        public override string ToString() {
            return Product.Name
                + ", $"
                + Product.Price
                + ", Quantity: "
                + Quantity
                + ", Subtotal: "
                + SubTotal().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
