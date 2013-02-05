namespace SimpleDependencyInjectionConsole
{
    public interface IHandleShippingMethod
    {
        bool CanHandle(ShippingMethod shippingMethod);
    }
}