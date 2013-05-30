namespace SimpleDependencyInjectionConsole
{
    public interface IShippingCostCalculator
    {
        decimal CalculatePrice(ShoppingBasket shoppingBasket);
    }
}