namespace SimpleDependencyInjectionConsole
{
    public interface IShippingCostCalculatorFactory
    {
        IShippingCostCalculator GetCalculator(ShippingMethod shippingMethod);
    }
}