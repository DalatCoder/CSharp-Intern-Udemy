using System;

namespace Testability
{
    public class Order
    {
        public DateTime DatePlaced { get; set; }
        public bool IsShip { get; set; }
        public float TotalPrice { get; set; }
        public Shipment Shipment { get; set; }
    }
}
