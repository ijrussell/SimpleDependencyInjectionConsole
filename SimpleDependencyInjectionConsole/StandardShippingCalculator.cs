namespace SimpleDependencyInjectionConsole
{
    public class StandardShippingCalculator : IShippingCostCalculator, IHandleShippingMethod
    {
        public decimal CalculatePrice(ShoppingBasket shoppingBasket)
        {
            return 5.0m;
        }

        public bool CanHandle(ShippingMethod shippingMethod)
        {
            return shippingMethod == ShippingMethod.Standard;
        }
    }
}