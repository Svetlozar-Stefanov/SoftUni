using P03._ShoppingCart;
using P03._ShoppingCart_Before.Contracts;

namespace P03._ShoppingCart_Before
{
    public abstract class PromotionStrategy : IPromotionStrategy
    {
        public abstract decimal CalculatePrice(IOrder item);

        public abstract bool IsMatch(IOrder item);
    }
}
