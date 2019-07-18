using P03._ShoppingCart_Before.Contracts;

namespace P03._ShoppingCart
{
    public class OrderItem : IOrder
    {
        public string Sku { get; set; }

        public int Quantity { get; set; }
    }
}
