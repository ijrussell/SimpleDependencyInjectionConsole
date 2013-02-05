namespace SimpleDependencyInjectionConsole
{
    public interface IShippingCostCalculator
    {
        int CalculatePrice(ShoppingBasket shoppingBasket);
    }
}