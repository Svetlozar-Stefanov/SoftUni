using P03._ShoppingCart;

namespace P03._ShoppingCart_Before.Contracts
{
    interface IPromotionStrategy
    {
        decimal CalculatePrice(IOrder item);

        bool IsMatch(IOrder item);
    }
}
