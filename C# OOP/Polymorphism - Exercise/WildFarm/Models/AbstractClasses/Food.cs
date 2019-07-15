using WildFarm.Contracts;

namespace WildFarm.Models
{
    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            Quantity = quantity;
        }

        public virtual int Quantity { get; protected set; }
    }
}
