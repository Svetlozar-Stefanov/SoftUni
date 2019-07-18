using P03._ShoppingCart;
using P03._ShoppingCart_Before.Contracts;

namespace P03._ShoppingCart_Before.Promotions
{
    public class EachPromotion : PromotionStrategy, IPromotionStrategy
    {
        public override decimal CalculatePrice(IOrder item)
        {
            return item.Quantity * 5m;
        }

        public override bool IsMatch(IOrder item)
        {
            return item.Sku.StartsWith("EACH");
        }
    }
}
