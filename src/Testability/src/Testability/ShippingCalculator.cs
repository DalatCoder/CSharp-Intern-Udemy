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
}
