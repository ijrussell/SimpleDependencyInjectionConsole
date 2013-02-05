namespace SimpleDependencyInjectionConsole
{
    public class FreeShippingCostCalculator : IShippingCostCalculator, IHandleShippingMethod
    {
        public int CalculatePrice(ShoppingBasket shoppingBasket)
        {
            return 0;
        }

        public bool CanHandle(ShippingMethod shippingMethod)
        {
            return shippingMethod == ShippingMethod.Free;
        }
    }
}