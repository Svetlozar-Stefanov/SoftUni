using P03._ShoppingCart_Before.Contracts;

namespace P03._ShoppingCart_Before.Promotions
{
    public class SpecialPromotion : PromotionStrategy, IPromotionStrategy
    {
        public override decimal CalculatePrice(IOrder item)
        {
            return (item.Quantity * .4m) - ((item.Quantity / 3) * 2);
        }

        public override bool IsMatch(IOrder item)
        {
            return item.Sku.StartsWith("SPECIAL");
        }
    }
}
