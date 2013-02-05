namespace SimpleDependencyInjectionConsole
{
    public class PriceSaverShippingCalculator : IShippingCostCalculator, IHandleShippingMethod
    {
        public int CalculatePrice(ShoppingBasket shoppingBasket)
        {
            return 250;
        }

        public bool CanHandle(ShippingMethod shippingMethod)
        {
            return shippingMethod == ShippingMethod.PriceSaver;
        }
    }
}