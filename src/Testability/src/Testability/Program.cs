using System;

namespace Testability
{
    public class ShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f; // cost 10%

            return 0; // free shipping
        }
    }

    public class Shipment
    {
        public float Cost { get; set; }
        public DateTime ShippingDate { get; set; }
    }

    public class OrderProcessor
    {
        private readonly ShippingCalculator _shippingCalculator;

        public OrderProcessor()
        {
            _shippingCalculator = new ShippingCalculator();
        }

        void Process(Order order)
        {
            if (order.IsShip)
                throw new InvalidOperationException("This order is already processed!");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }

    public class Order
    {
        public DateTime DatePlaced { get; set; }
        public bool IsShip { get; set; }
        public float TotalPrice { get; set; }
        public Shipment Shipment { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
