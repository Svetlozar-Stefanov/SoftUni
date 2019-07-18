using System;
using System.Collections.Generic;
using System.Text;

namespace P03._ShoppingCart_Before.Contracts
{
    public interface IOrder
    {
        string Sku { get; }

        int Quantity { get; }
    }
}
