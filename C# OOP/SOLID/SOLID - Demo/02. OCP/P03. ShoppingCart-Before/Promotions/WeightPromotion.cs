using P03._ShoppingCart_Before.Contracts;

namespace P03._ShoppingCart_Before.Promotions
{
    public class WeightPromotion : PromotionStrategy , IPromotionStrategy
    {
        public override decimal CalculatePrice(IOrder item)
        {
            return item.Quantity * 4m / 1000;
        }

        public override bool IsMatch(IOrder item)
        {
            return item.Sku.StartsWith("WEIGHT");
        }
    }
}
