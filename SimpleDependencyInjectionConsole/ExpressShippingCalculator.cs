namespace SimpleDependencyInjectionConsole
{
    public class ExpressShippingCalculator : IShippingCostCalculator, IHandleShippingMethod
    {
        public decimal CalculatePrice(ShoppingBasket shoppingBasket)
        {
            return 25.0m;
        }

        public bool CanHandle(ShippingMethod shippingMethod)
        {
            return shippingMethod == ShippingMethod.Express;
        }
    }
}