namespace SimpleDependencyInjectionConsole
{
    public class Checkout
    {
        public decimal CalculateShippingCost(ShoppingBasket shoppingBasket)
        {
            return GetShippingCost(shoppingBasket);
        }

        private decimal GetShippingCost(ShoppingBasket shoppingBasket)
        {
            switch (shoppingBasket.ShippingMethod)
            {
                case ShippingMethod.Express:
                    return 25.0m;
                case ShippingMethod.PriceSaver:
                    return 2.5m;
                default:
                    return 5.0m;
            }
        }
    }
}