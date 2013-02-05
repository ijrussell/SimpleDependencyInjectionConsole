namespace SimpleDependencyInjectionConsole
{
    public class StandardShippingCalculator : IShippingCostCalculator, IHandleShippingMethod
    {
        public int CalculatePrice(ShoppingBasket shoppingBasket)
        {
            return 500;
        }

        public bool CanHandle(ShippingMethod shippingMethod)
        {
            return shippingMethod == ShippingMethod.Standard;
        }
    }
}