namespace SimpleDependencyInjectionConsole
{
    public class ExpressShippingCalculator : IShippingCostCalculator, IHandleShippingMethod
    {
        public int CalculatePrice(ShoppingBasket shoppingBasket)
        {
            return 2500;
        }

        public bool CanHandle(ShippingMethod shippingMethod)
        {
            return shippingMethod == ShippingMethod.Express;
        }
    }
}