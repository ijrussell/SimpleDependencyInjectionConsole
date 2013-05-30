using System;

namespace SimpleDependencyInjectionConsole
{
    public class ShoppingBasket
    {
        public ShoppingBasket()
        {
            CreatedDate = DateTime.UtcNow;
        }
        
        public ShippingMethod ShippingMethod { get; set; }
        public int ShippingCost { get; set; }
        public DateTime CreatedDate { get; private set; }

    }
}