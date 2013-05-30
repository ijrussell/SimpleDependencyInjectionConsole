namespace SimpleDependencyInjectionConsole
{
    public class PriceSaverShippingCalculator : IShippingCostCalculator, IHandleShippingMethod
    {
        public decimal CalculatePrice(ShoppingBasket shoppingBasket)
        {
            return 2.5m;
        }

        public bool CanHandle(ShippingMethod shippingMethod)
        {
            return shippingMethod == ShippingMethod.PriceSaver;
        }
    }
}