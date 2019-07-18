namespace P03._ShoppingCart
{
    using P03._ShoppingCart_Before.Contracts;
    using P03._ShoppingCart_Before.Promotions;
    using System.Collections.Generic;
    using System.Linq;

    public class Cart
    {
        private readonly List<OrderItem> items;

        private readonly List<IPromotionStrategy> promotionStrategies = new List<IPromotionStrategy>
        {
            new EachPromotion(),
            new WeightPromotion(),
            new SpecialPromotion()
        };

        public Cart()
        {
            items = new List<OrderItem>();
        }

        public Cart(List<OrderItem> items)
        {
            this.items = items;
        }

        public IEnumerable<OrderItem> Items
        {
            get
            {
                return new List<OrderItem>(items);
            }
        }

        public string CustmerEmail { get; set; }

        public void Add(OrderItem orderItem)
        {
            items.Add(orderItem);
        }

        public decimal TotalAmount()
        {
            decimal total = 0m;

            foreach (var item in this.items)
            {
                IPromotionStrategy promotionStrategy = promotionStrategies.FirstOrDefault(p => p.IsMatch(item));

                total += promotionStrategy.CalculatePrice(item);
            }

            return total; 
        }
    }
}
